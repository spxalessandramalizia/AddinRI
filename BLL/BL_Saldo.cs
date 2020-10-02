using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DAL.IntragDownload;
using System.Globalization;

namespace BLL
{
    public class BL_Saldo
    {
        private DA_Saldo ObjDA = new DA_Saldo();

        //Variáveis
        #region
        public long CODCOT { get; private set; }
        public long CODFUND { get; private set; }
        public DateTime DTLANCT { get; private set; }
        public decimal VLCOTAP;
        //simples - exibe todas as cautelas do cotista; total - exibe todas as cautelas somadas 
        public string TIPOREGISTRO { get; private set; }
        //código da cautela
        public long CAUTELA { get; private set; }
        //saldo atual
        public decimal QNTCOTAS { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public void AtualizarDados(string Usuario, string Senha)
        {
            string Extract(string s, string tag)
            {
                var startTag = "<" + tag + ">";
                int startIndex = s.IndexOf(startTag) + startTag.Length;
                int endIndex = s.IndexOf("</" + tag + ">", startIndex);

                if (endIndex - startIndex < 0) { return ""; }
                else { return s.Substring(startIndex, endIndex - startIndex); }
            }

            List<long> Fundos = new BL_FIQ().Dados().Select(x => x.CODFUND).ToList();
            Fundos.AddRange(new BL_Master().Dados().Select(X => X.CODFUND));

            string[] linhas;
            linhas = new DownloadArquivoServiceService().saldosCotaFechamentoD0XMLNoZIP(Usuario, Senha, "991259").Split(Convert.ToChar("\n"));

            //Deletar();
            List<BL_Saldo> Saldos = new BL_Saldo().DadosCompletos();
            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].Contains("</CDFDO>"))
                {
                    BL_Saldo Saldo;
                    long CAUTELA_Aux = Convert.ToInt64(Extract(linhas[i + 9], "CDAPL"));
                    string CODAUX = Extract(linhas[i + 2], "AGENCIA") + Extract(linhas[i + 3], "CDCTA") + Extract(linhas[i + 4], "DAC10");
                    long CODCOT_Aux = Convert.ToInt64(CODAUX);
                    long CODFUND_Aux = Convert.ToInt64(Extract(linhas[i], "CDFDO"));
                    decimal QNTCOTAS_Aux = Convert.ToDecimal(Extract(linhas[i + 14], "QTCOTPAT")) / 100000;
                    string TIPOREGISTRO_Aux = Extract(linhas[i + 8], "IDTIPREG") == "20" ? "Simples" : "Total";
                    //DateTime DATACOTA_Aux = DateTime.ParseExact(Extract(linhas[i + 16], "DTACOTA"), "yyyyMMdd", CultureInfo.InvariantCulture);
                    //decimal COTA_Aux = Convert.ToDecimal(Extract(linhas[i + 17], "VLRCOT")) / 10000000;

                    if (CAUTELA_Aux != 0) { Saldo = Saldos.FirstOrDefault(x => x.CAUTELA == CAUTELA_Aux); }
                    else { Saldo = Saldos.FirstOrDefault(x => x.CODCOT == CODCOT_Aux && x.CODFUND == CODFUND_Aux && x.TIPOREGISTRO == "Total"); }
                    if (Saldo == null) //Inserir nova linha
                    {
                        DateTime DTLANCT_Aux;
                        if (TIPOREGISTRO_Aux == "Simples") { DTLANCT_Aux = DateTime.ParseExact(Extract(linhas[i + 6], "DTLANCT"), "yyyyMMdd", CultureInfo.InvariantCulture); }
                        else { DTLANCT_Aux = new DateTime(1753, 1, 1); }
                        decimal VLCOTAP_Aux = Convert.ToDecimal(Extract(linhas[i + 11], "VLCOTAP")) / 10000000;
                        Inserir(CODCOT_Aux, CODFUND_Aux, DTLANCT_Aux, VLCOTAP_Aux, TIPOREGISTRO_Aux, CAUTELA_Aux, QNTCOTAS_Aux);
                        continue;
                    }
                    if (TIPOREGISTRO_Aux == "Simples" && (CODCOT_Aux != Saldo.CODCOT || CODFUND_Aux != Saldo.CODFUND || QNTCOTAS_Aux != Saldo.QNTCOTAS))
                    {
                        EditarSimples(CODCOT_Aux, CODFUND_Aux, TIPOREGISTRO_Aux, CAUTELA_Aux, QNTCOTAS_Aux);
                    }
                    if (TIPOREGISTRO_Aux == "Total" && (QNTCOTAS_Aux != Saldo.QNTCOTAS)) { EditarTotal(CODCOT_Aux, CODFUND_Aux, QNTCOTAS_Aux); }
                    Saldos.Remove(Saldo);
                }
            }

