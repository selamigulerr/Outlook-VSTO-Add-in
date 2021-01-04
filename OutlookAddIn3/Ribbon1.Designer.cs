
namespace OutlookAddIn3
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.myApp = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.getMail = this.Factory.CreateRibbonButton();
            this.login = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.myApp.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // myApp
            // 
            this.myApp.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.myApp.Groups.Add(this.group1);
            this.myApp.Groups.Add(this.group2);
            this.myApp.Label = "myApp";
            this.myApp.Name = "myApp";
            // 
            // group1
            // 
            this.group1.Items.Add(this.getMail);
            this.group1.Items.Add(this.login);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // getMail
            // 
            this.getMail.Label = "Mail";
            this.getMail.Name = "getMail";
            this.getMail.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.getMail_Click);
            // 
            // login
            // 
            this.login.Label = "Login";
            this.login.Name = "login";
            this.login.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.login_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.label1);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // label1
            // 
            this.label1.Label = "label1";
            this.label1.Name = "label1";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = resources.GetString("$this.RibbonType");
            this.Tabs.Add(this.myApp);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.myApp.ResumeLayout(false);
            this.myApp.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab myApp;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton getMail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton login;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
