using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using DAL.Intrag;

namespace BLL
{
    public class BL_Cotista
    {
        private DA_Cotista ObjDA = new DA_Cotista();

        //Variáveis
        #region
        public long CPFCNPJ { get; private set; }
        public long CODCOT { get; private set; }
        public string NOME { get; private set; }
        public Int64 CODDIST { get; private set; }
        public Int64 CODALOCADOR { get; private set; }
        public DateTime VENCIMENTO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public void Inserir(long CODCOT, string NOME, long CPFCNPJ, long CODDIST, long CODALOCADOR, DateTime VENCIMENTO)
        {
            try { ObjDA.Inserir(CODCOT, NOME, CPFCNPJ, CODDIST, CODALOCADOR, VENCIMENTO); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - Inserir", "Erro: " + e.Message); }
        }
        public void Editar(long CODCOT, string NOME, long CPFCNPJ, long CODDIST, long CODALOCADOR, DateTime VENCIMENTO)
        {
            try { ObjDA.Editar(CODCOT, NOME, CPFCNPJ, CODDIST, CODALOCADOR, VENCIMENTO); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Boleta - Editar", "Erro: " + e.Message); }
        }
        public List<BL_Cotista> DadosPorCPFCNPJ(long CPFCNPJ)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCPFCNPJ(CPFCNPJ)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cotista - DadosPorCPFCNPJ", "Erro: " + e.Message); return new List<BL_Cotista>(); }
        }
        public BL_Cotista DadosPorCODCOT(long CODCOT)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCODCOT(CODCOT)).FirstOrDefault(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cotista - DadosPorCODCOT", "Erro: " + e.Message); return null; }
        }
        public List<BL_Cotista> DadosPorCPFCNPJeSALDO(long CPFCNPJ, long CODFUND)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCPFCNPJeSALDO(CPFCNPJ, CODFUND)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cotista - DadosPorCPFCNPJeSALDO", "Erro: " + e.Message); return new List<BL_Cotista>(); }
        }
        public List<BL_Cotista> DadosCompleto()
        {
            try { return ConverteDataTable(ObjDA.DadosCompletos()); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cotista - DadosCompleto", "Erro: " + e.Message); return new List<BL_Cotista>(); }
        }
        #endregion

        //Métodos de Classe
        #region
        public void Cadastrar(string NOME, long CPFCNPJ, long CODDIST, string Usuario, string Senha)
        {
            string Resposta = "";
            string XMLAUX = XML(NOME, CPFCNPJ, CODDIST, Usuario, Senha).Replace("\r\n", "");

            try
            {
                Resposta = new DA_XML().Envio(XMLAUX, "https://www.itaucustodia.com.br/PassivoWebServices/xmlcacintrag.jsp");

                if (!Resposta.Contains("COTISTA+JA+CADASTRADO"))
                {
                    Resposta = new Regex(@"[^\d]").Replace(Resposta, "");
                    if (long.TryParse(Resposta, out long CODCOT)) { Inserir(CODCOT, NOME, CPFCNPJ, CODDIST, 0, DateTime.Today.AddYears(2)); }
                }
            }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cotista - Cadastrar", "Erro: " + e.Message); }
            finally { new BL_LogOperacional().Inserir("BL_Cotista - Cadastrar", "Reposta Intrag:" + Resposta); }
        }
        //public void ValidarCotistasWebScraping(string Usuario, string Senha)
        //{
        //    List<long> CotistasAux = new BL_Cotista().DadosCompleto().Select(x => x.CODCOT).ToList();
        //    List<BL_Distribuidor> Distribuidores = new BL_Distribuidor().Dados().Where(x => x.POSSUICEO == "Sim").ToList();

        //    WebBrowser WebCaixa = new WebBrowser();
        //    WebCaixa.Navigate("https://www.itaucustodia.com.br/Passivo/");
        //    WebCaixa.ScriptErrorsSuppressed = true;

        //    while (WebCaixa.ReadyState.ToString() != "Complete") { Application.DoEvents(); }//Aguarda a pagina carregar

        //    var inputElements = WebCaixa.Document.GetElementsByTagName("input");
        //    var aElements = WebCaixa.Document.GetElementsByTagName("a");

        //    //Insere Login e Senha
        //    foreach (HtmlElement i in inputElements)
        //    {
        //        if (i.GetAttribute("name").Equals("ebusiness")) { i.InnerText = Usuario; }
        //        if (i.GetAttribute("name").Equals("senha")) { i.InnerText = Senha; }
        //    }

        //    //Clica no Login
        //    foreach (HtmlElement a in aElements) { if (a.GetAttribute("href").Equals("javascript:fn_login();")) { a.InvokeMember("click"); } }

        //    //Aguarda Pagina Carregar
        //    while (WebCaixa.ReadyState != WebBrowserReadyState.Interactive) { Application.DoEvents(); }

        //    //Navega até pagina do Check Upload
        //    WebCaixa.Navigate("https://www.itaucustodia.com.br/Passivo/abreFiltroConsultaUploadCheck.do?pageExecutionId=7376071690435952");

        //    //Aguarda Pagina Carregar
        //    while (WebCaixa.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

        //    //Seleciona Gestor na lista
        //    var ElementosSelect = WebCaixa.Document.GetElementsByTagName("select");
        //    foreach (HtmlElement a3 in ElementosSelect)
        //    {
        //        if (a3.GetAttribute("Name").Equals("codigoGestor")) { a3.SetAttribute("Value", "991259"); }
        //        if (a3.GetAttribute("Name").Equals("tipo")) { a3.SetAttribute("Value", "1"); }
        //    }

        //    //Clica em Continuar
        //    var aElements2 = WebCaixa.Document.GetElementsByTagName("a");
        //    foreach (HtmlElement a2 in aElements2) { if (a2.GetAttribute("href").Equals("javascript:enviar();")) { a2.InvokeMember("click"); } }

        //    //Aguarda Pagina Carregar
        //    while (WebCaixa.ReadyState != WebBrowserReadyState.Interactive) { Application.DoEvents(); }

        //    var E = WebCaixa.Document.GetElementsByTagName("td");

        //    //Cadastrar Cotistas não cadastrados na Base
        //    for (int i = 0; i < E.Count; i++)
        //    {
        //        if (E[i].InnerText == "Cotista:")
        //        {
        //            long Codcot = Convert.ToInt64(E[i + 1].InnerText.Split('-')[0].Trim());
        //            string Nome = E[i + 1].InnerText.Split('-')[1].Trim().ToString();
        //            long Cpfcnpj = Convert.ToInt64(E[i + 3].InnerText.Trim());

        //            if (!CotistasAux.Contains(Codcot) && Distribuidores.Where(x => x.CNPJ == Cpfcnpj).Count() > 0)
        //            {
        //                long CODDIST = Distribuidores.FirstOrDefault(x => x.CNPJ == Cpfcnpj).CODIGO;

        //                new BL_Cotista().Inserir(Codcot, Nome, Cpfcnpj, CODDIST, 0, DateTime.Today);
        //                CotistasAux.Add(Codcot);
        //            }
        //        }
        //    }
        //}

        public BL_Cotista ConsultarCotista(string Usuario, string Senha, string CODCOT)
        {
            //trocar para consulta via web service
            string[] Consulta = new string[0];
            try
            {
                Consulta = new PosicaoGerencialServiceService().consultarCotistaXML(Usuario, Senha, "991259", CODCOT).Split(Convert.ToChar("\n"));
            }
            catch (Exception e) { new BL_LogOperacional().Inserir("BL_Cotista - AtualizarCotista", "Erro: " + e.Message); return null; }

            BL_Cotista Cotista = new BL_Cotista();
            foreach (string line in Consulta)
            {
                if (line.Contains("<idClienteReceita>")) { Cotista.CPFCNPJ = Convert.ToInt64(Extract(line, "idClienteReceita")); }
                if (line.Contains("<nomeCliente>")) { Cotista.NOME = Extract(line, "nomeCliente"); }
            }

            return Cotista;
        }

        #endregion

        //Funções Auxiliares
        #region
        private string XML(string NOME, long CPFCNPJ, long CODDIST, string Usuario, string Senha)
        {
            //Estrutura do XML
            Dictionary<string, string> Parametros = new Dictionary<string, string>
            {
                { "EBUSINESSID", "" }, //EDITAR
                { "SENHA      ", "" }, //EDITAR
                { "INDORIG    ", "X" },
                { "INDOPER    ", "I" },
                { "CDBANCLI   ", "991259" },
                { "AGENCIA    ", "    " },
                { "CONTA      ", "         " },
                { "DAC        ", " " },
                { "NMCLI      ", ""}, //EDITAR
                { "DTNASCL8   ", "          " },
                { "PES        ", "J" },
                { "IDCGCCPF   ", "" },  //EDITAR
                { "TPDOCIDE   ", "NIRE "},
                { "IDDOCLI    ", "1111111111111"},
                { "DTDOCEXP   ", "          "},
                { "IDORGEMI   ", "       "},
                { "IDESTEMI   ", "  "},
                { "ICIMP      ", "F"},
                { "SITLEG     ", " "},
                { "CODSEX     ", " "},
                { "CDESTCIV   ", " "},
                { "CDRAMOAT   ", "31119999000"},
                { "CDPROATI   ", "   "},
                { "CDFCONST   ", "00"},
                { "ICLEC      ", "A"},
                { "CDREMLEC   ", "R"},
                { "DDD        ", "0011"},
                { "TEL8       ", "0030170570"},
                { "RAMAL      ", "000000"},
                { "EMAIL      ", "teste.teste@teste.com.br                                                        "},
                { "IDASSESS   ", "     "},
                { "IDCLITER   ", "                         "},
                { "ICEXTM     ", "C"},
                { "ICCFM      ", "R"},
                { "VRENDFAM   ", "11111111111"},
                { "VLPATRIM   ", "111111111111111"},
                { "CDCLSCLI   ", "052"},
                { "CDCETIP    ", "        "},
                { "CDDISTRB   ", ""}, //EDITAR
                { "NOMEPAI    ", "                              "},
                { "NOMEMAE    ", "                              "},
                { "NOMECONJ   ", "                              "},
                { "NOLOGRES   ", "                              "},
                { "NULOGRES   ", "     "},
                { "CPLOGRES   ", "               "},
                { "BAIRRRES   ", "               "},
                { "CEPRESID   ", "        "},
                { "CIDADRES   ", "                    "},
                { "UFRESID    ", "  "},
                { "NOLOGCOM   ", "                              "},
                { "NULOGCOM   ", "     "},
                { "CPLOGCOM   ", "               "},
                { "BAIRRCOM   ", "               "},
                { "CEPCOMER   ", "        "},
                { "CIDADCML   ", "                    "},
                { "UFCOMERC   ", "  "},
                { "NOLOGALT   ", "Avemida Magalhaes de Castro   "},
                { "NULOGALT   ", "04800"},
                { "CPLOGALT   ", "               "},
                { "BAIRRALT   ", "Butanta        "},
                { "CEPALTER   ", "05502001"},
                { "CIDADALT   ", "SAO PAULO           "},
                { "UFALTERN   ", "SP"},
                { "IDOPEMAC   ", "000000"},
                { "INDCTSAVICD", "N"},
                { "CDNATCAP   ", "101"},
                { "TIPOREND   ", " "},
                { "IDDCLFAT   ", "S"},
                { "IDRESFIS   ", " "},
                { "PAIRESDF   ", "   "},
                { "GIINTIN    ", ""}, //ZWU2WJ99999SL076
                { "CDJUSAGI   ", "02"},
                { "CNAEDIVI   ", "66"},
                { "CNAEGRUP   ", "01"},
                { "CNAECLAS   ", "26"},
                { "CNAESUBC   ", "01"},
                { "CODPAINA   ", "   "},
                { "NOMEFANT   ", "                              "},
                { "RANKANBI   ", "000000001"},
                { "EMPRTRAB   ", "                              "},
                { "DTINIEMP   ", "          "},
                { "NIRE       ", "11111111111"},
                { "CADEMP     ", "      "},
                { "CODNAC     ", "   "},
                { "CODCCID    ", "007388"},
                { "DTCONSTI   ", "          "},
                { "INCONPEP   ", " "}, //ALTERADO
                { "INDCORD    ", "S"},
                { "DDD2       ", "    "},
                { "TEL2       ", "          "},
                { "RAMAL2     ", "      "},
                { "DDD3       ", "    "},
                { "TEL3       ", "          "},
                { "RAMAL3     ", "      "},
                { "CPERFINV   ", "NIF"},
                { "CMOTPERF   ", "   "},
                { "CTIPOINV   ", "IP "},
                { "CTIPCATE   ", "009"},
                { "ICAVALTCAD ", "R"},
                { "ICMALADIR  ", "R"},
            };

            Parametros["EBUSINESSID"] = Usuario;
            Parametros["SENHA      "] = Senha;
            Parametros["NMCLI      "] = NOME + new string(' ', 30 - NOME.Length);
            Parametros["IDCGCCPF   "] = new string('0', 15 - CPFCNPJ.ToString().Length) + CPFCNPJ.ToString();
            Parametros["CDDISTRB   "] = new string('0', 10 - CODDIST.ToString().Length) + CODDIST.ToString();

            XElement Conteudo = new XElement("parameter");
            XElement XML = new XElement("itaumsg");

            //Monta o XML com base nos campos informados
            foreach (string Parametro in Parametros.Keys) { Conteudo.Add(new XElement("param", new XAttribute("id", Parametro), new XAttribute("value", Parametros[Parametro]))); }

            XML.Add(Conteudo);

            return XML.ToString();
        }
        private List<BL_Cotista> ConverteDataTable(DataTable Table)
        {
            List<BL_Cotista> Data = new List<BL_Cotista>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_Cotista
                    {
                        CODCOT = Convert.ToInt64(dr["CODCOT"]),
                        NOME = Convert.ToString(dr["NOME"]),
                        CPFCNPJ = Convert.ToInt64(dr["CPFCNPJ"]),
                        CODDIST = Convert.ToInt64(dr["CODDIST"]),
                        CODALOCADOR = Convert.ToInt64(dr["CODALOCADOR"]),
                        VENCIMENTO = Convert.ToDateTime(dr["VENCIMENTO"])
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cotista - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
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
