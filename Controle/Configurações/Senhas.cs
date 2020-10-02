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
using BLL;

namespace Controle
{
    public partial class Senhas : Form
    {
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public Senhas()
        {
            InitializeComponent();
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario != null && Usuario.USUARIO != "" && Usuario.SENHA != "")
                MessageBox.Show("Dados Salvos:\n" + "Usuário: " + Usuario.USUARIO + "\nSenha: " + Usuario.SENHA);
            else
                MessageBox.Show("Não há dados salvos.");
        }

        private void Senhas_VisibleChanged(object sender, EventArgs e)
        {
            if (Usuario != null)
            {
                TextBoxUser.Text = Usuario.USUARIO;
                TextBoxSenha.Text = Usuario.SENHA;
            }
        }

        private void BtnSalvarIntrag_Click(object sender, EventArgs e)
        {

            if (new BL_Boleta().VerificarCotista(41930000000000, 0, TextBoxUser.Text, TextBoxSenha.Text) == "Login Inválido")
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                return;
            }
            if (Usuario == null)
            {
                BL_Usuario NovoUsuario = new BL_Usuario();
                NovoUsuario.WINDOWSNAME = WINDOWSNAME;
                NovoUsuario.USUARIO = TextBoxUser.Text;
                NovoUsuario.SENHA = TextBoxSenha.Text;
                NovoUsuario.Inserir();
            }
            else { new BL_Usuario().Editar(WINDOWSNAME, TextBoxUser.Text, TextBoxSenha.Text); }
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            MessageBox.Show("Dados salvos com sucesso!");

        }

        private void BtnFechar_Click(object sender, EventArgs e) { Close(); }
    }
}
