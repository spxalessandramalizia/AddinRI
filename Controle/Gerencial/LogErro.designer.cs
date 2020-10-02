namespace Controle
{
    partial class LogErro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridErro = new System.Windows.Forms.DataGridView();
            this.BtnCarrega = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridErro)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridErro
            // 
            this.DataGridErro.AllowUserToAddRows = false;
            this.DataGridErro.AllowUserToDeleteRows = false;
            this.DataGridErro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridErro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridErro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridErro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridErro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridErro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridErro.ColumnHeadersHeight = 30;
            this.DataGridErro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridErro.EnableHeadersVisualStyles = false;
            this.DataGridErro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridErro.Location = new System.Drawing.Point(12, 55);
            this.DataGridErro.MultiSelect = false;
            this.DataGridErro.Name = "DataGridErro";
            this.DataGridErro.ReadOnly = true;
            this.DataGridErro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridErro.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridErro.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridErro.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridErro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridErro.Size = new System.Drawing.Size(1155, 468);
            this.DataGridErro.TabIndex = 45;
            // 
            // BtnCarrega
            // 
            this.BtnCarrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnCarrega.FlatAppearance.BorderSize = 0;
            this.BtnCarrega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnCarrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCarrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarrega.ForeColor = System.Drawing.Color.White;
            this.BtnCarrega.Location = new System.Drawing.Point(12, 14);
            this.BtnCarrega.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCarrega.Name = "BtnCarrega";
            this.BtnCarrega.Size = new System.Drawing.Size(155, 33);
            this.BtnCarrega.TabIndex = 46;
            this.BtnCarrega.Text = "Carrega Log";
            this.BtnCarrega.UseVisualStyleBackColor = false;
            this.BtnCarrega.Click += new System.EventHandler(this.BtnCarrega_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Location = new System.Drawing.Point(1140, 9);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 25);
            this.BtnFechar.TabIndex = 77;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // LogErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCarrega);
            this.Controls.Add(this.DataGridErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogErro";
            this.Text = "LogErro";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridErro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridErro;
        private System.Windows.Forms.Button BtnCarrega;
        private System.Windows.Forms.Button BtnFechar;
    }
}