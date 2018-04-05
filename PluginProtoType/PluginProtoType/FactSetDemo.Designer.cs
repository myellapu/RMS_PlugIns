namespace PluginProtoType
{
    partial class FactSetDemo : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FactSetDemo()
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
            this.FactSetRMSDemo = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Save = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.URL = this.Factory.CreateRibbonEditBox();
            this.FactSetRMSDemo.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FactSetRMSDemo
            // 
            this.FactSetRMSDemo.Groups.Add(this.group1);
            this.FactSetRMSDemo.Groups.Add(this.group2);
            this.FactSetRMSDemo.Label = "FactSet RMS Demo";
            this.FactSetRMSDemo.Name = "FactSetRMSDemo";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Save);
            this.group1.Name = "group1";
            // 
            // Save
            // 
            this.Save.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Save.Image = global::PluginProtoType.Properties.Resources.icon;
            this.Save.Label = "Save";
            this.Save.Name = "Save";
            this.Save.ScreenTip = "Save";
            this.Save.ShowImage = true;
            this.Save.SuperTip = "Click to Save Research to CodeRed";
            this.Save.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.save_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.URL);
            this.group2.Name = "group2";
            // 
            // URL
            // 
            this.URL.Label = "URL";
            this.URL.MaxLength = 1024;
            this.URL.Name = "URL";
            this.URL.ScreenTip = "URL";
            this.URL.SizeString = "999999999999999999999999999999999";
            this.URL.SuperTip = "Enter URL for connecting to CodeRed";
            this.URL.Text = null;
            // 
            // FactSetDemo
            // 
            this.Name = "FactSetDemo";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.FactSetRMSDemo);
            this.FactSetRMSDemo.ResumeLayout(false);
            this.FactSetRMSDemo.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab FactSetRMSDemo;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Save;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox URL;
    }

    partial class ThisRibbonCollection
    {
        internal FactSetDemo FactSetDemo
        {
            get { return this.GetRibbon<FactSetDemo>(); }
        }
    }
}
