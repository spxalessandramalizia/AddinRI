namespace Controle
{
    partial class Movimentacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.CmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.CmBoxData = new System.Windows.Forms.ComboBox();
            this.PanelOrdens = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckID = new System.Windows.Forms.CheckBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.DataGridStatus = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridOrdens = new System.Windows.Forms.DataGridView();
            this.IDBOLETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDORDEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrdens)).BeginInit();
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
            this.BtnFechar.TabIndex = 147;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // CmbBoxTipo
            // 
            this.CmbBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxTipo.FormattingEnabled = true;
            this.CmbBoxTipo.Items.AddRange(new object[] {
            "Ordens",
            "Movimentações"});
            this.CmbBoxTipo.Location = new System.Drawing.Point(12, 14);
            this.CmbBoxTipo.Name = "CmbBoxTipo";
            this.CmbBoxTipo.Size = new System.Drawing.Size(126, 28);
            this.CmbBoxTipo.TabIndex = 165;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(12, 84);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(126, 33);
            this.BtnAtualizar.TabIndex = 168;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // CmBoxData
            // 
            this.CmBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBoxData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxData.FormattingEnabled = true;
            this.CmBoxData.Location = new System.Drawing.Point(12, 48);
            this.CmBoxData.Name = "CmBoxData";
            this.CmBoxData.Size = new System.Drawing.Size(126, 28);
            this.CmBoxData.TabIndex = 169;
            // 
            // PanelOrdens
            // 
            this.PanelOrdens.AutoScroll = true;
            this.PanelOrdens.Location = new System.Drawing.Point(148, 14);
            this.PanelOrdens.Name = "PanelOrdens";
            this.PanelOrdens.Size = new System.Drawing.Size(984, 506);
            this.PanelOrdens.TabIndex = 171;
            // 
            // CheckID
            // 
            this.CheckID.AutoSize = true;
            this.CheckID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckID.Location = new System.Drawing.Point(12, 125);
            this.CheckID.Name = "CheckID";
            this.CheckID.Size = new System.Drawing.Size(126, 24);
            this.CheckID.TabIndex = 172;
            this.CheckID.Text = "Buscar por ID";
            this.CheckID.UseVisualStyleBackColor = true;
            this.CheckID.CheckedChanged += new System.EventHandler(this.CheckID_CheckedChanged);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Enabled = false;
            this.TextBoxID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxID.Location = new System.Drawing.Point(12, 155);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(126, 26);
            this.TextBoxID.TabIndex = 173;
            // 
            // DataGridStatus
            // 
            this.DataGridStatus.AllowUserToAddRows = false;
            this.DataGridStatus.AllowUserToDeleteRows = false;
            this.DataGridStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridStatus.ColumnHeadersHeight = 30;
            this.DataGridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridStatus.ColumnHeadersVisible = false;
            this.DataGridStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Status,
            this.Qnt});
            this.DataGridStatus.EnableHeadersVisualStyles = false;
            this.DataGridStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridStatus.Location = new System.Drawing.Point(12, 187);
            this.DataGridStatus.MultiSelect = false;
            this.DataGridStatus.Name = "DataGridStatus";
            this.DataGridStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridStatus.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridStatus.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridStatus.Size = new System.Drawing.Size(126, 148);
            this.DataGridStatus.TabIndex = 174;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Width = 20;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 80;
            // 
            // Qnt
            // 
            this.Qnt.HeaderText = "";
            this.Qnt.Name = "Qnt";
            this.Qnt.Width = 25;
            // 
            // DataGridOrdens
            // 
            this.DataGridOrdens.AllowUserToAddRows = false;
            this.DataGridOrdens.AllowUserToDeleteRows = false;
            this.DataGridOrdens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridOrdens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridOrdens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOrdens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOrdens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridOrdens.ColumnHeadersHeight = 30;
            this.DataGridOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridOrdens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBOLETA,
            this.IDORDEM,
            this.CODCOT,
            this.CPFCNPJ,
            this.NOME,
            this.FUNDO,
            this.OP,
            this.VALOR,
            this.CONTA,
            this.STATUS_});
            this.DataGridOrdens.EnableHeadersVisualStyles = false;
            this.DataGridOrdens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridOrdens.Location = new System.Drawing.Point(148, 14);
            this.DataGridOrdens.MultiSelect = false;
            this.DataGridOrdens.Name = "DataGridOrdens";
            this.DataGridOrdens.ReadOnly = true;
            this.DataGridOrdens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOrdens.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridOrdens.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridOrdens.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridOrdens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridOrdens.Size = new System.Drawing.Size(984, 506);
            this.DataGridOrdens.TabIndex = 175;
            this.DataGridOrdens.Visible = false;
            this.DataGridOrdens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridOrdens_CellFormatting);
            // 
            // IDBOLETA
            // 
            this.IDBOLETA.HeaderText = "IDBOLETA";
            this.IDBOLETA.Name = "IDBOLETA";
            this.IDBOLETA.ReadOnly = true;
            this.IDBOLETA.Visible = false;
            this.IDBOLETA.Width = 10;
            // 
            // IDORDEM
            // 
            this.IDORDEM.HeaderText = "IDORDEM";
            this.IDORDEM.Name = "IDORDEM";
            this.IDORDEM.ReadOnly = true;
            this.IDORDEM.Visible = false;
            this.IDORDEM.Width = 10;
            // 
            // CODCOT
            // 
            this.CODCOT.HeaderText = "CODCOT";
            this.CODCOT.Name = "CODCOT";
            this.CODCOT.ReadOnly = true;
            this.CODCOT.Visible = false;
            this.CODCOT.Width = 110;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPFCNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Width = 110;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 220;
            // 
            // FUNDO
            // 
            this.FUNDO.HeaderText = "FUNDO";
            this.FUNDO.Name = "FUNDO";
            this.FUNDO.ReadOnly = true;
            this.FUNDO.Width = 180;
            // 
            // OP
            // 
            this.OP.HeaderText = "OP";
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
            this.OP.Width = 30;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 150;
            // 
            // CONTA
            // 
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.Width = 160;
            // 
            // STATUS_
            // 
            this.STATUS_.HeaderText = "STATUS";
            this.STATUS_.Name = "STATUS_";
            this.STATUS_.ReadOnly = true;
            this.STATUS_.Width = 90;
            // 
            // Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.DataGridOrdens);
            this.Controls.Add(this.DataGridStatus);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.CheckID);
            this.Controls.Add(this.CmBoxData);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.CmbBoxTipo);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.PanelOrdens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movimentacoes";
            this.Text = "Movimentacoes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrdens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.ComboBox CmbBoxTipo;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.ComboBox CmBoxData;
        private System.Windows.Forms.FlowLayoutPanel PanelOrdens;
        private System.Windows.Forms.CheckBox CheckID;
        private System.Windows.Forms.TextBox TextBoxID;
        public System.Windows.Forms.DataGridView DataGridStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
        public System.Windows.Forms.DataGridView DataGridOrdens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBOLETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDORDEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_;
    }
}