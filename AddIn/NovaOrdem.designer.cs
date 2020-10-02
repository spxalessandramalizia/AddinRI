namespace AddIn
{
    partial class NovaOrdem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.PanelOp = new System.Windows.Forms.Panel();
            this.LabelOp = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelAssunto = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBoxLiquida = new System.Windows.Forms.ComboBox();
            this.TextBoxCpfCnpj = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbCotista = new System.Windows.Forms.ComboBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LabelResgate1 = new System.Windows.Forms.Label();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.CmbBoxFIQ = new System.Windows.Forms.ComboBox();
            this.CmbBoxOp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBoxConta = new System.Windows.Forms.ComboBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnGerarOrdem = new System.Windows.Forms.Button();
            this.BtnLimparGrid = new System.Windows.Forms.Button();
            this.DataGridBoletas = new System.Windows.Forms.DataGridView();
            this.CheckRecebimento = new System.Windows.Forms.CheckBox();
            this.CODCOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODFUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fundo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotização = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquidação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cautela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelOp.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.TopPanel.Controls.Add(this.BtnFechar);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(534, 45);
            this.TopPanel.TabIndex = 63;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.White;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnFechar.Location = new System.Drawing.Point(495, 14);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 25);
            this.BtnFechar.TabIndex = 147;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddIn.Properties.Resources.spx_capital_logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(29, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnChange.FlatAppearance.BorderSize = 0;
            this.BtnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChange.ForeColor = System.Drawing.Color.White;
            this.BtnChange.Location = new System.Drawing.Point(483, 140);
            this.BtnChange.Margin = new System.Windows.Forms.Padding(5);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(34, 30);
            this.BtnChange.TabIndex = 95;
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // PanelOp
            // 
            this.PanelOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(179)))));
            this.PanelOp.Controls.Add(this.LabelOp);
            this.PanelOp.Location = new System.Drawing.Point(22, 140);
            this.PanelOp.Name = "PanelOp";
            this.PanelOp.Size = new System.Drawing.Size(453, 30);
            this.PanelOp.TabIndex = 105;
            // 
            // LabelOp
            // 
            this.LabelOp.AutoSize = true;
            this.LabelOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(179)))));
            this.LabelOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOp.ForeColor = System.Drawing.Color.White;
            this.LabelOp.Location = new System.Drawing.Point(207, 5);
            this.LabelOp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelOp.Name = "LabelOp";
            this.LabelOp.Size = new System.Drawing.Size(92, 19);
            this.LabelOp.TabIndex = 68;
            this.LabelOp.Text = "Aplicação";
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHora.ForeColor = System.Drawing.Color.White;
            this.LabelHora.Location = new System.Drawing.Point(86, 105);
            this.LabelHora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(46, 19);
            this.LabelHora.TabIndex = 103;
            this.LabelHora.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 102;
            this.label7.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 101;
            this.label6.Text = "Assunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "De: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.LabelAssunto);
            this.panel1.Controls.Add(this.LabelEmail);
            this.panel1.Location = new System.Drawing.Point(22, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 72);
            this.panel1.TabIndex = 104;
            // 
            // LabelAssunto
            // 
            this.LabelAssunto.AutoSize = true;
            this.LabelAssunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelAssunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAssunto.ForeColor = System.Drawing.Color.White;
            this.LabelAssunto.Location = new System.Drawing.Point(89, 22);
            this.LabelAssunto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelAssunto.Name = "LabelAssunto";
            this.LabelAssunto.Size = new System.Drawing.Size(67, 19);
            this.LabelAssunto.TabIndex = 55;
            this.LabelAssunto.Text = "Assunto";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.White;
            this.LabelEmail.Location = new System.Drawing.Point(51, 1);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(52, 19);
            this.LabelEmail.TabIndex = 53;
            this.LabelEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 146;
            this.label1.Text = "Cotista";
            // 
            // CmbBoxLiquida
            // 
            this.CmbBoxLiquida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxLiquida.Enabled = false;
            this.CmbBoxLiquida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxLiquida.FormattingEnabled = true;
            this.CmbBoxLiquida.Items.AddRange(new object[] {
            "TED",
            "CETIP"});
            this.CmbBoxLiquida.Location = new System.Drawing.Point(212, 351);
            this.CmbBoxLiquida.Name = "CmbBoxLiquida";
            this.CmbBoxLiquida.Size = new System.Drawing.Size(305, 28);
            this.CmbBoxLiquida.TabIndex = 138;
            this.CmbBoxLiquida.SelectedValueChanged += new System.EventHandler(this.CmbBoxLiquida_SelectedValueChanged);
            // 
            // TextBoxCpfCnpj
            // 
            this.TextBoxCpfCnpj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCpfCnpj.Location = new System.Drawing.Point(212, 180);
            this.TextBoxCpfCnpj.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxCpfCnpj.MaxLength = 18;
            this.TextBoxCpfCnpj.Name = "TextBoxCpfCnpj";
            this.TextBoxCpfCnpj.Size = new System.Drawing.Size(305, 26);
            this.TextBoxCpfCnpj.TabIndex = 132;
            this.TextBoxCpfCnpj.TextChanged += new System.EventHandler(this.TextBoxCpfCnpj_TextChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(18, 281);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(108, 22);
            this.labelTipo.TabIndex = 143;
            this.labelTipo.Text = "Operação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 140;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 141;
            this.label4.Text = "Fundo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 144;
            this.label8.Text = "Conta";
            // 
            // CmbCotista
            // 
            this.CmbCotista.BackColor = System.Drawing.SystemColors.Window;
            this.CmbCotista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCotista.Enabled = false;
            this.CmbCotista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCotista.FormattingEnabled = true;
            this.CmbCotista.Location = new System.Drawing.Point(212, 246);
            this.CmbCotista.Name = "CmbCotista";
            this.CmbCotista.Size = new System.Drawing.Size(305, 28);
            this.CmbCotista.TabIndex = 135;
            this.CmbCotista.SelectedIndexChanged += new System.EventHandler(this.CmbCotista_SelectedIndexChanged);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnVerificar.FlatAppearance.BorderSize = 0;
            this.BtnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.ForeColor = System.Drawing.Color.White;
            this.BtnVerificar.Location = new System.Drawing.Point(483, 213);
            this.BtnVerificar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(34, 27);
            this.BtnVerificar.TabIndex = 134;
            this.BtnVerificar.UseVisualStyleBackColor = false;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LabelResgate1
            // 
            this.LabelResgate1.AutoSize = true;
            this.LabelResgate1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResgate1.Location = new System.Drawing.Point(18, 352);
            this.LabelResgate1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelResgate1.Name = "LabelResgate1";
            this.LabelResgate1.Size = new System.Drawing.Size(113, 22);
            this.LabelResgate1.TabIndex = 145;
            this.LabelResgate1.Text = "Liquidação";
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.Enabled = false;
            this.TextBoxValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxValor.Location = new System.Drawing.Point(212, 316);
            this.TextBoxValor.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(305, 27);
            this.TextBoxValor.TabIndex = 137;
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
            this.CmbBoxFIQ.Location = new System.Drawing.Point(212, 212);
            this.CmbBoxFIQ.Name = "CmbBoxFIQ";
            this.CmbBoxFIQ.Size = new System.Drawing.Size(263, 28);
            this.CmbBoxFIQ.TabIndex = 133;
            this.CmbBoxFIQ.TextChanged += new System.EventHandler(this.CmbBoxFIQ_TextChanged);
            // 
            // CmbBoxOp
            // 
            this.CmbBoxOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxOp.Enabled = false;
            this.CmbBoxOp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxOp.FormattingEnabled = true;
            this.CmbBoxOp.Items.AddRange(new object[] {
            "Financeiro"});
            this.CmbBoxOp.Location = new System.Drawing.Point(212, 280);
            this.CmbBoxOp.Name = "CmbBoxOp";
            this.CmbBoxOp.Size = new System.Drawing.Size(305, 28);
            this.CmbBoxOp.TabIndex = 136;
            this.CmbBoxOp.SelectedValueChanged += new System.EventHandler(this.CmbBoxOp_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 142;
            this.label5.Text = "Valor";
            // 
            // CmbBoxConta
            // 
            this.CmbBoxConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxConta.Enabled = false;
            this.CmbBoxConta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxConta.FormattingEnabled = true;
            this.CmbBoxConta.Location = new System.Drawing.Point(212, 385);
            this.CmbBoxConta.Name = "CmbBoxConta";
            this.CmbBoxConta.Size = new System.Drawing.Size(305, 28);
            this.CmbBoxConta.TabIndex = 139;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(212, 421);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(151, 26);
            this.BtnLimpar.TabIndex = 148;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnIncluir.FlatAppearance.BorderSize = 0;
            this.BtnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.ForeColor = System.Drawing.Color.White;
            this.BtnIncluir.Location = new System.Drawing.Point(373, 421);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(144, 26);
            this.BtnIncluir.TabIndex = 147;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = false;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(202, 594);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(151, 26);
            this.BtnExcluir.TabIndex = 151;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnGerarOrdem
            // 
            this.BtnGerarOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnGerarOrdem.FlatAppearance.BorderSize = 0;
            this.BtnGerarOrdem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnGerarOrdem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnGerarOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarOrdem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarOrdem.ForeColor = System.Drawing.Color.White;
            this.BtnGerarOrdem.Location = new System.Drawing.Point(376, 594);
            this.BtnGerarOrdem.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGerarOrdem.Name = "BtnGerarOrdem";
            this.BtnGerarOrdem.Size = new System.Drawing.Size(144, 26);
            this.BtnGerarOrdem.TabIndex = 150;
            this.BtnGerarOrdem.Text = "Gerar Ordem";
            this.BtnGerarOrdem.UseVisualStyleBackColor = false;
            this.BtnGerarOrdem.Click += new System.EventHandler(this.BtnGerarOrdem_Click);
            // 
            // BtnLimparGrid
            // 
            this.BtnLimparGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimparGrid.FlatAppearance.BorderSize = 0;
            this.BtnLimparGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnLimparGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnLimparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimparGrid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimparGrid.ForeColor = System.Drawing.Color.White;
            this.BtnLimparGrid.Location = new System.Drawing.Point(22, 594);
            this.BtnLimparGrid.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLimparGrid.Name = "BtnLimparGrid";
            this.BtnLimparGrid.Size = new System.Drawing.Size(156, 26);
            this.BtnLimparGrid.TabIndex = 152;
            this.BtnLimparGrid.Text = "Limpar";
            this.BtnLimparGrid.UseVisualStyleBackColor = false;
            this.BtnLimparGrid.Click += new System.EventHandler(this.BtnLimparGrid_Click);
            // 
            // DataGridBoletas
            // 
            this.DataGridBoletas.AllowUserToAddRows = false;
            this.DataGridBoletas.AllowUserToDeleteRows = false;
            this.DataGridBoletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridBoletas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridBoletas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridBoletas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBoletas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBoletas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBoletas.ColumnHeadersHeight = 30;
            this.DataGridBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODCOT,
            this.CODFUND,
            this.CPFCNPJ,
            this.Nome,
            this.Fundo,
            this.OPERACAO,
            this.STATUS,
            this.VALOR,
            this.CONTA,
            this.Cotização,
            this.Liquidação,
            this.Cautela});
            this.DataGridBoletas.EnableHeadersVisualStyles = false;
            this.DataGridBoletas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridBoletas.Location = new System.Drawing.Point(22, 455);
            this.DataGridBoletas.MultiSelect = false;
            this.DataGridBoletas.Name = "DataGridBoletas";
            this.DataGridBoletas.ReadOnly = true;
            this.DataGridBoletas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBoletas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBoletas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridBoletas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridBoletas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBoletas.Size = new System.Drawing.Size(495, 131);
            this.DataGridBoletas.TabIndex = 153;
            // 
            // CheckRecebimento
            // 
            this.CheckRecebimento.AutoSize = true;
            this.CheckRecebimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRecebimento.Location = new System.Drawing.Point(22, 428);
            this.CheckRecebimento.Name = "CheckRecebimento";
            this.CheckRecebimento.Size = new System.Drawing.Size(144, 21);
            this.CheckRecebimento.TabIndex = 154;
            this.CheckRecebimento.Text = "Email Automático";
            this.CheckRecebimento.UseVisualStyleBackColor = true;
            // 
            // CODCOT
            // 
            this.CODCOT.HeaderText = "CODCOT";
            this.CODCOT.Name = "CODCOT";
            this.CODCOT.ReadOnly = true;
            this.CODCOT.Visible = false;
            this.CODCOT.Width = 88;
            // 
            // CODFUND
            // 
            this.CODFUND.HeaderText = "CODFUND";
            this.CODFUND.Name = "CODFUND";
            this.CODFUND.ReadOnly = true;
            this.CODFUND.Visible = false;
            this.CODFUND.Width = 94;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPFCNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Width = 87;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 69;
            // 
            // Fundo
            // 
            this.Fundo.HeaderText = "Fundo";
            this.Fundo.Name = "Fundo";
            this.Fundo.ReadOnly = true;
            this.Fundo.Width = 70;
            // 
            // OPERACAO
            // 
            this.OPERACAO.HeaderText = "Operação";
            this.OPERACAO.Name = "OPERACAO";
            this.OPERACAO.ReadOnly = true;
            this.OPERACAO.Width = 98;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 69;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 66;
            // 
            // CONTA
            // 
            this.CONTA.HeaderText = "Conta";
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.Width = 70;
            // 
            // Cotização
            // 
            this.Cotização.HeaderText = "Cotização";
            this.Cotização.Name = "Cotização";
            this.Cotização.ReadOnly = true;
            this.Cotização.Width = 97;
            // 
            // Liquidação
            // 
            this.Liquidação.HeaderText = "Liquidação";
            this.Liquidação.Name = "Liquidação";
            this.Liquidação.ReadOnly = true;
            this.Liquidação.Width = 105;
            // 
            // Cautela
            // 
            this.Cautela.HeaderText = "Cautela";
            this.Cautela.Name = "Cautela";
            this.Cautela.ReadOnly = true;
            this.Cautela.Visible = false;
            this.Cautela.Width = 83;
            // 
            // NovaOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 632);
            this.Controls.Add(this.CheckRecebimento);
            this.Controls.Add(this.DataGridBoletas);
            this.Controls.Add(this.BtnLimparGrid);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGerarOrdem);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBoxLiquida);
            this.Controls.Add(this.TextBoxCpfCnpj);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbCotista);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.LabelResgate1);
            this.Controls.Add(this.TextBoxValor);
            this.Controls.Add(this.CmbBoxFIQ);
            this.Controls.Add(this.CmbBoxOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbBoxConta);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.PanelOp);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovaOrdem";
            this.Text = "NovaOrdem";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelOp.ResumeLayout(false);
            this.PanelOp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Panel PanelOp;
        private System.Windows.Forms.Label LabelOp;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelAssunto;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBoxLiquida;
        private System.Windows.Forms.TextBox TextBoxCpfCnpj;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbCotista;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label LabelResgate1;
        private System.Windows.Forms.TextBox TextBoxValor;
        private System.Windows.Forms.ComboBox CmbBoxFIQ;
        private System.Windows.Forms.ComboBox CmbBoxOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBoxConta;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnGerarOrdem;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLimparGrid;
        public System.Windows.Forms.DataGridView DataGridBoletas;
        private System.Windows.Forms.CheckBox CheckRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODFUND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fundo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotização;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquidação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cautela;
    }
}