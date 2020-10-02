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
using System.Security.Principal;
using BLL;

namespace Controle
{
    public partial class ContaOrdem : Form
    {
        //Variaveis 
        #region
        List<BL_Distribuidor> Distribuidores = new List<BL_Distribuidor>();
        List<BL_FIQ> Fundos = new List<BL_FIQ>();
        List<BL_Cotista> Cotistas = new List<BL_Cotista>();
        List<BL_ContaCredito> Contas = new List<BL_ContaCredito>();
        BL_Distribuidor DistribuidorAux = new BL_Distribuidor();
        List<BL_Saldo> Saldos = new List<BL_Saldo>();
        private string WINDOWSNAME;
        BL_Usuario Usuario;
        #endregion

        public ContaOrdem()
        {
            InitializeComponent();

            Distribuidores = new BL_Distribuidor().Dados().Where(x => x.POSSUICEO == "Sim").ToList();

            //Distribuidores.Insert(0, new BL_Distribuidor() { RAZAOSOCIAL = "                 - - - Distribuidor - - -" });
            CmbBoxDistribuidor.DisplayMember = "RAZAOSOCIAL";
            CmbBoxDistribuidor.ValueMember = "CNPJ";
            CmbBoxDistribuidor.DataSource = Distribuidores;
            CmbBoxDistribuidor.SelectedIndex = -1;

            Fundos = new BL_FIQ().Dados();
            CmbBoxFIQ.DisplayMember = "NOME";
            CmbBoxFIQ.ValueMember = "CODFUND";
            CmbBoxFIQ.DataSource = Fundos;
            CmbBoxFIQ.SelectedIndex = -1;

            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];

        }

        private void ProcessarDataGrid()
        {
            //Carrega Base de Cotistas
            Cotistas = new BL_Cotista().DadosPorCPFCNPJ(Convert.ToInt64(CmbBoxDistribuidor.SelectedValue.ToString()));

            //Carrega Saldos
            Saldos = new BL_Saldo().DadosPorCPFCNPJ(Convert.ToInt64(CmbBoxDistribuidor.SelectedValue.ToString()));

            //Contas
            Contas = new BL_ContaCredito().DadosPorCPFCNPJ(Convert.ToInt64(CmbBoxDistribuidor.SelectedValue.ToString()));

            //Percorre todas Boletas
            foreach (DataGridViewRow DR in DataGridBoletas.Rows)
            {
                BL_FIQ FundoAux = Fundos.FirstOrDefault(x => x.CODFUND == Convert.ToInt64(DR.Cells[5].Value));
                if (FundoAux == null) { MessageBox.Show("Fundo não encontrado!"); continue; }

                //Seleciona o cotista pelo nome e cnpj
                BL_Cotista CotistaAux = Cotistas.FirstOrDefault(x => x.NOME == DR.Cells[0].Value.ToString() && x.CPFCNPJ == Convert.ToInt64(DR.Cells[1].Value));
                if (CotistaAux != null) { DR.Cells[2].Value = CotistaAux.CODCOT; DR.Cells[8].Value = "Cadastrado"; }

                //Aplicação
                if (DR.Cells[3].Value.ToString() == "AP" && DR.Cells[2].Value.ToString().Length == 14) { DR.Cells[8].Value = "Liberado"; }

                //Contas Cadastradas
                if (DR.Cells[3].Value.ToString() != "AP" && DR.Cells[2].Value.ToString().Length == 14)
                {
                    long BANCO = Convert.ToInt64(DR.Cells[7].Value.ToString().Split('-')[0]);
                    long AGENCIA = Convert.ToInt64(DR.Cells[7].Value.ToString().Split('-')[1]);
                    long CONTA = Convert.ToInt64(DR.Cells[7].Value.ToString().Split('-')[2]);
                    long DIGITO = Convert.ToInt64(DR.Cells[7].Value.ToString().Split('-')[3]);

                    if (Contas.Where(x => x.CODCOT == Convert.ToInt64(DR.Cells[2].Value) && BANCO == x.BANCO && AGENCIA == x.AGENCIA && CONTA == Convert.ToInt64(x.CONTA) && DIGITO == x.DIGITO).ToList().Count > 0)
                    {
                        DR.Cells[8].Value = "Conta Cadastrada";
                    }
                    else { DR.Cells[8].Value = "Conta Pendente"; }
                }

                //Saldo Para cotistas com status Conta Cadastrada
                if (DR.Cells[3].Value.ToString() != "AP" && DR.Cells[8].Value.ToString() == "Conta Cadastrada")
                {
                    //Saldo Auxiliar
                    BL_Saldo SaldoAux = Saldos.FirstOrDefault(x => x.CODCOT == Convert.ToInt64(DR.Cells[2].Value) && x.CODFUND == Convert.ToInt64(DR.Cells[5].Value) && x.TIPOREGISTRO == "Total");

                    if (SaldoAux == null) { continue; }

                    if (DR.Cells[3].Value.ToString() == "RT")
                    {
                        DR.Cells[6].Value = Convert.ToDecimal(SaldoAux.QNTCOTAS).ToString();
                        DR.Cells[8].Value = "Liberado";
                    }
                    else if (DR.Cells[3].Value.ToString() == "R")
                    {
                        decimal Cota = new BL_Cota().UltimaCota(FundoAux.CODFUND).COTA;
                        //Valida se vai ferir saldo minimo
                        if (SaldoAux.QNTCOTAS * Cota - Convert.ToDecimal(DR.Cells[6].Value) >= FundoAux.Valorsaldominimo && Convert.ToDecimal(DR.Cells[6].Value) >= FundoAux.VALORMINRES)
                        {
                            DR.Cells[8].Value = "Liberado";
                        }
                    }
                    else if (DR.Cells[3].Value.ToString() == "RC")
                    {
                        decimal Cota = new BL_Cota().UltimaCota(FundoAux.CODFUND).COTA;
                        //Valida se vai ferir saldo minimo
                        if ((SaldoAux.QNTCOTAS - Convert.ToDecimal(DR.Cells[6].Value)) * Cota >= FundoAux.Valorsaldominimo && Convert.ToDecimal(DR.Cells[6].Value) * Cota >= FundoAux.VALORMINRES)
                        {
                            DR.Cells[8].Value = "Liberado";
                        }
                    }
                }
            }
        }

