using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Security.Principal;

namespace BLL
{
    public class BL_LogOperacional
    {
        private DA_LogOperacional ObjDA = new DA_LogOperacional();

        //Variáveis
        #region
        public DateTime DATA { get; private set; }
        public DateTime HORA { get; private set; }
        public string SISTEMA { get; private set; }
        public string USUARIO { get; private set; }
        public string DESCRICAO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public void Inserir(string SISTEMA, string DESCRICAO)
        {
            try { ObjDA.Inserir(DateTime.Today, DateTime.Now, SISTEMA, WindowsIdentity.GetCurrent().Name.Split('\\')[1], DESCRICAO); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_LogOperacional - Inserir", "Erro: " + e.Message); }
        }
        public DataTable DadosPorData(DateTime Dia)
        {
            try { return ObjDA.DadosPorData(Dia); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_LogOperacional - DadosPorData", "Erro: " + e.Message); return new DataTable(); }
        }
        public DataTable DadosCompletos()
        {
            try { return ObjDA.DadosCompletos(); }
            catch (ArgumentException e) { new BL_LogErro().Inserir("BL_LogOperacional - DadosCompletos", "Erro: " + e.Message); return new DataTable(); }
        }
        public DateTime UltimoLog(string DESCRICAO)
        {
            return ObjDA.UltimoLog(DESCRICAO);
        }

        #endregion
    }
}
