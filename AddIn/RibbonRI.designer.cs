namespace AddIn
{
    partial class RibbonRI : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonRI()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Grupo1 = this.Factory.CreateRibbonGroup();
            this.Configuracao = this.Factory.CreateRibbonGroup();
            this.TextUser = this.Factory.CreateRibbonEditBox();
            this.TextSenha = this.Factory.CreateRibbonEditBox();
            this.BtnAtualizar = this.Factory.CreateRibbonButton();
            this.BtnNovaOrdem = this.Factory.CreateRibbonButton();
            this.BtnConfirma = this.Factory.CreateRibbonButton();
            this.BtnGerarEmails = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Grupo1.SuspendLayout();
            this.Configuracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.Grupo1);
            this.tab1.Groups.Add(this.Configuracao);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // Grupo1
            // 
            this.Grupo1.Items.Add(this.BtnNovaOrdem);
            this.Grupo1.Items.Add(this.BtnConfirma);
            this.Grupo1.Items.Add(this.BtnGerarEmails);
            this.Grupo1.Label = "Boletagem";
            this.Grupo1.Name = "Grupo1";
            // 
            // Configuracao
            // 
            this.Configuracao.Items.Add(this.TextUser);
            this.Configuracao.Items.Add(this.TextSenha);
            this.Configuracao.Items.Add(this.BtnAtualizar);
            this.Configuracao.Label = "Configuração";
            this.Configuracao.Name = "Configuracao";
            // 
            // TextUser
            // 
            this.TextUser.Label = "Usuário";
            this.TextUser.Name = "TextUser";
            this.TextUser.Text = null;
            // 
            // TextSenha
            // 
            this.TextSenha.Label = "Senha";
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.Text = null;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Label = "Atualizar";
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnAtualizar_Click);
            // 
            // BtnNovaOrdem
            // 
            this.BtnNovaOrdem.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnNovaOrdem.Image = global::AddIn.Properties.Resources.novaboleta;
            this.BtnNovaOrdem.KeyTip = "Z";
            this.BtnNovaOrdem.Label = "Nova Ordem";
            this.BtnNovaOrdem.Name = "BtnNovaOrdem";
            this.BtnNovaOrdem.ShowImage = true;
            this.BtnNovaOrdem.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnNovaOrdem_Click);
            // 
            // BtnConfirma
            // 
            this.BtnConfirma.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnConfirma.Image = global::AddIn.Properties.Resources.ConfirmaMail;
            this.BtnConfirma.Label = "Confirmações";
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.ShowImage = true;
            this.BtnConfirma.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnConfirma_Click);
            // 
            // BtnGerarEmails
            // 
            this.BtnGerarEmails.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnGerarEmails.Image = global::AddIn.Properties.Resources.sendmail;
            this.BtnGerarEmails.Label = "Enviar Emails";
            this.BtnGerarEmails.Name = "BtnGerarEmails";
            this.BtnGerarEmails.ShowImage = true;
            this.BtnGerarEmails.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnGerarEmails_Click);
            // 
            // RibbonRI
            // 
            this.Name = "RibbonRI";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.Configuracao.ResumeLayout(false);
            this.Configuracao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Grupo1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnNovaOrdem;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnConfirma;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnGerarEmails;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TextUser;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TextSenha;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnAtualizar;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Configuracao;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonRI RibbonRI
        {
            get { return this.GetRibbon<RibbonRI>(); }
        }
    }
}
