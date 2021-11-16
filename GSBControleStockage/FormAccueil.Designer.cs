﻿namespace GSBControleStockage
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
            this.mnuItemControleObliga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDunUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuGSBControleStock.Size = new System.Drawing.Size(271, 450);
            this.mnuGSBControleStock.TabIndex = 0;
            this.mnuGSBControleStock.Text = "menuStrip1";
            // 
            // mnuItemZoneStock
            // 
            this.mnuItemZoneStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneZoneStockageToolStripMenuItem});
            this.mnuItemZoneStock.Name = "mnuItemZoneStock";
            this.mnuItemZoneStock.Size = new System.Drawing.Size(258, 24);
            this.mnuItemZoneStock.Tag = "GZ";
            this.mnuItemZoneStock.Text = "Gestion zones de stockages";
            this.mnuItemZoneStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDuneZoneStockageToolStripMenuItem
            // 
            this.ajoutDuneZoneStockageToolStripMenuItem.Name = "ajoutDuneZoneStockageToolStripMenuItem";
            this.ajoutDuneZoneStockageToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.ajoutDuneZoneStockageToolStripMenuItem.Tag = "GZ";
            this.ajoutDuneZoneStockageToolStripMenuItem.Text = "Ajout d\'une Zone de Stockage";
            this.ajoutDuneZoneStockageToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneZoneStockageToolStripMenuItem_Click);
            // 
            // mnuItemEntreprise
            // 
            this.mnuItemEntreprise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneEntrepriseToolStripMenuItem});
            this.mnuItemEntreprise.Name = "mnuItemEntreprise";
            this.mnuItemEntreprise.Size = new System.Drawing.Size(258, 24);
            this.mnuItemEntreprise.Tag = "GE";
            this.mnuItemEntreprise.Text = "Gestion des entreprises";
            this.mnuItemEntreprise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDuneEntrepriseToolStripMenuItem
            // 
            this.ajoutDuneEntrepriseToolStripMenuItem.Name = "ajoutDuneEntrepriseToolStripMenuItem";
            this.ajoutDuneEntrepriseToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.ajoutDuneEntrepriseToolStripMenuItem.Tag = "GE";
            this.ajoutDuneEntrepriseToolStripMenuItem.Text = "Ajout  d\'une Entreprise";
            this.ajoutDuneEntrepriseToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneEntrepriseToolStripMenuItem_Click);
            // 
            // mnuItemControleRealise
            // 
            this.mnuItemControleRealise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunControleToolStripMenuItem});
            this.mnuItemControleRealise.Name = "mnuItemControleRealise";
            this.mnuItemControleRealise.Size = new System.Drawing.Size(258, 24);
            this.mnuItemControleRealise.Tag = "GC";
            this.mnuItemControleRealise.Text = "Gestion des contrôles réalisés";
            this.mnuItemControleRealise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDunControleToolStripMenuItem
            // 
            this.ajoutDunControleToolStripMenuItem.Name = "ajoutDunControleToolStripMenuItem";
            this.ajoutDunControleToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ajoutDunControleToolStripMenuItem.Tag = "GC";
            this.ajoutDunControleToolStripMenuItem.Text = "Ajout d\'un controle";
            this.ajoutDunControleToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunControleToolStripMenuItem_Click);
            // 
            // mnuItemControleObliga
            // 
            this.mnuItemControleObliga.Name = "mnuItemControleObliga";
            this.mnuItemControleObliga.Size = new System.Drawing.Size(258, 24);
            this.mnuItemControleObliga.Tag = "GO";
            this.mnuItemControleObliga.Text = "Gestion des obligations de contrôles";
            this.mnuItemControleObliga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuItemUtilisateur
            // 
            this.mnuItemUtilisateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunUtilisateurToolStripMenuItem,
            this.consultationDesUtilisateursToolStripMenuItem,
            this.modificationDunUtilisateurToolStripMenuItem});
            this.mnuItemUtilisateur.Name = "mnuItemUtilisateur";
            this.mnuItemUtilisateur.Size = new System.Drawing.Size(258, 24);
            this.mnuItemUtilisateur.Tag = "GU";
            this.mnuItemUtilisateur.Text = "Gestion des utilisateurs";
            this.mnuItemUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutDunUtilisateurToolStripMenuItem
            // 
            this.ajoutDunUtilisateurToolStripMenuItem.Name = "ajoutDunUtilisateurToolStripMenuItem";
            this.ajoutDunUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.ajoutDunUtilisateurToolStripMenuItem.Text = "Ajout d\'un utilisateur";
            this.ajoutDunUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunUtilisateurToolStripMenuItem_Click);
            // 
            // consultationDesUtilisateursToolStripMenuItem
            // 
            this.consultationDesUtilisateursToolStripMenuItem.Name = "consultationDesUtilisateursToolStripMenuItem";
            this.consultationDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.consultationDesUtilisateursToolStripMenuItem.Text = "Consultation des utilisateurs";
            this.consultationDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.consultationDesUtilisateursToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // modificationDunUtilisateurToolStripMenuItem
            // 
            this.modificationDunUtilisateurToolStripMenuItem.Name = "modificationDunUtilisateurToolStripMenuItem";
            this.modificationDunUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.modificationDunUtilisateurToolStripMenuItem.Text = "Modification d\'un utilisateur";
            this.modificationDunUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.modificationDunUtilisateurToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneZoneStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneEntrepriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunControleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDunUtilisateurToolStripMenuItem;
    }
}