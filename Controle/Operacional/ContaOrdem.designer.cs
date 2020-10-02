namespace Controle
{
    partial class ContaOrdem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCadastrarCotistas = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCadastrarConta = new System.Windows.Forms.Button();
            this.BtnGerarOrdem = new System.Windows.Forms.Button();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.CmbBoxFIQ = new System.Windows.Forms.ComboBox();
            this.CmbBoxOp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridBoletas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODFUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbBoxDistribuidor = new System.Windows.Forms.ComboBox();
            this.TextBoxCOD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpa = new System.Windows.Forms.Button();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.TextBoxBanco = new System.Windows.Forms.TextBox();
            this.TextBoxAg = new System.Windows.Forms.TextBox();
            this.TextBoxConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSelecionarDist = new System.Windows.Forms.Button();
            this.PanelOrdem = new System.Windows.Forms.Panel();
            this.TextBoxDCC = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnProcessar = new System.Windows.Forms.Button();
            this.TextImporta = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BackCadastraCotistas = new System.ComponentModel.BackgroundWorker();
            this.BackCadastraConta = new System.ComponentModel.BackgroundWorker();
            this.WebCaixa = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).BeginInit();
            this.PanelOrdem.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Location = new System.Drawing.Point(1140, 14);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 25);
            this.BtnFechar.TabIndex = 148;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCadastrarCotistas
            // 
            this.BtnCadastrarCotistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCadastrarCotistas.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarCotistas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCadastrarCotistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCadastrarCotistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarCotistas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarCotistas.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCotistas.Location = new System.Drawing.Point(802, 445);
            this.BtnCadastrarCotistas.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCadastrarCotistas.Name = "BtnCadastrarCotistas";
            this.BtnCadastrarCotistas.Size = new System.Drawing.Size(155, 33);
            this.BtnCadastrarCotistas.TabIndex = 15;
            this.BtnCadastrarCotistas.Text = "Cadastrar Cotistas";
            this.BtnCadastrarCotistas.UseVisualStyleBackColor = false;
            this.BtnCadastrarCotistas.Click += new System.EventHandler(this.BtnCadastrarCotistas_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(12, 303);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(159, 33);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(8, 118);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(118, 24);
            this.labelTipo.TabIndex = 164;
            this.labelTipo.Text = "Operação";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnIncluir.FlatAppearance.BorderSize = 0;
            this.BtnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.ForeColor = System.Drawing.Color.White;
            this.BtnIncluir.Location = new System.Drawing.Point(179, 303);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(159, 33);
            this.BtnIncluir.TabIndex = 10;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = false;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 162;
            this.label2.Text = "Fundo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 165;
            this.label8.Text = "Banco";
            // 
            // BtnCadastrarConta
            // 
            this.BtnCadastrarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCadastrarConta.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCadastrarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCadastrarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarConta.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarConta.Location = new System.Drawing.Point(802, 488);
            this.BtnCadastrarConta.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCadastrarConta.Name = "BtnCadastrarConta";
            this.BtnCadastrarConta.Size = new System.Drawing.Size(155, 33);
            this.BtnCadastrarConta.TabIndex = 14;
            this.BtnCadastrarConta.Text = "Cadastrar Conta";
            this.BtnCadastrarConta.UseVisualStyleBackColor = false;
            this.BtnCadastrarConta.Click += new System.EventHandler(this.BtnCadastrarConta_Click);
            // 
            // BtnGerarOrdem
            // 
            this.BtnGerarOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnGerarOrdem.FlatAppearance.BorderSize = 0;
            this.BtnGerarOrdem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnGerarOrdem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnGerarOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarOrdem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarOrdem.ForeColor = System.Drawing.Color.White;
            this.BtnGerarOrdem.Location = new System.Drawing.Point(977, 488);
            this.BtnGerarOrdem.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGerarOrdem.Name = "BtnGerarOrdem";
            this.BtnGerarOrdem.Size = new System.Drawing.Size(155, 33);
            this.BtnGerarOrdem.TabIndex = 12;
            this.BtnGerarOrdem.Text = "Gerar Ordem";
            this.BtnGerarOrdem.UseVisualStyleBackColor = false;
            this.BtnGerarOrdem.Click += new System.EventHandler(this.BtnGerarOrdem_Click);
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxValor.Location = new System.Drawing.Point(14, 107);
            this.TextBoxValor.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(201, 27);
            this.TextBoxValor.TabIndex = 6;
            this.TextBoxValor.Leave += new System.EventHandler(this.TextBoxValor_Leave);
            // 
            // CmbBoxFIQ
            // 
            this.CmbBoxFIQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbBoxFIQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbBoxFIQ.DropDownHeight = 250;
            this.CmbBoxFIQ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxFIQ.FormattingEnabled = true;
            this.CmbBoxFIQ.IntegralHeight = false;
            this.CmbBoxFIQ.Location = new System.Drawing.Point(11, 0);
            this.CmbBoxFIQ.Name = "CmbBoxFIQ";
            this.CmbBoxFIQ.Size = new System.Drawing.Size(201, 28);
            this.CmbBoxFIQ.TabIndex = 3;
            // 
            // CmbBoxOp
            // 
            this.CmbBoxOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxOp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxOp.FormattingEnabled = true;
            this.CmbBoxOp.Items.AddRange(new object[] {
            "Aplicação",
            "Resgate",
            "Resgate por Cotas",
            "Resgate Total"});
            this.CmbBoxOp.Location = new System.Drawing.Point(11, 71);
            this.CmbBoxOp.Name = "CmbBoxOp";
            this.CmbBoxOp.Size = new System.Drawing.Size(201, 28);
            this.CmbBoxOp.TabIndex = 5;
            this.CmbBoxOp.SelectedValueChanged += new System.EventHandler(this.CmbBoxOp_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 163;
            this.label4.Text = "Valor";
            // 
            // DataGridBoletas
            // 
            this.DataGridBoletas.AllowUserToAddRows = false;
            this.DataGridBoletas.AllowUserToDeleteRows = false;
            this.DataGridBoletas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridBoletas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridBoletas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBoletas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBoletas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridBoletas.ColumnHeadersHeight = 30;
            this.DataGridBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CNPJ,
            this.CODCOT,
            this.OP,
            this.FUNDO,
            this.CODFUND,
            this.VALOR,
            this.CONTA,
            this.STATUS});
            this.DataGridBoletas.EnableHeadersVisualStyles = false;
            this.DataGridBoletas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridBoletas.Location = new System.Drawing.Point(346, 14);
            this.DataGridBoletas.MultiSelect = false;
            this.DataGridBoletas.Name = "DataGridBoletas";
            this.DataGridBoletas.ReadOnly = true;
            this.DataGridBoletas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBoletas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridBoletas.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridBoletas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridBoletas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBoletas.Size = new System.Drawing.Size(786, 423);
            this.DataGridBoletas.TabIndex = 168;
            this.DataGridBoletas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridBoletas_CellFormatting);
            this.DataGridBoletas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridBoletas_ColumnHeaderMouseClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Visible = false;
            // 
            // CODCOT
            // 
            this.CODCOT.HeaderText = "CODCOT";
            this.CODCOT.Name = "CODCOT";
            this.CODCOT.ReadOnly = true;
            // 
            // OP
            // 
            this.OP.HeaderText = "OP";
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
            this.OP.Width = 30;
            // 
            // FUNDO
            // 
            this.FUNDO.HeaderText = "FUNDO";
            this.FUNDO.Name = "FUNDO";
            this.FUNDO.ReadOnly = true;
            // 
            // CODFUND
            // 
            this.CODFUND.HeaderText = "CODFUND";
            this.CODFUND.Name = "CODFUND";
            this.CODFUND.ReadOnly = true;
            this.CODFUND.Visible = false;
            // 
            // VALOR
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle6;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // CONTA
            // 
            this.CONTA.HeaderText = "CONTA CRED";
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.Width = 120;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 80;
            // 
            // CmbBoxDistribuidor
            // 
            this.CmbBoxDistribuidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxDistribuidor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxDistribuidor.FormattingEnabled = true;
            this.CmbBoxDistribuidor.Location = new System.Drawing.Point(12, 14);
            this.CmbBoxDistribuidor.Name = "CmbBoxDistribuidor";
            this.CmbBoxDistribuidor.Size = new System.Drawing.Size(292, 28);
            this.CmbBoxDistribuidor.TabIndex = 1;
            // 
            // TextBoxCOD
            // 
            this.TextBoxCOD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCOD.Location = new System.Drawing.Point(11, 36);
            this.TextBoxCOD.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxCOD.Name = "TextBoxCOD";
            this.TextBoxCOD.Size = new System.Drawing.Size(201, 27);
            this.TextBoxCOD.TabIndex = 4;
            this.TextBoxCOD.TextChanged += new System.EventHandler(this.TextBoxCOD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 174;
            this.label1.Text = "Código";
            // 
            // BtnLimpa
            // 
            this.BtnLimpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimpa.FlatAppearance.BorderSize = 0;
            this.BtnLimpa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnLimpa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpa.ForeColor = System.Drawing.Color.White;
            this.BtnLimpa.Location = new System.Drawing.Point(645, 488);
            this.BtnLimpa.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLimpa.Name = "BtnLimpa";
            this.BtnLimpa.Size = new System.Drawing.Size(138, 33);
            this.BtnLimpa.TabIndex = 13;
            this.BtnLimpa.Text = "Limpar";
            this.BtnLimpa.UseVisualStyleBackColor = false;
            this.BtnLimpa.Click += new System.EventHandler(this.BtnLimpa_Click);
            // 
            // BtnImportar
            // 
            this.BtnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnImportar.FlatAppearance.BorderSize = 0;
            this.BtnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportar.ForeColor = System.Drawing.Color.White;
            this.BtnImportar.Location = new System.Drawing.Point(9, 492);
            this.BtnImportar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(326, 29);
            this.BtnImportar.TabIndex = 17;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = false;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // TextBoxBanco
            // 
            this.TextBoxBanco.Enabled = false;
            this.TextBoxBanco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBanco.Location = new System.Drawing.Point(11, 144);
            this.TextBoxBanco.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxBanco.Name = "TextBoxBanco";
            this.TextBoxBanco.Size = new System.Drawing.Size(201, 27);
            this.TextBoxBanco.TabIndex = 7;
            this.TextBoxBanco.TextChanged += new System.EventHandler(this.TextBoxBanco_TextChanged);
            // 
            // TextBoxAg
            // 
            this.TextBoxAg.Enabled = false;
            this.TextBoxAg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAg.Location = new System.Drawing.Point(11, 181);
            this.TextBoxAg.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxAg.Name = "TextBoxAg";
            this.TextBoxAg.Size = new System.Drawing.Size(201, 27);
            this.TextBoxAg.TabIndex = 8;
            this.TextBoxAg.TextChanged += new System.EventHandler(this.TextBoxAg_TextChanged);
            // 
            // TextBoxConta
            // 
            this.TextBoxConta.Enabled = false;
            this.TextBoxConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxConta.Location = new System.Drawing.Point(11, 218);
            this.TextBoxConta.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxConta.Name = "TextBoxConta";
            this.TextBoxConta.Size = new System.Drawing.Size(170, 27);
            this.TextBoxConta.TabIndex = 9;
            this.TextBoxConta.TextChanged += new System.EventHandler(this.TextBoxConta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 180;
            this.label3.Text = "Agencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 181;
            this.label5.Text = "Conta";
            // 
            // BtnSelecionarDist
            // 
            this.BtnSelecionarDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnSelecionarDist.FlatAppearance.BorderSize = 0;
            this.BtnSelecionarDist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnSelecionarDist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSelecionarDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelecionarDist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelecionarDist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSelecionarDist.Location = new System.Drawing.Point(310, 14);
            this.BtnSelecionarDist.Name = "BtnSelecionarDist";
            this.BtnSelecionarDist.Size = new System.Drawing.Size(28, 28);
            this.BtnSelecionarDist.TabIndex = 2;
            this.BtnSelecionarDist.UseVisualStyleBackColor = false;
            this.BtnSelecionarDist.Click += new System.EventHandler(this.BtnSelecionarDist_Click);
            // 
            // PanelOrdem
            // 
            this.PanelOrdem.Controls.Add(this.TextBoxDCC);
            this.PanelOrdem.Controls.Add(this.CmbBoxFIQ);
            this.PanelOrdem.Controls.Add(this.TextBoxCOD);
            this.PanelOrdem.Controls.Add(this.TextBoxConta);
            this.PanelOrdem.Controls.Add(this.CmbBoxOp);
            this.PanelOrdem.Controls.Add(this.TextBoxAg);
            this.PanelOrdem.Controls.Add(this.TextBoxValor);
            this.PanelOrdem.Controls.Add(this.TextBoxBanco);
            this.PanelOrdem.Enabled = false;
            this.PanelOrdem.Location = new System.Drawing.Point(123, 48);
            this.PanelOrdem.Name = "PanelOrdem";
            this.PanelOrdem.Size = new System.Drawing.Size(215, 247);
            this.PanelOrdem.TabIndex = 183;
            // 
            // TextBoxDCC
            // 
            this.TextBoxDCC.Enabled = false;
            this.TextBoxDCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDCC.Location = new System.Drawing.Point(186, 218);
            this.TextBoxDCC.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxDCC.Name = "TextBoxDCC";
            this.TextBoxDCC.Size = new System.Drawing.Size(26, 27);
            this.TextBoxDCC.TabIndex = 10;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(645, 445);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(138, 33);
            this.BtnExcluir.TabIndex = 16;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnProcessar
            // 
            this.BtnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnProcessar.FlatAppearance.BorderSize = 0;
            this.BtnProcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcessar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcessar.ForeColor = System.Drawing.Color.White;
            this.BtnProcessar.Location = new System.Drawing.Point(977, 445);
            this.BtnProcessar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnProcessar.Name = "BtnProcessar";
            this.BtnProcessar.Size = new System.Drawing.Size(155, 33);
            this.BtnProcessar.TabIndex = 184;
            this.BtnProcessar.Text = "Processar";
            this.BtnProcessar.UseVisualStyleBackColor = false;
            this.BtnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // TextImporta
            // 
            this.TextImporta.Location = new System.Drawing.Point(9, 393);
            this.TextImporta.Name = "TextImporta";
            this.TextImporta.Size = new System.Drawing.Size(326, 91);
            this.TextImporta.TabIndex = 185;
            this.TextImporta.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 186;
            this.label6.Text = "Dados TXT";
            // 
            // BackCadastraCotistas
            // 
            this.BackCadastraCotistas.WorkerReportsProgress = true;
            this.BackCadastraCotistas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackCadastraCotistas_DoWork);
            this.BackCadastraCotistas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackCadastraCotistas_RunWorkerCompleted);
            // 
            // BackCadastraConta
            // 
            this.BackCadastraConta.WorkerReportsProgress = true;
            this.BackCadastraConta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackCadastraConta_DoWork);
            this.BackCadastraConta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackCadastraConta_RunWorkerCompleted);
            // 
            // WebCaixa
            // 
            this.WebCaixa.Location = new System.Drawing.Point(346, 445);
            this.WebCaixa.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebCaixa.Name = "WebCaixa";
            this.WebCaixa.Size = new System.Drawing.Size(786, 20);
            this.WebCaixa.TabIndex = 187;
            this.WebCaixa.Visible = false;
            // 
            // ContaOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnProcessar);
            this.Controls.Add(this.BtnCadastrarCotistas);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.WebCaixa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextImporta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSelecionarDist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLimpa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBoxDistribuidor);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCadastrarConta);
            this.Controls.Add(this.BtnGerarOrdem);
            this.Controls.Add(this.DataGridBoletas);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.PanelOrdem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContaOrdem";
            this.Text = "ContaOrdem";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).EndInit();
            this.PanelOrdem.ResumeLayout(false);
            this.PanelOrdem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCadastrarCotistas;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCadastrarConta;
        private System.Windows.Forms.Button BtnGerarOrdem;
        private System.Windows.Forms.TextBox TextBoxValor;
        private System.Windows.Forms.ComboBox CmbBoxFIQ;
        private System.Windows.Forms.ComboBox CmbBoxOp;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView DataGridBoletas;
        private System.Windows.Forms.TextBox TextBoxCOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpa;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.TextBox TextBoxBanco;
        private System.Windows.Forms.TextBox TextBoxAg;
        private System.Windows.Forms.TextBox TextBoxConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSelecionarDist;
        private System.Windows.Forms.Panel PanelOrdem;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnProcessar;
        private System.Windows.Forms.TextBox TextBoxDCC;
        private System.Windows.Forms.RichTextBox TextImporta;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker BackCadastraCotistas;
        private System.ComponentModel.BackgroundWorker BackCadastraConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODFUND;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.WebBrowser WebCaixa;
        private System.Windows.Forms.ComboBox CmbBoxDistribuidor;
    }
}