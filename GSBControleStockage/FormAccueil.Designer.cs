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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.mnuItemEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleRealise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleObliga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemAjoutUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunControleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGSBControleStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuGSBControleStock
            // 
            this.mnuGSBControleStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuGSBControleStock.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuGSBControleStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemZoneStock,
            this.mnuItemEntreprise,
            this.mnuItemControleRealise,
            this.mnuItemControleObliga,
            this.mnuItemUtilisateur,
            this.mnuItemDeconnexion});
            this.mnuGSBControleStock.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuGSBControleStock.Location = new System.Drawing.Point(0, 0);
            this.mnuGSBControleStock.Name = "mnuGSBControleStock";
            this.mnuGSBControleStock.Size = new System.Drawing.Size(1087, 28);
            this.mnuGSBControleStock.TabIndex = 0;
            this.mnuGSBControleStock.Text = "menuStrip1";
            // 
            // mnuItemZoneStock
            // 
            this.mnuItemZoneStock.Name = "mnuItemZoneStock";
            this.mnuItemZoneStock.Size = new System.Drawing.Size(205, 24);
            this.mnuItemZoneStock.Text = "Gestion zones de stockages";
            this.mnuItemZoneStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemEntreprise
            // 
            this.mnuItemEntreprise.Name = "mnuItemEntreprise";
            this.mnuItemEntreprise.Size = new System.Drawing.Size(176, 24);
            this.mnuItemEntreprise.Text = "Gestion des entreprises";
            this.mnuItemEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemControleRealise
            // 
            this.mnuItemControleRealise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunControleToolStripMenuItem});
            this.mnuItemControleRealise.Name = "mnuItemControleRealise";
            this.mnuItemControleRealise.Size = new System.Drawing.Size(218, 24);
            this.mnuItemControleRealise.Text = "Gestion des contrôles réalisés";
            this.mnuItemControleRealise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemControleObliga
            // 
            this.mnuItemControleObliga.Name = "mnuItemControleObliga";
            this.mnuItemControleObliga.Size = new System.Drawing.Size(265, 24);
            this.mnuItemControleObliga.Text = "Gestion des obligations de contrôles";
            this.mnuItemControleObliga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemUtilisateur
            // 
            this.mnuItemUtilisateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitemAjoutUtilisateur});
            this.mnuItemUtilisateur.Name = "mnuItemUtilisateur";
            this.mnuItemUtilisateur.Size = new System.Drawing.Size(175, 24);
            this.mnuItemUtilisateur.Text = "Gestion des utilisateurs";
            this.mnuItemUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuitemAjoutUtilisateur
            // 
            this.mnuitemAjoutUtilisateur.Name = "mnuitemAjoutUtilisateur";
            this.mnuitemAjoutUtilisateur.Size = new System.Drawing.Size(229, 26);
            this.mnuitemAjoutUtilisateur.Text = "Ajout d\'un utilisateur";
            this.mnuitemAjoutUtilisateur.Click += new System.EventHandler(this.mnuitemAjoutUtilisateur_Click);
            // 
            // mnuItemDeconnexion
            // 
            this.mnuItemDeconnexion.Name = "mnuItemDeconnexion";
            this.mnuItemDeconnexion.Size = new System.Drawing.Size(258, 24);
            this.mnuItemDeconnexion.Text = "Déconnexion";
            this.mnuItemDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuItemDeconnexion.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // ajoutDunControleToolStripMenuItem
            // 
            this.ajoutDunControleToolStripMenuItem.Name = "ajoutDunControleToolStripMenuItem";
            this.ajoutDunControleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutDunControleToolStripMenuItem.Text = "Ajout d\'un controle";
            this.ajoutDunControleToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunControleToolStripMenuItem_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 366);
            this.Controls.Add(this.mnuGSBControleStock);
            this.MainMenuStrip = this.mnuGSBControleStock;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}