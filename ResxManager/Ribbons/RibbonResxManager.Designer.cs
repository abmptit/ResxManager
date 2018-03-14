namespace ResxManager
{
    partial class RibbonResxManager : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonResxManager()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResxManagerTab = this.Factory.CreateRibbonTab();
            this.ImportGroup = this.Factory.CreateRibbonGroup();
            this.AddResxFiles = this.Factory.CreateRibbonButton();
            this.ResxManagerTab.SuspendLayout();
            this.ImportGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResxManagerTab
            // 
            this.ResxManagerTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.ResxManagerTab.Groups.Add(this.ImportGroup);
            this.ResxManagerTab.Label = "Resx Manager";
            this.ResxManagerTab.Name = "ResxManagerTab";
            // 
            // ImportGroup
            // 
            this.ImportGroup.Items.Add(this.AddResxFiles);
            this.ImportGroup.Label = "Import";
            this.ImportGroup.Name = "ImportGroup";
            // 
            // AddResxFiles
            // 
            this.AddResxFiles.Label = "Add Resx File";
            this.AddResxFiles.Name = "AddResxFiles";
            // 
            // RibbonResxManager
            // 
            this.Name = "RibbonResxManager";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ResxManagerTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonResxManager_Load);
            this.ResxManagerTab.ResumeLayout(false);
            this.ResxManagerTab.PerformLayout();
            this.ImportGroup.ResumeLayout(false);
            this.ImportGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ResxManagerTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ImportGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddResxFiles;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonResxManager RibbonResxManager
        {
            get { return this.GetRibbon<RibbonResxManager>(); }
        }
    }
}