        //Btns Clicks
        #region
        private void BtnGerarOrdem_Click(object sender, EventArgs e)
        {
            //Verificar se todos cotistas estão liberados
            if (DataGridBoletas.Rows.OfType<DataGridViewRow>().Where(r => r.Cells[8].Value.ToString() != "Liberado").Count() > 0) { MessageBox.Show("Verificar Cotistas não Liberados!"); return; }

            string IDORDEM = new BL_Ordem().Inserir("C&O", "C&O");

            foreach (DataGridViewRow DR in DataGridBoletas.Rows)
            {
                new BL_Boleta().Inserir(IDORDEM, Convert.ToInt64(DR.Cells[2].Value), Convert.ToInt64(DR.Cells[5].Value), DR.Cells[8].Value.ToString(),
                    DateTime.Today, DateTime.Today, DR.Cells[3].Value.ToString(), Convert.ToDecimal(DR.Cells[6].Value), DR.Cells[7].Value.ToString());
            }

            //Limpa Formulário
            {
                //Limpar Dados do DataGrid
                CmbBoxFIQ.SelectedIndex = -1; CmbBoxFIQ.Text = "";

                //Limpa 
                CmbBoxOp.SelectedIndex = -1;

                //limpa dados boleta
                TextBoxCOD.Text = ""; TextBoxValor.Text = "";

                //Limpa dados conta credito
                TextBoxBanco.Text = ""; TextBoxAg.Text = ""; TextBoxConta.Text = "";

                //Limpa DataGrid
                DataGridBoletas.Rows.Clear();

                PanelOrdem.Enabled = false;
                CmbBoxDistribuidor.Enabled = true;
            }

            MessageBox.Show("Ordem Gerada!");

        }
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            //Valida se todos CNPJS são iguais
            //Valida Linha a Linha
            string CNPJ = TextImporta.Lines[0].Split(';')[21];

            //Se posssuir CNPJs Diferentes
            foreach (string Line in TextImporta.Lines) { if (CNPJ != Line.Split(';')[21]) { MessageBox.Show("CNPJs Diferentes!"); return; } }

            for (int i = 0; i < Distribuidores.Count; i++)
            {
                if (Distribuidores[i].CNPJ == Convert.ToInt64(new Regex(@"[^\d]").Replace(CNPJ, ""))) { CmbBoxDistribuidor.SelectedIndex = i; }
            }

            if (CmbBoxDistribuidor.SelectedIndex == -1) { MessageBox.Show("CNPJ não reconhecido!"); }
        
            PanelOrdem.Enabled = true;
            CmbBoxDistribuidor.Enabled = false;

            //Valida Dados
            foreach (string Line in TextImporta.Lines) { if (Line.Split(';').Count() != 23) { TextImporta.Text = ""; MessageBox.Show("Importação inválida!");  return; } }

