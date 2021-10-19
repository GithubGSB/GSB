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
            this.mnuItemAjoutZoneStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAjoutEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleRealise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAjoutControle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleObliga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAjoutUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuGSBControleStock.Size = new System.Drawing.Size(271, 450);
            this.mnuGSBControleStock.TabIndex = 0;
            this.mnuGSBControleStock.Text = "menuStrip1";
            // 
            // mnuItemZoneStock
            // 
            this.mnuItemZoneStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAjoutZoneStock});
            this.mnuItemZoneStock.Name = "mnuItemZoneStock";
            this.mnuItemZoneStock.Size = new System.Drawing.Size(258, 24);
            this.mnuItemZoneStock.Text = "Gestion zones de stockages";
            this.mnuItemZoneStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemAjoutZoneStock
            // 
            this.mnuItemAjoutZoneStock.Name = "mnuItemAjoutZoneStock";
            this.mnuItemAjoutZoneStock.Size = new System.Drawing.Size(292, 26);
            this.mnuItemAjoutZoneStock.Tag = "GZ";
            this.mnuItemAjoutZoneStock.Text = "Ajout d\'une Zone de Stockage";
            this.mnuItemAjoutZoneStock.Click += new System.EventHandler(this.mnuItemAjoutZoneStock_Click);
            // 
            // mnuItemEntreprise
            // 
            this.mnuItemEntreprise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAjoutEntreprise});
            this.mnuItemEntreprise.Name = "mnuItemEntreprise";
            this.mnuItemEntreprise.Size = new System.Drawing.Size(258, 24);
            this.mnuItemEntreprise.Text = "Gestion des entreprises";
            this.mnuItemEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemAjoutEntreprise
            // 
            this.mnuItemAjoutEntreprise.Name = "mnuItemAjoutEntreprise";
            this.mnuItemAjoutEntreprise.Size = new System.Drawing.Size(242, 26);
            this.mnuItemAjoutEntreprise.Tag = "GE";
            this.mnuItemAjoutEntreprise.Text = "Ajout  d\'une Entreprise";
            this.mnuItemAjoutEntreprise.Click += new System.EventHandler(this.mnuItemAjoutEntreprise_Click);
            // 
            // mnuItemControleRealise
            // 
            this.mnuItemControleRealise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAjoutControle});
            this.mnuItemControleRealise.Name = "mnuItemControleRealise";
            this.mnuItemControleRealise.Size = new System.Drawing.Size(258, 24);
            this.mnuItemControleRealise.Tag = "GC";
            this.mnuItemControleRealise.Text = "Gestion des contrôles réalisés";
            this.mnuItemControleRealise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemAjoutControle
            // 
            this.mnuItemAjoutControle.Name = "mnuItemAjoutControle";
            this.mnuItemAjoutControle.Size = new System.Drawing.Size(224, 26);
            this.mnuItemAjoutControle.Tag = "GC";
            this.mnuItemAjoutControle.Text = "Ajout d\'un controle";
            this.mnuItemAjoutControle.Click += new System.EventHandler(this.mnuItemAjoutControle_Click);
            // 
            // mnuItemControleObliga
            // 
            this.mnuItemControleObliga.Name = "mnuItemControleObliga";
            this.mnuItemControleObliga.Size = new System.Drawing.Size(258, 24);
            this.mnuItemControleObliga.Text = "Gestion des obligations de contrôles";
            this.mnuItemControleObliga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemUtilisateur
            // 
            this.mnuItemUtilisateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAjoutUtilisateur});
            this.mnuItemUtilisateur.Name = "mnuItemUtilisateur";
            this.mnuItemUtilisateur.Size = new System.Drawing.Size(258, 24);
            this.mnuItemUtilisateur.Tag = "GU";
            this.mnuItemUtilisateur.Text = "Gestion des utilisateurs";
            this.mnuItemUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemAjoutUtilisateur
            // 
            this.mnuItemAjoutUtilisateur.Name = "mnuItemAjoutUtilisateur";
            this.mnuItemAjoutUtilisateur.Size = new System.Drawing.Size(229, 26);
            this.mnuItemAjoutUtilisateur.Text = "Ajout d\'un utilisateur";
            this.mnuItemAjoutUtilisateur.Click += new System.EventHandler(this.mnuitemAjoutUtilisateur_Click);
            // 
            // mnuItemDeconnexion
            // 
            this.mnuItemDeconnexion.Name = "mnuItemDeconnexion";
            this.mnuItemDeconnexion.Size = new System.Drawing.Size(258, 24);
            this.mnuItemDeconnexion.Text = "Déconnexion";
            this.mnuItemDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuItemDeconnexion.Click += new System.EventHandler(this.mnuItemDeconnexion_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.mnuGSBControleStock);
            this.MainMenuStrip = this.mnuGSBControleStock;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem mnuItemAjoutZoneStock;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAjoutEntreprise;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAjoutControle;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAjoutUtilisateur;
    }
}