            foreach (BL_Saldo Resto in Saldos)
            {
                if (Resto.TIPOREGISTRO == "Simples") { DeletarSimples(Resto.CAUTELA); }
                else if (Resto.TIPOREGISTRO == "Total") { DeletarTotal(Resto.CODCOT, Resto.CODFUND); }
            }
            linhas = null;
        }
        public void Inserir(long CODCOT, long CODFUND, DateTime DTLANCT, decimal VLCOTAP, string TIPOREGISTRO, long CAUTELA, decimal QNTCOTAS)
        {
            ObjDA.Inserir(CODCOT, CODFUND, TIPOREGISTRO, CAUTELA, QNTCOTAS, DTLANCT, VLCOTAP);
        }
        public void EditarSimples(long CODCOT, long CODFUNDl, string TIPOREGISTRO, long CAUTELA, decimal QNTCOTAS)
        {
            try { ObjDA.EditarSimples(CODCOT, CODFUNDl, TIPOREGISTRO, CAUTELA, QNTCOTAS); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Saldo - EditarSimples", "Erro: " + e.Message); }
        }
        public void EditarTotal(long CODCOT, long CODFUND, decimal QNTCOTAS)
        {
            try { ObjDA.EditarTotal(CODCOT, CODFUND, QNTCOTAS); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Saldo - EditarTotal", "Erro: " + e.Message); }
        }
        public void DeletarSimples(long CAUTELA)
        {
            try { ObjDA.DeletarSimples(CAUTELA); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Saldo - DeletarSimples", "Erro: " + e.Message); }
        }
        public void DeletarTotal(long CODCOT, long CODFUND)
        {
            try { ObjDA.DeletarTotal(CODCOT, CODFUND); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Saldo - DeletarTotal", "Erro: " + e.Message); }
        }
        public void Deletar() { ObjDA.Deletar(); }
        public DataTable DadosTable()
        {
            try { return ObjDA.DadosCompletos(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_SALDO - DadosTable", "Erro: " + e.Message); return new DataTable(); }
        }
        public List<BL_Saldo> DadosCompletos()
        {
            try { return ConverteDataTable(ObjDA.DadosCompletos()); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_SALDO - DadosCompletos - DAL", "Erro: " + e.Message); return new List<BL_Saldo>(); }
        }
        public List<BL_Saldo> DadosPorCPFCNPJ(long CPFCNPJ)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCPFCNPJ(CPFCNPJ)); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_SALDO - DadosCompletos - DAL", "Erro: " + e.Message); return new List<BL_Saldo>(); }
        }
        public BL_Saldo DadosPorCODCOTeCODFUND(long CODCOT, long CODFUND)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCODCOTeFUNDO(CODCOT, CODFUND))[0]; }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_SALDO - DadosCompletos - DAL", "Erro: " + e.Message); return new BL_Saldo(); }
        }
        public List<BL_Saldo> CautelasPorCODCOTeCODFUND(long CODCOT, long CODFUND)
        {
            try { return ConverteDataTable(ObjDA.CautelasPorCODCOTeFUNDO(CODCOT, CODFUND)); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_SALDO - CautelasPorCODCOTeCODFUND - DAL", "Erro: " + e.Message); return new List<BL_Saldo>(); }
        }
        public BL_Saldo DadosPorCAUTELA(long CAUTELA)
        {
            try { return ConverteDataTable(ObjDA.DadosPorCAUTELA(CAUTELA))[0]; }
            catch (Exception) { return null; }
        }
        #endregion

        //Funções Auxiliares
        #region
        private List<BL_Saldo> ConverteDataTable(DataTable Table)
        {
            List<BL_Saldo> Data = new List<BL_Saldo>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    DateTime Dt = dr["DTLANCT"] == DBNull.Value ? DateTime.Today.AddDays(1) : Convert.ToDateTime(dr["DTLANCT"]);
                    decimal VlCotAp = dr["VLCOTAP"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["VLCOTAP"]);
                    Data.Add(new BL_Saldo
                    {
                        CAUTELA = Convert.ToInt64(dr["CAUTELA"]),
                        CODCOT = Convert.ToInt64(dr["CODCOT"]),
                        CODFUND = Convert.ToInt64(dr["CODFUND"]),
                        DTLANCT = Dt,
                        VLCOTAP = VlCotAp,
                        TIPOREGISTRO = dr["TIPOREGISTRO"].ToString(),
                        //DATACOTA = Convert.ToDateTime(dr["DATACOTA"]),
                        QNTCOTAS = Convert.ToDecimal(dr["QNTCOTAS"]),
                        //COTA = Convert.ToDecimal(dr["COTA"]),
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_SALDO - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
        #endregion

    }
}
