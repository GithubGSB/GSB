
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
            this.tabpnlPrincipal = new System.Windows.Forms.TableLayoutPanel();
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
            this.tabpnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjouter.Location = new System.Drawing.Point(403, 373);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(394, 74);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // tabpnlPrincipal
            // 
            this.tabpnlPrincipal.ColumnCount = 2;
            this.tabpnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpnlPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpnlPrincipal.Controls.Add(this.btnAjouter, 1, 5);
            this.tabpnlPrincipal.Controls.Add(this.txtMdpConf, 1, 4);
            this.tabpnlPrincipal.Controls.Add(this.lblMdpConf, 0, 4);
            this.tabpnlPrincipal.Controls.Add(this.txtMdp, 1, 3);
            this.tabpnlPrincipal.Controls.Add(this.lblMdp, 0, 3);
            this.tabpnlPrincipal.Controls.Add(this.lblProfil, 0, 2);
            this.tabpnlPrincipal.Controls.Add(this.txtPrenom, 1, 1);
            this.tabpnlPrincipal.Controls.Add(this.lblPrenom, 0, 1);
            this.tabpnlPrincipal.Controls.Add(this.lblNom, 0, 0);
            this.tabpnlPrincipal.Controls.Add(this.txtNom, 1, 0);
            this.tabpnlPrincipal.Controls.Add(this.cbxProfil, 1, 2);
            this.tabpnlPrincipal.Controls.Add(this.btnAnnuler, 0, 5);
            this.tabpnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabpnlPrincipal.Name = "tabpnlPrincipal";
            this.tabpnlPrincipal.RowCount = 6;
            this.tabpnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpnlPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpnlPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tabpnlPrincipal.TabIndex = 1;
            // 
            // txtMdpConf
            // 
            this.txtMdpConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdpConf.Location = new System.Drawing.Point(403, 322);
            this.txtMdpConf.Name = "txtMdpConf";
            this.txtMdpConf.PasswordChar = '*';
            this.txtMdpConf.Size = new System.Drawing.Size(394, 22);
            this.txtMdpConf.TabIndex = 9;
            this.txtMdpConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMdpConf
            // 
            this.lblMdpConf.AutoSize = true;
            this.lblMdpConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMdpConf.Location = new System.Drawing.Point(3, 296);
            this.lblMdpConf.Name = "lblMdpConf";
            this.lblMdpConf.Size = new System.Drawing.Size(394, 74);
            this.lblMdpConf.TabIndex = 8;
            this.lblMdpConf.Text = "Mot de passe (confirmation) :";
            this.lblMdpConf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdp.Location = new System.Drawing.Point(403, 248);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(394, 22);
            this.txtMdp.TabIndex = 7;
            this.txtMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMdp.Location = new System.Drawing.Point(3, 222);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(394, 74);
            this.lblMdp.TabIndex = 6;
            this.lblMdp.Text = "Mot de passe :";
            this.lblMdp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfil.Location = new System.Drawing.Point(3, 148);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(394, 74);
            this.lblProfil.TabIndex = 4;
            this.lblProfil.Text = "Profil :";
            this.lblProfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(403, 100);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(394, 22);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrenom.Location = new System.Drawing.Point(3, 74);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(394, 74);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNom.Location = new System.Drawing.Point(3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(394, 74);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(403, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(394, 22);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxProfil
            // 
            this.cbxProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProfil.FormattingEnabled = true;
            this.cbxProfil.Location = new System.Drawing.Point(403, 172);
            this.cbxProfil.Name = "cbxProfil";
            this.cbxProfil.Size = new System.Drawing.Size(394, 24);
            this.cbxProfil.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnnuler.Location = new System.Drawing.Point(3, 373);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(394, 74);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormAjoutUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabpnlPrincipal);
            this.Name = "FormAjoutUtilisateur";
            this.Text = "Ajout d\'un utilisateur";
            this.tabpnlPrincipal.ResumeLayout(false);
            this.tabpnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TableLayoutPanel tabpnlPrincipal;
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