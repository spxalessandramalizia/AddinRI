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
    public class BL_ContaCredito
    {
        private DA_ContaCredito ObjDA = new DA_ContaCredito();

        //Variáveis
        #region
        public long CODCOT { get; private set; }
        public string TIPOCONTA { get; private set; }
        public long CETIP { get; private set; }
        public int BANCO { get; private set; }
        public int AGENCIA { get; private set; }
        public long CONTA { get; private set; }
        public int DIGITO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        private void Inserir(BL_ContaCredito Conta)
        {
            try { ObjDA.Inserir(Conta.CODCOT, Conta.TIPOCONTA, Conta.CETIP, Conta.BANCO, Conta.AGENCIA, Conta.CONTA, Conta.DIGITO); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_ContaCredito - Inserir", "Erro: " + e.Message); }
        }
        public List<BL_ContaCredito> DadosPorCODCOT(long CODCOT)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCODCOT(CODCOT)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_ContaCredito - DadosPorCODCOT", "Erro: " + e.Message); return new List<BL_ContaCredito>(); }
        }
        public List<BL_ContaCredito> DadosPorCPFCNPJ(long CPFCNPJ)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCPFCNPJ(CPFCNPJ)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_ContaCredito - DadosPorCPFCNPJ", "Erro: " + e.Message); return new List<BL_ContaCredito>(); }
        }
        #endregion

        //Métodos da Classe
        #region
        public string Cadastrar(long CODCOT, string TIPOCONTA, long CETIP, int BANCO, int AGENCIA, long CONTA, int DIGITO, string Usuario, string Senha)
        {
            BL_ContaCredito Conta = new BL_ContaCredito
            {
                CODCOT = CODCOT,
                TIPOCONTA = TIPOCONTA,
                CETIP = CETIP,
                BANCO = BANCO,
                AGENCIA = AGENCIA,
                CONTA = CONTA,
                DIGITO = DIGITO
            };

            string XML_Envio = XML(Conta, Usuario, Senha).Replace("\r\n", "");

            string RespostaIntrag;

            //Envio de Conta CETIP
            if (Conta.TIPOCONTA == "Cetip") { RespostaIntrag = new DA_XML().Envio(XML_Envio, "https://www.itaucustodia.com.br/PassivoWebServices/xmlctp.jsp"); Console.WriteLine(RespostaIntrag); }

            //Envio de Conta de Credito
            else { RespostaIntrag = new DA_XML().Envio(XML_Envio, "https://www.itaucustodia.com.br/PassivoWebServices/xmlcci.jsp"); }

            //Login Inválido -> Remove o Usuario e Senha Atual e Notifica o Usuario
            if (RespostaIntrag.Contains("LOGIN+INVALIDO")) { /*new LogErro().LoginInvalido()*/; return "Login Inválido"; }

            //Operação Efetuada -> Adiciona na Base de Dados
            if (RespostaIntrag.Contains("OPERACAO+EFETUADA") || Conta.TIPOCONTA == "Cetip") { Inserir(Conta); return "Conta Cadastrada"; }

            //Conta já está Cadastrada -> Adiciona na Base de Dados
            if (RespostaIntrag.Contains("A+CONTA+JA+CONSTA+EM+NOSSO+CADASTRO")) { Inserir(Conta); return "A Conta já está cadastrada"; }

            //Outro
            return "Erro não identificado: " + RespostaIntrag;
        }
        #endregion

        //Funções Auxiliares
        #region
        public string DISPLAYCONTA
        {
            get
            {
                if (TIPOCONTA == "Cetip") { return string.Format("CETIP: {0}", CETIP.ToString()); }
                else { return string.Format("{0} - {1} - {2} - {3}", BANCO.ToString(), AGENCIA.ToString(), CONTA.ToString(), DIGITO.ToString()); }
            }
        }
        private string XML(BL_ContaCredito Conta, string Usuario, string Senha)
        {
            //Criar um metodo Geral para essa string
            string ContaCredito()
            {
                if (Conta.BANCO == 341)
                {
                    return
                    new String('0', 4 - Conta.BANCO.ToString().Length) + Conta.BANCO.ToString() +
                    new String('0', 5 - Conta.AGENCIA.ToString().Length) + Conta.AGENCIA.ToString() + " " +
                    new String('0', 11 - Conta.CONTA.ToString().Length) + Conta.CONTA.ToString() + "  " +
                    Conta.DIGITO.ToString();
                }
                else
                {
                    return
                    new String('0', 4 - Conta.BANCO.ToString().Length) + Conta.BANCO.ToString() +
                    new String('0', 5 - Conta.AGENCIA.ToString().Length) + Conta.AGENCIA.ToString() + " " +
                    new String('0', 12 - Conta.CONTA.ToString().Length) + Conta.CONTA.ToString() +
                    Conta.DIGITO.ToString() + " ";
                }
            }

            Dictionary<string, string> Parametros = new Dictionary<string, string>
            {
                { "EBUSINESSID", Usuario },
                { "SENHA      ", Senha },
                { "CDBANCLI   ", "991259" },
                { "AGENCIA    ", Conta.CODCOT.ToString().Substring(0, 4) },
                { "CDCTA      ", Conta.CODCOT.ToString().Substring(4, 9) },
                { "DAC10      ", Conta.CODCOT.ToString().Substring(13, 1) },
            };

            if (Conta.TIPOCONTA == "Cetip")
            {
                Parametros.Add("OPERACAO   ", "I");
                Parametros.Add("CDCETIP8   ", Conta.CETIP.ToString());
                Parametros.Add("CDCETIP8ALT", "");
            }
            else
            {
                Parametros.Add("CODMOV     ", "I");
                Parametros.Add("IDTIPCT1   ", "C");
                Parametros.Add("BCOAGCT1   ", ContaCredito());
                Parametros.Add("IDTPCT01   ", "P");
                Parametros.Add("IDCGCCPF   ", "");
                Parametros.Add("IDTTCI01   ", "1");
                Parametros.Add("IDCLIT01   ", "");
                Parametros.Add("IDOPEMAC   ", new string('0', 6));
                Parametros.Add("ISPB       ", new string(' ', 8));
            }

            XElement XML = new XElement("itaumsg");
            XElement Conteudo = new XElement("parameter");

            //Monta o XML com base nos campos informados
            foreach (string Parametro in Parametros.Keys) { Conteudo.Add(new XElement("param", new XAttribute("id", Parametro), new XAttribute("value", Parametros[Parametro]))); }

            XML.Add(Conteudo);

            return XML.ToString();
        }
        private List<BL_ContaCredito> ConverteDataTable(DataTable Table)
        {
            List<BL_ContaCredito> Data = new List<BL_ContaCredito>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_ContaCredito
                    {
                        CODCOT = Convert.ToInt64(dr["CODCOT"]),
                        TIPOCONTA = dr["TIPOCONTA"].ToString(),
                        CETIP = Convert.ToInt64(dr["CETIP"]),
                        BANCO = Convert.ToInt16(dr["BANCO"]),
                        AGENCIA = Convert.ToInt16(dr["AGENCIA"]),
                        CONTA = Convert.ToInt64(dr["CONTA"]),
                        DIGITO = Convert.ToInt16(dr["DIGITO"])
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_ContaCredito - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
        #endregion
    }
}
