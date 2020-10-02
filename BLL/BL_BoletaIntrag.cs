using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DAL.Intrag;
using System.Globalization;

namespace BLL
{
    public class BL_BoletaIntrag
    {
        private DA_BoletaIntrag ObjDA = new DA_BoletaIntrag();

        //Variáveis
        #region
        public long CODCOT { get; private set; }
        public long CODFUND { get; private set; }
        public DateTime COTIZA { get; private set; }
        public DateTime IMPACTO { get; private set; }
        public DateTime HORA { get; private set; }
        public string OPERACAO { get; private set; }
        public string TIPORESGATE { get; private set; }
        public string TIPOLIQUIDA { get; private set; }
        public decimal FINANCEIRO { get; private set; }
        public decimal QUANTIDADE { get; private set; }
        public string TIPOCONTA { get; private set; }
        public long BANCO { get; private set; }
        public string CONTACORRENTE { get; private set; }
        public string STATUS { get; private set; }
        public string USUARIO { get; private set; }
        public DateTime SOLICITACAO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        private void Limpar()
        {
            try { ObjDA.Limpar(DateTime.Today); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_BoletaIntrag - Limpar", "Erro: " + e.Message); }
        }
        private void Inserir(BL_BoletaIntrag Bol)
        {
            try { ObjDA.Inserir(Bol.CODCOT, Bol.CODFUND, Bol.COTIZA, Bol.IMPACTO, Bol.HORA, Bol.OPERACAO, Bol.TIPORESGATE, Bol.TIPOLIQUIDA, Bol.FINANCEIRO, Bol.QUANTIDADE, Bol.TIPOCONTA, Bol.BANCO, Bol.CONTACORRENTE, Bol.STATUS, Bol.USUARIO, Bol.SOLICITACAO); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_BoletaIntrag - Inserir", "Erro: " + e.Message); }
        }
        public DataTable DadosTable(DateTime Dia)
        {
            try { return ObjDA.DadosDia(Dia); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_BoletaIntrag - DadosTable", "Erro: " + e.Message); return new DataTable(); }
        }
        public List<BL_BoletaIntrag> DadosDia(DateTime Dia)
        {
            DataTable Table = new DataTable();
            List<BL_BoletaIntrag> Data = new List<BL_BoletaIntrag>();
            Table = ObjDA.DadosDia(Dia);

            foreach (DataRow dr in Table.Rows)
            {
                Data.Add(new BL_BoletaIntrag
                {
                    CODCOT = Convert.ToInt64(dr["CODCOT"]),
                    CODFUND = Convert.ToInt64(dr["CODFUND"]),
                    SOLICITACAO = Convert.ToDateTime(dr["SOLICITACAO"]),
                    COTIZA = Convert.ToDateTime(dr["COTIZACAO"]),
                    IMPACTO = Convert.ToDateTime(dr["IMPACTO"]),
                    HORA = Convert.ToDateTime(dr["HORA"].ToString()),
                    OPERACAO = dr["OPERACAO"].ToString(),
                    TIPORESGATE = dr["TIPORESGATE"].ToString(),
                    TIPOLIQUIDA = dr["TIPOLIQUIDA"].ToString(),
                    FINANCEIRO = Convert.ToDecimal(dr["FINANCEIRO"]),
                    QUANTIDADE = Convert.ToDecimal(dr["QUANTIDADE"]),
                    TIPOCONTA = dr["TIPOCONTA"].ToString(),
                    BANCO = Convert.ToInt16(dr["BANCO"]),
                    CONTACORRENTE = dr["CONTA"].ToString(),
                    STATUS = dr["STATUS"].ToString(),
                    USUARIO = dr["USUARIO"].ToString()
                });
            }

            return Data;
        }
        #endregion

        //Métodos Classe
        #region
        public void AtualizarDados(string Usuario, string Senha)
        {
            List<BL_BoletaIntrag> Boletas = new List<BL_BoletaIntrag>();
            string[] linhas;

            try { linhas = new PosicaoGerencialServiceService().consultarMovimentosDiaXML(Usuario, Senha, "991259").Split(Convert.ToChar("\n")); }
            catch { linhas = new string[0]; }

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].Length > 13 && (linhas[i].Substring(0, 14) == "<codigoBanco/>" || linhas[i].Substring(0, 13) == "<codigoBanco>"))
                {
                    BL_BoletaIntrag Boleta = new BL_BoletaIntrag
                    {
                        CODCOT = Convert.ToInt64(Extract(linhas[i + 1], "codigoCotista").Insert(4, "0000")),
                        CODFUND = Convert.ToInt64(Extract(linhas[i + 2], "codigoFundo")),
                        HORA = Convert.ToDateTime(Extract(linhas[i + 6], "horaOperacao")),
                        OPERACAO = Extract(linhas[i + 9], "operacao"), //AP / CT / ST / TF
                        STATUS = Extract(linhas[i + 11], "status"),
                        TIPOCONTA = Extract(linhas[i + 12], "tipoContaCredito"),//C/C 
                        TIPOLIQUIDA = Extract(linhas[i + 13], "tipoOperacao"), //DISPONIVEL / CETIP / TEF / TED STR
                        USUARIO = Extract(linhas[i + 15], "usuario"),
                        SOLICITACAO = DateTime.Today,
                    };

                    if (Boleta.OPERACAO != "AP")
                    {
                        try { Boleta.BANCO = Convert.ToInt64(Extract(linhas[i], "codigoBanco")); } catch { Boleta.BANCO = 0; }

                        try { Boleta.CONTACORRENTE = Extract(linhas[i + 3], "contaCorrente"); }
                        catch { Boleta.CONTACORRENTE = " "; }
                        finally { if (Boleta.CONTACORRENTE == null) { Boleta.CONTACORRENTE = " "; } }

                        try
                        {
                            Boleta.IMPACTO = Convert.ToDateTime(Extract(linhas[i + 5], "dataPagamento"));
                            Console.WriteLine($"Data de impacto: {Boleta.IMPACTO}");
                        } catch { Boleta.IMPACTO = DateTime.Today;} //Erro de conversão para boletas de offshore ou máscara
                        try { Boleta.QUANTIDADE = Convert.ToDecimal(Extract(linhas[i + 10], "quantidadeCotas"), new CultureInfo("pt-BR")); } catch { Boleta.QUANTIDADE = 0; }
                        try { Boleta.TIPORESGATE = Extract(linhas[i + 14], "tipoResgate"); } catch { Boleta.TIPORESGATE = ""; }
                    }
                    else { Boleta.TIPORESGATE = ""; Boleta.IMPACTO = DateTime.Today; Boleta.CONTACORRENTE = ""; }

                    try { Boleta.COTIZA = Convert.ToDateTime(Extract(linhas[i + 4], "dataConversao")); }
                    catch { Boleta.COTIZA = DateTime.Today; }
                    try { Boleta.FINANCEIRO = Convert.ToDecimal(Extract(linhas[i + 16], "valorOperacao")); } catch { }

                    Boleta.FINANCEIRO = Convert.ToDecimal(Extract(linhas[i + 16], "valorOperacao"), new CultureInfo("pt-BR"));

                    Boletas.Add(Boleta);
                }
            }

            if (Boletas.Count == 0) { return; }

            Limpar();

            foreach (BL_BoletaIntrag Boleta in Boletas) { Inserir(Boleta); }
        }
        #endregion

        //Funções Auxiliares
        #region
        private string Extract(string s, string tag)
        {
            var startTag = "<" + tag + ">";
            int startIndex = s.IndexOf(startTag) + startTag.Length;
            int endIndex = s.IndexOf("</" + tag + ">", startIndex);

            if (endIndex - startIndex < 0) { return ""; }
            else { return s.Substring(startIndex, endIndex - startIndex); }
        }
        #endregion
    }
}
