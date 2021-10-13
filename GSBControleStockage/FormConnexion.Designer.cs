
namespace GSBControleStockage
{
    partial class FormConnexion
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(37, 9);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(77, 17);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(13, 37);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(101, 17);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(120, 6);
            this.txtIdentifiant.MaxLength = 50;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(287, 22);
            this.txtIdentifiant.TabIndex = 2;
            this.txtIdentifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(121, 35);
            this.txtMdp.MaxLength = 20;
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(286, 22);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(13, 71);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(394, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 103);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Name = "FormConnexion";
            this.Text = "Connexion au gestionnaire de contrôle de stockage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnexion;
    }
}