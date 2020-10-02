namespace Controle
{
    partial class Controle
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxAltCaixa = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.DataGridControle = new System.Windows.Forms.DataGridView();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BackGroundControle = new System.ComponentModel.BackgroundWorker();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridControle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Periodo";
            // 
            // TextBoxAltCaixa
            // 
            this.TextBoxAltCaixa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAltCaixa.Location = new System.Drawing.Point(88, 82);
            this.TextBoxAltCaixa.Name = "TextBoxAltCaixa";
            this.TextBoxAltCaixa.Size = new System.Drawing.Size(46, 27);
            this.TextBoxAltCaixa.TabIndex = 35;
            this.TextBoxAltCaixa.Text = "5";
            this.TextBoxAltCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(18, 48);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(116, 28);
            this.BtnIniciar.TabIndex = 34;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // DataGridControle
            // 
            this.DataGridControle.AllowUserToAddRows = false;
            this.DataGridControle.AllowUserToDeleteRows = false;
            this.DataGridControle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridControle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridControle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridControle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridControle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridControle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridControle.ColumnHeadersHeight = 30;
            this.DataGridControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridControle.EnableHeadersVisualStyles = false;
            this.DataGridControle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridControle.Location = new System.Drawing.Point(140, 14);
            this.DataGridControle.MultiSelect = false;
            this.DataGridControle.Name = "DataGridControle";
            this.DataGridControle.ReadOnly = true;
            this.DataGridControle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridControle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridControle.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridControle.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridControle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridControle.Size = new System.Drawing.Size(992, 505);
            this.DataGridControle.TabIndex = 135;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(18, 14);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(116, 28);
            this.BtnAtualizar.TabIndex = 137;
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
            this.BtnFechar.TabIndex = 147;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BackGroundControle
            // 
            this.BackGroundControle.WorkerReportsProgress = true;
            this.BackGroundControle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundControle_DoWork);
            this.BackGroundControle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundControle_RunWorkerCompleted);
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.DataGridControle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxAltCaixa);
            this.Controls.Add(this.BtnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controle";
            this.Text = "Controle";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridControle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxAltCaixa;
        private System.Windows.Forms.Button BtnIniciar;
        public System.Windows.Forms.DataGridView DataGridControle;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.ComponentModel.BackgroundWorker BackGroundControle;
        private System.Windows.Forms.Timer Timer;
    }
}