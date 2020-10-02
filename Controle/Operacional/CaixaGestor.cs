using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle
{
    public partial class CaixaGestor : Form
    {
        private string WINDOWSNAME;
        BL_Usuario Usuario;
        BL_RegistroAplica ObjRegApl = new BL_RegistroAplica();

        public CaixaGestor() {
            InitializeComponent();
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Dictionary<long, string> INVFUND = new BL_FIQ().Dados().ToDictionary(Key => Key.CODFUND, Value => Value.NOME);
            foreach (BL_Master Master in new BL_Master().Dados()) { INVFUND.Add(Master.CODFUND, Master.NOMEFUND); }
            
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario == null || Usuario.USUARIO == "" || Usuario.SENHA == "") { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); return; }
            string Resposta = ObjRegApl.AtualizarDados(Usuario.USUARIO, Usuario.SENHA);
            if(Resposta == "Não há lançamentos de créditos!"){ MessageBox.Show("Não há lançamentos de créditos!");}
            else  { new BL_LogOperacional().Inserir("Caixa Gestor", Resposta); }

            //ObjRegApl.AtualizarDados("spx.op35", "258369");

            List<BL_RegistroAplica> Registros = ObjRegApl.Dados();

            DataGridMovimenta.Rows.Clear();

            foreach (BL_RegistroAplica Registro in Registros)
            {
                if (INVFUND.ContainsKey(Registro.CODFUND))
                {
                    DataGridMovimenta.Rows.Add(new string[] { INVFUND[Registro.CODFUND], Registro.VALOR.ToString(), Registro.CPFCNPJ.ToString(), Registro.NOME, Registro.HORA.ToShortTimeString() });
                }
                else
                {
                    DataGridMovimenta.Rows.Add(new string[] { Registro.CODFUND.ToString(), Registro.VALOR.ToString(), Registro.CPFCNPJ.ToString(), Registro.NOME, Registro.HORA.ToShortTimeString() });
                }
            }
        }
    }
}
