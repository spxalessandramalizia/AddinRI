using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Controle
{
    public partial class CadastroCotista : Form
    {
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public CadastroCotista() {
            InitializeComponent();
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }
        
        private void CadastroCotistaLoad()
        {
            DataTable Distribuidores = new BL_Distribuidor().DadosTable();
            Distribuidores.DefaultView.Sort = "RAZAOSOCIAL";
            cmbdistribuidor.DataSource = Distribuidores.DefaultView.ToTable();
            cmbdistribuidor.DisplayMember = "RAZAOSOCIAL";
            cmbdistribuidor.ValueMember = "CODIGO"; 
            cmbdistribuidor.SelectedIndex = -1;

            DataTable Alocadores = new BL_Alocador().DadosTable();
            Alocadores.DefaultView.Sort = "NOME";
            cmbalocador.DataSource = Alocadores.DefaultView.ToTable();
            cmbalocador.DisplayMember = "NOME";
            cmbalocador.ValueMember = "ID";
            cmbalocador.SelectedIndex = -1;

        }
        private void Btnsalvar_Click(object sender, EventArgs e)
        {
            //Valida Código Externo
            if (textboxcodext.Text.Length != 14) { MessageBox.Show("O código do cotista deve possuir 14 digitos!"); return; }

            //Valida Nome
            if (textboxnome.Text.Length == 0) { MessageBox.Show("Favor informar o nome do cotista"); return; }

            //Valida CPF
            if (!Int64.TryParse(textboxcpfcnpj.Text,out long CPFCNPJ)) { MessageBox.Show("Erro ao converter CPF/CNPJ, favor verificar!"); return; }

            //Valida Distribuidor
            if (cmbdistribuidor.SelectedIndex == -1) { MessageBox.Show("Favor selecionar um Distribuidor!"); return; }

            //Valida Alocador
            if (cmbalocador.SelectedIndex == -1) { MessageBox.Show("Favor selecionar um Alocador!"); return; }

            //Valida Validade
            if (!DateTime.TryParse(textboxvalidade.Text, out DateTime Data)) { MessageBox.Show("Erro ao converter a data de validade, favor verificar!"); return; }

            string Nome = textboxnome.Text;
            long Codcot = Convert.ToInt64(textboxcodext.Text);
            long Cpfcnpj = CPFCNPJ;
            long Coddist = Convert.ToInt64(cmbdistribuidor.SelectedValue.ToString());
            long Codalocador = Convert.ToInt64(cmbalocador.SelectedValue.ToString());
            DateTime Vencimento = Data;

            BL_Cotista Cotista = new BL_Cotista().DadosCompleto().FirstOrDefault(x => x.CODCOT == Codcot);
            if (Cotista != null)
            {
                if (Cotista.NOME == Nome && Cotista.CODCOT == Codcot && Cotista.CPFCNPJ == Cpfcnpj
                && Cotista.CODDIST == Coddist && Cotista.CODALOCADOR == Codalocador && Cotista.VENCIMENTO == Vencimento)
                {
                    MessageBox.Show("Cotista já cadastrado na base!");
                }
                else
                {
                    new BL_Cotista().Editar(Codcot, Nome, Cpfcnpj, Coddist, Codalocador, Vencimento);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
            }
            else
            {
                new BL_Cotista().Inserir(Codcot, Nome, Cpfcnpj, Coddist, Codalocador, Vencimento);
                MessageBox.Show("Cotista Salvo Com Sucesso!");
            }
            

            textboxcodext.Text = "";
            textboxcpfcnpj.Text = "";
            textboxnome.Text = "";
            textboxvalidade.Text = "";
            cmbalocador.SelectedIndex = -1;
            cmbdistribuidor.SelectedIndex = -1;

            textboxcodext.Enabled = true; BtnVerificar.Enabled = true; PainelCotista.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e) { this.Close(); }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textboxcodext.Text = "";
            textboxcpfcnpj.Text = "";
            textboxnome.Text = "";
            textboxvalidade.Text = "";
            cmbalocador.SelectedIndex = -1;
            cmbdistribuidor.SelectedIndex = -1;

            //Altera Configurações da Página
            textboxcodext.Enabled = true; BtnVerificar.Enabled = true; PainelCotista.Enabled = false;
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        //Verifica se o CODCOT já existe
        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (textboxcodext.Text.Length != 14) { MessageBox.Show("O código do cotista deve possuir 14 digitos."); return; }

            CadastroCotistaLoad();

            if (Int64.TryParse(textboxcodext.Text, out Int64 CODCOT))
            {
                BL_Cotista Cotista = new BL_Cotista().DadosCompleto().FirstOrDefault(x => x.CODCOT == CODCOT);

                //Carrega informações caso cotista seja encontrado
                if (Cotista != null)
                {
                    textboxcpfcnpj.Text = Cotista.CPFCNPJ.ToString();
                    textboxnome.Text = Cotista.NOME;
                    cmbdistribuidor.SelectedValue = Cotista.CODDIST;
                    cmbalocador.SelectedValue = Cotista.CODALOCADOR;
                    textboxvalidade.Text = Cotista.VENCIMENTO.ToShortDateString();
                }
                else
                //Busca informações na Intrag caso o cotista não esteja na base
                {
                    Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
                    if (Usuario != null && Usuario.USUARIO != "" && Usuario.SENHA != "") {
                        Cotista = new BL_Cotista().ConsultarCotista(Usuario.USUARIO, Usuario.SENHA, CODCOT.ToString());
                        if (Cotista != null)
                        {
                            textboxcpfcnpj.Text = Cotista.CPFCNPJ.ToString();
                            textboxnome.Text = Cotista.NOME;
                        }
                    }
                    else { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); }
                }
                //Altera Configurações da Página
                textboxcodext.Enabled = false; BtnVerificar.Enabled = false; PainelCotista.Enabled = true;
            }
        }

        private void textboxcpfcnpj_TextChanged(object sender, EventArgs e)
        {
            textboxcpfcnpj.Text = new Regex(@"[^\d]").Replace(textboxcpfcnpj.Text, "");
        }
    }
}
