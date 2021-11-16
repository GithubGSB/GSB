
namespace GSBControleStockage
{
    partial class FormModifUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.cbxProfil = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectionUtilisateur = new System.Windows.Forms.Label();
            this.cbcUtilisateur = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(0, 89);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(274, 29);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(274, 89);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(275, 29);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(219, 8);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom :";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProfil
            // 
            this.cbxProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProfil.FormattingEnabled = true;
            this.cbxProfil.Location = new System.Drawing.Point(273, 59);
            this.cbxProfil.Name = "cbxProfil";
            this.cbxProfil.Size = new System.Drawing.Size(273, 24);
            this.cbxProfil.TabIndex = 17;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(274, 31);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(273, 22);
            this.txtPrenom.TabIndex = 15;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(274, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(275, 22);
            this.txtNom.TabIndex = 13;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(202, 36);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 14;
            this.lblPrenom.Text = "Prénom :";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(219, 62);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(48, 17);
            this.lblProfil.TabIndex = 16;
            this.lblProfil.Text = "Profil :";
            this.lblProfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.lblPrenom);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.txtPrenom);
            this.panel1.Controls.Add(this.cbxProfil);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.lblProfil);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 124);
            this.panel1.TabIndex = 24;
            // 
            // lblSelectionUtilisateur
            // 
            this.lblSelectionUtilisateur.AutoSize = true;
            this.lblSelectionUtilisateur.Location = new System.Drawing.Point(12, 9);
            this.lblSelectionUtilisateur.Name = "lblSelectionUtilisateur";
            this.lblSelectionUtilisateur.Size = new System.Drawing.Size(145, 17);
            this.lblSelectionUtilisateur.TabIndex = 24;
            this.lblSelectionUtilisateur.Text = "Utilisateur a modifier :";
            this.lblSelectionUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbcUtilisateur
            // 
            this.cbcUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbcUtilisateur.FormattingEnabled = true;
            this.cbcUtilisateur.Location = new System.Drawing.Point(163, 6);
            this.cbcUtilisateur.Name = "cbcUtilisateur";
            this.cbcUtilisateur.Size = new System.Drawing.Size(398, 24);
            this.cbcUtilisateur.TabIndex = 24;
            this.cbcUtilisateur.SelectionChangeCommitted += new System.EventHandler(this.cbcUtilisateur_SelectionChangeCommitted);
            // 
            // FormModifUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 174);
            this.Controls.Add(this.cbcUtilisateur);
            this.Controls.Add(this.lblSelectionUtilisateur);
            this.Controls.Add(this.panel1);
            this.Name = "FormModifUtilisateur";
            this.Text = "Modification d\'un utilisateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cbxProfil;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectionUtilisateur;
        private System.Windows.Forms.ComboBox cbcUtilisateur;
    }
}