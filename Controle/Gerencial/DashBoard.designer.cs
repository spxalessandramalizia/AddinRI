namespace Controle
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridFIQs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridBatimento = new System.Windows.Forms.DataGridView();
            this.BtnAplica = new System.Windows.Forms.Button();
            this.DataGridResgates = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFIQs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBatimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResgates)).BeginInit();
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
            this.BtnFechar.TabIndex = 121;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(1021, 488);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(144, 33);
            this.BtnAtualizar.TabIndex = 125;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 126;
            this.label2.Text = "Aplicações";
            // 
            // DataGridFIQs
            // 
            this.DataGridFIQs.AllowUserToAddRows = false;
            this.DataGridFIQs.AllowUserToDeleteRows = false;
            this.DataGridFIQs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridFIQs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFIQs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridFIQs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFIQs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFIQs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridFIQs.ColumnHeadersHeight = 30;
            this.DataGridFIQs.EnableHeadersVisualStyles = false;
            this.DataGridFIQs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridFIQs.Location = new System.Drawing.Point(25, 50);
            this.DataGridFIQs.Name = "DataGridFIQs";
            this.DataGridFIQs.ReadOnly = true;
            this.DataGridFIQs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFIQs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridFIQs.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFIQs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridFIQs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridFIQs.Size = new System.Drawing.Size(300, 430);
            this.DataGridFIQs.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 130;
            this.label1.Text = "Batimento Aplicação por FIQ";
            // 
            // DataGridBatimento
            // 
            this.DataGridBatimento.AllowUserToAddRows = false;
            this.DataGridBatimento.AllowUserToDeleteRows = false;
            this.DataGridBatimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridBatimento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridBatimento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridBatimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBatimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBatimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridBatimento.ColumnHeadersHeight = 30;
            this.DataGridBatimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridBatimento.EnableHeadersVisualStyles = false;
            this.DataGridBatimento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridBatimento.Location = new System.Drawing.Point(331, 50);
            this.DataGridBatimento.Name = "DataGridBatimento";
            this.DataGridBatimento.ReadOnly = true;
            this.DataGridBatimento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBatimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridBatimento.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridBatimento.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridBatimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBatimento.Size = new System.Drawing.Size(445, 430);
            this.DataGridBatimento.TabIndex = 129;
            this.DataGridBatimento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridBatimento_CellFormatting);
            // 
            // BtnAplica
            // 
            this.BtnAplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAplica.FlatAppearance.BorderSize = 0;
            this.BtnAplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAplica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAplica.ForeColor = System.Drawing.Color.White;
            this.BtnAplica.Location = new System.Drawing.Point(126, 15);
            this.BtnAplica.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAplica.Name = "BtnAplica";
            this.BtnAplica.Size = new System.Drawing.Size(96, 27);
            this.BtnAplica.TabIndex = 131;
            this.BtnAplica.Text = "Por Master";
            this.BtnAplica.UseVisualStyleBackColor = false;
            this.BtnAplica.Click += new System.EventHandler(this.BtnAplicaMaster_Click);
            // 
            // DataGridResgates
            // 
            this.DataGridResgates.AllowUserToAddRows = false;
            this.DataGridResgates.AllowUserToDeleteRows = false;
            this.DataGridResgates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridResgates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridResgates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridResgates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridResgates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridResgates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridResgates.ColumnHeadersHeight = 30;
            this.DataGridResgates.EnableHeadersVisualStyles = false;
            this.DataGridResgates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridResgates.Location = new System.Drawing.Point(782, 50);
            this.DataGridResgates.Name = "DataGridResgates";
            this.DataGridResgates.ReadOnly = true;
            this.DataGridResgates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridResgates.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridResgates.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridResgates.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridResgates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridResgates.Size = new System.Drawing.Size(383, 430);
            this.DataGridResgates.TabIndex = 133;
            this.DataGridResgates.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridResgates_CellFormatting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(778, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 132;
            this.label3.Text = "Batimento Resgates";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.DataGridResgates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAplica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridBatimento);
            this.Controls.Add(this.DataGridFIQs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.VisibleChanged += new System.EventHandler(this.BtnAtualizar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFIQs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBatimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResgates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView DataGridFIQs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DataGridBatimento;
        private System.Windows.Forms.Button BtnAplica;
        public System.Windows.Forms.DataGridView DataGridResgates;
        private System.Windows.Forms.Label label3;
    }
}