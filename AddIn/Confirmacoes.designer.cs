namespace AddIn
{
    partial class Confirmacoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckTabela = new System.Windows.Forms.CheckBox();
            this.btnGerarEmail = new System.Windows.Forms.Button();
            this.CmbBoxOrdem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridBoletas = new System.Windows.Forms.DataGridView();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fundo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConcluidas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CheckTabela);
            this.panel1.Location = new System.Drawing.Point(16, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 29);
            this.panel1.TabIndex = 91;
            // 
            // CheckTabela
            // 
            this.CheckTabela.AutoSize = true;
            this.CheckTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckTabela.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTabela.Location = new System.Drawing.Point(474, 3);
            this.CheckTabela.Name = "CheckTabela";
            this.CheckTabela.Size = new System.Drawing.Size(126, 21);
            this.CheckTabela.TabIndex = 75;
            this.CheckTabela.Text = "Formato Tabela";
            this.CheckTabela.UseVisualStyleBackColor = true;
            // 
            // btnGerarEmail
            // 
            this.btnGerarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnGerarEmail.FlatAppearance.BorderSize = 0;
            this.btnGerarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnGerarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnGerarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarEmail.ForeColor = System.Drawing.Color.White;
            this.btnGerarEmail.Location = new System.Drawing.Point(435, 358);
            this.btnGerarEmail.Margin = new System.Windows.Forms.Padding(5);
            this.btnGerarEmail.Name = "btnGerarEmail";
            this.btnGerarEmail.Size = new System.Drawing.Size(186, 32);
            this.btnGerarEmail.TabIndex = 81;
            this.btnGerarEmail.Text = "Gerar Email";
            this.btnGerarEmail.UseVisualStyleBackColor = false;
            this.btnGerarEmail.Click += new System.EventHandler(this.BtnGerarEmail_Click);
            // 
            // CmbBoxOrdem
            // 
            this.CmbBoxOrdem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbBoxOrdem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbBoxOrdem.DropDownHeight = 250;
            this.CmbBoxOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxOrdem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxOrdem.FormattingEnabled = true;
            this.CmbBoxOrdem.IntegralHeight = false;
            this.CmbBoxOrdem.Location = new System.Drawing.Point(16, 87);
            this.CmbBoxOrdem.Name = "CmbBoxOrdem";
            this.CmbBoxOrdem.Size = new System.Drawing.Size(605, 25);
            this.CmbBoxOrdem.TabIndex = 77;
            this.CmbBoxOrdem.SelectedIndexChanged += new System.EventHandler(this.CmbBoxOrdem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 85;
            this.label4.Text = "Ordem";
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
            this.TopPanel.Size = new System.Drawing.Size(635, 45);
            this.TopPanel.TabIndex = 84;
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
            this.BtnFechar.Location = new System.Drawing.Point(596, 14);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 25);
            this.BtnFechar.TabIndex = 148;
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
            // DataGridBoletas
            // 
            this.DataGridBoletas.AllowUserToAddRows = false;
            this.DataGridBoletas.AllowUserToDeleteRows = false;
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
            this.CPFCNPJ,
            this.Nome,
            this.Fundo,
            this.Operação,
            this.Situação,
            this.Valor,
            this.Conta});
            this.DataGridBoletas.EnableHeadersVisualStyles = false;
            this.DataGridBoletas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridBoletas.Location = new System.Drawing.Point(16, 118);
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
            this.DataGridBoletas.Size = new System.Drawing.Size(605, 232);
            this.DataGridBoletas.TabIndex = 150;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPFCNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Fundo
            // 
            this.Fundo.HeaderText = "Fundo";
            this.Fundo.Name = "Fundo";
            this.Fundo.ReadOnly = true;
            this.Fundo.Width = 80;
            // 
            // Operação
            // 
            this.Operação.HeaderText = "Operação";
            this.Operação.Name = "Operação";
            this.Operação.ReadOnly = true;
            this.Operação.Width = 80;
            // 
            // Situação
            // 
            this.Situação.HeaderText = "Status";
            this.Situação.Name = "Situação";
            this.Situação.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Conta
            // 
            this.Conta.HeaderText = "Conta";
            this.Conta.Name = "Conta";
            this.Conta.ReadOnly = true;
            this.Conta.Width = 70;
            // 
            // BtnConcluidas
            // 
            this.BtnConcluidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnConcluidas.FlatAppearance.BorderSize = 0;
            this.BtnConcluidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnConcluidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnConcluidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConcluidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConcluidas.ForeColor = System.Drawing.Color.White;
            this.BtnConcluidas.Location = new System.Drawing.Point(239, 358);
            this.BtnConcluidas.Margin = new System.Windows.Forms.Padding(5);
            this.BtnConcluidas.Name = "BtnConcluidas";
            this.BtnConcluidas.Size = new System.Drawing.Size(186, 32);
            this.BtnConcluidas.TabIndex = 151;
            this.BtnConcluidas.Text = "Mostrar Concluídas";
            this.BtnConcluidas.UseVisualStyleBackColor = false;
            this.BtnConcluidas.Click += new System.EventHandler(this.BtnConcluidas_Click);
            // 
            // Confirmacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 441);
            this.Controls.Add(this.BtnConcluidas);
            this.Controls.Add(this.DataGridBoletas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGerarEmail);
            this.Controls.Add(this.CmbBoxOrdem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmacoes";
            this.Text = "Confirmacoes";
            this.Load += new System.EventHandler(this.Confirmacoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckTabela;
        private System.Windows.Forms.Button btnGerarEmail;
        private System.Windows.Forms.ComboBox CmbBoxOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView DataGridBoletas;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fundo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta;
        private System.Windows.Forms.Button BtnConcluidas;
    }
}