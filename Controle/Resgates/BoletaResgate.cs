using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Controle
{
    public partial class BoletaResgate : Form
    {
        //Variáveis de Dados
        #region
        //Bases:
        List<BL_FIQ> Fundos = new List<BL_FIQ>();
        List<BL_Cotista> Cotistas = new List<BL_Cotista>();
        List<BL_Saldo> Saldos = new List<BL_Saldo>();
        List<BL_ContaCredito> ContasCredito = new List<BL_ContaCredito>();

        //Auxiliares:
        BL_FIQ FIQ = new BL_FIQ();
        BL_Cotista Cotista = new BL_Cotista();
        BL_Saldo Saldo = new BL_Saldo();
        BL_ContaCredito ContaCredito = new BL_ContaCredito();
        #endregion

        //Inicializador
        #region 
        public BoletaResgate()
        {
            InitializeComponent();

            Fundos = new BL_FIQ().Dados().Where(x => x.CODMASTER != 61984).ToList();

            CmbCotista.DisplayMember = "NOME";
            CmbCotista.ValueMember = "CODCOT";
            CmbBoxFIQ.DisplayMember = "NOME";
            CmbBoxFIQ.ValueMember = "CODFUND";
            CmbBoxConta.DisplayMember = "DISPLAYCONTA";
            CmbBoxFIQ.DataSource = Fundos;
            CmbBoxFIQ.SelectedIndex = -1;
        }
        #endregion

        //Macros ativadas por botão
        #region
        private void BtnLimpar_Click(object sender, EventArgs e) { Limpar(); }

        private void Btnverificaposi_Click(object sender, EventArgs e)
        {
            //Valida CPF CNPJ e se tem fundo selecionado
            if ((new BL_Validador().CNPJ(TextBoxCpfCnpj.Text) || new BL_Validador().CPF(TextBoxCpfCnpj.Text)) && CmbBoxFIQ.SelectedIndex > -1)
            {
                //Busca Cotistas com CPFCNPJ e CODFUND selecionados com Saldo > 0
                Cotistas = new BL_Cotista().DadosPorCPFCNPJeSALDO(Convert.ToInt64(TextBoxCpfCnpj.Text), Convert.ToInt64(CmbBoxFIQ.SelectedValue.ToString()));

                if (Cotistas.Count == 0) { MessageBox.Show("Nenhum cotista com CPF e Saldo no fundo informado encontrado!"); return; }

                if (Cotistas.Count > 0)
                {
                    //Inclui Cotistas na Lista
                    CmbCotista.Enabled = true;
                    btnverificaposi.Enabled = false;
                    TextBoxCpfCnpj.Enabled = false;
                    CmbBoxFIQ.Enabled = false;
                    CmbBoxOp.Enabled = true;
                    CmbBoxLiquida.Enabled = true;

                    CmbCotista.DataSource = Cotistas;
                    FIQ = Fundos.FirstOrDefault(Fund => Fund.CODFUND.ToString() == CmbBoxFIQ.SelectedValue.ToString());

                    if (Cotistas.Count == 1) { CmbCotista.Enabled = false; }
                    else { CmbCotista.Enabled = true; }
                }
            }
            else if (CmbBoxFIQ.SelectedIndex > -1) { MessageBox.Show("CPF ou CNPJ inválido!"); }
            else { MessageBox.Show("Favor Selecionar um Fundo!"); }
        }

        private void BtnBoletar_Click(object sender, EventArgs e)
        {
            if (CmbCotista.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum Cotistas Selecionado!");
            }
            else if (CmbBoxOp.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum tipo de Operação Selecionada!");
                CmbBoxOp.Focus();
            }
            else if (CmbBoxLiquida.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum tipo de liquidação Selecionada!");
                CmbBoxLiquida.Focus();
            }
            else if (CmbBoxConta.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhuma conta selecionada!");
                CmbBoxConta.Focus();
            }
            else if (TextBoxValor.Text.Length == 0)
            {
                MessageBox.Show("Favor preencher o valor do resgate!");
                TextBoxValor.Focus();
            }
            else
            {
                //Converte Para Boleta de Resgate
                #region 
                ContaCredito = ContasCredito.FirstOrDefault(X => X.DISPLAYCONTA == CmbBoxConta.Text);

                long Codcot = Convert.ToInt64(CmbCotista.SelectedValue);
                long Codfund = FIQ.CODFUND;
                string Op = CmbBoxOp.Text;
                decimal Valor = Convert.ToDecimal(TextBoxValor.Text);
                string Status = "Pendente";
                string Conta = ContaCredito.DISPLAYCONTA;
       
                #endregion

                try
                {
                    new BL_RegistroResgate().Inserir(Codcot, Codfund, Op, Valor, Conta, Status);
                    MessageBox.Show("Registro Incluído com Sucesso!");
                    Limpar();
                }
                catch(ArgumentException Ex)
                {
                    MessageBox.Show("Erro ao Incluir: " + Ex.Message);
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        //Macros Ativadas por variações no formulário
        #region 
        private void CmbCotista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Encontra Saldo para CODCOT + CODFUND
            if (CmbCotista.SelectedIndex < 0) { return; }

            Saldo = new BL_Saldo().DadosPorCODCOTeCODFUND(Convert.ToInt64(CmbCotista.SelectedValue.ToString()), Convert.ToInt64(CmbBoxFIQ.SelectedValue.ToString()));

            if (CmbCotista.SelectedIndex > -1)
            {
                LabelCodigo.Text = CmbCotista.SelectedValue.ToString();
                LabelCota.Text = Saldo.COTA.ToString();
                LabelCotas.Text = Saldo.QNTCOTAS.ToString();
                LabelFin.Text = string.Format("{0:N}", Saldo.VLPATLIQ);
            }
            else
            {
                LabelCodigo.Text = "-";
                LabelCota.Text = "-";
                LabelCotas.Text = "-";
                LabelFin.Text = "-";
            }

            CmbBoxOp.SelectedIndex = -1;
            CmbBoxLiquida.SelectedIndex = -1;
            CmbBoxConta.SelectedIndex = -1;
            TextBoxValor.Text = "";
        }

        private void TextBoxCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            TextBoxCpfCnpj.Text = new Regex(@"[^\d]").Replace(TextBoxCpfCnpj.Text, "");
        }

        private void CmbBoxFIQ_TextChanged(object sender, EventArgs e)
        {
            if (CmbBoxFIQ.Text.Length == 5 && long.TryParse(CmbBoxFIQ.Text, out long codfund))
            {
                if (Fundos.Where(Fundo => Fundo.CODFUND == codfund).ToList().Count == 1)
                {
                    CmbBoxFIQ.Text = Fundos.Where(Fundo => Fundo.CODFUND == Convert.ToInt64(CmbBoxFIQ.Text)).ToList()[0].NOME;
                }
            }
        }

        private void TextBoxValor_Leave(object sender, EventArgs e)
        {
            if (CmbBoxOp.Text == "Financeiro" && TextBoxValor.Text.Length > 0)
            {
                try
                {
                    TextBoxValor.Text = string.Format("{0:N}", Convert.ToDouble(TextBoxValor.Text));

                    if (Convert.ToDouble(LabelFin.Text.ToString()) - Convert.ToDouble(TextBoxValor.Text) < Convert.ToDouble(FIQ.Valorsaldominimo))
                    {
                        MessageBox.Show("Valor inválido!\nO saldo mínimo no fundo é: " + string.Format("{0:N}", Convert.ToDouble(FIQ.Valorsaldominimo)));
                        TextBoxValor.Text = ""; TextBoxValor.Focus();
                    }
                    else if (Convert.ToDouble(TextBoxValor.Text) < Convert.ToDouble(FIQ.VALORMINRES))
                    {
                        MessageBox.Show("Valor inválido!\nO resgate mínimo no fundo  é: " + string.Format("{0:N}", Convert.ToDouble(FIQ.VALORMINRES)));
                        TextBoxValor.Text = ""; TextBoxValor.Focus();
                    }
                }
                catch { MessageBox.Show("Valor Financeiro inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
            else if (CmbBoxOp.Text == "Por Cotas" && TextBoxValor.Text.Length > 0)
            {
                try
                {
                    TextBoxValor.Text = Math.Round(Convert.ToDecimal(TextBoxValor.Text), 5).ToString();

                    if (Convert.ToDouble(LabelFin.Text.ToString()) - Convert.ToDouble(TextBoxValor.Text) * Convert.ToDouble(LabelCota.Text) < Convert.ToDouble(FIQ.Valorsaldominimo))
                    {
                        MessageBox.Show("Valor inválido!\nO saldo mínimo no fundo é: " + string.Format("{0:N}", Convert.ToDouble(FIQ.Valorsaldominimo)));
                        TextBoxValor.Text = ""; TextBoxValor.Focus();
                    }
                    else if (Convert.ToDouble(TextBoxValor.Text) * Convert.ToDouble(LabelCota.Text) < Convert.ToDouble(FIQ.VALORMINRES))
                    {
                        MessageBox.Show("Valor inválido!\nO resgate mínimo no fundo  é: " + string.Format("{0:N}", Convert.ToDouble(FIQ.VALORMINRES)));
                        TextBoxValor.Text = ""; TextBoxValor.Focus();
                    }
                }
                catch { MessageBox.Show("Valor Por Cotas inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
        }

        private void CmbBoxOp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbBoxOp.Text == "Financeiro")
            {
                TextBoxValor.Text = "";
                TextBoxValor.Enabled = true;
            }
            else if (CmbBoxOp.Text == "Por Cotas")
            {
                TextBoxValor.Text = "";
                TextBoxValor.Enabled = true;
            }
            else if (CmbBoxOp.Text == "Total")
            {
                TextBoxValor.Text = LabelCotas.Text;
                TextBoxValor.Enabled = false;
            }
            else
            {
                TextBoxValor.Enabled = false;
                TextBoxValor.Text = "Selecione Operação!";
            }
        }

        private void CmbBoxLiquida_SelectedValueChanged(object sender, EventArgs e)
        {
            //Busca ContasCredito para o Cotista Selecionado
            ContasCredito = new BL_ContaCredito().DadosPorCODCOT(Convert.ToInt64(CmbCotista.SelectedValue.ToString()));

            if (CmbCotista.SelectedIndex > -1 && ContasCredito.Count > 0)
            {
                if (CmbBoxLiquida.Text == "TED")
                {
                    CmbBoxConta.DataSource = ContasCredito.Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                    CmbBoxConta.Enabled = true;
                }
                else if (CmbBoxLiquida.Text == "CETIP")
                {
                    CmbBoxConta.DataSource = ContasCredito.Where(Cont => Cont.TIPOCONTA == "Cetip").ToList();
                    CmbBoxConta.Enabled = true;
                }
                else
                {
                    CmbBoxConta.Text = "";
                    CmbBoxConta.Enabled = false;
                }

                if (CmbBoxConta.Items.Count == 1)
                {
                    CmbBoxConta.Enabled = false;
                }
                else if (CmbBoxConta.Items.Count > 1)
                {
                    CmbBoxConta.Enabled = true;
                    CmbBoxConta.SelectedIndex = -1;
                }
                else
                {
                    CmbBoxConta.Text = "";
                    CmbBoxConta.Enabled = false;
                }
            }
        }
        #endregion

        //Função Geral que limpa o formulário
        private void Limpar()
        {
            TextBoxCpfCnpj.Text = "";
            TextBoxValor.Text = "";
            LabelCodigo.Text = "*";
            LabelCota.Text = "*";
            LabelCotas.Text = "*";
            LabelFin.Text = "*";

            CmbBoxLiquida.SelectedIndex = -1;
            CmbBoxOp.SelectedIndex = -1;
            CmbBoxFIQ.SelectedIndex = -1;
            CmbCotista.SelectedIndex = -1;

            CmbCotista.DataSource = new List<BL_Cotista>();
            CmbBoxConta.DataSource = new List<BL_ContaCredito>();

            btnverificaposi.Enabled = true;
            TextBoxCpfCnpj.Enabled = true;
            CmbBoxFIQ.Enabled = true;
            TextBoxValor.Enabled = false;
            CmbBoxOp.Enabled = false;
            CmbCotista.Enabled = false;
            CmbBoxLiquida.Enabled = false;
            CmbBoxConta.Enabled = false;
        }
    }
}
