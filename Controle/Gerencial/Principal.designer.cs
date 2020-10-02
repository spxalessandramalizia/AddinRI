namespace Controle
{
    partial class Principal
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuDashBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOrdens = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuNovaOrdem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVisulaizarOrdens = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCaixaGestor = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuResgates = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuNovoResgate = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuContaeOrdem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroCotista = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroCC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuSenhas = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.gerencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuMovimenta = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuLogErro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelConteudo = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1179, 45);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::Controle.Properties.Resources.minimaze;
            this.btnMinimize.Location = new System.Drawing.Point(1084, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 29);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Controle.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1133, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle.Properties.Resources.spx_capital_logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(29, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.MenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDashBoard,
            this.MenuOrdens,
            this.MenuCadastro,
            this.MenuConfiguracao,
            this.gerencialToolStripMenuItem,
            this.MenuControle});
            this.MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 45);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1179, 28);
            this.MenuPrincipal.Stretch = false;
            this.MenuPrincipal.TabIndex = 4;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuDashBoard
            // 
            this.MenuDashBoard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDashBoard.ForeColor = System.Drawing.Color.Black;
            this.MenuDashBoard.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.MenuDashBoard.Name = "MenuDashBoard";
            this.MenuDashBoard.Size = new System.Drawing.Size(101, 24);
            this.MenuDashBoard.Text = "DashBoard";
            this.MenuDashBoard.Click += new System.EventHandler(this.MenuDashBoard_Click);
            // 
            // MenuOrdens
            // 
            this.MenuOrdens.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuNovaOrdem,
            this.SubMenuVisulaizarOrdens,
            this.SubMenuCaixaGestor,
            this.SubMenuResgates,
            this.SubMenuNovoResgate,
            this.SubMenuContaeOrdem});
            this.MenuOrdens.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOrdens.ForeColor = System.Drawing.Color.Black;
            this.MenuOrdens.Name = "MenuOrdens";
            this.MenuOrdens.Size = new System.Drawing.Size(74, 24);
            this.MenuOrdens.Text = "Ordens";
            // 
            // SubMenuNovaOrdem
            // 
            this.SubMenuNovaOrdem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubMenuNovaOrdem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuNovaOrdem.Name = "SubMenuNovaOrdem";
            this.SubMenuNovaOrdem.Size = new System.Drawing.Size(201, 24);
            this.SubMenuNovaOrdem.Text = "Nova Ordem";
            this.SubMenuNovaOrdem.Click += new System.EventHandler(this.SubMenuNovaOrdem_Click);
            // 
            // SubMenuVisulaizarOrdens
            // 
            this.SubMenuVisulaizarOrdens.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuVisulaizarOrdens.Name = "SubMenuVisulaizarOrdens";
            this.SubMenuVisulaizarOrdens.Size = new System.Drawing.Size(201, 24);
            this.SubMenuVisulaizarOrdens.Text = "Visualizar Ordens";
            this.SubMenuVisulaizarOrdens.Click += new System.EventHandler(this.SubMenuVisulaizarOrdens_Click);
            // 
            // SubMenuCaixaGestor
            // 
            this.SubMenuCaixaGestor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuCaixaGestor.Name = "SubMenuCaixaGestor";
            this.SubMenuCaixaGestor.Size = new System.Drawing.Size(201, 24);
            this.SubMenuCaixaGestor.Text = "Caixa Gestor";
            this.SubMenuCaixaGestor.Click += new System.EventHandler(this.SubMenuCaixaGestor_Click);
            // 
            // SubMenuResgates
            // 
            this.SubMenuResgates.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuResgates.Name = "SubMenuResgates";
            this.SubMenuResgates.Size = new System.Drawing.Size(201, 24);
            this.SubMenuResgates.Text = "Resgates";
            this.SubMenuResgates.Click += new System.EventHandler(this.SubMenuResgates_Click);
            // 
            // SubMenuNovoResgate
            // 
            this.SubMenuNovoResgate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuNovoResgate.Name = "SubMenuNovoResgate";
            this.SubMenuNovoResgate.Size = new System.Drawing.Size(201, 24);
            this.SubMenuNovoResgate.Text = "Novo Resgate";
            this.SubMenuNovoResgate.Click += new System.EventHandler(this.SubMenuNovoResgate_Click);
            // 
            // SubMenuContaeOrdem
            // 
            this.SubMenuContaeOrdem.Name = "SubMenuContaeOrdem";
            this.SubMenuContaeOrdem.Size = new System.Drawing.Size(201, 24);
            this.SubMenuContaeOrdem.Text = "Conta e Ordem";
            this.SubMenuContaeOrdem.Click += new System.EventHandler(this.SubMenuContaeOrdem_Click);
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCadastroCotista,
            this.SubMenuCadastroCC});
            this.MenuCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.ForeColor = System.Drawing.Color.Black;
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(89, 24);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // SubMenuCadastroCotista
            // 
            this.SubMenuCadastroCotista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuCadastroCotista.Name = "SubMenuCadastroCotista";
            this.SubMenuCadastroCotista.Size = new System.Drawing.Size(207, 24);
            this.SubMenuCadastroCotista.Text = "Cotista";
            this.SubMenuCadastroCotista.Click += new System.EventHandler(this.SubMenuCadastroCotista_Click);
            // 
            // SubMenuCadastroCC
            // 
            this.SubMenuCadastroCC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuCadastroCC.Name = "SubMenuCadastroCC";
            this.SubMenuCadastroCC.Size = new System.Drawing.Size(207, 24);
            this.SubMenuCadastroCC.Text = "Conta de Credito";
            this.SubMenuCadastroCC.Click += new System.EventHandler(this.SubMenuCadastroCC_Click);
            // 
            // MenuConfiguracao
            // 
            this.MenuConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuSenhas,
            this.SubMenuArquivos});
            this.MenuConfiguracao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuConfiguracao.ForeColor = System.Drawing.Color.Black;
            this.MenuConfiguracao.Name = "MenuConfiguracao";
            this.MenuConfiguracao.Size = new System.Drawing.Size(130, 24);
            this.MenuConfiguracao.Text = "Configurações";
            // 
            // SubMenuSenhas
            // 
            this.SubMenuSenhas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuSenhas.Name = "SubMenuSenhas";
            this.SubMenuSenhas.Size = new System.Drawing.Size(142, 24);
            this.SubMenuSenhas.Text = "Senhas";
            this.SubMenuSenhas.Click += new System.EventHandler(this.SubMenuSenhas_Click);
            // 
            // SubMenuArquivos
            // 
            this.SubMenuArquivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMenuArquivos.Name = "SubMenuArquivos";
            this.SubMenuArquivos.Size = new System.Drawing.Size(142, 24);
            this.SubMenuArquivos.Text = "Arquivos";
            this.SubMenuArquivos.Click += new System.EventHandler(this.SubMenuArquivos_Click);
            // 
            // gerencialToolStripMenuItem
            // 
            this.gerencialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuMovimenta,
            this.SubMenuLogErro});
            this.gerencialToolStripMenuItem.Name = "gerencialToolStripMenuItem";
            this.gerencialToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.gerencialToolStripMenuItem.Text = "Gerencial";
            // 
            // SubMenuMovimenta
            // 
            this.SubMenuMovimenta.Name = "SubMenuMovimenta";
            this.SubMenuMovimenta.Size = new System.Drawing.Size(199, 24);
            this.SubMenuMovimenta.Text = "Movimentações";
            this.SubMenuMovimenta.Click += new System.EventHandler(this.SubMenuMovimenta_Click);
            // 
            // SubMenuLogErro
            // 
            this.SubMenuLogErro.Name = "SubMenuLogErro";
            this.SubMenuLogErro.Size = new System.Drawing.Size(199, 24);
            this.SubMenuLogErro.Text = "Log de Erro";
            this.SubMenuLogErro.Click += new System.EventHandler(this.SubMenuLogErro_Click);
            // 
            // MenuControle
            // 
            this.MenuControle.Name = "MenuControle";
            this.MenuControle.Size = new System.Drawing.Size(85, 24);
            this.MenuControle.Text = "Controle";
            this.MenuControle.Click += new System.EventHandler(this.MenuControle_Click);
            // 
            // PanelConteudo
            // 
            this.PanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelConteudo.Location = new System.Drawing.Point(0, 73);
            this.PanelConteudo.Name = "PanelConteudo";
            this.PanelConteudo.Size = new System.Drawing.Size(1179, 535);
            this.PanelConteudo.TabIndex = 5;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 608);
            this.Controls.Add(this.PanelConteudo);
            this.Controls.Add(this.MenuPrincipal);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "PrincipalForm";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuDashBoard;
        private System.Windows.Forms.ToolStripMenuItem MenuOrdens;
        private System.Windows.Forms.ToolStripMenuItem SubMenuNovaOrdem;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVisulaizarOrdens;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCaixaGestor;
        private System.Windows.Forms.ToolStripMenuItem SubMenuResgates;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroCotista;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroCC;
        private System.Windows.Forms.ToolStripMenuItem MenuConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem SubMenuSenhas;
        private System.Windows.Forms.ToolStripMenuItem SubMenuArquivos;
        private System.Windows.Forms.Panel PanelConteudo;
        private System.Windows.Forms.ToolStripMenuItem SubMenuNovoResgate;
        private System.Windows.Forms.ToolStripMenuItem MenuControle;
        private System.Windows.Forms.ToolStripMenuItem SubMenuContaeOrdem;
        private System.Windows.Forms.ToolStripMenuItem gerencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubMenuMovimenta;
        private System.Windows.Forms.ToolStripMenuItem SubMenuLogErro;
    }
}