            //Valida Linha a Linha
            foreach (string Line in TextImporta.Lines)
            {
                try
                {
                    if (Line.Substring(0, 2) == "ID") { continue; }

                    string NOME;
                    long CPFCNPJ;
                    string OP;
                    long CODFUND;
                    decimal VALOR;
                    string STATUS;
                    string CONTA;
         
                    BL_FIQ FundoAux = Fundos.FirstOrDefault(x => x.CNPJ == Convert.ToInt64(new Regex(@"[^\d]").Replace(Line.Split(';')[3], "")));

                    CPFCNPJ = Convert.ToInt64(new Regex(@"[^\d]").Replace(Line.Split(';')[21], ""));

                    if (Line.Split(';')[4] == "A") { OP = "AP"; VALOR = Convert.ToDecimal(Line.Split(';')[6]); }
                    else if (Line.Split(';')[4] == "RP") { OP = "R"; VALOR = Convert.ToDecimal(Line.Split(';')[6]); }
                    else if (Line.Split(';')[4] == "RC") { OP = "RC"; VALOR = Convert.ToDecimal(Line.Split(';')[5]); }
                    else { OP = "RT"; VALOR = 0; }

                    NOME = Line.Split(';')[2];
                    CODFUND = FundoAux.CODFUND;
                    STATUS = "Pendente";

                    if (OP != "AP")
                    {
                        long BANCO;
                        long AGENCIA;
                        long CC;
                        long DIGITO;

                        BANCO = Convert.ToInt16(Line.Split(';')[9]);
                        AGENCIA = Convert.ToInt16(Line.Split(';')[10]);

                        //Se não tiver digito, converte ultimo digito da  conta em digito verificador
                        if (Line.Split(';')[12].Length == 0)
                        {
                            CC = Convert.ToInt32(Line.Split(';')[11].Substring(0, Line.Split(';')[11].Length - 1));
                            DIGITO = Convert.ToInt16(Line.Split(';')[11].Substring(Line.Split(';')[11].Length - 1, 1));
                        }
                        else
                        {
                            CC = Convert.ToInt32(Line.Split(';')[11]);
                            DIGITO = Convert.ToInt16(Line.Split(';')[12]);
                        }

                        CONTA = BANCO + " - " + AGENCIA + " - " + CC + " - " + DIGITO;
                    }
                    else { CONTA = "VIA TED"; }

                    DataGridBoletas.Rows.Add(new string[] { NOME, CPFCNPJ.ToString(),"", OP, FundoAux.NOME,FundoAux.CODFUND.ToString(), VALOR.ToString(), CONTA, STATUS });
                }
                catch { MessageBox.Show("Linha não processada: " + Line); }
            }

