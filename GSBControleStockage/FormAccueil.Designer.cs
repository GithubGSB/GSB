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
            this.ajoutDuneZoneStockageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneEntrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleRealise = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunControleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesControlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemControleObliga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnContrôleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.déconnexionToolStripMenuItem});
            this.mnuGSBControleStock.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuGSBControleStock.Location = new System.Drawing.Point(0, 0);
            this.mnuGSBControleStock.Name = "mnuGSBControleStock";
            this.mnuGSBControleStock.Size = new System.Drawing.Size(216, 366);
            this.mnuGSBControleStock.TabIndex = 0;
            this.mnuGSBControleStock.Text = "menuStrip1";
            // 
            // mnuItemZoneStock
            // 
            this.mnuItemZoneStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneZoneStockageToolStripMenuItem});
            this.mnuItemZoneStock.Name = "mnuItemZoneStock";
            this.mnuItemZoneStock.Size = new System.Drawing.Size(203, 19);
            this.mnuItemZoneStock.Tag = "GZ";
            this.mnuItemZoneStock.Text = "Gestion zones de stockages";
            this.mnuItemZoneStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDuneZoneStockageToolStripMenuItem
            // 
            this.ajoutDuneZoneStockageToolStripMenuItem.Name = "ajoutDuneZoneStockageToolStripMenuItem";
            this.ajoutDuneZoneStockageToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ajoutDuneZoneStockageToolStripMenuItem.Tag = "GZ";
            this.ajoutDuneZoneStockageToolStripMenuItem.Text = "Ajout d\'une Zone de Stockage";
            this.ajoutDuneZoneStockageToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneZoneStockageToolStripMenuItem_Click);
            // 
            // mnuItemEntreprise
            // 
            this.mnuItemEntreprise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneEntrepriseToolStripMenuItem});
            this.mnuItemEntreprise.Name = "mnuItemEntreprise";
            this.mnuItemEntreprise.Size = new System.Drawing.Size(203, 19);
            this.mnuItemEntreprise.Tag = "GE";
            this.mnuItemEntreprise.Text = "Gestion des entreprises";
            this.mnuItemEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDuneEntrepriseToolStripMenuItem
            // 
            this.ajoutDuneEntrepriseToolStripMenuItem.Name = "ajoutDuneEntrepriseToolStripMenuItem";
            this.ajoutDuneEntrepriseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ajoutDuneEntrepriseToolStripMenuItem.Tag = "GE";
            this.ajoutDuneEntrepriseToolStripMenuItem.Text = "Ajout  d\'une Entreprise";
            this.ajoutDuneEntrepriseToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneEntrepriseToolStripMenuItem_Click);
            // 
            // mnuItemControleRealise
            // 
            this.mnuItemControleRealise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunControleToolStripMenuItem,
            this.consultationDesControlesToolStripMenuItem,
            this.modifierUnContrôleToolStripMenuItem});
            this.mnuItemControleRealise.Name = "mnuItemControleRealise";
            this.mnuItemControleRealise.Size = new System.Drawing.Size(203, 19);
            this.mnuItemControleRealise.Tag = "GC";
            this.mnuItemControleRealise.Text = "Gestion des contrôles réalisés";
            this.mnuItemControleRealise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDunControleToolStripMenuItem
            // 
            this.ajoutDunControleToolStripMenuItem.Name = "ajoutDunControleToolStripMenuItem";
            this.ajoutDunControleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ajoutDunControleToolStripMenuItem.Tag = "GC";
            this.ajoutDunControleToolStripMenuItem.Text = "Ajout d\'un controle";
            this.ajoutDunControleToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunControleToolStripMenuItem_Click);
            // 
            // consultationDesControlesToolStripMenuItem
            // 
            this.consultationDesControlesToolStripMenuItem.Name = "consultationDesControlesToolStripMenuItem";
            this.consultationDesControlesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.consultationDesControlesToolStripMenuItem.Tag = "GC";
            this.consultationDesControlesToolStripMenuItem.Text = "Consultation des controles";
            this.consultationDesControlesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesControlesToolStripMenuItem_Click);
            // 
            // mnuItemControleObliga
            // 
            this.mnuItemControleObliga.Name = "mnuItemControleObliga";
            this.mnuItemControleObliga.Size = new System.Drawing.Size(203, 19);
            this.mnuItemControleObliga.Tag = "GO";
            this.mnuItemControleObliga.Text = "Gestion des obligations de contrôles";
            this.mnuItemControleObliga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemUtilisateur
            // 
            this.mnuItemUtilisateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunUtilisateurToolStripMenuItem});
            this.mnuItemUtilisateur.Name = "mnuItemUtilisateur";
            this.mnuItemUtilisateur.Size = new System.Drawing.Size(203, 19);
            this.mnuItemUtilisateur.Tag = "GU";
            this.mnuItemUtilisateur.Text = "Gestion des utilisateurs";
            this.mnuItemUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDunUtilisateurToolStripMenuItem
            // 
            this.ajoutDunUtilisateurToolStripMenuItem.Name = "ajoutDunUtilisateurToolStripMenuItem";
            this.ajoutDunUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ajoutDunUtilisateurToolStripMenuItem.Tag = "GU";
            this.ajoutDunUtilisateurToolStripMenuItem.Text = "Ajout d\'un utilisateur";
            this.ajoutDunUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunUtilisateurToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(203, 19);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // modifierUnContrôleToolStripMenuItem
            // 
            this.modifierUnContrôleToolStripMenuItem.Name = "modifierUnContrôleToolStripMenuItem";
            this.modifierUnContrôleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.modifierUnContrôleToolStripMenuItem.Tag = "GC";
            this.modifierUnContrôleToolStripMenuItem.Text = "Modifier un contrôle";
            this.modifierUnContrôleToolStripMenuItem.Click += new System.EventHandler(this.modifierUnContrôleToolStripMenuItem_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 366);
            this.Controls.Add(this.mnuGSBControleStock);
            this.MainMenuStrip = this.mnuGSBControleStock;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneZoneStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneEntrepriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunControleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesControlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnContrôleToolStripMenuItem;
    }
}