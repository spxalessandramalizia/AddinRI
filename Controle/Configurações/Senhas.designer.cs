namespace Controle
{
    partial class Senhas
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
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalvarIntrag = new System.Windows.Forms.Button();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnVerificar.FlatAppearance.BorderSize = 0;
            this.BtnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.ForeColor = System.Drawing.Color.White;
            this.BtnVerificar.Location = new System.Drawing.Point(463, 192);
            this.BtnVerificar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(256, 33);
            this.BtnVerificar.TabIndex = 19;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = false;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuário";
            // 
            // BtnSalvarIntrag
            // 
            this.BtnSalvarIntrag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSalvarIntrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnSalvarIntrag.FlatAppearance.BorderSize = 0;
            this.BtnSalvarIntrag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnSalvarIntrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSalvarIntrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarIntrag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarIntrag.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarIntrag.Location = new System.Drawing.Point(463, 309);
            this.BtnSalvarIntrag.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSalvarIntrag.Name = "BtnSalvarIntrag";
            this.BtnSalvarIntrag.Size = new System.Drawing.Size(256, 33);
            this.BtnSalvarIntrag.TabIndex = 18;
            this.BtnSalvarIntrag.Text = "Salvar";
            this.BtnSalvarIntrag.UseVisualStyleBackColor = false;
            this.BtnSalvarIntrag.Click += new System.EventHandler(this.BtnSalvarIntrag_Click);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.Location = new System.Drawing.Point(550, 235);
            this.TextBoxUser.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(169, 27);
            this.TextBoxUser.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSenha.Location = new System.Drawing.Point(550, 272);
            this.TextBoxSenha.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '*';
            this.TextBoxSenha.Size = new System.Drawing.Size(169, 27);
            this.TextBoxSenha.TabIndex = 16;
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
            this.BtnFechar.TabIndex = 78;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 535);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvarIntrag);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Senhas";
            this.Text = "Senhas";
            this.VisibleChanged += new System.EventHandler(this.Senhas_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalvarIntrag;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Button BtnFechar;
    }
}