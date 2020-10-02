using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BL_FIQ
    {
        private DA_FIQ ObjDA = new DA_FIQ();

        //Variáveis
        #region
        public long CODFUND { get; private set; }
        public string NOME { get; private set; }
        public string CODCARTEIRA { get; private set; }
        public long CODCOT { get; private set; }
        public long CNPJ { get; private set; }
        //comentar
        public decimal VALORAPLAMIN { get; private set; }
        public decimal VALORAPLMINADI { get; private set; }
        //valor de saldo mínimo
        public decimal Valorsaldominimo { get; private set; }
        //valor mínimo de resgate
        public decimal VALORMINRES { get; private set; }
        public int CONVAPL { get; private set; }
        public int CONVRESG { get; private set; }
        public string REGRARESGATE { get; private set; }
        public int DIASRESGANT { get; private set; }
        public decimal TXSAIDARESGANT { get; private set; }
        public string PERMRESGANT { get; private set; }
        public int LOCKUP { get; private set; }
        public int LIQUIDARESG { get; private set; }
        public string INDPRAZDIASCORCRED { get; private set; }
        public string INDPRAZDIASCORRCOTZ { get; private set; }
        public int BACNOCTAPL { get; private set; }
        public int AGCTAPL { get; private set; }
        public long CCAPL { get; private set; }
        public int DGCTAPL { get; private set; }
        public int BANCOMOV { get; private set; }
        public int AGMOV { get; private set; }
        public long CCMOV { get; private set; }
        public int DCCMOV { get; private set; }
        public string SITUACAO { get; private set; }
        public string ALOCADOR { get; private set; }
        public long CETIP { get; private set; }
        public long CODMASTER { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public BL_FIQ DadosPorCODFUND(long CODFUND)
        {
            try
            {
                List<BL_FIQ> Lista = ConverteDataTable(ObjDA.DadosPorCODFUND(CODFUND));
                if (Lista.Count > 0) { return Lista[0]; }
                return null;
            }
            catch (Exception e) { new BL_LogErro().Inserir("BL_FIQ - DadosPorCODFUND", "Erro: " + e.Message); return null; }
        }
        public DataTable DadosTable()
        {
            try { return ObjDA.DadosCompletos(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_FIQ - DadosTable", "Erro: " + e.Message); return new DataTable(); }
        }
        public List<BL_FIQ> Dados()
        {
            try { return ConverteDataTable(ObjDA.DadosCompletos()); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_FIQ - Dados", "Erro: " + e.Message); return new List<BL_FIQ>(); }
        }
        public DataTable DadosPorSolicitacao(DateTime Dia)
        {
            try { return ObjDA.AplicaPorFIQ(Dia); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_FIQ - DadosPorSolicitacao", "Erro: " + e.Message); return new DataTable(); }
        }
        public DataTable BatimentoSolicitacao(DateTime Dia)
        {
            DataTable DT = new DataTable();

            DT.Columns.Add("FIQ");
            DT.Columns.Add("INTRAG");
            DT.Columns.Add("CONTROLE");
            DT.Columns.Add("CHECK");

            List<BL_FIQ> FIQs = new BL_FIQ().Dados();
            Dictionary<long, decimal> INTRAG = new BL_BoletaIntrag().DadosDia(Dia).Where(x => x.OPERACAO == "AP" && x.STATUS != "E").GroupBy(x => x.CODFUND).ToDictionary(k => k.Key, v => v.Sum(y => y.FINANCEIRO));
            Dictionary<long, decimal> CONTROLE = new BL_Boleta().DadosDia(Dia).Where(x => x.OPERACAO == "AP" && x.STATUS != "Cancelado").GroupBy(x => x.CODFUND).ToDictionary(k => k.Key, v => v.Sum(y => y.VALOR));

            foreach (BL_FIQ FIQ in FIQs)
            {
                if (INTRAG.ContainsKey(FIQ.CODFUND) || CONTROLE.ContainsKey(FIQ.CODFUND))
                {
                    DataRow DR = DT.NewRow();
                    DR["FIQ"] = FIQ.NOME;
                    if (INTRAG.ContainsKey(FIQ.CODFUND)) { DR["INTRAG"] = Convert.ToDecimal(INTRAG[FIQ.CODFUND]); }
                    if (CONTROLE.ContainsKey(FIQ.CODFUND)) { DR["CONTROLE"] = Convert.ToDecimal(CONTROLE[FIQ.CODFUND]); }

                    DT.Rows.Add(DR);
                }
            }

            foreach (DataRow DR in DT.Rows)
            {
                if (DR["INTRAG"].ToString() == "") { DR["CHECK"] = -Convert.ToDecimal(DR["CONTROLE"]); }
                else if (DR["CONTROLE"].ToString() == "") { DR["CHECK"] = Convert.ToDecimal(DR["INTRAG"]); }
                else { DR["CHECK"] = Convert.ToDecimal(DR["INTRAG"]) - Convert.ToDecimal(DR["CONTROLE"]); }
            }

            DT.DefaultView.Sort = "CHECK desc";

            try { return DT; }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_FIQ - BatimentoSolicitacao", "Erro: " + e.Message); return new DataTable(); }
        }
        #endregion

        //Funções Auxiliares
        #region
        private List<BL_FIQ> ConverteDataTable(DataTable Table)
        {
            List<BL_FIQ> Data = new List<BL_FIQ>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_FIQ
                    {
                        CODFUND = Convert.ToInt64(dr["CODFUND"]),
                        NOME = dr["NOMEFANTASIA"].ToString(),
                        CODCARTEIRA = dr["CODCARTEIRA"].ToString(),
                        CODCOT = Convert.ToInt64(dr["CODCOT"]),
                        CNPJ = Convert.ToInt64(dr["CNPJ"]),
                        VALORAPLAMIN = Convert.ToDecimal(dr["VALORAPLAMIN"]),
                        VALORAPLMINADI = Convert.ToDecimal(dr["VALORAPLMINADI"]),
                        Valorsaldominimo = Convert.ToDecimal(dr["SALDOMINAPL"]),
                        VALORMINRES = Convert.ToDecimal(dr["VALORMINRES"]),
                        CONVAPL = Convert.ToInt16(dr["CONVAPL"]),
                        CONVRESG = Convert.ToInt16(dr["CONVRESG"]),
                        REGRARESGATE = dr["REGRARESGATE"].ToString(),
                        DIASRESGANT = Convert.ToInt16(dr["DIASRESGANT"]),
                        TXSAIDARESGANT = Convert.ToInt16(dr["TXSAIDARESGANT"]),
                        PERMRESGANT = dr["PERMRESGANT"].ToString(),
                        LOCKUP = Convert.ToInt16(dr["LOCKUP"]),
                        LIQUIDARESG = Convert.ToInt16(dr["LIQUIDARESG"]),
                        INDPRAZDIASCORCRED = dr["INDPRAZDIASCORCRED"].ToString(),
                        INDPRAZDIASCORRCOTZ = dr["INDPRAZDIASCORRCOTZ"].ToString(),
                        BACNOCTAPL = Convert.ToInt16(dr["BACNOCTAPL"]),
                        AGCTAPL = Convert.ToInt16(dr["AGCTAPL"]),
                        CCAPL = Convert.ToInt64(dr["CCAPL"]),
                        DGCTAPL = Convert.ToInt16(dr["DGCTAPL"]),
                        BANCOMOV = Convert.ToInt16(dr["BANCOMOV"]),
                        AGMOV = Convert.ToInt16(dr["AGMOV"]),
                        CCMOV = Convert.ToInt64(dr["CCMOV"]),
                        DCCMOV = Convert.ToInt16(dr["DCCMOV"]),
                        SITUACAO = dr["SITUACAO"].ToString(),
                        ALOCADOR = dr["ALOCADOR"].ToString(),
                        CETIP = Convert.ToInt64(dr["CETIP"]),
                        CODMASTER = Convert.ToInt64(dr["CODMASTER"]),
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_FIQ - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
        #endregion
    }
}
