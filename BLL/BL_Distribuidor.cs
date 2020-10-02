using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BL_Distribuidor
    {
        private DA_Distribuidor ObjDA = new DA_Distribuidor();

        //Variáveis
        #region
        public long CODIGO { get; private set; }
        public long CNPJ { get; private set; }
        public string RAZAOSOCIAL { get; set; }
        public string CLASSIFICACAO { get; private set; }
        public string POSSUICEO { get; private set; }
        public string PREFIXOCEO { get; private set; }
        public string APELIDOCEO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public DataTable DadosTable()
        {
            try { return ObjDA.DadosCompletos(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Distribuidor - DadosTable", "Erro: " + e.Message); return new DataTable(); }
        }
        public List<BL_Distribuidor> Dados()
        {
            try { return ConverteDataTable(ObjDA.DadosCompletos()); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Distribuidor - Dados", "Erro: " + e.Message); return new List<BL_Distribuidor>(); }
        }
        #endregion

        //Funções Auxiliares
        #region
        private List<BL_Distribuidor> ConverteDataTable(DataTable Table)
        {
            List<BL_Distribuidor> Data = new List<BL_Distribuidor>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_Distribuidor
                    {
                        CODIGO = Convert.ToInt64(dr["CODIGO"]),
                        CNPJ = Convert.ToInt64(dr["CNPJ"]),
                        RAZAOSOCIAL = dr["RAZAOSOCIAL"].ToString(),
                        CLASSIFICACAO = dr["CLASSIFICACAO"].ToString(),
                        POSSUICEO = dr["POSSUICEO"].ToString(),
                        PREFIXOCEO = dr["PREFIXOCEO"].ToString(),
                        APELIDOCEO = dr["APELIDOCEO"].ToString(),
                    });
                }
                catch (ArgumentException e) { new BL_LogErro().Inserir("BL_Distribuidor - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }
        #endregion
    }
}