            TextImporta.Text = "";
        }
        private void BtnProcessar_Click(object sender, EventArgs e) { ProcessarDataGrid(); }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            //Valida COD
            if (TextBoxCOD.Text.Length == 0) { MessageBox.Show("Favor informar o código"); TextBoxCOD.Focus(); return; }

            //Valida Operação
            if (CmbBoxOp.SelectedIndex == -1) { MessageBox.Show("Favor informar a operação"); CmbBoxOp.Focus(); return; }

            //Valida Valor
            if (TextBoxValor.Text.Length == 0 && CmbBoxOp.Text != "Resgate Total") { MessageBox.Show("Favor informar o valor da operação"); TextBoxValor.Focus(); return; }

            //Valida Conta se for Resgate
            if (TextBoxBanco.Text.Length == 0 && CmbBoxOp.Text != "Aplicação") { MessageBox.Show("Favor informar o banco"); TextBoxBanco.Focus(); return; }
            if (TextBoxAg.Text.Length == 0 && CmbBoxOp.Text != "Aplicação") { MessageBox.Show("Favor informar a Agencia"); TextBoxAg.Focus(); return; }
            if (TextBoxConta.Text.Length == 0 && CmbBoxOp.Text != "Aplicação") { MessageBox.Show("Favor informar a Conta"); TextBoxConta.Focus(); return; }
            if (TextBoxDCC.Text.Length == 0 && CmbBoxOp.Text != "Aplicação") { MessageBox.Show("Favor informar o Digito"); TextBoxDCC.Focus(); return; }

            DistribuidorAux = Distribuidores.FirstOrDefault(x => x.CNPJ.ToString() == CmbBoxDistribuidor.SelectedValue.ToString());

            string NOME = DistribuidorAux.PREFIXOCEO + " " + TextBoxCOD.Text;
            long CPFCNPJ = DistribuidorAux.CNPJ;
            string OP;
            long CODFUND = Convert.ToInt64(CmbBoxFIQ.SelectedValue);
            decimal VALOR;
            string STATUS = "Pendente";
            string CONTA;

            if (CmbBoxOp.Text == "Aplicação") { OP = "AP"; VALOR = Convert.ToDecimal(TextBoxValor.Text); }
            else if (CmbBoxOp.Text == "Resgate") { OP = "R"; VALOR = Convert.ToDecimal(TextBoxValor.Text); }
            else if (CmbBoxOp.Text == "Resgate por Cotas") { OP = "RC"; VALOR = Convert.ToDecimal(TextBoxValor.Text); }
            else { OP = "RT"; VALOR = 0; }

            if (OP != "AP")
            {
                long BANCO = Convert.ToInt16(TextBoxBanco.Text);
                long AGENCIA = Convert.ToInt64(TextBoxAg.Text);
                long CC = Convert.ToInt64(TextBoxConta.Text);
                long DIGITO = Convert.ToInt64(TextBoxDCC.Text);

                CONTA = BANCO.ToString() + " - " + AGENCIA.ToString() + " - " + CC.ToString() + " - " + DIGITO.ToString(); 
            }
            else { CONTA = "VIA TED"; }

            DataGridBoletas.Rows.Add(new string[] { NOME, CPFCNPJ.ToString(), "", OP, Fundos.FirstOrDefault(x => x.CODFUND == CODFUND).NOME, CODFUND.ToString(), VALOR.ToString(), CONTA, STATUS });

            //Limpar Dados do DataGrid
            CmbBoxFIQ.SelectedIndex = -1; CmbBoxFIQ.Text = "";

            //Limpa 
            CmbBoxOp.SelectedIndex = -1;

            //limpa dados boleta
            TextBoxCOD.Text = ""; TextBoxValor.Text = "";

            //Limpa dados conta credito
            TextBoxBanco.Text = ""; TextBoxAg.Text = ""; TextBoxConta.Text = "";

        }
        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }
        private void BtnSelecionarDist_Click(object sender, EventArgs e)
        {
            PanelOrdem.Enabled = true;
            CmbBoxDistribuidor.Enabled = false;
        }
        private void BtnLimpa_Click(object sender, EventArgs e)
        {
            //Limpar Dados do DataGrid
            CmbBoxFIQ.SelectedIndex = -1; CmbBoxFIQ.Text = "";

            //Limpa 
            CmbBoxOp.SelectedIndex = -1;

            //limpa dados boleta
            TextBoxCOD.Text = ""; TextBoxValor.Text = "";

            //Limpa dados conta credito
            TextBoxBanco.Text = ""; TextBoxAg.Text = ""; TextBoxConta.Text = "";

            //Limpa DataGrid
            DataGridBoletas.Rows.Clear();

            PanelOrdem.Enabled = false;
            CmbBoxDistribuidor.Enabled = true;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DataGridBoletas.SelectedRows.Count == 1) { DataGridBoletas.Rows.Remove(DataGridBoletas.SelectedRows[0]); }
            else { MessageBox.Show("Nenhuma movimentação selecionada!"); }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar Dados do DataGrid
            CmbBoxFIQ.SelectedIndex = -1; CmbBoxFIQ.Text = "";

            //Limpa 
            CmbBoxOp.SelectedIndex = -1;

            //limpa dados boleta
            TextBoxCOD.Text = ""; TextBoxValor.Text = "";

            //Limpa dados conta credito
            TextBoxBanco.Text = ""; TextBoxAg.Text = ""; TextBoxConta.Text = "";
        }
        #endregion

        //Cadastra Cotistas
        #region
        private void BackCadastraCotistas_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (DataGridViewRow DR in DataGridBoletas.Rows)
            {
                if (DR.Cells[3].Value.ToString() == "AP" && DR.Cells[8].Value.ToString() == "Pendente")
                {
                    string NOME = DR.Cells[0].Value.ToString();
                    long CPFCNPJ = Convert.ToInt64(DR.Cells[1].Value);
                    long CODDIST = Distribuidores.FirstOrDefault(x => x.CNPJ == CPFCNPJ).CODIGO;

                    new BL_Cotista().Cadastrar(NOME, CPFCNPJ, CODDIST, Usuario.USUARIO, Usuario.SENHA);
                }
            }
        }
        private void BtnCadastrarCotistas_Click(object sender, EventArgs e)
        {
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario == null || Usuario.USUARIO == "" || Usuario.SENHA == "") { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); return; }
            if (!BackCadastraCotistas.IsBusy) { ProcessarDataGrid(); BackCadastraCotistas.RunWorkerAsync(); this.Enabled = false; }
        }
        private void BackCadastraCotistas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
            ProcessarDataGrid();
        }

        #endregion

        //Cadastra Contas Credito
        #region
        private void BackCadastraConta_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (DataGridViewRow DR in DataGridBoletas.Rows)
            {
                if (DR.Cells[3].Value.ToString() != "AP" && DR.Cells[8].Value.ToString() == "Conta Pendente")
                {
                    long Codcot = Convert.ToInt64(DR.Cells[2].Value);
                    int Banco = Convert.ToInt16(DR.Cells[7].Value.ToString().Split('-')[0]);
                    int Agencia = Convert.ToInt16(DR.Cells[7].Value.ToString().Split('-')[1]);
                    long Conta = Convert.ToInt64(DR.Cells[7].Value.ToString().Split('-')[2]);
                    int Digito = Convert.ToInt16(DR.Cells[7].Value.ToString().Split('-')[3]);

                    new BL_ContaCredito().Cadastrar(Codcot,"CC",0,Banco,Agencia, Conta,Digito, Usuario.USUARIO, Usuario.SENHA);
                }       
            }
        }    
        private void BtnCadastrarConta_Click(object sender, EventArgs e) {
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario == null) { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); return; }
            if (!BackCadastraConta.IsBusy) { ProcessarDataGrid(); BackCadastraConta.RunWorkerAsync(); this.Enabled = false; }
        }
        private void BackCadastraConta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) { this.Enabled = true; ProcessarDataGrid(); }
        #endregion

        //Voids Ativadas por Função
        #region
        private void TextBoxBanco_TextChanged(object sender, EventArgs e) { TextBoxBanco.Text = new Regex(@"[^\d]").Replace(TextBoxBanco.Text, ""); }
        private void TextBoxAg_TextChanged(object sender, EventArgs e) { TextBoxAg.Text = new Regex(@"[^\d]").Replace(TextBoxAg.Text, ""); }
        private void TextBoxConta_TextChanged(object sender, EventArgs e) { TextBoxConta.Text = new Regex(@"[^\d]").Replace(TextBoxConta.Text, ""); }
        private void TextBoxValor_Leave(object sender, EventArgs e)
        {
            if ((CmbBoxOp.Text == "Aplicação" || CmbBoxOp.Text == "Resgate") && TextBoxValor.Text.Length > 0)
            {
                try { TextBoxValor.Text = string.Format("{0:N}", Convert.ToDouble(TextBoxValor.Text)); }
                catch { MessageBox.Show("Valor Financeiro inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
            else if (CmbBoxOp.Text == "Resgate por Cotas" && TextBoxValor.Text.Length > 0)
            {
                try { TextBoxValor.Text = Convert.ToDouble(TextBoxValor.Text).ToString(); }
                catch { MessageBox.Show("Valor Por Cotas inválido."); TextBoxValor.Text = ""; TextBoxValor.Focus(); }
            }
        }
        private void TextBoxCOD_TextChanged(object sender, EventArgs e) { TextBoxCOD.Text = new Regex(@"[^\d]").Replace(TextBoxCOD.Text, ""); }
        private void CmbBoxOp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbBoxOp.Text == "Aplicação")
            {
                TextBoxBanco.Text = ""; TextBoxAg.Text = ""; TextBoxConta.Text = ""; TextBoxDCC.Text = "";
                TextBoxBanco.Enabled = false; TextBoxAg.Enabled = false; TextBoxConta.Enabled = false; TextBoxDCC.Enabled = false;
            }
            else
            {
                TextBoxBanco.Text = ""; TextBoxAg.Text = ""; TextBoxConta.Text = ""; TextBoxDCC.Text = "";
                TextBoxBanco.Enabled = true; TextBoxAg.Enabled = true; TextBoxConta.Enabled = true; TextBoxDCC.Enabled = true;
            }
        }
        private void DataGridBoletas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) { DataGridBoletas.ClearSelection(); }
        private void DataGridBoletas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridBoletas.Columns[e.ColumnIndex].Name == "STATUS")
            {
                //Cadastrado e Conta Cadastrada
                //Pendente
                //Liberado
                //Concluído
                //Conta Pendente
                //Saldo Pendente

                if (e.Value.ToString() == "Cadastrado" || e.Value.ToString() == "Conta Cadastrada")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 255, 153);
                }
                else if (e.Value.ToString() == "Pendente")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else if (e.Value.ToString() == "Liberado")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(153, 255, 153);
                }
                else if (e.Value.ToString() == "Conta Pendente")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else if (e.Value.ToString() == "Saldo Pendente")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 163, 102);
                }
            }
        }
        #endregion
    }
}
