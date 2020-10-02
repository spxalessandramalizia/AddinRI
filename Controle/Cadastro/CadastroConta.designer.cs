namespace Controle
{
    partial class CadastroConta
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
            this.cmbCotista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelResgate1 = new System.Windows.Forms.Label();
            this.ComboBoxLiquida = new System.Windows.Forms.ComboBox();
            this.textboxcetip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxbanco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxconta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxdigito = new System.Windows.Forms.TextBox();
            this.PanelOp = new System.Windows.Forms.Panel();
            this.LabelOp = new System.Windows.Forms.Label();
            this.TextBoxCpfCnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCheckCotista = new System.Windows.Forms.Button();
            this.PanelOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCotista
            // 
            this.cmbCotista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotista.Enabled = false;
            this.cmbCotista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotista.FormattingEnabled = true;
            this.cmbCotista.Location = new System.Drawing.Point(516, 169);
            this.cmbCotista.Name = "cmbCotista";
            this.cmbCotista.Size = new System.Drawing.Size(323, 28);
            this.cmbCotista.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 105;
            this.label3.Text = "Cotista";
            // 
            // LabelResgate1
            // 
            this.LabelResgate1.AutoSize = true;
            this.LabelResgate1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResgate1.Location = new System.Drawing.Point(344, 202);
            this.LabelResgate1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelResgate1.Name = "LabelResgate1";
            this.LabelResgate1.Size = new System.Drawing.Size(120, 24);
            this.LabelResgate1.TabIndex = 103;
            this.LabelResgate1.Text = "Tipo Conta";
            // 
            // ComboBoxLiquida
            // 
            this.ComboBoxLiquida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLiquida.Enabled = false;
            this.ComboBoxLiquida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxLiquida.FormattingEnabled = true;
            this.ComboBoxLiquida.Items.AddRange(new object[] {
            "CC",
            "Cetip"});
            this.ComboBoxLiquida.Location = new System.Drawing.Point(515, 203);
            this.ComboBoxLiquida.Name = "ComboBoxLiquida";
            this.ComboBoxLiquida.Size = new System.Drawing.Size(324, 28);
            this.ComboBoxLiquida.TabIndex = 3;
            this.ComboBoxLiquida.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLiquida_SelectedIndexChanged);
            // 
            // textboxcetip
            // 
            this.textboxcetip.Enabled = false;
            this.textboxcetip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxcetip.Location = new System.Drawing.Point(515, 239);
            this.textboxcetip.Margin = new System.Windows.Forms.Padding(5);
            this.textboxcetip.MaxLength = 14;
            this.textboxcetip.Name = "textboxcetip";
            this.textboxcetip.Size = new System.Drawing.Size(324, 27);
            this.textboxcetip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "CETIP";
            // 
            // textboxbanco
            // 
            this.textboxbanco.Enabled = false;
            this.textboxbanco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxbanco.Location = new System.Drawing.Point(515, 276);
            this.textboxbanco.Margin = new System.Windows.Forms.Padding(5);
            this.textboxbanco.MaxLength = 14;
            this.textboxbanco.Name = "textboxbanco";
            this.textboxbanco.Size = new System.Drawing.Size(324, 27);
            this.textboxbanco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 108;
            this.label4.Text = "Banco";
            // 
            // textboxag
            // 
            this.textboxag.Enabled = false;
            this.textboxag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxag.Location = new System.Drawing.Point(516, 313);
            this.textboxag.Margin = new System.Windows.Forms.Padding(5);
            this.textboxag.MaxLength = 14;
            this.textboxag.Name = "textboxag";
            this.textboxag.Size = new System.Drawing.Size(323, 27);
            this.textboxag.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 110;
            this.label5.Text = "Agência";
            // 
            // textboxconta
            // 
            this.textboxconta.Enabled = false;
            this.textboxconta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxconta.Location = new System.Drawing.Point(516, 350);
            this.textboxconta.Margin = new System.Windows.Forms.Padding(5);
            this.textboxconta.MaxLength = 14;
            this.textboxconta.Name = "textboxconta";
            this.textboxconta.Size = new System.Drawing.Size(277, 27);
            this.textboxconta.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 112;
            this.label6.Text = "Conta e Dígito";
            // 
            // textboxdigito
            // 
            this.textboxdigito.Enabled = false;
            this.textboxdigito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdigito.Location = new System.Drawing.Point(804, 350);
            this.textboxdigito.Margin = new System.Windows.Forms.Padding(5);
            this.textboxdigito.MaxLength = 14;
            this.textboxdigito.Name = "textboxdigito";
            this.textboxdigito.Size = new System.Drawing.Size(36, 27);
            this.textboxdigito.TabIndex = 8;
            // 
            // PanelOp
            // 
            this.PanelOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.PanelOp.Controls.Add(this.LabelOp);
            this.PanelOp.Location = new System.Drawing.Point(348, 92);
            this.PanelOp.Name = "PanelOp";
            this.PanelOp.Size = new System.Drawing.Size(491, 30);
            this.PanelOp.TabIndex = 119;
            // 
            // LabelOp
            // 
            this.LabelOp.AutoSize = true;
            this.LabelOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.LabelOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOp.ForeColor = System.Drawing.Color.White;
            this.LabelOp.Location = new System.Drawing.Point(188, 5);
            this.LabelOp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelOp.Name = "LabelOp";
            this.LabelOp.Size = new System.Drawing.Size(130, 19);
            this.LabelOp.TabIndex = 68;
            this.LabelOp.Text = "Cadastro Conta";
            // 
            // TextBoxCpfCnpj
            // 
            this.TextBoxCpfCnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCpfCnpj.Location = new System.Drawing.Point(515, 134);
            this.TextBoxCpfCnpj.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxCpfCnpj.MaxLength = 18;
            this.TextBoxCpfCnpj.Name = "TextBoxCpfCnpj";
            this.TextBoxCpfCnpj.Size = new System.Drawing.Size(280, 27);
            this.TextBoxCpfCnpj.TabIndex = 1;
            this.TextBoxCpfCnpj.TextChanged += new System.EventHandler(this.TextBoxCpfCnpj_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 117;
            this.label1.Text = "CPF/CNPJ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(348, 387);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(240, 33);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(600, 387);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(240, 33);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
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
            this.BtnFechar.TabIndex = 120;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCheckCotista
            // 
            this.BtnCheckCotista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCheckCotista.FlatAppearance.BorderSize = 0;
            this.BtnCheckCotista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnCheckCotista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCheckCotista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckCotista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckCotista.ForeColor = System.Drawing.Color.White;
            this.BtnCheckCotista.Location = new System.Drawing.Point(805, 134);
            this.BtnCheckCotista.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCheckCotista.Name = "BtnCheckCotista";
            this.BtnCheckCotista.Size = new System.Drawing.Size(34, 27);
            this.BtnCheckCotista.TabIndex = 121;
            this.BtnCheckCotista.UseVisualStyleBackColor = false;
            this.BtnCheckCotista.Click += new System.EventHandler(this.BtnCheckCotista_Click);
            // 
            // CadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnCheckCotista);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.PanelOp);
            this.Controls.Add(this.TextBoxCpfCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxdigito);
            this.Controls.Add(this.textboxconta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxbanco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxcetip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCotista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelResgate1);
            this.Controls.Add(this.ComboBoxLiquida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroConta";
            this.Text = "CadastroConta";
            this.PanelOp.ResumeLayout(false);
            this.PanelOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCotista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelResgate1;
        private System.Windows.Forms.ComboBox ComboBoxLiquida;
        private System.Windows.Forms.TextBox textboxcetip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxbanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxconta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxdigito;
        private System.Windows.Forms.Panel PanelOp;
        private System.Windows.Forms.Label LabelOp;
        private System.Windows.Forms.TextBox TextBoxCpfCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCheckCotista;
    }
}