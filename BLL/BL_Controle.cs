using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BL_Controle
    {
        //Controles
        private BL_Boleta ObjBoleta = new BL_Boleta();
        private BL_BoletaIntrag ObjBolIntr = new BL_BoletaIntrag();
        private BL_RegistroAplica ObjRegAp = new BL_RegistroAplica();
        private BL_RegistroResgate ObjRegRes = new BL_RegistroResgate();
        private BL_LogOperacional ObjLogOp = new BL_LogOperacional();

        //Roda Validações e Boletagem
        public void RodaControle(string Usuario, string Senha)
        {
            AtualizarArquivos(Usuario, Senha);

            BateResgates();

            VerificaBoletados();

            BoletaOperacoes(Usuario, Senha);
        }

        private void AtualizarArquivos(string Usuario, string Senha)
        {
            //Atualiza arquivo de saldos e de cotas (diariamente)
            if (ObjLogOp.UltimoLog("Arquivos Atualizados") != DateTime.Today)
            {
                try { new BL_Saldo().AtualizarDados(Usuario, Senha); }
                catch (Exception e) { new BL_LogOperacional().Inserir("BL_Controle - Atualizar Saldos", $"Atualizar manualmente! Erro: {e.Message}"); }

                try { new BL_Cota().AtualizarDados(Usuario, Senha); }
                catch (Exception e) { new BL_LogOperacional().Inserir("BL_Controle - Atualizar Cotas", $"Erro: {e.Message}"); }
                
                ObjLogOp.Inserir("BL_Controle - Atualizar Arquivos", "Arquivos Atualizados");
            }
            //Atualiza Boletas Intrag
            try { ObjBolIntr.AtualizarDados(Usuario, Senha); }
            catch(Exception e) { new BL_LogOperacional().Inserir("BL_Controle - AtualizaDataIntrag", $"Erro: {e.Message}"); }

            //Atualiza Registros Aplica
            //ObjRegAp.AtualizarDados(Usuario, Senha);
        }

        //private void AtualizaDataIntrag(string Usuario, string Senha)
        //{
        //    //Atualiza Boletas Intrag
        //    //Atualiza Registros Aplica

        //    //ObjRegAp.AtualizarDados(Usuario, Senha);
        //    ObjBolIntr.AtualizarDados(Usuario, Senha);
        //}

        //Valida Resgates e Boletas Similares (CODCOT, CODFUND, OP, VALOR e CONTA)

        private void BateResgates()
        {
            //Encontra Resgates Similares nas Boletas e RegistrosResgates
            List<BL_Boleta> Boletas = ObjBoleta.DadosDia(DateTime.Today).Where(x => x.OPERACAO != "AP" && x.STATUS == "Pendente").ToList(); /*Boletas de Resgate e Status Pendente*/
            List<BL_RegistroResgate> Registros = ObjRegRes.DadosPorDia(DateTime.Today).Where(x => x.STATUS == "Pendente").ToList(); /*Registros Resgate com Status Pendente*/

            //Validar para cada Boleta de Resgate, se existe um Resgate Similar
            foreach (BL_Boleta B in Boletas)
            {
                BL_RegistroResgate RegAux = Registros.FirstOrDefault(x => x.CODCOT == B.CODCOT && x.CODFUND == B.CODFUND && x.VALOR == B.VALOR && x.CONTA == B.CONTA);

                //Se não encontrar RegistroAuxilar proxima Boleta
                if (RegAux == null) { continue; }

                //Remove da lista de registros quando encotra resgate similar
                Registros.Remove(RegAux);

                //AlteraStatus
                ObjBoleta.Editar(B.IDBOLETA, B.COTIZACAO, B.IMPACTO, "Liberado");
                ObjRegRes.EditarIDREGISTRO(RegAux.IDREGISTRO, B.IDBOLETA, "Liberado");
                ObjLogOp.Inserir("BL_Controle - BateResgates - Libera Resgate", string.Format("Boleta {0} Liberada com Registro Resgate {1}", B.IDBOLETA, RegAux.IDREGISTRO));
            }
        }

        //Altera Status para Boletado das Boletas e BoletasIntrag Similares (CODCOT, CODFUND, OP, VALOR)
        private void VerificaBoletados()
        {
            //Comparar Base de Boletas e Base da Intrag
            //Trocar status para "Boletado"/"Estornado" das boletas devidas
            //Status In -> Liberado, Validando, Liquidação
            List<BL_Boleta> Boletas = new List<BL_Boleta>();
            Boletas = Boletas.Concat(new BL_Boleta().DadosDia(DateTime.Today)).ToList();
            Boletas = Boletas.Concat(new BL_Boleta().DadosZeragemDia(DateTime.Today)).ToList();
            List<BL_BoletaIntrag> BoletasIntrag = ObjBolIntr.DadosDia(DateTime.Today);

            //Remover BoletasIntrag que já possuam Boleta Similar
            for (int i = BoletasIntrag.Count - 1; i > -1; i--)
            {
                BL_Boleta BAux = Boletas.FirstOrDefault(B =>
                B.CODCOT == BoletasIntrag[i].CODCOT && B.CODFUND == BoletasIntrag[i].CODFUND &&
                (
                    (B.VALOR == BoletasIntrag[i].FINANCEIRO && (B.OPERACAO == BoletasIntrag[i].OPERACAO || B.OPERACAO == "R" && BoletasIntrag[i].TIPORESGATE == "PARCIAL" /*Aplicação e Resgate Financeiro*/))
                    || (B.VALOR == BoletasIntrag[i].QUANTIDADE && B.OPERACAO == "RC" && BoletasIntrag[i].TIPORESGATE == "PARCIAL" /*Resgate por cotas*/)
                    || (B.OPERACAO == "RT" && BoletasIntrag[i].TIPORESGATE == "TOTAL" /*Resgate por Total*/)
                )
                && (B.STATUS == "Boletado" || B.STATUS == "Concluído"));

                if (BAux != null) {
                    Boletas.Remove(BAux);
                    BoletasIntrag.Remove(BoletasIntrag[i]);
                }
            }

            //Troca para "Boletado" Operações Remanescentes que encontrem BoletaIntrag
            foreach (BL_Boleta B in Boletas.Where(x => x.STATUS == "Liquidação" || x.STATUS == "Liberado" || x.STATUS == "Validando").ToList())
            {
                //Encontra BoletaIntrag similar
                BL_BoletaIntrag BAux = BoletasIntrag.FirstOrDefault(BI =>
                B.CODCOT == BI.CODCOT && B.CODFUND == BI.CODFUND &&
                (
                    (B.VALOR == BI.FINANCEIRO && (B.OPERACAO == BI.OPERACAO || B.OPERACAO == "R" && BI.TIPORESGATE == "PARCIAL" /*Aplicação e Resgate Financeiro*/))
                    || (B.VALOR == BI.QUANTIDADE && B.OPERACAO == "RC" && BI.TIPORESGATE == "PARCIAL" /*Resgate por cotas*/)
                    || (B.OPERACAO == "RT" && BI.TIPORESGATE == "TOTAL" /*Resgate por Total*/)
                )
                );

                if (BAux == null) { continue; }

                BoletasIntrag.Remove(BAux);
                //Altera status para boletado e atualiza datas de cotização e impacto
                //Altera status da Boleta do RegistroResgate
                try{
                    ObjBoleta.Editar(B.IDBOLETA, BAux.COTIZA, BAux.IMPACTO, "Boletado");
                    ObjLogOp.Inserir("Controle - Verifica Boletados", B.IDBOLETA.ToString() + " - Validada!");
                    ObjRegRes.EditarIDBOLETA(B.IDBOLETA, "Concluído");
                }
                catch(Exception e) { new BL_LogOperacional().Inserir("BL_Controle - VerificaBoletados", $"Erro ao validar Boleta {B.IDBOLETA}. " + e.Message); }                
            }
        }

        //Boleta Operações "Liberado" e que tenham caixa no caso de aplicação VIA TED
        private void BoletaOperacoes(string Usuario, string Senha)
        {
            //Dicionario de Cotistas Auxiliar
            Dictionary<long, long> INVCODCPF = new BL_Cotista().DadosCompleto().ToDictionary(Key => Key.CODCOT, Value => Value.CPFCNPJ);

            //Boleta operações com status Liberado
            //Valida Caixa no caso de Aplicações via ted
            List<BL_Boleta> Boletas = ObjBoleta.DadosDia(DateTime.Today).Where(x => x.STATUS == "Liberado" /*|| x.STATUS == "Cadastro Pendente"*/).ToList();
            List<BL_RegistroAplica> RegistrosAplica = ObjRegAp.Dados();

            //Boleta operações que não são aplicação VIA TED
            foreach (BL_Boleta B in Boletas.Where(x => !(x.OPERACAO == "AP" && x.CONTA == "VIA TED"))) { ObjBoleta.Boletar(B, Usuario, Senha); }

            //Aplica Boletas de aplicação via TED
            foreach (BL_Boleta B in Boletas.Where(x => x.OPERACAO == "AP" && x.CONTA == "VIA TED"))
            {
                BL_RegistroAplica RegistroCaixa = RegistrosAplica.FirstOrDefault(x => x.CPFCNPJ == INVCODCPF[B.CODCOT] && x.CODFUND == B.CODFUND && x.VALOR == B.VALOR);

                if (RegistroCaixa == null) {
                    continue;
                }

                //Registro encontrado, Caso seja efetivamente Boletado, Remove Saldo do Caixa.
                if (ObjBoleta.Boletar(B, Usuario, Senha) == "Validando") { RegistrosAplica.Remove(RegistroCaixa); }
            }
        }
    }
}
