using BLL;
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

namespace Controle
{
    public partial class NovaOrdem : Form
    {
        //Inicializador
        public NovaOrdem()
        {
            InitializeComponent();
            CmbBoxOp.SelectedIndex = 0;

            Fundos = new BL_FIQ().Dados();
            //CODFUNDSRAPTOR = new BL_FIQ().Dados().Where(x => x.CODMASTER == 61984).Select(x => x.CODFUND).ToList();

            CmbCotista.DisplayMember = "NOME";
            CmbCotista.ValueMember = "CODCOT";
            CmbBoxFIQ.DisplayMember = "NOME";
            CmbBoxFIQ.ValueMember = "CODFUND";
            CmbBoxConta.DisplayMember = "DISPLAYCONTA";
            CmbBoxFIQ.DataSource = Fundos;
            CmbBoxFIQ.SelectedIndex = -1;
        }

        //Bases
        List<BL_FIQ> Fundos = new List<BL_FIQ>();
        List<BL_Saldo> Saldos = new List<BL_Saldo>();
        BL_FIQ FIQ = new BL_FIQ();
        //List<long> CODFUNDSRAPTOR = new List<long>();

        //Clicks Botoes
        #region
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (CmbCotista.SelectedIndex == -1) { MessageBox.Show("Nenhum Cotistas Selecionado!"); }
            else if (CmbBoxOp.SelectedIndex == -1) { MessageBox.Show("Nenhum tipo de Operação Selecionada!"); CmbBoxOp.Focus(); }
            else if (CmbBoxLiquida.SelectedIndex == -1) { MessageBox.Show("Nenhum tipo de liquidação Selecionada!"); CmbBoxLiquida.Focus(); }
            else if (CmbBoxConta.SelectedIndex == -1 && !(LabelOp.Text == "Aplicação" && CmbBoxLiquida.Text == "TED")) { MessageBox.Show("Nenhuma conta selecionada!"); CmbBoxConta.Focus(); }
            else if (TextBoxValor.Text.Length == 0) { MessageBox.Show("Favor preencher o valor da operação!"); TextBoxValor.Focus(); }
            else if (CheckPorCautela.Checked == true && ComboBoxCautela.SelectedIndex == -1) { MessageBox.Show("Favor selecionar uma cautela!"); }
            //else if (LabelOp.Text != "Aplicação" && CODFUNDSRAPTOR.Contains(Convert.ToInt64(CmbBoxFIQ.SelectedValue))) { Limpar(); MessageBox.Show("Resgates do Raptor devem ser feitos manualmente!"); }

