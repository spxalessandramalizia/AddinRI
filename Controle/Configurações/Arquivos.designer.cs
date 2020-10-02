namespace Controle
{
    partial class Arquivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextLogErro = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BackData = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.UploadBar = new System.Windows.Forms.ProgressBar();
            this.BtnBuscarArquivo = new System.Windows.Forms.Button();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.TextBoxLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxFile = new System.Windows.Forms.ComboBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAtualizaSaldos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAtualizaCotas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Arquivos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextLogErro);
            this.panel1.Controls.Add(this.BtnAtualizar);
            this.panel1.Location = new System.Drawing.Point(12, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 89);
            this.panel1.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "LogErro";
            // 
            // TextLogErro
            // 
            this.TextLogErro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLogErro.Location = new System.Drawing.Point(9, 37);
            this.TextLogErro.Name = "TextLogErro";
            this.TextLogErro.Size = new System.Drawing.Size(418, 23);
            this.TextLogErro.TabIndex = 71;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(435, 37);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(175, 23);
            this.BtnAtualizar.TabIndex = 67;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
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
            this.BtnFechar.TabIndex = 76;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BackData
            // 
            this.BackData.WorkerReportsProgress = true;
            this.BackData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackData_DoWork);
            this.BackData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackData_ProgressChanged);
            this.BackData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackData_RunWorkerCompleted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.UploadBar);
            this.panel3.Controls.Add(this.BtnBuscarArquivo);
            this.panel3.Controls.Add(this.BtnUpload);
            this.panel3.Controls.Add(this.TextBoxLocal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ComboBoxFile);
            this.panel3.Location = new System.Drawing.Point(12, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 196);
            this.panel3.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Local";
            // 
            // UploadBar
            // 
            this.UploadBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.UploadBar.Location = new System.Drawing.Point(7, 154);
            this.UploadBar.Name = "UploadBar";
            this.UploadBar.Size = new System.Drawing.Size(603, 23);
            this.UploadBar.Step = 1;
            this.UploadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.UploadBar.TabIndex = 73;
            // 
            // BtnBuscarArquivo
            // 
            this.BtnBuscarArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnBuscarArquivo.FlatAppearance.BorderSize = 0;
            this.BtnBuscarArquivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnBuscarArquivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnBuscarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarArquivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarArquivo.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarArquivo.Location = new System.Drawing.Point(435, 38);
            this.BtnBuscarArquivo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBuscarArquivo.Name = "BtnBuscarArquivo";
            this.BtnBuscarArquivo.Size = new System.Drawing.Size(175, 26);
            this.BtnBuscarArquivo.TabIndex = 67;
            this.BtnBuscarArquivo.Text = "Buscar Arquivo";
            this.BtnBuscarArquivo.UseVisualStyleBackColor = false;
            this.BtnBuscarArquivo.Click += new System.EventHandler(this.BtnBuscarArquivo_Click);
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnUpload.FlatAppearance.BorderSize = 0;
            this.BtnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpload.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.White;
            this.BtnUpload.Location = new System.Drawing.Point(435, 107);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(175, 28);
            this.BtnUpload.TabIndex = 72;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // TextBoxLocal
            // 
            this.TextBoxLocal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLocal.Location = new System.Drawing.Point(7, 38);
            this.TextBoxLocal.Name = "TextBoxLocal";
            this.TextBoxLocal.Size = new System.Drawing.Size(420, 26);
            this.TextBoxLocal.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tipo Arquivo";
            // 
            // ComboBoxFile
            // 
            this.ComboBoxFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxFile.FormattingEnabled = true;
            this.ComboBoxFile.Location = new System.Drawing.Point(7, 107);
            this.ComboBoxFile.Name = "ComboBoxFile";
            this.ComboBoxFile.Size = new System.Drawing.Size(420, 28);
            this.ComboBoxFile.TabIndex = 69;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BtnAtualizaCotas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BtnAtualizaSaldos);
            this.panel2.Location = new System.Drawing.Point(786, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 161);
            this.panel2.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "ARQSDFD0 (SALDOS) - WEBSERVICE";
            // 
            // BtnAtualizaSaldos
            // 
            this.BtnAtualizaSaldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizaSaldos.FlatAppearance.BorderSize = 0;
            this.BtnAtualizaSaldos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizaSaldos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizaSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizaSaldos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizaSaldos.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizaSaldos.Location = new System.Drawing.Point(9, 39);
            this.BtnAtualizaSaldos.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizaSaldos.Name = "BtnAtualizaSaldos";
            this.BtnAtualizaSaldos.Size = new System.Drawing.Size(92, 27);
            this.BtnAtualizaSaldos.TabIndex = 67;
            this.BtnAtualizaSaldos.Text = "Atualizar";
            this.BtnAtualizaSaldos.UseVisualStyleBackColor = false;
            this.BtnAtualizaSaldos.Click += new System.EventHandler(this.BtnAtualizaSaldos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "ARQCOT (COTAS) - WEBSERVICE";
            // 
            // BtnAtualizaCotas
            // 
            this.BtnAtualizaCotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizaCotas.FlatAppearance.BorderSize = 0;
            this.BtnAtualizaCotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizaCotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnAtualizaCotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizaCotas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizaCotas.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizaCotas.Location = new System.Drawing.Point(9, 121);
            this.BtnAtualizaCotas.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAtualizaCotas.Name = "BtnAtualizaCotas";
            this.BtnAtualizaCotas.Size = new System.Drawing.Size(92, 27);
            this.BtnAtualizaCotas.TabIndex = 75;
            this.BtnAtualizaCotas.Text = "Atualizar";
            this.BtnAtualizaCotas.UseVisualStyleBackColor = false;
            this.BtnAtualizaCotas.Click += new System.EventHandler(this.BtnAtualizaCotas_Click);
            // 
            // Arquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Arquivos";
            this.Text = "Arquivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextLogErro;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.ComponentModel.BackgroundWorker BackData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar UploadBar;
        private System.Windows.Forms.Button BtnBuscarArquivo;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.TextBox TextBoxLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAtualizaCotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAtualizaSaldos;
    }
}