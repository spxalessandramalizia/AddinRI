using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BL_Master
    {
        private DA_Master ObjDA = new DA_Master();

        //Variáveis
        #region
        public long CODFUND { get; private set; }
        public string NOMEFUND { get; private set; }
        public string CODCARTEIRA { get; private set; }
        public long CNPJ { get; private set; }
        public short DIASCONVAPL { get; private set; }
        public short DIASCONVRESG { get; private set; }
        public short DIASLIQUIDARESG { get; private set; }
        public string INDICADORCRED { get; private set; }
        public string INDICADORCOTZ { get; private set; }
        public int BANCOAPL { get; private set; }
        public int AGAPL { get; private set; }
        public long CCAPL { get; private set; }
        public int DGAPL { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public DataTable DadosTable()
        {
            try { return ObjDA.DadosCompletos(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Master - DadosTable", "Erro: " + e.Message); return new DataTable(); }
        }
        public List<BL_Master> Dados()
        {
            try { return ConverteDataTable(ObjDA.DadosCompletos()); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Master - Dados", "Erro: " + e.Message); return new List<BL_Master>(); }
        }
        public DataTable DadosPorSolicitacao(DateTime Dia)
        {
            try { return ObjDA.AplicaPorMaster(Dia); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Master - DadosPorSolicitacao", "Erro: " + e.Message); return new DataTable(); }
        }
        #endregion

        //Funções Auxiliares
        #region
        private List<BL_Master> ConverteDataTable(DataTable Table)
        {
            List<BL_Master> Data = new List<BL_Master>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_Master
                    {
                        CODFUND = Convert.ToInt64(dr["CODFUND"]),
                        NOMEFUND = dr["NOMEFANTASIA"].ToString(),
                        CODCARTEIRA = dr["CODCARTEIRA"].ToString(),
                        CNPJ = Convert.ToInt64(dr["CNPJ"]),
                        DIASCONVAPL = Convert.ToInt16(dr["DIASCONVAPL"]),
                        DIASCONVRESG = Convert.ToInt16(dr["DIASCONVRESG"]),
                        DIASLIQUIDARESG = Convert.ToInt16(dr["DIASLIQUIDARESG"]),
                        INDICADORCRED = dr["INDICADORCRED"].ToString(),
                        INDICADORCOTZ = dr["INDICADORCOTZ"].ToString(),
                        BANCOAPL = Convert.ToInt16(dr["BANCOAPL"]),
                        AGAPL = Convert.ToInt16(dr["AGAPL"]),
                        CCAPL = Convert.ToInt32(dr["CCAPL"]),
                        DGAPL = Convert.ToInt16(dr["DGAPL"]),
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Master - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
        #endregion
    }
}
