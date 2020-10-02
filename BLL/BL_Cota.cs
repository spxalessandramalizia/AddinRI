using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.IntragDownload;

namespace BLL
{
    public class BL_Cota
    {
        private DA_Cota ObjDA = new DA_Cota();

        public long CODFUND { get; private set; }
        public DateTime DATA { get; private set; }
        public decimal COTA { get; private set; }
        private string KEY { get { return CODFUND.ToString() + DATA.ToString("ddMMyyyy"); } }

        private void Inserir(long Codfund, DateTime Data, decimal Cota)
        {
            ObjDA.Inserir(Codfund, Data, Cota);
        }
        private void Editar(long Codfund, DateTime Data, decimal Cota)
        {
            ObjDA.Editar(Codfund, Data, Cota);
        }
        public List<BL_Cota> CotasCompleto()
        {
            return ConverteDataTable(ObjDA.DadosCompletos());
        }
        public List<BL_Cota> CotasPorData(DateTime Data)
        {
            return ConverteDataTable(ObjDA.DadosDia(Data));
        }
        public BL_Cota Cota(long CODFUND, DateTime DATA)
        {
            return ConverteDataTable(ObjDA.DadoCota(CODFUND, DATA))[0];
        }
        public BL_Cota UltimaCota(long CODFUND)
        {
            return ConverteDataTable(ObjDA.DadoUltimaCota(CODFUND))[0];
        }

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

            Dictionary<string, decimal> CotasBase = CotasCompleto().ToDictionary(Key => Key.CODFUND.ToString() + Key.DATA.ToString("ddMMyyyy"), Value => Value.COTA);
            List<long> Fundos = new BL_FIQ().Dados().Select(x => x.CODFUND).ToList();
            Fundos.AddRange(new BL_Master().Dados().Select(X => X.CODFUND));

            string[] linhas;

            try {  linhas = new DownloadArquivoServiceService().cotacaoXML(Usuario,Senha,"991259").Split(Convert.ToChar("\n")); }
            catch { linhas = new string[0]; }

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].Length > 13 && (linhas[i].Contains("</CDFDO>")))
                {
                    BL_Cota CotaNew = new BL_Cota
                    {
                        CODFUND = Convert.ToInt64(Extract(linhas[i], "CDFDO")),
                        DATA = DateTime.ParseExact(Extract(linhas[i + 1], "DTAPROCE"), "yyyyMMdd", CultureInfo.InvariantCulture),
                        COTA = Convert.ToDecimal(Extract(linhas[i + 2], "VLCOTAP")) /10000000,
                    };

                    if (!Fundos.Contains(CotaNew.CODFUND)) { continue; }

                    if (CotasBase.Keys.Contains(CotaNew.KEY))
                    {
                        if (CotasBase[CotaNew.KEY] != CotaNew.COTA) { Editar(CotaNew.CODFUND, CotaNew.DATA, CotaNew.COTA); }
                    }
                    else { Inserir(CotaNew.CODFUND,CotaNew.DATA,CotaNew.COTA); }
                }
            }
        }


        public void ImportaCSV(string DADOS)
        {
            Dictionary<string, decimal> CotasBase = CotasCompleto().ToDictionary(Key => Key.CODFUND.ToString() + Key.DATA.ToString("ddMMyyyy"), Value => Value.COTA);
            List<long> Fundos = new BL_FIQ().Dados().Select(x => x.CODFUND).ToList();
            Fundos.AddRange(new BL_Master().Dados().Select(X => X.CODFUND));

            string[] linhas;

            try { linhas = DADOS.Split(Convert.ToChar("\n")); }
            catch { linhas = new string[0]; }

            for (int i = 0; i < linhas.Length; i++)
            {
                BL_Cota CotaNew = new BL_Cota
                {
                    CODFUND = Convert.ToInt64(linhas[i].Split(';')[0]),
                    DATA = Convert.ToDateTime(linhas[i].Split(';')[1]),
                    COTA = Convert.ToDecimal(linhas[i].Split(';')[2])
                };

                if (!Fundos.Contains(CotaNew.CODFUND)) { continue; }

                if (CotasBase.Keys.Contains(CotaNew.KEY))
                {
                    if (CotasBase[CotaNew.KEY] != CotaNew.COTA) { Editar(CotaNew.CODFUND, CotaNew.DATA, CotaNew.COTA); }
                }
                else { Inserir(CotaNew.CODFUND, CotaNew.DATA, CotaNew.COTA); }
            }
        }

        private List<BL_Cota> ConverteDataTable(DataTable Table)
        {
            List<BL_Cota> Data = new List<BL_Cota>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_Cota
                    {
                        CODFUND = Convert.ToInt64(dr["CODFUND"]),
                        DATA = Convert.ToDateTime(dr["DATA"]),
                        COTA = Convert.ToDecimal(dr["COTA"]),
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Cota - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
    }
}
