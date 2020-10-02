namespace Controle
{
    partial class SubOrdens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.DataGridOrdens = new System.Windows.Forms.DataGridView();
            this.PanelOrdens = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.DataGridStatus = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbBoxVisualiza = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrdens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStatus)).BeginInit();
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
            // DataGridOrdens
            // 
            this.DataGridOrdens.AllowUserToAddRows = false;
            this.DataGridOrdens.AllowUserToDeleteRows = false;
            this.DataGridOrdens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridOrdens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridOrdens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOrdens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOrdens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOrdens.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridOrdens.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridOrdens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridOrdens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridOrdens.Size = new System.Drawing.Size(984, 503);
            this.DataGridOrdens.TabIndex = 158;
            this.DataGridOrdens.Visible = false;
            this.DataGridOrdens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridOrdens_CellFormatting);
            this.DataGridOrdens.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridOrdens_ColumnHeaderMouseClick);
            // 
            // PanelOrdens
            // 
            this.PanelOrdens.AutoScroll = true;
            this.PanelOrdens.Location = new System.Drawing.Point(148, 14);
            this.PanelOrdens.Name = "PanelOrdens";
            this.PanelOrdens.Size = new System.Drawing.Size(984, 506);
            this.PanelOrdens.TabIndex = 159;
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
            this.BtnAtualizar.Location = new System.Drawing.Point(14, 50);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(126, 33);
            this.BtnAtualizar.TabIndex = 157;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // DataGridStatus
            // 
            this.DataGridStatus.AllowUserToAddRows = false;
            this.DataGridStatus.AllowUserToDeleteRows = false;
            this.DataGridStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridStatus.ColumnHeadersHeight = 30;
            this.DataGridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridStatus.ColumnHeadersVisible = false;
            this.DataGridStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Status,
            this.Qnt});
            this.DataGridStatus.EnableHeadersVisualStyles = false;
            this.DataGridStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridStatus.Location = new System.Drawing.Point(14, 91);
            this.DataGridStatus.MultiSelect = false;
            this.DataGridStatus.Name = "DataGridStatus";
            this.DataGridStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridStatus.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridStatus.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridStatus.Size = new System.Drawing.Size(126, 148);
            this.DataGridStatus.TabIndex = 163;
            this.DataGridStatus.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStatus_CellEndEdit);
            this.DataGridStatus.SelectionChanged += new System.EventHandler(this.DataGridStatus_SelectionChanged);
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
            // CmbBoxVisualiza
            // 
            this.CmbBoxVisualiza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxVisualiza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxVisualiza.FormattingEnabled = true;
            this.CmbBoxVisualiza.Items.AddRange(new object[] {
            "Ordens",
            "Movimentações"});
            this.CmbBoxVisualiza.Location = new System.Drawing.Point(14, 14);
            this.CmbBoxVisualiza.Name = "CmbBoxVisualiza";
            this.CmbBoxVisualiza.Size = new System.Drawing.Size(126, 28);
            this.CmbBoxVisualiza.TabIndex = 164;
            this.CmbBoxVisualiza.SelectedValueChanged += new System.EventHandler(this.CmbBoxVisualiza_SelectedValueChanged);
            // 
            // IDBOLETA
            // 
            this.IDBOLETA.HeaderText = "ID";
            this.IDBOLETA.Name = "IDBOLETA";
            this.IDBOLETA.ReadOnly = true;
            this.IDBOLETA.Width = 30;
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
            this.CONTA.Width = 150;
            // 
            // STATUS_
            // 
            this.STATUS_.HeaderText = "STATUS";
            this.STATUS_.Name = "STATUS_";
            this.STATUS_.ReadOnly = true;
            this.STATUS_.Width = 90;
            // 
            // SubOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.CmbBoxVisualiza);
            this.Controls.Add(this.DataGridStatus);
            this.Controls.Add(this.DataGridOrdens);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.PanelOrdens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubOrdens";
            this.Text = "SubOrdens";
            this.VisibleChanged += new System.EventHandler(this.SubOrdens_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrdens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        public System.Windows.Forms.DataGridView DataGridOrdens;
        private System.Windows.Forms.FlowLayoutPanel PanelOrdens;
        private System.Windows.Forms.Button BtnAtualizar;
        public System.Windows.Forms.DataGridView DataGridStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
        private System.Windows.Forms.ComboBox CmbBoxVisualiza;
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