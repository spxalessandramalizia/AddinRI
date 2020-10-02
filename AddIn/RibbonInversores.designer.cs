namespace AddIn
{
    partial class RibbonInversores : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonInversores()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonInversores));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Inversores = this.Factory.CreateRibbonGroup();
            this.BtnXP = this.Factory.CreateRibbonButton();
            this.BtnJGP = this.Factory.CreateRibbonButton();
            this.BtnCSHG = this.Factory.CreateRibbonButton();
            this.BtnVitreo = this.Factory.CreateRibbonButton();
            this.BtnBTG = this.Factory.CreateRibbonButton();
            this.BtnSantander = this.Factory.CreateRibbonButton();
            this.BtnBradesco = this.Factory.CreateRibbonButton();
            this.BtnItau = this.Factory.CreateRibbonButton();
            this.BtnBB = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Inversores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.Inversores);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // Inversores
            // 
            this.Inversores.Items.Add(this.BtnXP);
            this.Inversores.Items.Add(this.BtnJGP);
            this.Inversores.Items.Add(this.BtnCSHG);
            this.Inversores.Items.Add(this.BtnVitreo);
            this.Inversores.Items.Add(this.BtnBTG);
            this.Inversores.Items.Add(this.BtnSantander);
            this.Inversores.Items.Add(this.BtnBradesco);
            this.Inversores.Items.Add(this.BtnItau);
            this.Inversores.Items.Add(this.BtnBB);
            this.Inversores.Label = "Inversores";
            this.Inversores.Name = "Inversores";
            // 
            // BtnXP
            // 
            this.BtnXP.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnXP.Image = global::AddIn.Properties.Resources.Ícone_XP;
            this.BtnXP.Label = "XP";
            this.BtnXP.Name = "BtnXP";
            this.BtnXP.ShowImage = true;
            this.BtnXP.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnXP_Click);
            // 
            // BtnJGP
            // 
            this.BtnJGP.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnJGP.Image = ((System.Drawing.Image)(resources.GetObject("BtnJGP.Image")));
            this.BtnJGP.Label = "JGP";
            this.BtnJGP.Name = "BtnJGP";
            this.BtnJGP.ShowImage = true;
            this.BtnJGP.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnJGP_Click);
            // 
            // BtnCSHG
            // 
            this.BtnCSHG.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnCSHG.Image = global::AddIn.Properties.Resources.CSHG_Logo;
            this.BtnCSHG.Label = "CSHG";
            this.BtnCSHG.Name = "BtnCSHG";
            this.BtnCSHG.ShowImage = true;
            this.BtnCSHG.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnCSHG_Click);
            // 
            // BtnVitreo
            // 
            this.BtnVitreo.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnVitreo.Image = global::AddIn.Properties.Resources.Ícone_Vitreo;
            this.BtnVitreo.Label = "Vitreo";
            this.BtnVitreo.Name = "BtnVitreo";
            this.BtnVitreo.ShowImage = true;
            this.BtnVitreo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnVitreo_Click);
            // 
            // BtnBTG
            // 
            this.BtnBTG.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnBTG.Image = global::AddIn.Properties.Resources.BTG_Logo;
            this.BtnBTG.Label = "BTG";
            this.BtnBTG.Name = "BtnBTG";
            this.BtnBTG.ShowImage = true;
            this.BtnBTG.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnBTG_Click);
            // 
            // BtnSantander
            // 
            this.BtnSantander.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnSantander.Image = global::AddIn.Properties.Resources.Santender;
            this.BtnSantander.Label = "Santander";
            this.BtnSantander.Name = "BtnSantander";
            this.BtnSantander.ShowImage = true;
            this.BtnSantander.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSantander_Click);
            // 
            // BtnBradesco
            // 
            this.BtnBradesco.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnBradesco.Image = global::AddIn.Properties.Resources.Ícone_Bradesco;
            this.BtnBradesco.Label = "Bradesco";
            this.BtnBradesco.Name = "BtnBradesco";
            this.BtnBradesco.ShowImage = true;
            this.BtnBradesco.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnBradesco_Click);
            // 
            // BtnItau
            // 
            this.BtnItau.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnItau.Image = global::AddIn.Properties.Resources.Itau_Logo;
            this.BtnItau.Label = "Itaú";
            this.BtnItau.Name = "BtnItau";
            this.BtnItau.ShowImage = true;
            this.BtnItau.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnItau_Click);
            // 
            // BtnBB
            // 
            this.BtnBB.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnBB.Image = ((System.Drawing.Image)(resources.GetObject("BtnBB.Image")));
            this.BtnBB.Label = "BB";
            this.BtnBB.Name = "BtnBB";
            this.BtnBB.ShowImage = true;
            this.BtnBB.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnBB_Click);
            // 
            // RibbonInversores
            // 
            this.Name = "RibbonInversores";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Inversores.ResumeLayout(false);
            this.Inversores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Inversores;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnItau;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnSantander;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnCSHG;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnBradesco;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnBB;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnVitreo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnXP;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnBTG;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnJGP;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonInversores RibbonInversores
        {
            get { return this.GetRibbon<RibbonInversores>(); }
        }
    }
}
