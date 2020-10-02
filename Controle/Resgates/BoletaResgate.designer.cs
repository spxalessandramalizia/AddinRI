namespace Controle
{
    partial class BoletaResgate
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
            this.CmbBoxOp = new System.Windows.Forms.ComboBox();
            this.CmbBoxConta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.LabelResgate1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.TextBoxCpfCnpj = new System.Windows.Forms.TextBox();
            this.CmbBoxFIQ = new System.Windows.Forms.ComboBox();
            this.CmbBoxLiquida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCotista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelOp = new System.Windows.Forms.Panel();
            this.LabelOp = new System.Windows.Forms.Label();
            this.btnBoletar = new System.Windows.Forms.Button();
            this.btnverificaposi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCota = new System.Windows.Forms.Label();
            this.LabelFin = new System.Windows.Forms.Label();
            this.LabelCotas = new System.Windows.Forms.Label();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.PanelOp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbBoxOp
            // 
            this.CmbBoxOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxOp.Enabled = false;
            this.CmbBoxOp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxOp.FormattingEnabled = true;
            this.CmbBoxOp.Items.AddRange(new object[] {
            "Financeiro",
            "Por Cotas",
            "Total"});
            this.CmbBoxOp.Location = new System.Drawing.Point(505, 305);
            this.CmbBoxOp.Name = "CmbBoxOp";
            this.CmbBoxOp.Size = new System.Drawing.Size(324, 28);
            this.CmbBoxOp.TabIndex = 6;
            this.CmbBoxOp.SelectedValueChanged += new System.EventHandler(this.CmbBoxOp_SelectedValueChanged);
            // 
            // CmbBoxConta
            // 
            this.CmbBoxConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxConta.Enabled = false;
            this.CmbBoxConta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxConta.FormattingEnabled = true;
            this.CmbBoxConta.Location = new System.Drawing.Point(505, 410);
            this.CmbBoxConta.Name = "CmbBoxConta";
            this.CmbBoxConta.Size = new System.Drawing.Size(324, 28);
            this.CmbBoxConta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "Valor";
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.Enabled = false;
            this.TextBoxValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxValor.Location = new System.Drawing.Point(505, 341);
            this.TextBoxValor.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(324, 27);
            this.TextBoxValor.TabIndex = 6;
            this.TextBoxValor.Leave += new System.EventHandler(this.TextBoxValor_Leave);
            // 
            // LabelResgate1
            // 
            this.LabelResgate1.AutoSize = true;
            this.LabelResgate1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResgate1.Location = new System.Drawing.Point(333, 375);
            this.LabelResgate1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelResgate1.Name = "LabelResgate1";
            this.LabelResgate1.Size = new System.Drawing.Size(123, 24);
            this.LabelResgate1.TabIndex = 96;
            this.LabelResgate1.Text = "Liquidação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 95;
            this.label8.Text = "Conta";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(333, 304);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(118, 24);
            this.labelTipo.TabIndex = 94;
            this.labelTipo.Text = "Operação";
            // 
            // TextBoxCpfCnpj
            // 
            this.TextBoxCpfCnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCpfCnpj.Location = new System.Drawing.Point(505, 90);
            this.TextBoxCpfCnpj.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxCpfCnpj.MaxLength = 18;
            this.TextBoxCpfCnpj.Name = "TextBoxCpfCnpj";
            this.TextBoxCpfCnpj.Size = new System.Drawing.Size(324, 27);
            this.TextBoxCpfCnpj.TabIndex = 1;
            this.TextBoxCpfCnpj.TextChanged += new System.EventHandler(this.TextBoxCpfCnpj_TextChanged);
            // 
            // CmbBoxFIQ
            // 
            this.CmbBoxFIQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbBoxFIQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbBoxFIQ.DropDownHeight = 250;
            this.CmbBoxFIQ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxFIQ.FormattingEnabled = true;
            this.CmbBoxFIQ.IntegralHeight = false;
            this.CmbBoxFIQ.Location = new System.Drawing.Point(505, 126);
            this.CmbBoxFIQ.Name = "CmbBoxFIQ";
            this.CmbBoxFIQ.Size = new System.Drawing.Size(324, 28);
            this.CmbBoxFIQ.TabIndex = 2;
            this.CmbBoxFIQ.TextChanged += new System.EventHandler(this.CmbBoxFIQ_TextChanged);
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
            this.CmbBoxLiquida.Location = new System.Drawing.Point(505, 376);
            this.CmbBoxLiquida.Name = "CmbBoxLiquida";
            this.CmbBoxLiquida.Size = new System.Drawing.Size(324, 28);
            this.CmbBoxLiquida.TabIndex = 7;
            this.CmbBoxLiquida.SelectedValueChanged += new System.EventHandler(this.CmbBoxLiquida_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 88;
            this.label2.Text = "Fundo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "CPF/CNPJ";
            // 
            // CmbCotista
            // 
            this.CmbCotista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCotista.Enabled = false;
            this.CmbCotista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCotista.FormattingEnabled = true;
            this.CmbCotista.Location = new System.Drawing.Point(505, 196);
            this.CmbCotista.Name = "CmbCotista";
            this.CmbCotista.Size = new System.Drawing.Size(324, 28);
            this.CmbCotista.TabIndex = 5;
            this.CmbCotista.SelectedIndexChanged += new System.EventHandler(this.CmbCotista_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 99;
            this.label3.Text = "Cotista";
            // 
            // PanelOp
            // 
            this.PanelOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PanelOp.Controls.Add(this.LabelOp);
            this.PanelOp.Location = new System.Drawing.Point(337, 48);
            this.PanelOp.Name = "PanelOp";
            this.PanelOp.Size = new System.Drawing.Size(491, 30);
            this.PanelOp.TabIndex = 103;
            // 
            // LabelOp
            // 
            this.LabelOp.AutoSize = true;
            this.LabelOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LabelOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOp.ForeColor = System.Drawing.Color.White;
            this.LabelOp.Location = new System.Drawing.Point(219, 5);
            this.LabelOp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelOp.Name = "LabelOp";
            this.LabelOp.Size = new System.Drawing.Size(70, 19);
            this.LabelOp.TabIndex = 68;
            this.LabelOp.Text = "Resgate";
            // 
            // btnBoletar
            // 
            this.btnBoletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnBoletar.FlatAppearance.BorderSize = 0;
            this.btnBoletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBoletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnBoletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletar.ForeColor = System.Drawing.Color.White;
            this.btnBoletar.Location = new System.Drawing.Point(674, 446);
            this.btnBoletar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBoletar.Name = "btnBoletar";
            this.btnBoletar.Size = new System.Drawing.Size(155, 33);
            this.btnBoletar.TabIndex = 9;
            this.btnBoletar.Text = "Boletar";
            this.btnBoletar.UseVisualStyleBackColor = false;
            this.btnBoletar.Click += new System.EventHandler(this.BtnBoletar_Click);
            // 
            // btnverificaposi
            // 
            this.btnverificaposi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnverificaposi.FlatAppearance.BorderSize = 0;
            this.btnverificaposi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnverificaposi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnverificaposi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificaposi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificaposi.ForeColor = System.Drawing.Color.White;
            this.btnverificaposi.Location = new System.Drawing.Point(745, 162);
            this.btnverificaposi.Margin = new System.Windows.Forms.Padding(5);
            this.btnverificaposi.Name = "btnverificaposi";
            this.btnverificaposi.Size = new System.Drawing.Size(83, 26);
            this.btnverificaposi.TabIndex = 3;
            this.btnverificaposi.Text = "Verificar";
            this.btnverificaposi.UseVisualStyleBackColor = false;
            this.btnverificaposi.Click += new System.EventHandler(this.Btnverificaposi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 111;
            this.label7.Text = "Saldo Financeiro: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "Saldo em Cotas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 109;
            this.label9.Text = "Código: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.LabelCota);
            this.panel1.Controls.Add(this.LabelFin);
            this.panel1.Controls.Add(this.LabelCotas);
            this.panel1.Controls.Add(this.LabelCodigo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LabelEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(337, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 69);
            this.panel1.TabIndex = 113;
            // 
            // LabelCota
            // 
            this.LabelCota.AutoSize = true;
            this.LabelCota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelCota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCota.ForeColor = System.Drawing.Color.White;
            this.LabelCota.Location = new System.Drawing.Point(393, 26);
            this.LabelCota.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCota.Name = "LabelCota";
            this.LabelCota.Size = new System.Drawing.Size(16, 19);
            this.LabelCota.TabIndex = 114;
            this.LabelCota.Text = "*";
            // 
            // LabelFin
            // 
            this.LabelFin.AutoSize = true;
            this.LabelFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFin.ForeColor = System.Drawing.Color.White;
            this.LabelFin.Location = new System.Drawing.Point(162, 45);
            this.LabelFin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFin.Name = "LabelFin";
            this.LabelFin.Size = new System.Drawing.Size(16, 19);
            this.LabelFin.TabIndex = 113;
            this.LabelFin.Text = "*";
            // 
            // LabelCotas
            // 
            this.LabelCotas.AutoSize = true;
            this.LabelCotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelCotas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCotas.ForeColor = System.Drawing.Color.White;
            this.LabelCotas.Location = new System.Drawing.Point(149, 26);
            this.LabelCotas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCotas.Name = "LabelCotas";
            this.LabelCotas.Size = new System.Drawing.Size(16, 19);
            this.LabelCotas.TabIndex = 112;
            this.LabelCotas.Text = "*";
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.ForeColor = System.Drawing.Color.White;
            this.LabelCodigo.Location = new System.Drawing.Point(80, 5);
            this.LabelCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(16, 19);
            this.LabelCodigo.TabIndex = 55;
            this.LabelCodigo.Text = "*";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.White;
            this.LabelEmail.Location = new System.Drawing.Point(333, 24);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(50, 19);
            this.LabelEmail.TabIndex = 53;
            this.LabelEmail.Text = "Cota:";
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
            this.BtnLimpar.Location = new System.Drawing.Point(505, 446);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(155, 33);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
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
            this.BtnFechar.TabIndex = 147;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BoletaResgate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnverificaposi);
            this.Controls.Add(this.btnBoletar);
            this.Controls.Add(this.PanelOp);
            this.Controls.Add(this.CmbCotista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbBoxOp);
            this.Controls.Add(this.CmbBoxConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxValor);
            this.Controls.Add(this.LabelResgate1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.TextBoxCpfCnpj);
            this.Controls.Add(this.CmbBoxFIQ);
            this.Controls.Add(this.CmbBoxLiquida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoletaResgate";
            this.Text = "BoletaResgate";
            this.PanelOp.ResumeLayout(false);
            this.PanelOp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbBoxOp;
        private System.Windows.Forms.ComboBox CmbBoxConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxValor;
        private System.Windows.Forms.Label LabelResgate1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox TextBoxCpfCnpj;
        private System.Windows.Forms.ComboBox CmbBoxFIQ;
        private System.Windows.Forms.ComboBox CmbBoxLiquida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCotista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelOp;
        private System.Windows.Forms.Label LabelOp;
        private System.Windows.Forms.Button btnBoletar;
        private System.Windows.Forms.Button btnverificaposi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelCota;
        private System.Windows.Forms.Label LabelFin;
        private System.Windows.Forms.Label LabelCotas;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnFechar;
    }
}