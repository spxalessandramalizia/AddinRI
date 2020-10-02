using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Controle
{
    public partial class CadastroConta : Form
    {
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public CadastroConta()
        {
            InitializeComponent();
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        //Movimentar o Formulário
        #region
        Point lastpoint;
    
        //Mouse Em Click
        private void TopPanel_MouseDown(object sender, MouseEventArgs e) { lastpoint = new Point(e.X, e.Y); }

        //Mouse Direito
        private void TopPanel_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastpoint.X; this.Top += e.Y - lastpoint.Y; } }
        #endregion

        //Remove Caracters diferentes de números
        private void TextBoxCpfCnpj_TextChanged(object sender, EventArgs e) { TextBoxCpfCnpj.Text = new Regex(@"[^\d]").Replace(TextBoxCpfCnpj.Text, ""); }

        //Limpar Formulário
        void Limpar()
        {
            //Btn CheckCotista
            BtnCheckCotista.Enabled = true;

            //CmbBoxCotista
            cmbCotista.DataSource = null; cmbCotista.Enabled = false;

            //CmbTipoConta
            ComboBoxLiquida.SelectedIndex = -1; ComboBoxLiquida.Enabled = false;

            //Limpa e Libera TextCpfCnpj
            TextBoxCpfCnpj.Text = ""; TextBoxCpfCnpj.Enabled = true;

            //Limpa e Trava Dados da conta
            textboxcetip.Text = ""; textboxcetip.Enabled = false;
            textboxbanco.Text = ""; textboxbanco.Enabled = false;
            textboxconta.Text = ""; textboxconta.Enabled = false;
            textboxag.Text = ""; textboxag.Enabled = false;
            textboxdigito.Text = ""; textboxdigito.Enabled = false;
        }

        //Limpar Dados
        private void BtnLimpar_Click(object sender, EventArgs e) { Limpar(); }

        //Altera Liquidação
        private void ComboBoxLiquida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLiquida.Text == "CC")
            {
                //Habilita Modo CC
                textboxbanco.Enabled = true;
                textboxconta.Enabled = true;
                textboxag.Enabled = true;
                textboxdigito.Enabled = true;

                //Trava meio Cetip
                textboxcetip.Text = ""; textboxcetip.Enabled = false;
            }
            else if (ComboBoxLiquida.Text == "Cetip")
            {
                //Habilita Cetip
                textboxcetip.Enabled = true;

                //Trava CC
                textboxbanco.Text = ""; textboxbanco.Enabled = false;
                textboxconta.Text = ""; textboxconta.Enabled = false;
                textboxag.Text = ""; textboxag.Enabled = false;
                textboxdigito.Text = ""; textboxdigito.Enabled = false;
            }
        }
   
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Variaveis Auxiliares
            long Codcot;
            string Tipoconta;
            long Cetip =  0;
            int Banco = 0;
            int Agencia = 0;
            Int64 ContaCorrente = 0;
            int Digito = 0;
            
            //Valida Cotista
            if (cmbCotista.SelectedIndex < 0) { MessageBox.Show("Nenhum cotista selecionado!"); cmbCotista.Focus(); return; }

            //Valida Tipo Conta
            if (ComboBoxLiquida.SelectedIndex < 0) { MessageBox.Show("Nenhum tipo de conta selecionada!"); ComboBoxLiquida.Focus(); return; }

            //Valida Campo se for Cetip
            if (ComboBoxLiquida.Text == "Cetip" && !Int64.TryParse(textboxcetip.Text, out Cetip)) { MessageBox.Show("Erro ao converter conta Cetip!"); textboxcetip.Focus(); return; }

            //Valida Campos se for CC
            if (ComboBoxLiquida.Text == "CC")
            {
                //Valida Banco
                if (!int.TryParse(textboxbanco.Text, out Banco) || textboxbanco.Text.Length == 0) { MessageBox.Show("Erro ao validar o banco!"); textboxbanco.Focus(); return; }

                //Valida agencia
                if (!int.TryParse(textboxag.Text, out Agencia) || textboxag.Text.Length == 0) { MessageBox.Show("Erro ao validar a agencia!"); textboxag.Focus(); return; }

                //Valida CC
                if (!Int64.TryParse(textboxconta.Text, out ContaCorrente) || textboxconta.Text.Length == 0) { MessageBox.Show("Erro ao validar a conta!"); textboxconta.Focus(); return; }

                //Valida Digito
                if (!int.TryParse(textboxdigito.Text, out Digito) || textboxdigito.Text.Length == 0) { MessageBox.Show("Erro ao validar o digito!"); textboxdigito.Focus(); return; }

                Tipoconta = "CC";
            }
            else { Tipoconta = "Cetip"; }

            Codcot = Convert.ToInt64(cmbCotista.SelectedValue.ToString());

            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario != null && Usuario.USUARIO != "" && Usuario.SENHA != "")
            {
                try { Limpar(); MessageBox.Show(new BL_ContaCredito().Cadastrar(Codcot, Tipoconta, Cetip, Banco, Agencia, ContaCorrente, Digito, Usuario.USUARIO, Usuario.SENHA)); }
                catch (ArgumentException Ex) { MessageBox.Show("Não foi possivel cadastrar, Erro: " + Ex.Message); }
            }
            else { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); }

        }

        private void BtnCheckCotista_Click(object sender, EventArgs e)
        {
            if (new BL_Validador().CNPJ(TextBoxCpfCnpj.Text) || new BL_Validador().CPF(TextBoxCpfCnpj.Text))
            {
                List<BL_Cotista> Cotistas = new BL_Cotista().DadosPorCPFCNPJ(Convert.ToInt64(TextBoxCpfCnpj.Text));

                if (Cotistas.Count > 0)
                {
                    TextBoxCpfCnpj.Enabled = false; BtnCheckCotista.Enabled = false;
    
                    cmbCotista.DataSource = Cotistas;
                    cmbCotista.DisplayMember = "NOME";
                    cmbCotista.ValueMember = "CODCOT";

                    cmbCotista.Enabled = true; ComboBoxLiquida.Enabled = true;
                }
                else
                {
                    MessageBox.Show("CPF / CNPJ não encontrado");
                }
            }
        }
    }
}
