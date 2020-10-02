using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Windows.Forms;
using System.Security.Principal;

namespace BLL
{
    public class BL_LogErro
    {
        private DA_LogErro ObjDA = new DA_LogErro();

        string Local = @"O:\Project Triton\Bases de Dados em txt\LogErro.txt";

        //Variáveis
        #region
        public DateTime DATA { get; private set; }
        public DateTime HORA { get; private set; }
        public string USUARIO { get; private set; }
        public string SISTEMA { get; private set; }
        public string DESCRICAO { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public void Inserir(string SISTEMA, string DESCRICAO)
        {
            ObjDA.Inserir(DateTime.Today, DateTime.Now, WindowsIdentity.GetCurrent().Name.Split('\\')[1], SISTEMA, DESCRICAO, Local);
            MessageBox.Show("SISTEMA:\n" + SISTEMA + "\nDESCRICAO:\n" + DESCRICAO, "Novo Erro!");
        }
        public DataTable ErrosPorData(DateTime Data, string Local) { return ObjDA.DadosPorData(Data, Local); }
        public DataTable ErrosCompleto() { return ObjDA.DadosCompletos(Local); }
        #endregion
    }
}
