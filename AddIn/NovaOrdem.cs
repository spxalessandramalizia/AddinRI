using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;

namespace AddIn
{
    public partial class NovaOrdem : Form
    {
        //Inicializador
        #region 
        public NovaOrdem(MailItem Email, List<BL_Boleta> BoletasImportadas)
        {
            EmailRecebido = Email;
            Email.Display();

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

            LabelEmail.Text = EmailRecebido.SenderName.ToString();
            LabelHora.Text = EmailRecebido.ReceivedTime.ToShortTimeString();
            LabelAssunto.Text = EmailRecebido.Subject.ToString();

            this.TopMost = true;
        }
        #endregion

        //Movimentar o Formulário
        #region MoveForm
        Point lastpoint;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e) { lastpoint = new Point(e.X, e.Y); }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { Left += e.X - lastpoint.X; Top += e.Y - lastpoint.Y; } }
        #endregion

        //Bases
        public MailItem EmailRecebido;
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
            else if (TextBoxValor.Text.Length == 0) { MessageBox.Show("Favor preencher o valor da Operação!"); TextBoxValor.Focus(); }
            //else if (LabelOp.Text != "Aplicação" && CODFUNDSRAPTOR.Contains(Convert.ToInt64(CmbBoxFIQ.SelectedValue))) { Limpar(); MessageBox.Show("Resgates do Raptor devem ser feitos Manualmente");  }

            else
            {
                //Conversor
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
                string Status = "Pendente";
                decimal VALOR = Convert.ToDecimal(TextBoxValor.Text);
                string CONTA = CmbBoxConta.Text;
                if(CONTA == "") { CONTA = "VIA TED"; }

                List<BL_Boleta> Boletas = new List<BL_Boleta>();
                BL_FIQ Fundo = new BL_FIQ().DadosPorCODFUND(CODFUND);
                BL_Cotista Cotista = new BL_Cotista().DadosPorCODCOT(CODCOT);

                if (Op() == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                else if (Op() != "AP" && Fundo.LOCKUP != 0)
                {
                    if (VALOR > new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS)
                    { MessageBox.Show("O valor solicitado é maior que o saldo disponível!"); }
                    else { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, VALOR, DateTime.Today, Op(), CONTA); }
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
            //Valida se possui boletas
            if (DataGridBoletas.Rows.Count == 0) { MessageBox.Show("Nenhuma boleta no DataGrid!"); return; }

            string IDORDEM = new BL_Ordem().Inserir(LabelEmail.Text, LabelAssunto.Text);

            foreach (DataGridViewRow DR in DataGridBoletas.Rows)
            {
                new BL_Boleta().Inserir(IDORDEM, Convert.ToInt64(DR.Cells[0].Value), Convert.ToInt64(DR.Cells[1].Value), DR.Cells[6].Value.ToString(), Convert.ToDateTime(DR.Cells[9].Value),
                    Convert.ToDateTime(DR.Cells[10].Value), DR.Cells[5].Value.ToString(), Convert.ToDecimal(DR.Cells[7].Value), DR.Cells[8].Value.ToString(), Convert.ToInt64(DR.Cells[11].Value));
            }

            DataGridBoletas.Rows.Clear();

            //Criar Email de Recebimento.
            string HTML = new HTML().ConfirmaRecebimento(new BL_Boleta().DadosIDORDEM(IDORDEM));

            MailItem EmailReply = EmailRecebido.ReplyAll();
            EmailReply.Recipients.Add("ri@spxcapital.com.br");
            EmailReply.HTMLBody = "<HTML><BODY>" + HTML + "</BODY></HTML>" + EmailReply.HTMLBody;
            if (CheckRecebimento.Checked)
            {
                EmailReply.Send();
            }
            else { EmailReply.Display(); }

            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            NameSpace nameSpace = outlook.GetNamespace("MAPI");
            MAPIFolder mapiFolderPurchase = nameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox).Parent;
            MAPIFolder BoletadosFolder = mapiFolderPurchase.Folders["Boletas do Dia"];
            MAPIFolder BoletadosRecebimento = mapiFolderPurchase.Folders["Boletas Recebidas"];

            //EmailRecebido.Move(BoletadosFolder);
            //EmailReply.Move(BoletadosRecebimento);

            MessageBox.Show("Ordem Gerada!");
        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            Limpar();

            if (LabelOp.Text == "Aplicação")
            {
                LabelOp.Text = "Resgate"; LabelOp.BackColor = Color.FromArgb(255, 153, 153); PanelOp.BackColor = Color.FromArgb(255, 153, 153);
                CmbBoxOp.DataSource = new string[] { "Financeiro", "Por Cotas", "Total" };
                CmbBoxOp.SelectedIndex = -1;
            }
            else
            {
                LabelOp.Text = "Aplicação"; LabelOp.BackColor = Color.FromArgb(179, 230, 179); PanelOp.BackColor = Color.FromArgb(179, 230, 179);
                CmbBoxOp.DataSource = new string[] { "Financeiro" };
                CmbBoxOp.SelectedIndex = 0;
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
                { Cotistas = new BL_Cotista().DadosPorCPFCNPJeSALDO(Convert.ToInt64(TextBoxCpfCnpj.Text), Convert.ToInt64(CmbBoxFIQ.SelectedValue.ToString())); }
                else { Cotistas = new BL_Cotista().DadosPorCPFCNPJ(Convert.ToInt64(TextBoxCpfCnpj.Text)); }

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
                    else { CmbCotista.Enabled = true; CmbCotista.SelectedIndex = -1; }
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
        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); EmailRecebido.Close(OlInspectorClose.olDiscard); }
        public void Limpar()
        {
            TextBoxCpfCnpj.Text = ""; TextBoxCpfCnpj.Enabled = true;

            CmbBoxFIQ.Text = ""; CmbBoxFIQ.Enabled = true;

            BtnVerificar.Enabled = true;

            CmbCotista.SelectedIndex = -1; CmbCotista.DataSource = new List<BL_Cotista>(); CmbCotista.Enabled = false;

            CmbBoxOp.SelectedIndex = -1; CmbBoxOp.Enabled = false; if (LabelOp.Text == "Aplicação") { CmbBoxOp.SelectedIndex = 0; }

            TextBoxValor.Text = ""; TextBoxValor.Enabled = false;

            CmbBoxConta.SelectedIndex = -1; CmbBoxConta.DataSource = new List<BL_ContaCredito>(); CmbBoxConta.Enabled = false;

            CmbBoxLiquida.SelectedIndex = -1; CmbBoxLiquida.Enabled = false;
        }
        #endregion

        //Macros Ativadas por variações no formulário
        #region
        private void TextBoxCpfCnpj_TextChanged(object sender, EventArgs e) { TextBoxCpfCnpj.Text = new Regex(@"[^\d]").Replace(TextBoxCpfCnpj.Text, ""); }
        private void TextBoxValor_Leave(object sender, EventArgs e)
        {
            if (CmbBoxOp.Text == "Financeiro" && TextBoxValor.Text.Length > 0)
            {
                try { TextBoxValor.Text = string.Format("{0:N}", Convert.ToDouble(TextBoxValor.Text)); }
                catch { MessageBox.Show("Valor Financeiro inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
            else if (CmbBoxOp.Text == "Por Cotas" && TextBoxValor.Text.Length > 0)
            {
                try { TextBoxValor.Text = Math.Round(Convert.ToDecimal(TextBoxValor.Text), 5).ToString(); }
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
                    CmbBoxConta.Text = ""; CmbBoxConta.Enabled = false;
                }

                if (CmbBoxConta.Items.Count == 1) { CmbBoxConta.Enabled = false; }
                else if (CmbBoxConta.Items.Count > 1) { CmbBoxConta.Enabled = true; CmbBoxConta.SelectedIndex = -1; }
                else { CmbBoxConta.Text = ""; CmbBoxConta.Enabled = false; }
            }
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
        #endregion


    }
}
