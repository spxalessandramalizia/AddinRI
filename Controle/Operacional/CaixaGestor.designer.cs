namespace Controle
{
    partial class CaixaGestor
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
            this.DataGridMovimenta = new System.Windows.Forms.DataGridView();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.Fund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMovimenta)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMovimenta
            // 
            this.DataGridMovimenta.AllowUserToAddRows = false;
            this.DataGridMovimenta.AllowUserToDeleteRows = false;
            this.DataGridMovimenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridMovimenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridMovimenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridMovimenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridMovimenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMovimenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridMovimenta.ColumnHeadersHeight = 30;
            this.DataGridMovimenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridMovimenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fund,
            this.Valor,
            this.CPFCNPJ,
            this.Cotista,
            this.Horario});
            this.DataGridMovimenta.EnableHeadersVisualStyles = false;
            this.DataGridMovimenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridMovimenta.Location = new System.Drawing.Point(12, 55);
            this.DataGridMovimenta.Name = "DataGridMovimenta";
            this.DataGridMovimenta.ReadOnly = true;
            this.DataGridMovimenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMovimenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridMovimenta.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridMovimenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridMovimenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridMovimenta.Size = new System.Drawing.Size(1155, 468);
            this.DataGridMovimenta.TabIndex = 49;
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
            this.BtnAtualizar.Location = new System.Drawing.Point(12, 14);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(155, 33);
            this.BtnAtualizar.TabIndex = 50;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
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
            this.BtnFechar.TabIndex = 77;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Fund
            // 
            this.Fund.HeaderText = "Fundo";
            this.Fund.Name = "Fund";
            this.Fund.ReadOnly = true;
            this.Fund.Width = 70;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 66;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPF / CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Width = 101;
            // 
            // Cotista
            // 
            this.Cotista.HeaderText = "Cotista";
            this.Cotista.Name = "Cotista";
            this.Cotista.ReadOnly = true;
            this.Cotista.Width = 76;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 79;
            // 
            // CaixaGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.DataGridMovimenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaixaGestor";
            this.Text = "CaixaGestor";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMovimenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridMovimenta;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fund;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
    }
}