            else
            {//Conversor
                string Op()
                {
                    if (LabelOp.Text == "Aplicação") { return "AP"; }
                    else if (CmbBoxOp.Text == "Por Cotas") { return "RC"; }
                    else if (CmbBoxOp.Text == "Total") { return "RT"; }
                    else { return "R"; }
                }
                //Variaveis
                long CODCOT = Convert.ToInt64(CmbCotista.SelectedValue);
                long CODFUND = Convert.ToInt64(CmbBoxFIQ.SelectedValue);
                string OPERACAO = Op();
                decimal VALOR = Convert.ToDecimal(TextBoxValor.Text);
                string CONTA = CmbBoxConta.Text;
                if (CONTA == "") { CONTA = "VIA TED"; }

                List<BL_Boleta> Boletas = new List<BL_Boleta>();
                BL_FIQ Fundo = new BL_FIQ().DadosPorCODFUND(CODFUND);
                BL_Cotista Cotista = new BL_Cotista().DadosPorCODCOT(CODCOT);

                if (Op() == "R" && CheckPorCautela.Checked) { MessageBox.Show("Não é possível realizar resgates financeiros por cautela!"); }
                else if (Op() == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                else if (Op() != "AP" && Fundo.LOCKUP != 0 && !CheckPorCautela.Checked)
                {
                    if (VALOR > new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS)
                    { MessageBox.Show("O valor solicitado é maior que o saldo disponível!"); }
                    else { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, VALOR, DateTime.Today, Op(), CONTA); }
                }
                else if (CheckPorCautela.Checked)
                {
                    DataGridBoletas.Columns["Cautela"].Visible = true;
                    long CAUTELA = Convert.ToInt64(ComboBoxCautela.SelectedValue);
                    BL_Saldo Cautela = new BL_Saldo().CautelasPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).FirstOrDefault(x => x.CAUTELA == CAUTELA);
                    if (VALOR > Cautela.QNTCOTAS) { MessageBox.Show("O valor solicitado é maior que a quantidade de cotas disponível na cautela!"); }
                    else { Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, VALOR, DateTime.Today, Op(), CONTA, CAUTELA)); }
                }
                else
                {
                    Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, VALOR, DateTime.Today, Op(), CONTA));
                    if (Op() == "AP") { Boletas[0].STATUS = new BL_Boleta().VerificarCotista(CODCOT, CODFUND, Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha); }
                }

                Boletas.OrderBy(x => x.COTIZACAO).ToList();
                foreach (BL_Boleta Boleta in Boletas)
                {
                    DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                        Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                }
                Limpar();
            }
        }

        private void BtnGerarOrdem_Click(object sender, EventArgs e)
        {
            string IDORDEM;

            //Valida se possui boletas
            if (DataGridBoletas.Rows.Count == 0) { MessageBox.Show("Nenhuma boleta no DataGrid!"); return; }

            //Valida se o metodo for de incluir Ordem, se possui ordem selecionada.
            if (CheckIncluirAOrdem.Checked && CmbOrdem.SelectedIndex == -1) { MessageBox.Show("Nenhuma ordem selecionada!"); CmbOrdem.Focus(); return; }
            //inserre a ordem na base e retorna a id criptografada da ordem
            else if (!CheckIncluirAOrdem.Checked) { IDORDEM = new BL_Ordem().Inserir("Manual", "Manual"); }
            else
            { //recupera a id da ordem selecionada e limpa o formulário
                IDORDEM = CmbOrdem.Text;
                CmbOrdem.Enabled = false;
                CmbOrdem.SelectedIndex = -1;
                CheckIncluirAOrdem.Checked = false;
            }

            foreach (DataGridViewRow DR in DataGridBoletas.Rows)
            {
                new BL_Boleta().Inserir(IDORDEM, Convert.ToInt64(DR.Cells[0].Value), Convert.ToInt64(DR.Cells[1].Value), DR.Cells[6].Value.ToString(), Convert.ToDateTime(DR.Cells[9].Value),
                    Convert.ToDateTime(DR.Cells[10].Value), DR.Cells[5].Value.ToString(), Convert.ToDecimal(DR.Cells[7].Value), DR.Cells[8].Value.ToString(), Convert.ToInt64(DR.Cells[11].Value));
            }

            DataGridBoletas.Rows.Clear();
            DataGridBoletas.Columns["Cautela"].Visible = false;

        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            Limpar();

            if (LabelOp.Text == "Aplicação")
            {
                LabelOp.Text = "Resgate"; LabelOp.BackColor = Color.FromArgb(255, 153, 153); PanelOp.BackColor = Color.FromArgb(255, 153, 153);
                CmbBoxOp.DataSource = new string[] { "Financeiro", "Por Cotas", "Total" };
                CmbBoxOp.SelectedIndex = -1;
                CheckPorCautela.Visible = true; ComboBoxCautela.Visible = true;
            }
            else
            {
                LabelOp.Text = "Aplicação"; LabelOp.BackColor = Color.FromArgb(179, 230, 179); PanelOp.BackColor = Color.FromArgb(179, 230, 179);
                CmbBoxOp.DataSource = new string[] { "Financeiro" };
                CmbBoxOp.SelectedIndex = 0;
                CheckPorCautela.Visible = false; ComboBoxCautela.Visible = false;
            }
        }
        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            //Valida CPF CNPJ e se tem fundo selecionado
            if ((new BL_Validador().CNPJ(TextBoxCpfCnpj.Text) || new BL_Validador().CPF(TextBoxCpfCnpj.Text)) && CmbBoxFIQ.SelectedIndex > -1)
            {
                FIQ = new BL_FIQ().DadosPorCODFUND(Convert.ToInt64(CmbBoxFIQ.SelectedValue));
                List<BL_Cotista> Cotistas = new List<BL_Cotista>();

                //Valida se o fundo foi encontrado
                if (FIQ == null) { MessageBox.Show("Fundo não encontrado!"); return; }

                //Se for resgate, busca cotistas que possuem saldo no fundo
                if (LabelOp.Text == "Resgate")
                {
                    if (FIQ.LOCKUP != 0) { DataGridBoletas.Columns["Cautela"].Visible = true; }
                    Cotistas = new BL_Cotista().DadosPorCPFCNPJeSALDO(Convert.ToInt64(TextBoxCpfCnpj.Text), Convert.ToInt64(CmbBoxFIQ.SelectedValue.ToString()));
                }
                else
                {
                    Cotistas = new BL_Cotista().DadosPorCPFCNPJ(Convert.ToInt64(TextBoxCpfCnpj.Text));
                }

                if (Cotistas.Count > 0)
                {
                    //Inclui Cotistas na Lista
                    CmbCotista.Enabled = true;
                    BtnVerificar.Enabled = false;
                    TextBoxCpfCnpj.Enabled = false;
                    CmbBoxFIQ.Enabled = false;
                    CmbBoxLiquida.Enabled = true;
                    CmbCotista.DataSource = Cotistas;

                    if (LabelOp.Text == "Resgate") { CmbBoxOp.Enabled = true; TextBoxValor.Enabled = true; }
                    else { TextBoxValor.Enabled = true; }

                    if (Cotistas.Count == 1) { CmbCotista.Enabled = false; }
                    else { CmbCotista.Enabled = true; }
                }
                else
                {
                    if (LabelOp.Text == "Resgate") { MessageBox.Show("CPF / CNPJ não possui saldo no " + CmbBoxFIQ.Text); }
                    else { MessageBox.Show("CPF / CNPJ não retornou cotistas!"); }
                }

            }
            else if (CmbBoxFIQ.SelectedIndex > -1) { MessageBox.Show("CPF ou CNPJ Inválido!"); }
            else { MessageBox.Show("Favor Selecionar um Fundo!"); }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DataGridBoletas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Favor Selecionar um Registro");
                return;
            }
            else { DataGridBoletas.Rows.RemoveAt(DataGridBoletas.SelectedRows[0].Index); }

            DataGridBoletas.ClearSelection();
        }
        private void BtnLimpar_Click(object sender, EventArgs e) { Limpar(); }
        private void BtnLimparGrid_Click(object sender, EventArgs e) { DataGridBoletas.Rows.Clear(); }
        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }
        private void Limpar()
        {
            TextBoxCpfCnpj.Text = ""; TextBoxCpfCnpj.Enabled = true;

            CmbBoxFIQ.Text = ""; CmbBoxFIQ.Enabled = true;

            BtnVerificar.Enabled = true;

            CmbCotista.SelectedIndex = -1; CmbCotista.DataSource = new List<BL_Cotista>(); CmbCotista.Enabled = false;

            CmbBoxOp.SelectedIndex = -1; CmbBoxOp.Enabled = false; if (LabelOp.Text == "Aplicação") { CmbBoxOp.SelectedIndex = 0; }

            TextBoxValor.Text = ""; TextBoxValor.Enabled = false;

            CmbBoxConta.SelectedIndex = -1; CmbBoxConta.DataSource = new List<BL_ContaCredito>(); CmbBoxConta.Enabled = false;

            CmbBoxLiquida.SelectedIndex = -1; CmbBoxLiquida.Enabled = false;

            CheckIncluirAOrdem.Checked = false; CheckPorCautela.Checked = false;
        }
        #endregion

        //Macros Ativadas por variações no formulário
        #region
        private void TextBoxCpfCnpj_TextChanged(object sender, EventArgs e) { TextBoxCpfCnpj.Text = new Regex(@"[^\d]").Replace(TextBoxCpfCnpj.Text, ""); }
        private void TextBoxValor_Leave(object sender, EventArgs e)
        {
            if (CmbBoxOp.Text == "Financeiro" && TextBoxValor.Text.Length > 0)
            {
                try
                {
                    TextBoxValor.Text = string.Format("{0:N}", Convert.ToDouble(TextBoxValor.Text));
                }
                catch { MessageBox.Show("Valor Financeiro inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
            else if (CmbBoxOp.Text == "Por Cotas" && TextBoxValor.Text.Length > 0)
            {
                try
                {
                    TextBoxValor.Text = Math.Round(Convert.ToDecimal(TextBoxValor.Text), 5).ToString();
                }
                catch { MessageBox.Show("Valor Por Cotas inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
        }
        private void CmbCotista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LabelOp.Text == "Resgate") { CmbBoxOp.SelectedIndex = -1; }
            else { TextBoxValor.Enabled = true; }

            CmbBoxLiquida.SelectedIndex = -1;
            CmbBoxConta.SelectedIndex = -1;
            TextBoxValor.Text = "";
        }
        private void CmbBoxOp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbCotista.SelectedIndex > -1)
            {
                if (CmbBoxOp.Text == "Financeiro") { TextBoxValor.Text = ""; TextBoxValor.Enabled = true; }
                else if (CmbBoxOp.Text == "Por Cotas") { TextBoxValor.Text = ""; TextBoxValor.Enabled = true; }
                else if (CmbBoxOp.Text == "Total")
                {
                    TextBoxValor.Text = new BL_Saldo().DadosPorCODCOTeCODFUND(Convert.ToInt64(CmbCotista.SelectedValue.ToString()), Convert.ToInt64(CmbBoxFIQ.SelectedValue.ToString())).QNTCOTAS.ToString();
                    TextBoxValor.Enabled = false;
                }
            }
        }
        private void CmbBoxLiquida_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbCotista.SelectedIndex == -1) { return; }

            if (CmbCotista.SelectedIndex > -1)
            {
                if (CmbBoxLiquida.Text == "TED" && LabelOp.Text == "Resgate")
                {
                    CmbBoxConta.DataSource = new BL_ContaCredito().DadosPorCODCOT(Convert.ToInt64(CmbCotista.SelectedValue)).Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                    CmbBoxConta.Enabled = true;
                }
                else if (CmbBoxLiquida.Text == "CETIP")
                {
                    CmbBoxConta.DataSource = new BL_ContaCredito().DadosPorCODCOT(Convert.ToInt64(CmbCotista.SelectedValue)).Where(Cont => Cont.TIPOCONTA == "Cetip").ToList();
                    CmbBoxConta.Enabled = true;
                }
                else
                {
                    CmbBoxConta.Text = "";
                    CmbBoxConta.Enabled = false;
                }

                if (CmbBoxConta.Items.Count == 1) { CmbBoxConta.Enabled = false; }
                else if (CmbBoxConta.Items.Count > 1) { CmbBoxConta.Enabled = true; CmbBoxConta.SelectedIndex = -1; }
                else { CmbBoxConta.Text = ""; CmbBoxConta.Enabled = false; }
            }
        }
        //Completa textbox com o nome do fundo pelo código
        private void CmbBoxFIQ_TextChanged(object sender, EventArgs e)
        {
            if (CmbBoxFIQ.Text.Length == 5 && long.TryParse(CmbBoxFIQ.Text, out long codfund))
            {
                Console.WriteLine(Fundos.Where(Fundo => Fundo.CODFUND == codfund).ToList().Count);
                if (Fundos.Where(Fundo => Fundo.CODFUND == codfund).ToList().Count == 1)
                {
                    CmbBoxFIQ.Text = Fundos.Where(Fundo => Fundo.CODFUND == Convert.ToInt64(CmbBoxFIQ.Text)).ToList()[0].NOME;
                }
            }
        }
        private void CheckIncluirAOrdem_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIncluirAOrdem.Checked)
            {
                //AtualizaDados do CheckBox
                CmbOrdem.DataSource = new BL_Ordem().DadosPorData(DateTime.Today).Select(x => x.IDORDEM).ToList();

                CmbOrdem.Enabled = true; CmbOrdem.SelectedIndex = -1;
            }
            else { CmbOrdem.Enabled = false; CmbOrdem.SelectedIndex = -1; }
        }
        #endregion

        private void CheckPorCautela_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCautela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}