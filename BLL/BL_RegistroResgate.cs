using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BL_RegistroResgate
    {
        private DA_RegistroResgate ObjDA = new DA_RegistroResgate();

        //Variáveis
        #region
        public long IDREGISTRO { get; private set; }
        public long IDBOLETA { get; private set; }
        public long CODCOT { get; private set; }
        public long CODFUND { get; private set; }
        public string OPERACAO { get; private set; }
        public decimal VALOR { get; private set; }
        public string CONTA { get; private set; }
        public string STATUS { get; private set; }
        public DateTime SOLICITACAO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public void Inserir(long CODCOT, long CODFUND, string OPERACAO, decimal VALOR, string CONTA, string STATUS)
        {
            try { ObjDA.Inserir(CODCOT, CODFUND, OPERACAO, VALOR, CONTA, STATUS, DateTime.Today); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - Inserir", "Erro: " + e.Message); }
        }
        public void EditarIDREGISTRO(long IDREGISTRO, long IDBOLETA, string STATUS)
        {
            try { ObjDA.EditarIDREGISTRO(IDREGISTRO, IDBOLETA, STATUS); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - EditarIDREGISTRO", "Erro: " + e.Message); }
        }
        public void EditarIDBOLETA(long IDBOLETA, string STATUS)
        {
            try { ObjDA.EditarIDBOLETA(IDBOLETA, STATUS); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - EditarIDBOLETA", "Erro: " + e.Message); }
        }
        public void DeletarIDREGISTRO(long IDREGISTRO)
        {
            try { ObjDA.DeletarIDREGISTRO(IDREGISTRO); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - DeletarIDREGISTRO", "Erro: " + e.Message); }
        }
        public void DeletarIDBOLETA(long IDBOLETA)
        {
            try { ObjDA.DeletarIDBOLETA(IDBOLETA); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - DeletarIDBOLETA", "Erro: " + e.Message); }
        }
        public DataTable DadosDisplay(DateTime Dia)
        {
            try { return ObjDA.DadosDisplay(Dia); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - DadosDisplay", "Erro: " + e.Message); return new DataTable(); }
        }
        public List<DateTime> DatasSolicitacao()
        {
            try { return ObjDA.DataSolicitacao(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_RegistroResgate - DatasSolicitacao", "Erro: " + e.Message); return new List<DateTime>(); }
        }
        public List<BL_RegistroResgate> DadosPorDia(DateTime Dia)
        {
            DataTable Table = new DataTable();
            List<BL_RegistroResgate> Data = new List<BL_RegistroResgate>();
            Table = ObjDA.DadosPorData(Dia);

            foreach (DataRow dr in Table.Rows)
            {
                //try
                //{
                Data.Add(new BL_RegistroResgate
                {
                    IDREGISTRO = Convert.ToInt64(dr["IDREGISTRO"]),
                    IDBOLETA = Convert.ToInt64(dr["IDBOLETA"]),
                    CODCOT = Convert.ToInt64(dr["CODCOT"]),
                    CODFUND = Convert.ToInt64(dr["CODFUND"]),
                    STATUS = dr["STATUS"].ToString(),
                    OPERACAO = dr["OPERACAO"].ToString(),
                    VALOR = Convert.ToDecimal(dr["VALOR"]),
                    CONTA = dr["CONTA"].ToString(),
                    SOLICITACAO = Convert.ToDateTime(dr["SOLICITACAO"]),
                });
                //}
                //catch { /*new LogErro().Adicionar("DAL - Ler - Cotistas - Completo", "Erro ao ler a linha: " + dr.ToString());*/ }
            }

            return Data;
        }
        #endregion
    }
}
