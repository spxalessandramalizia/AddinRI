using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using BLL;
using System.Security.Principal;

namespace Controle
{
    public partial class Principal : Form
    {
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public Principal()
        {
            InitializeComponent();
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if(Usuario != null && Usuario.DTATUALIZACAO != DateTime.Today) { Usuario.Resetar(); }
        }

        //Função de Abrir Formulario
        public void AbrirFormulario<Formulario>() where Formulario : Form, new()
        {
            Form FormAux;
            FormAux = PanelConteudo.Controls.OfType<Formulario>().FirstOrDefault();

            if (FormAux == null)
            {
                FormAux = new Formulario { TopLevel = false };
                PanelConteudo.Controls.Add(FormAux);
                PanelConteudo.Tag = FormAux;
                FormAux.Show();
            }
            else { FormAux.Visible = false; FormAux.Visible = true; }

            FormAux.BringToFront();
        }

        //Movimentar o Formulário
        #region MoveForm
        Point lastpoint;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e) { lastpoint = new Point(e.X, e.Y); }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastpoint.X; this.Top += e.Y - lastpoint.Y; } }

        #endregion

        //Click Botões
        #region 
        //Botões de Função
        private void BtnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void BtnClose_Click(object sender, EventArgs e) { Application.Exit(); }

        //Botões de Abrir Formulários
        private void MenuDashBoard_Click(object sender, EventArgs e) { AbrirFormulario<DashBoard>(); }
        private void SubMenuVisulaizarOrdens_Click(object sender, EventArgs e) { AbrirFormulario<SubOrdens>(); }
        private void SubMenuCadastroCotista_Click(object sender, EventArgs e) { AbrirFormulario<CadastroCotista>(); }
        private void SubMenuCadastroCC_Click(object sender, EventArgs e) { AbrirFormulario<CadastroConta>(); }
        private void SubMenuLogErro_Click(object sender, EventArgs e) { AbrirFormulario<LogErro>(); }
        private void SubMenuResgates_Click(object sender, EventArgs e) { AbrirFormulario<ControleResgates>(); }
        private void SubMenuNovoResgate_Click(object sender, EventArgs e) { AbrirFormulario<BoletaResgate>(); }
        private void SubMenuNovaOrdem_Click(object sender, EventArgs e) { AbrirFormulario<NovaOrdem>(); }
        private void SubMenuArquivos_Click(object sender, EventArgs e) { AbrirFormulario<Arquivos>(); }
        private void SubMenuSenhas_Click(object sender, EventArgs e) { AbrirFormulario<Senhas>(); }
        private void SubMenuCaixaGestor_Click(object sender, EventArgs e) { AbrirFormulario<CaixaGestor>(); }
        private void MenuControle_Click(object sender, EventArgs e) { AbrirFormulario<Controle>(); }
        private void SubMenuContaeOrdem_Click(object sender, EventArgs e) { AbrirFormulario<ContaOrdem>(); }
        private void SubMenuMovimenta_Click(object sender, EventArgs e) { AbrirFormulario<Movimentacoes>(); }
        private void cotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Cotas>();
        }
        #endregion


    }
}
