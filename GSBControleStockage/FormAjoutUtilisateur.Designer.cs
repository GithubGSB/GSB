
namespace GSBControleStockage
{
    partial class FormAjoutUtilisateur
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtMdpConf = new System.Windows.Forms.TextBox();
            this.lblMdpConf = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbxProfil = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(295, 144);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(275, 29);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtMdpConf
            // 
            this.txtMdpConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdpConf.Location = new System.Drawing.Point(295, 119);
            this.txtMdpConf.Name = "txtMdpConf";
            this.txtMdpConf.PasswordChar = '*';
            this.txtMdpConf.Size = new System.Drawing.Size(275, 22);
            this.txtMdpConf.TabIndex = 9;
            this.txtMdpConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMdpConf
            // 
            this.lblMdpConf.AutoSize = true;
            this.lblMdpConf.Location = new System.Drawing.Point(97, 119);
            this.lblMdpConf.Name = "lblMdpConf";
            this.lblMdpConf.Size = new System.Drawing.Size(192, 17);
            this.lblMdpConf.TabIndex = 8;
            this.lblMdpConf.Text = "Mot de passe (confirmation) :";
            this.lblMdpConf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdp.Location = new System.Drawing.Point(295, 90);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(275, 22);
            this.txtMdp.TabIndex = 7;
            this.txtMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(188, 93);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(101, 17);
            this.lblMdp.TabIndex = 6;
            this.lblMdp.Text = "Mot de passe :";
            this.lblMdp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(241, 65);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(48, 17);
            this.lblProfil.TabIndex = 4;
            this.lblProfil.Text = "Profil :";
            this.lblProfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(295, 33);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(275, 22);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(224, 35);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(244, 7);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(295, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(275, 22);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxProfil
            // 
            this.cbxProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProfil.FormattingEnabled = true;
            this.cbxProfil.Location = new System.Drawing.Point(295, 61);
            this.cbxProfil.Name = "cbxProfil";
            this.cbxProfil.Size = new System.Drawing.Size(275, 24);
            this.cbxProfil.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(15, 144);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(274, 29);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormAjoutUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 185);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtMdpConf);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdpConf);
            this.Controls.Add(this.cbxProfil);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblProfil);
            this.Name = "FormAjoutUtilisateur";
            this.Text = "Ajout d\'un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtMdpConf;
        private System.Windows.Forms.Label lblMdpConf;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cbxProfil;
        private System.Windows.Forms.Button btnAnnuler;
    }
}