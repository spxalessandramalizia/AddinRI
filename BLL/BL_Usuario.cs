using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BL_Usuario
    {
        public string WINDOWSNAME { get; set; }
        public string USUARIO { get; set; }
        public string SENHA { get;  set; }
        public string IP { get; set; }
        public string MAQUINA { get; set; }
        public DateTime DTATUALIZACAO { get; set; }

        private static DA_Usuario ObjDA = new DA_Usuario();

        public void Inserir()
        {
            try { ObjDA.Inserir(WINDOWSNAME, USUARIO, SENHA, DateTime.Today); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Usuario - Inserir", "Erro: " + e.Message); }
        }

        public void Editar(string WINDOWSNAME, string USUARIO, string SENHA)
        {
            try { ObjDA.Editar(WINDOWSNAME, USUARIO, SENHA, DateTime.Today); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Usuario - Editar", "Erro: " + e.Message); }
        }

        public void Resetar()
        {
            try { ObjDA.Resetar(WINDOWSNAME); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Usuario - Resetar", "Erro: " + e.Message); }
        }

        public BL_Usuario DadosNome(string NAME)
        {
            try { return ConverteDataTable(ObjDA.DadosNome(NAME))[0]; }
            catch (Exception e) { return null;  new BL_LogErro().Inserir("BL_Usuario - BoletaPorIDBOLETA", "Erro: " + e.Message); }
        }
        
        private List<BL_Usuario> ConverteDataTable(DataTable Table)
        {
            List<BL_Usuario> Data = new List<BL_Usuario>();

            foreach (DataRow dr in Table.Rows)
            {
                try
                {
                    Data.Add(new BL_Usuario
                    {
                        WINDOWSNAME = dr["WINDOWSNAME"].ToString(),
                        USUARIO = dr["USUARIO"].ToString(),
                        SENHA = dr["SENHA"].ToString(),
                        DTATUALIZACAO = Convert.ToDateTime(dr["DTATUALIZACAO"]),
                        IP = dr["IP"].ToString(),
                        MAQUINA = dr["MAQUINA"].ToString(),
                    });
                }
                catch (Exception e) { new BL_LogErro().Inserir("BL_Usuario - ConverteDataTable", "Erro: " + e.Message); }
            }

            return Data;
        }

        //public bool Autenticar(string username, string password)
        //{
        //    DataTable dTable = new DataTable();


        //    bool found = false;
        //    foreach(DataRow dRow in dTable.Rows)
        //    {
        //        if(username == dRow["_username"].ToString() && password == dRow["_password"].ToString())
        //        {
        //            WindowsName = dRow["userId"].ToString();
        //            found = true;
        //        }
        //    }
        //    return found;
        //}

    }
}
