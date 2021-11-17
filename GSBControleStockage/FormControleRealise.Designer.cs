
namespace GSBControleStockage
{
    partial class FormControleRealise
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
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtPrixHT = new System.Windows.Forms.TextBox();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.cbxEntreprise = new System.Windows.Forms.ComboBox();
            this.cbxTypeControle = new System.Windows.Forms.ComboBox();
            this.cbxZoneStockage = new System.Windows.Forms.ComboBox();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.lblZoneStockage = new System.Windows.Forms.Label();
            this.lblTypeControle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(397, 250);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 32;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtPrixHT
            // 
            this.txtPrixHT.Location = new System.Drawing.Point(271, 108);
            this.txtPrixHT.Name = "txtPrixHT";
            this.txtPrixHT.Size = new System.Drawing.Size(201, 20);
            this.txtPrixHT.TabIndex = 27;
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(139, 111);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(132, 13);
            this.lblPrixHT.TabIndex = 23;
            this.lblPrixHT.Text = "Prix hors taxe du contrôle :";
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(270, 82);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(202, 20);
            this.txtResume.TabIndex = 28;
            this.txtResume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(160, 85);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(105, 13);
            this.lblResume.TabIndex = 22;
            this.lblResume.Text = "Resumé du contôle :";
            this.lblResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(270, 250);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(75, 23);
            this.btnAnnul.TabIndex = 33;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            // 
            // cbxEntreprise
            // 
            this.cbxEntreprise.FormattingEnabled = true;
            this.cbxEntreprise.Location = new System.Drawing.Point(270, 149);
            this.cbxEntreprise.Name = "cbxEntreprise";
            this.cbxEntreprise.Size = new System.Drawing.Size(202, 21);
            this.cbxEntreprise.TabIndex = 34;
            // 
            // cbxTypeControle
            // 
            this.cbxTypeControle.FormattingEnabled = true;
            this.cbxTypeControle.Location = new System.Drawing.Point(270, 203);
            this.cbxTypeControle.Name = "cbxTypeControle";
            this.cbxTypeControle.Size = new System.Drawing.Size(202, 21);
            this.cbxTypeControle.TabIndex = 35;
            // 
            // cbxZoneStockage
            // 
            this.cbxZoneStockage.FormattingEnabled = true;
            this.cbxZoneStockage.Location = new System.Drawing.Point(270, 176);
            this.cbxZoneStockage.Name = "cbxZoneStockage";
            this.cbxZoneStockage.Size = new System.Drawing.Size(202, 21);
            this.cbxZoneStockage.TabIndex = 36;
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(204, 157);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(60, 13);
            this.lblEntreprise.TabIndex = 37;
            this.lblEntreprise.Text = "Entreprise :";
            // 
            // lblZoneStockage
            // 
            this.lblZoneStockage.AutoSize = true;
            this.lblZoneStockage.Location = new System.Drawing.Point(165, 184);
            this.lblZoneStockage.Name = "lblZoneStockage";
            this.lblZoneStockage.Size = new System.Drawing.Size(100, 13);
            this.lblZoneStockage.TabIndex = 38;
            this.lblZoneStockage.Text = "Zone de stockage :";
            // 
            // lblTypeControle
            // 
            this.lblTypeControle.AutoSize = true;
            this.lblTypeControle.Location = new System.Drawing.Point(171, 211);
            this.lblTypeControle.Name = "lblTypeControle";
            this.lblTypeControle.Size = new System.Drawing.Size(93, 13);
            this.lblTypeControle.TabIndex = 39;
            this.lblTypeControle.Text = "Type de contrôle :";
            // 
            // FormControleRealise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTypeControle);
            this.Controls.Add(this.lblZoneStockage);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.cbxZoneStockage);
            this.Controls.Add(this.cbxTypeControle);
            this.Controls.Add(this.cbxEntreprise);
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.txtPrixHT);
            this.Controls.Add(this.btnAjout);
            this.Name = "FormControleRealise";
            this.Text = "Ajout d\'un contrôle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtPrixHT;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.ComboBox cbxEntreprise;
        private System.Windows.Forms.ComboBox cbxTypeControle;
        private System.Windows.Forms.ComboBox cbxZoneStockage;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.Label lblZoneStockage;
        private System.Windows.Forms.Label lblTypeControle;
    }
}