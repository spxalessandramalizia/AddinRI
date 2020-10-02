using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Xml.Linq;

namespace BLL
{
    public class BL_Boleta
    {
        private DA_Boleta ObjDA = new DA_Boleta();
        private BL_LogOperacional ObjLogOp = new BL_LogOperacional();

        //Variáveis
        #region
        public long IDBOLETA { get; private set; }
        public string IDORDEM { get; private set; }
        public long CODCOT { get; private set; }
        public long CODFUND { get; private set; }
        public string STATUS { get; set; }  //9 possibilidades
        public DateTime SOLICITACAO { get; private set; }//data de solicitação
        public DateTime COTIZACAO { get; private set; }//data de cotização
        public DateTime IMPACTO { get; private set; }//data de liquidação
        public string OPERACAO { get; private set; }
        public long CAUTELA { get; private set; }
        public decimal VALOR { get; private set; }
        public string CONTA { get; private set; }//"banco-ag-conta-dig"  ou "VIA TED" ou "CETIP: (8 dig)"
        //Variaveis de visão apenas:
        public string NOME { get; private set; }
        public long CPFCNPJ { get; private set; }
        public string FUNDO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        //insere boleta na base
        public void Inserir(string IDORDEM, long CODCOT, long CODFUND, string STATUS, DateTime COTIZACAO, DateTime IMPACTO, string OPERACAO, decimal VALOR, string CONTA, long CAUTELA = 0)
        {
            //Realizar VALIDAÇÕES
            try { ObjDA.Inserir(IDORDEM, CODCOT, CODFUND, STATUS, DateTime.Today, COTIZACAO, IMPACTO, OPERACAO, VALOR, CONTA, CAUTELA); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - Inserir", "Erro: " + e.Message); }
        }
        public void Editar(long IDBOLETA, DateTime COTIZACAO, DateTime IMPACTO, string STATUS)
        {
            try { ObjDA.Editar(IDBOLETA, COTIZACAO, IMPACTO, STATUS); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - Editar", "Erro: " + e.Message); }
        }
        public void Deletar(long IDBOLETA)
        {
            try { ObjDA.Deletar(IDBOLETA); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - Deletar", "Erro: " + e.Message); }
        }
        public List<DateTime> DatasSolicitacao()
        {
            try { return ObjDA.DataSolicitacao(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - DatasSolicitacao", "Erro: " + e.Message); return new List<DateTime>(); }
        }
        public List<BL_Boleta> DadosCompletos()
        {
            try { return ConverteDataTable(ObjDA.DadosCompletos()); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Boleta - DadosCompletos", "Erro: " + e.Message); return new List<BL_Boleta>(); }
        }
        public List<BL_Boleta> DadosDia(DateTime Dia) //Não recupera boletas de FIC-Master
        {
            try { return ConverteDataTable(ObjDA.DadosDia(Dia)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - DadosDia", "Erro: " + e.Message); return new List<BL_Boleta>(); }
        }
        public List<BL_Boleta> DadosZeragemDia(DateTime Dia) //Recupera apenas boletas de FIC-Master
        {
            try { return ConverteDataTable(ObjDA.DadosZeragemDia(Dia)); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Boleta - DadosZeragemDia", "Erro: " + e.Message); return new List<BL_Boleta>(); }
        }
        public List<BL_Boleta> DadosIDORDEM(string IDORDEM)
        {
            try { return ConverteDataTable(ObjDA.DadosIDORDEM(IDORDEM)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - DadosIDORDEM", "Erro: " + e.Message); return new List<BL_Boleta>(); }
        }
        public BL_Boleta BoletaPorIDBOLETA(long IDBOLETA)
        {
            try { return ConverteDataTable(ObjDA.DataBoletaPorID(IDBOLETA))[0]; }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - BoletaPorIDBOLETA", "Erro: " + e.Message); return new BL_Boleta(); }
        }
        #endregion

        //Métodos da Classe
        #region
        public bool ValidaBoleta(BL_Cotista Cotista, BL_FIQ Fundo, string OPERACAO, decimal VALOR, DateTime SOLICITACAO, long CAUTELA, ref string Status)
        {
            Status = "Liberado";
            BL_Saldo Saldo = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND);
            if (OPERACAO == "AP") //Aplicação
            { //Aplicação inicial mínima
                if (Saldo.QNTCOTAS == 0 && VALOR < Fundo.VALORAPLAMIN)
                {
                    Status = $"O valor solicitado é inferior à aplicação inicial mínima permitida de {Fundo.VALORAPLAMIN}!";
                } //Aplicação adicional mínima
                else if (VALOR < Fundo.VALORAPLMINADI)
                {
                    Status = $"O valor solicitado é inferior à aplicação adicional mínima permitida de {Fundo.VALORAPLMINADI}!";
                } //Janela do Raptor
                DateTime Cotizacao = CalculaCotizacao(SOLICITACAO, OPERACAO, Fundo.CODFUND);
                DateTime JanelaRaptor = new BL_Feriados().AddWorkDays(Cotizacao, -1);
                if (SOLICITACAO != JanelaRaptor)
                {
                    Status = $"Operação não permitida hoje! A próxima janela de aplicação do Raptor será dia {JanelaRaptor}.";
                }
            }
            else //Resgates
            {
                BL_Cota UltimaCota = new BL_Cota().UltimaCota(Fundo.CODFUND);
                if (OPERACAO == "R")
                {
                    if (Fundo.LOCKUP != 0) { Status = "Não é possível resgatar por financeiro em fundos com lockup!"; }
                    else if (VALOR < Fundo.VALORMINRES) { Status = $"O valor solicitado é inferior ao resgate mínimo permitido de {Fundo.VALORMINRES}!"; }
                    else if (Saldo.QNTCOTAS * UltimaCota.COTA - VALOR < Fundo.Valorsaldominimo)
                    { Status = $"O saldo restante será inferior ao mínimo permitido de {Fundo.Valorsaldominimo}!"; }
                }
                else
                {
                    if (VALOR * UltimaCota.COTA < Fundo.VALORMINRES)
                    { Status = $"O valor solicitado é inferior ao resgate mínimo permitido de {Fundo.VALORMINRES}!"; }
                    else if (OPERACAO == "RC" && (Saldo.QNTCOTAS - VALOR) * UltimaCota.COTA < Fundo.Valorsaldominimo)
                    { Status = $"O saldo restante será inferior ao mínimo permitido de {Fundo.Valorsaldominimo}!"; }
                }
                if (CAUTELA != 0) //Resgate por cautela
                {
                    if (OPERACAO == "R") { Status = "Não é possível realizar resgates financeiros por cautela!"; }
                    else if (VALOR > Saldo.QNTCOTAS) { Status = "O valor solicitado é maior que a quantidade de cotas disponível na cautela!"; }
                }
            }

            if (Status == "Liberado") { return true; }
            return false;
        }
        public DateTime CalculaCotizacao(DateTime DataSol, string OP, long CODFUND)
        {
            BL_FIQ Fundo = new BL_FIQ().DadosPorCODFUND(CODFUND);
            int Prazo = OP == "AP" ? Fundo.CONVAPL : Fundo.CONVRESG;
            string Tipo;
            if (OP == "AP" && Fundo.REGRARESGATE == "T") { Tipo = "M"; }
            else { Tipo = Fundo.REGRARESGATE; }

            DateTime Ans = new BL_Feriados().CalculaCotizacao(DataSol, Prazo, Tipo);

            return Ans;
        }
        public DateTime CalculaLiquidacao(DateTime DataCot, string OP, long CODFUND)
        {
            BL_FIQ Fundo = new BL_FIQ().DadosPorCODFUND(CODFUND);
            DateTime Ans = new BL_Feriados().CalculaLiquidacao(DataCot, Fundo.LIQUIDARESG);

            return Ans;
        }
        public List<BL_Boleta> BoletaPorCautela(BL_Cotista Cotista, BL_FIQ Fundo, decimal VALOR, DateTime DataSol, string OP, string CONTA)
        {
            List<BL_Boleta> Ans = new List<BL_Boleta>();
            List<BL_Saldo> Cautelas = new BL_Saldo().CautelasPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND);

            DateTime MaisRecente = Cautelas.Select(x => x.DTLANCT).Max();
            DateTime Cotizacao = CalculaCotizacao(DataSol, OP, Fundo.CODFUND);
            List<BL_Saldo> CautelasLiberadas = Cautelas.Where(x => Cotizacao.Subtract(x.DTLANCT).Days >= 630 + 90).ToList();
            CautelasLiberadas = CautelasLiberadas.OrderByDescending(x => x.VLCOTAP).ToList();
            while (VALOR != 0 && CautelasLiberadas.Count > 0) //resgata das cautelas liberadas em ordem de menor rentabilidade
            {
                BL_Saldo Cautela = CautelasLiberadas[0];
                BL_Boleta Boleta;
                decimal Valor; string Operacao;
                if (VALOR >= Cautela.QNTCOTAS) { Valor = Cautela.QNTCOTAS; Operacao = "RT"; }
                else { Valor = VALOR; Operacao = "RC"; }
                Boleta = GeraBoleta(Cotista, Fundo, Valor, DataSol, Operacao, CONTA, Cautela.CAUTELA);
                Ans.Add(Boleta);
                VALOR -= Valor;
                CautelasLiberadas.Remove(Cautela);
            }
            if (VALOR > 0) //resgata das cautelas travadas em ordem de data de aplicação
            {
                List<BL_Saldo> CautelasTravadas = Cautelas.Where(x => Cotizacao.Subtract(x.DTLANCT).Days < Fundo.LOCKUP + Fundo.CONVRESG).ToList();
                CautelasTravadas = CautelasTravadas.OrderBy(x => x.DTLANCT).ToList();
                while (VALOR != 0 && CautelasTravadas.Count > 0)
                {
                    BL_Saldo Cautela = CautelasTravadas[0];
                    BL_Boleta Boleta;
                    decimal Valor; string Operacao;
                    if (VALOR >= Cautela.QNTCOTAS) { Valor = Cautela.QNTCOTAS; Operacao = "RT"; }
                    else { Valor = VALOR; Operacao = "RC"; }
                    Boleta = GeraBoleta(Cotista, Fundo, Valor, Cautela.DTLANCT.AddDays(Fundo.LOCKUP), Operacao, CONTA, Cautela.CAUTELA);
                    Ans.Add(Boleta);
                    VALOR -= Valor;
                    CautelasTravadas.Remove(Cautela);
                }
            }

            return Ans;
        }
        public BL_Boleta GeraBoleta(BL_Cotista Cotista, BL_FIQ Fundo, decimal VALOR, DateTime DataSol, string OP, string CONTA, long CAUTELA = 0)
        {
            DateTime Solicitacao = DataSol;
            if (CAUTELA != 0 && Fundo.LOCKUP != 0)
            {
                BL_Saldo Cautela = new BL_Saldo().CautelasPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).FirstOrDefault(x => x.CAUTELA == CAUTELA);
                Solicitacao = Solicitacao > Cautela.DTLANCT.AddDays(Fundo.LOCKUP) ? Solicitacao : Cautela.DTLANCT.AddDays(Fundo.LOCKUP);
            }
            DateTime Cotizacao = new BL_Boleta().CalculaCotizacao(Solicitacao, OP, Fundo.CODFUND);
            DateTime Impacto = OP == "AP" ? DataSol : new BL_Boleta().CalculaLiquidacao(Cotizacao, OP, Fundo.CODFUND);

            BL_Boleta Boleta = new BL_Boleta
            {
                CODCOT = Cotista.CODCOT,
                CODFUND = Fundo.CODFUND,
                CPFCNPJ = Cotista.CPFCNPJ,
                NOME = Cotista.NOME,
                FUNDO = Fundo.NOME,
                OPERACAO = OP,
                STATUS = "Pendente",
                VALOR = VALOR,
                CONTA = CONTA,
                COTIZACAO = Cotizacao,
                IMPACTO = Impacto,
                CAUTELA = CAUTELA
            };
            return Boleta;
        }
        public string Boletar(BL_Boleta Boleta, string Usuario, string Senha)
        {   //Recebe resposta Intrag
            string Resposta = "";
            //string teste = new BL_Boleta().XML(Boleta, Usuario, Senha);
            string teste = Boleta.XML(Usuario, Senha);
            Console.WriteLine(teste);
            try
            {
                Resposta = new DA_XML().Envio(Boleta.XML(Usuario, Senha).Replace("\r\n", ""), "https://www.itaucustodia.com.br/PassivoWebServices/xmlmva.jsp");
                Console.WriteLine(Resposta);
            }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - Boletar", "Erro: " + e.Message); }


            //Valor Superior ao permitido
            if (Resposta.Contains("\"**Valor+ac")) { return "Liberado"; }

            //Cadastro Pendente (vencido ou incompleto)
            if (Resposta.Contains("\"COTISTA+SE")) { return "Cadastro Pendente"; }

            //Pendente de TCR
            if (Resposta.Contains("\"COTISTA+CO") || Resposta.Contains("\"APLICACAO+NAO")) { return "TCR Pendente"; }

            //Codext Não existe
            if (Resposta.Contains("\"CODIGO+DO+")) { return "Código externo não existe"; }

            //Fundo não encontrado
            if (Resposta.Contains("\"FUNDO+NAO+")) { return "Fundo não encontrado"; }

            //Login Inválido
            if (Resposta.Contains("\"LOGIN+INVA")) { return "Login Inválido"; }

            #region Boletagem

            //Saldo Inferior
            if (Resposta.Contains("\"**OPERACAO+P") || Resposta.Contains("\"existe++saldo+disponivel"))
            {
                ObjLogOp.Inserir("BL_BOLETA - Boletar", string.Format("Boleta ID - {0} Não existe saldo disponível", Boleta.IDBOLETA));
                return "Saldo Insuficiente";
            }

            //Lançamento de Cetip
            if (Boleta.CONTA.Contains("CETIP"))
            {
                if (Resposta.Contains("MOVIMENTO+PENDENTE+DE+LIQUIDA"))
                {
                    Editar(Boleta.IDBOLETA, Boleta.COTIZACAO, Boleta.IMPACTO, "Liquidação");
                    ObjLogOp.Inserir("BL_BOLETA - Boletar", string.Format("Boleta ID - {0} Lançada na Cetip", Boleta.IDBOLETA));
                    return "Em liquidação";
                }
                else if (Resposta.Contains("\"COTISTA+NAO"))
                {
                    ObjLogOp.Inserir("BL_Boleta - Boletar", $"Boleta ID {Boleta.IDBOLETA}: Cotista não possui conta cetip cadastrada!");
                    return "Cetip Pendente";
                }
                else if (Resposta.Contains("\"OPERACAO+EN")) { return "Fora do horário permitido"; }
            }

            //Boletagem Efetuada
            if (Resposta.Contains("\"**OPERACAO+E") || (Resposta.Contains("\"PROCESSO+EFETUADO")))
            {
                if (Boleta.OPERACAO == "AP" && Boleta.CONTA == "VIA TED" && Boleta.VALOR == 10000000000) { return "Liberado"; }
                else
                {
                    BL_FIQ Fundo = new BL_FIQ().DadosPorCODFUND(Boleta.CODFUND);
                    if (Fundo != null && Fundo.CODMASTER == 61984 && Boleta.OPERACAO != "AP") { Editar(Boleta.IDBOLETA, Boleta.COTIZACAO, Boleta.IMPACTO, "Boletado"); }
                    else { Editar(Boleta.IDBOLETA, Boleta.COTIZACAO, Boleta.IMPACTO, "Validando"); }

                    //Atualiza RegistroResgate Caso seja Resgate
                    if (Boleta.OPERACAO != "AP") { new BL_RegistroResgate().EditarIDBOLETA(Boleta.IDBOLETA, "Concluído"); }
                    return "Validando";
                }
            }

            #endregion

            //Reposta não identificada
            ObjLogOp.Inserir("BL_Boleta - Boletar", string.Format("Reposta não identificada da boleta ({0}): {1}", Boleta.IDBOLETA, Resposta));
            return "Erro Desconhecido: " + Resposta;
        }

        public string VerificarCotista(long CODCOT, long CODFUND, string Usuario, string Senha)
        {
            BL_Boleta Boleta = new BL_Boleta
            {
                CODCOT = CODCOT,
                CODFUND = CODFUND,
                OPERACAO = "AP",
                VALOR = 10000000000, //10 bi
                CONTA = "VIA TED",
            };

            return Boletar(Boleta, Usuario, Senha);
        }
        #endregion

        //Funções Auxiliares
        #region

        //ARQEOP_XML passivo
        public string XML(string Usuario, string Senha)
        {
            BL_FIQ Fundo = new BL_FIQ().DadosPorCODFUND(CODFUND);
            //Inversores de Dados
            string Operacao()
            {
                if (OPERACAO == "AP") { return "030"; }
                else
                {
                    if (CAUTELA == 0)
                    {
                        if (OPERACAO == "R") { return "105"; }
                        else if (OPERACAO == "RC" || (Fundo != null && Fundo.CODMASTER == 61984 && OPERACAO == "RT" && Fundo.PERMRESGANT == "N"))
                        { return "121"; }
                        else { return "115"; } //resgate de raptor nunca vai ser total
                    }
                    else //resgate por cautela
                    {
                        if (OPERACAO == "R") { return "106"; }
                        else if (OPERACAO == "RC" || (Fundo != null && Fundo.CODMASTER == 61984 && OPERACAO == "RT" && Fundo.PERMRESGANT == "N"))
                        { return "123"; } //resgate de raptor com lockup é sempre 123
                        else { return "116"; }
                    }
                }


            }
            string DataCotiza()
            {
                string Ans;
                if (OPERACAO != "AP" && Fundo != null && Fundo.CODMASTER == 61984) { Ans = COTIZACAO.ToString("ddMMyyyy"); }
                else { Ans = new String(Convert.ToChar(" "), 8); }
                return Ans;
            }
            string DataLancamento()
            {
                string Ans;
                if (OPERACAO != "AP" && Fundo != null && Fundo.CODMASTER == 61984) { Ans = DateTime.Today.ToString("ddMMyyyy"); }
                else { Ans = new String(Convert.ToChar(" "), 8); }
                return Ans;
            }
            string TipoLiquida()
            {
                if (CONTA.Contains("CETIP")) { return "C"; }
                else if (OPERACAO == "AP") { return "R"; }
                else if (Convert.ToInt64(CONTA.Split('-')[0]) == 341) { return "F"; }
                else { return "S"; }
            }
            string Valor()
            {
                if (OPERACAO == "AP" || OPERACAO == "R") { return new string('0', 15 - Convert.ToInt64(VALOR * 100).ToString().Length) + Convert.ToInt64(VALOR * 100).ToString(); }
                else if (Operacao() == "121" || Operacao() == "123") { return new string('0', 15 - Convert.ToInt64(VALOR * 100000).ToString().Length) + Convert.ToInt64(VALOR * 100000).ToString(); }
                else { return new String(' ', 15); }
            }
            string ContaCredito()
            {
                if (OPERACAO == "AP") { return new String(' ', 24); }
                else if (CONTA.Contains("CETIP")) { return new String(' ', 24); }
                else //resgate via ted
                {
                    //banco itaú
                    if (Convert.ToInt64(CONTA.Split('-')[0]) == 341)
                    {
                        return
                        //código do banco (BBBB)
                        new String('0', 4 - Convert.ToInt64(CONTA.Split('-')[0]).ToString().Length) + Convert.ToInt64(CONTA.Split('-')[0]).ToString() +
                        //código da agência (AAAAA)
                        new String('0', 5 - Convert.ToInt64(CONTA.Split('-')[1]).ToString().Length) + Convert.ToInt64(CONTA.Split('-')[1]).ToString() + " " +
                        //código da conta (CCCCCCCCCCC)
                        new String('0', 11 - Convert.ToInt64(CONTA.Split('-')[2]).ToString().Length) + Convert.ToInt64(CONTA.Split('-')[2]).ToString() + "  " +
                        //dígito da conta I
                        Convert.ToInt64(CONTA.Split('-')[3]).ToString();
                    }
                    else
                    {//outros bancos
                        return
                        new String('0', 4 - Convert.ToInt64(CONTA.Split('-')[0]).ToString().Length) + Convert.ToInt64(CONTA.Split('-')[0]).ToString() +
                        new String('0', 5 - Convert.ToInt64(CONTA.Split('-')[1]).ToString().Length) + Convert.ToInt64(CONTA.Split('-')[1]).ToString() + " " +
                        new String('0', 12 - Convert.ToInt64(CONTA.Split('-')[2]).ToString().Length) + Convert.ToInt64(CONTA.Split('-')[2]).ToString() +
                        Convert.ToInt64(CONTA.Split('-')[3]).ToString() + " ";
                    }
                }
            }
            string Cautela()
            {
                if (CAUTELA == 0) { return new String(' ', 10); }
                else return new String('0', 10 - CAUTELA.ToString().Length) + CAUTELA.ToString();
            }
            //Estrutura do XML
            Dictionary<string, string> Parametros = new Dictionary<string, string>
            {
                { "campo0", Usuario },
                { "campo1", Senha },
                { "campo2", "991259" },
                { "campo3", CODFUND.ToString() },
                { "campo4", "991259" },
                { "campo5", CODCOT.ToString().Substring(0,4) },
                { "campo6", CODCOT.ToString().Substring(4,9) },
                { "campo7", CODCOT.ToString().Substring(13,1) },
                { "campo8", "201" },
                { "campo9", Operacao() },
                { "campo10", Valor() },
                { "campo11", ContaCredito() },
                { "campo12", new String('0', 6) }, //identificador do arquivo (xml)
                { "campo13", TipoLiquida() },
                { "campo14", Cautela() },
                { "campo15", "C" }, //tipo de conta de crédito (conta corrente)
                { "campo16", DataCotiza() },
                { "campo17", DataLancamento() },
                { "campo18", new String(' ', 8) } //código ispb (em branco)
            };
            //Adicina um campo caso seja via CETIP
            if (CONTA.Contains("CETIP")) { Parametros.Add("campo19", new String('0', 8 - CONTA.Replace("CETIP: ", "").ToString().Length) + CONTA.Replace("CETIP: ", "").ToString()); }

            XElement Conteudo = new XElement("parameter");
            XElement XML = new XElement("itaumsg");
            //Monta o XML com base nos campos informados
            foreach (string Parametro in Parametros.Keys)
            {
                Conteudo.Add(new XElement("param", new XAttribute("id", Parametro), new XAttribute("value", Parametros[Parametro])));
            }
            XML.Add(Conteudo);
            return XML.ToString();
        }
        private List<BL_Boleta> ConverteDataTable(DataTable Table)
        {
            List<BL_Boleta> Data = new List<BL_Boleta>();
            foreach (DataRow dr in Table.Rows)
            {
                long Cautela = 0;
                if (dr["CAUTELA"].GetType() != typeof(DBNull)) { Cautela = Convert.ToInt64(dr["CAUTELA"]); }
                try
                {
                    Data.Add(new BL_Boleta
                    {
                        IDBOLETA = Convert.ToInt64(dr["IDBOLETA"]),
                        IDORDEM = dr["IDORDEM"].ToString(),
                        CODCOT = Convert.ToInt64(dr["CODCOT"]),
                        CODFUND = Convert.ToInt64(dr["CODFUND"]),
                        STATUS = dr["STATUS"].ToString(),
                        SOLICITACAO = Convert.ToDateTime(dr["SOLICITACAO"]),
                        COTIZACAO = Convert.ToDateTime(dr["COTIZACAO"]),
                        IMPACTO = Convert.ToDateTime(dr["IMPACTO"]),
                        OPERACAO = dr["OPERACAO"].ToString(),
                        VALOR = Convert.ToDecimal(dr["VALOR"]),
                        CONTA = dr["CONTA"].ToString(),
                        NOME = dr["NOME"].ToString(),
                        CPFCNPJ = Convert.ToInt64(dr["CPFCNPJ"]),
                        FUNDO = dr["FUNDO"].ToString(),
                        CAUTELA = Cautela
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - ConverteDataTable", "Erro: " + e.Message); }
            }
            return Data;
        }
        #endregion

    }
}
