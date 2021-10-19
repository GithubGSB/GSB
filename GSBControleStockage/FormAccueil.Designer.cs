
namespace GSBControleStockage
{
    partial class FormAccueil
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
            this.mnuGSBControleStock = new System.Windows.Forms.MenuStrip();
            this.mnuItemZoneStock = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDeLaZoneDeStockageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneEntrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleRealise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleObliga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGSBControleStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuGSBControleStock
            // 
            this.mnuGSBControleStock.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuGSBControleStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemZoneStock,
            this.mnuItemEntreprise,
            this.mnuItemControleRealise,
            this.mnuItemControleObliga,
            this.mnuItemUtilisateur});
            this.mnuGSBControleStock.Location = new System.Drawing.Point(0, 0);
            this.mnuGSBControleStock.Name = "mnuGSBControleStock";
            this.mnuGSBControleStock.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuGSBControleStock.Size = new System.Drawing.Size(815, 24);
            this.mnuGSBControleStock.TabIndex = 0;
            this.mnuGSBControleStock.Text = "menuStrip1";
            // 
            // mnuItemZoneStock
            // 
            this.mnuItemZoneStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDeLaZoneDeStockageToolStripMenuItem});
            this.mnuItemZoneStock.Name = "mnuItemZoneStock";
            this.mnuItemZoneStock.Size = new System.Drawing.Size(163, 20);
            this.mnuItemZoneStock.Text = "Gestion zones de stockages";
            // 
            // ajoutDeLaZoneDeStockageToolStripMenuItem
            // 
            this.ajoutDeLaZoneDeStockageToolStripMenuItem.Name = "ajoutDeLaZoneDeStockageToolStripMenuItem";
            this.ajoutDeLaZoneDeStockageToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ajoutDeLaZoneDeStockageToolStripMenuItem.Text = "Ajout de la zone de stockage";
            this.ajoutDeLaZoneDeStockageToolStripMenuItem.Click += new System.EventHandler(this.ajoutDeLaZoneDeStockageToolStripMenuItem_Click);
            // 
            // mnuItemEntreprise
            // 
            this.mnuItemEntreprise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneEntrepriseToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.mnuItemEntreprise.Name = "mnuItemEntreprise";
            this.mnuItemEntreprise.Size = new System.Drawing.Size(140, 20);
            this.mnuItemEntreprise.Text = "Gestion des entreprises";
            // 
            // ajoutDuneEntrepriseToolStripMenuItem
            // 
            this.ajoutDuneEntrepriseToolStripMenuItem.Name = "ajoutDuneEntrepriseToolStripMenuItem";
            this.ajoutDuneEntrepriseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ajoutDuneEntrepriseToolStripMenuItem.Text = "Ajout d\'une entreprise";
            this.ajoutDuneEntrepriseToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneEntrepriseToolStripMenuItem_Click);
            // 
            // mnuItemControleRealise
            // 
            this.mnuItemControleRealise.Name = "mnuItemControleRealise";
            this.mnuItemControleRealise.Size = new System.Drawing.Size(173, 20);
            this.mnuItemControleRealise.Text = "Gestion des contrôles réalisés";
            // 
            // mnuItemControleObliga
            // 
            this.mnuItemControleObliga.Name = "mnuItemControleObliga";
            this.mnuItemControleObliga.Size = new System.Drawing.Size(210, 20);
            this.mnuItemControleObliga.Text = "Gestion des obligations de contrôles";
            // 
            // mnuItemUtilisateur
            // 
            this.mnuItemUtilisateur.Name = "mnuItemUtilisateur";
            this.mnuItemUtilisateur.Size = new System.Drawing.Size(140, 20);
            this.mnuItemUtilisateur.Text = "Gestion des utilisateurs";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 366);
            this.Controls.Add(this.mnuGSBControleStock);
            this.MainMenuStrip = this.mnuGSBControleStock;
            this.Name = "FormAccueil";
            this.Text = "GSB Contrôle des stockage";
            this.mnuGSBControleStock.ResumeLayout(false);
            this.mnuGSBControleStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGSBControleStock;
        private System.Windows.Forms.ToolStripMenuItem mnuItemZoneStock;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEntreprise;
        private System.Windows.Forms.ToolStripMenuItem mnuItemControleRealise;
        private System.Windows.Forms.ToolStripMenuItem mnuItemControleObliga;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem ajoutDeLaZoneDeStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneEntrepriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
    }
}

