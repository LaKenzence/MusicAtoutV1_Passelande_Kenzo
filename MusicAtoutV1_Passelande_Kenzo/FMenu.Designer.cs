
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bsVille = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lISTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vILLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bATIMENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tYPESDOEUVREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPOSITEURSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nATIONALITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTYLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTILISATEURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsVille
            // 
            this.bsVille.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTEToolStripMenuItem,
            this.cOMPOSITEURSToolStripMenuItem,
            this.UTILISATEURToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lISTEToolStripMenuItem
            // 
            this.lISTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vILLESToolStripMenuItem,
            this.sALLESToolStripMenuItem,
            this.bATIMENTSToolStripMenuItem,
            this.tYPESDOEUVREToolStripMenuItem});
            this.lISTEToolStripMenuItem.Name = "lISTEToolStripMenuItem";
            this.lISTEToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.lISTEToolStripMenuItem.Text = "LISTE";
            this.lISTEToolStripMenuItem.Click += new System.EventHandler(this.lISTEToolStripMenuItem_Click_1);
            // 
            // vILLESToolStripMenuItem
            // 
            this.vILLESToolStripMenuItem.Name = "vILLESToolStripMenuItem";
            this.vILLESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vILLESToolStripMenuItem.Text = "VILLES";
            this.vILLESToolStripMenuItem.Click += new System.EventHandler(this.vILLESToolStripMenuItem_Click_1);
            // 
            // sALLESToolStripMenuItem
            // 
            this.sALLESToolStripMenuItem.Name = "sALLESToolStripMenuItem";
            this.sALLESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALLESToolStripMenuItem.Text = "SALLES";
            this.sALLESToolStripMenuItem.Click += new System.EventHandler(this.sALLESToolStripMenuItem_Click_1);
            // 
            // bATIMENTSToolStripMenuItem
            // 
            this.bATIMENTSToolStripMenuItem.Name = "bATIMENTSToolStripMenuItem";
            this.bATIMENTSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bATIMENTSToolStripMenuItem.Text = "BATIMENTS";
            this.bATIMENTSToolStripMenuItem.Click += new System.EventHandler(this.bATIMENTSToolStripMenuItem_Click_1);
            // 
            // tYPESDOEUVREToolStripMenuItem
            // 
            this.tYPESDOEUVREToolStripMenuItem.Name = "tYPESDOEUVREToolStripMenuItem";
            this.tYPESDOEUVREToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tYPESDOEUVREToolStripMenuItem.Text = "TYPES D\'OEUVRE";
            this.tYPESDOEUVREToolStripMenuItem.Click += new System.EventHandler(this.tYPESDOEUVREToolStripMenuItem_Click);
            // 
            // cOMPOSITEURSToolStripMenuItem
            // 
            this.cOMPOSITEURSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nATIONALITEToolStripMenuItem,
            this.sTYLEToolStripMenuItem});
            this.cOMPOSITEURSToolStripMenuItem.Name = "cOMPOSITEURSToolStripMenuItem";
            this.cOMPOSITEURSToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.cOMPOSITEURSToolStripMenuItem.Text = "COMPOSITEURS";
            // 
            // nATIONALITEToolStripMenuItem
            // 
            this.nATIONALITEToolStripMenuItem.Name = "nATIONALITEToolStripMenuItem";
            this.nATIONALITEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nATIONALITEToolStripMenuItem.Text = "Par nationalité";
            this.nATIONALITEToolStripMenuItem.Click += new System.EventHandler(this.nATIONALITEToolStripMenuItem_Click);
            // 
            // sTYLEToolStripMenuItem
            // 
            this.sTYLEToolStripMenuItem.Name = "sTYLEToolStripMenuItem";
            this.sTYLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sTYLEToolStripMenuItem.Text = "Par style";
            this.sTYLEToolStripMenuItem.Click += new System.EventHandler(this.sTYLEToolStripMenuItem_Click_1);
            // 
            // UTILISATEURToolStripMenuItem
            // 
            this.UTILISATEURToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.UTILISATEURToolStripMenuItem.Name = "UTILISATEURToolStripMenuItem";
            this.UTILISATEURToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.UTILISATEURToolStripMenuItem.Text = "UTILISATEUR";
            this.UTILISATEURToolStripMenuItem.Visible = false;
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Visible = false;
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click_1);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVille;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lISTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vILLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bATIMENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tYPESDOEUVREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPOSITEURSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nATIONALITEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTYLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTILISATEURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
    }
}

