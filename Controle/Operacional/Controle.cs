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
    public partial class Controle : Form
    {
        BL_Controle ObjControl = new BL_Controle();
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public Controle() {
            InitializeComponent();
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }
        

        //Click Botões
        #region 
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridControle.DataSource = new BL_LogOperacional().DadosPorData(DateTime.Today);
            DataGridControle.ClearSelection();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario == null || Usuario.USUARIO == "" || Usuario.SENHA == "") { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); return; }
            //Verifica se o BackGroundControle está Rodando
            if (BtnIniciar.Text == "Parar" && BtnIniciar.Enabled == true) { Timer.Stop(); BtnIniciar.Text = "Iniciar"; }
            else if (BtnIniciar.Text == "Iniciar") { Timer.Interval = Convert.ToInt32(TextBoxAltCaixa.Text) * 1000 * 60; Timer.Start(); BtnIniciar.Text = "Parar"; }
        }
        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        //Executa o controle em background
        private void BackGroundControle_DoWork(object sender, DoWorkEventArgs e)
        {
            ObjControl.RodaControle(Usuario.USUARIO, Usuario.SENHA);
        }

        //Ativar Timer e controles
        private void BackGroundControle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnFechar.Enabled = BtnIniciar.Enabled = BtnAtualizar.Enabled = true;
            Timer.Start();
        }

        //Ativa BackgroundWorker
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Parar Timer e controles
            Timer.Stop();
            BtnFechar.Enabled = BtnIniciar.Enabled = BtnAtualizar.Enabled = false;

            //Atualiza Caixas* (Atualização via WebScraping quando o WebService não funciona)
            new BL_RegistroAplica().AtualizarDados(Usuario.USUARIO, Usuario.SENHA);

            //Inicia o Background
            BackGroundControle.RunWorkerAsync();
        }
    }
}
