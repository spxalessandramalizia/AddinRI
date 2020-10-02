using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DAL.Intrag;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

namespace BLL
{
    public class BL_RegistroAplica
    {
        private DA_RegistroAplica ObjDA = new DA_RegistroAplica();

        //Variáveis
        #region
        public long CPFCNPJ { get; private set; }
        public string NOME { get; private set; }
        public DateTime HORA { get; private set; }
        public decimal VALOR { get; private set; }
        public long CODFUND { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        private void Limpar()
        {
            try { ObjDA.Limpar(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroAplica - Limpar", "Erro: " + e.Message); }
        }
        public List<BL_RegistroAplica> Dados()
        {
            DataTable Table = new DataTable();

            try { Table = ObjDA.DadosCompletos(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroAplica - Dados", "Erro: " + e.Message); return new List<BL_RegistroAplica>(); }

            List<BL_RegistroAplica> Data = new List<BL_RegistroAplica>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_RegistroAplica
                    {
                        CPFCNPJ = Convert.ToInt64(dr["CPFCNPJ"]),
                        NOME = dr["NOME"].ToString(),
                        HORA = Convert.ToDateTime(dr["HORA"]),
                        VALOR = Convert.ToDecimal(dr["VALOR"]),
                        CODFUND = Convert.ToInt64(dr["CODFUND"]),
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroAplica - Dados - Linha", "Erro: " + e.Message); return new List<BL_RegistroAplica>(); }
            }

            return Data;
        }
        #endregion

        //Métodos da Classe
        #region

        public string AtualizarDados(string usuario, string senha)
        {
            CreditosAplicacaoBean[] creditos;
            try {
                //new DAL.Intrag.PosicaoGerencialServiceService().consultarCotista("","","","")
                creditos = new PosicaoGerencialServiceService().consultarCreditosAplicacaoGestor(usuario, senha, "991259", "");
            }
             catch (Exception e) {
                //retorno em formato html
                //testa se não há lançamentos
                Console.WriteLine(e.Message);
                if (e.Message.Contains("NAO HA LANCAMENTOS DE CREDITOS")) { Limpar(); return "Não há lançamentos de créditos!"; }
                else {
                    //new BL_LogErro().Inserir("BL_RegistroAplica - AtualizarDados", "Erro " + e.Message);
                    new BL_LogOperacional().Inserir("BL_RegistroAplica - AtualizarDados", "Erro " + e.Message);
                    AtualizaCaixaWebScraping(usuario, senha);
                    return "Consulta realizada por Web Scraping!";
                }
            }

            Limpar();
            foreach (CreditosAplicacaoBean cred in creditos)
            {
                ObjDA.Inserir(Convert.ToInt64(cred.cpfCnpjCotista), cred.nomeCotista, Convert.ToDateTime(cred.horaCredito),
                    Convert.ToDecimal(cred.valorCredito), Convert.ToInt64(cred.contaCaptacao.Substring(0, 5)));
            }
            return "Consulta realizada com sucesso!";
        }

        public void AtualizaCaixaWebScraping(string Usuario, string Senha)
        {
            Limpar();

            //FUNÇÃO PARA AGUARDAR (MINUTOS E SEGUNDOS)
            void TimeWait(int minutes, int seconds)
            {
                var waitTime = new TimeSpan(0, 0, minutes, seconds);
                var waitUntil = DateTime.Now + waitTime;
                while (DateTime.Now <= waitUntil) { Application.DoEvents(); }
            }

            Console.WriteLine("Atualiza Data Intrag");
            WebBrowser WebCaixa = new WebBrowser();
            WebCaixa.Navigate("https://www.itaucustodia.com.br/Passivo/");
            WebCaixa.ScriptErrorsSuppressed = true;

            //Aguarda a pagina carregar
            while (WebCaixa.ReadyState.ToString() != "Complete") { Application.DoEvents(); }

            var inputElements = WebCaixa.Document.GetElementsByTagName("input");
            var aElements = WebCaixa.Document.GetElementsByTagName("a");
            foreach (HtmlElement i in inputElements)
            {
                if (i.GetAttribute("name").Equals("ebusiness"))
                {
                    i.InnerText = Usuario;
                }
                if (i.GetAttribute("name").Equals("senha"))
                {
                    i.InnerText = Senha;
                }
            }//Insere Login e Senha
            foreach (HtmlElement a in aElements)
            {
                //Clica no Login
                if (a.GetAttribute("href").Equals("javascript:fn_login();")) { a.InvokeMember("click"); }
            }

            //Aguarda Pagina Carregar
            while (WebCaixa.ReadyState != WebBrowserReadyState.Interactive) { Application.DoEvents(); }

            WebCaixa.Navigate("https://www.itaucustodia.com.br/Passivo/abreFiltroCreditosAplicacaoGestor.do?pageExecutionId=5489278750081852");

            //Aguarda Pagina Carregar
            while (WebCaixa.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

            var optionElements = WebCaixa.Document.GetElementsByTagName("option");
            optionElements[1].SetAttribute("selected", "selected");//Seleciona Gestor na lista
            var selectElements = WebCaixa.Document.GetElementsByTagName("select");
            selectElements[0].InvokeMember("onchange");

            while (WebCaixa.Document.GetElementsByTagName("select").Count.ToString() != "2")
            { TimeWait(0, 1); }

            var optionElements2 = WebCaixa.Document.GetElementsByTagName("option");
            optionElements2[3].SetAttribute("selected", "selected");//Seleciona Gestor do Fundo na lista
            var selectElements2 = WebCaixa.Document.GetElementsByTagName("select");
            selectElements2[1].InvokeMember("onchange");
            var aElements2 = WebCaixa.Document.GetElementsByTagName("a");

            foreach (HtmlElement a2 in aElements2)
            {
                //Clica em Continuar
                if (a2.GetAttribute("href").Equals("javascript:fn_enviar();")) { a2.InvokeMember("click"); }
            }

            var tdElements = WebCaixa.Document.GetElementsByTagName("td");

            int tempo = 0;

            //Aguarda o Numero de elementos com tag "td" ser maior que 50 {Pagina Carregada}
            while (tdElements.Count < 50)
            {
                TimeWait(0, 1);
                tdElements = WebCaixa.Document.GetElementsByTagName("td");
                tempo++;
                if (tempo > 10) { break; }
            }

            string Fundo;

            for (int i = 0; i < tdElements.Count - 1; i++)
            {
                if (tdElements[i].InnerText == "Fundo:")
                {
                    i++;
                    Fundo = tdElements[i].InnerText;
                    Console.WriteLine(tdElements[i].InnerText);
                    while (tdElements[i].InnerText != "Fundo:")
                    {
                        if (tdElements[i].InnerText == "Valor da Operação:")
                        {
                            if (tdElements[i + 7].InnerText == DateTime.Now.ToString("dd/MM/yyyy"))
                            {
                                BL_RegistroAplica RA = new BL_RegistroAplica();

                                RA.CODFUND = Convert.ToInt64(Fundo.Split('-')[0].Trim());
                                RA.CPFCNPJ = Convert.ToInt64(new Regex(@"[^\d]").Replace(tdElements[i - 3].InnerText.Trim(), "")); //Regex

                                try { RA.NOME = tdElements[i - 5].InnerText.Trim(); }
                                catch { RA.NOME = ""; }

                                RA.HORA = Convert.ToDateTime(tdElements[i + 9].InnerText.Trim());
                                RA.VALOR = Convert.ToDecimal(tdElements[i + 1].InnerText.Trim(), new CultureInfo("pt-BR"));

                                ObjDA.Inserir(RA.CPFCNPJ, RA.NOME, RA.HORA, RA.VALOR, RA.CODFUND);
                            }
                        }
                        i++;
                        if (i > tdElements.Count - 1) { break; }
                    }
                    i = i - 1;
                }
            }

        }



        #endregion
    }
}
