
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
            this.lblDateDerniereModif = new System.Windows.Forms.Label();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.lblDateControle = new System.Windows.Forms.Label();
            this.dtCreation = new System.Windows.Forms.DateTimePicker();
            this.dtControle = new System.Windows.Forms.DateTimePicker();
            this.dtDerniereModif = new System.Windows.Forms.DateTimePicker();
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
            // lblDateDerniereModif
            // 
            this.lblDateDerniereModif.AutoSize = true;
            this.lblDateDerniereModif.Location = new System.Drawing.Point(35, 112);
            this.lblDateDerniereModif.Name = "lblDateDerniereModif";
            this.lblDateDerniereModif.Size = new System.Drawing.Size(162, 13);
            this.lblDateDerniereModif.TabIndex = 24;
            this.lblDateDerniereModif.Text = "Date de la dernière modification :";
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Location = new System.Drawing.Point(111, 82);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(77, 13);
            this.lblDateCreation.TabIndex = 25;
            this.lblDateCreation.Text = "Date création :";
            // 
            // lblDateControle
            // 
            this.lblDateControle.AutoSize = true;
            this.lblDateControle.Location = new System.Drawing.Point(110, 55);
            this.lblDateControle.Name = "lblDateControle";
            this.lblDateControle.Size = new System.Drawing.Size(77, 13);
            this.lblDateControle.TabIndex = 26;
            this.lblDateControle.Text = "Date contrôle :";
            // 
            // dtCreation
            // 
            this.dtCreation.Location = new System.Drawing.Point(198, 76);
            this.dtCreation.Name = "dtCreation";
            this.dtCreation.Size = new System.Drawing.Size(200, 20);
            this.dtCreation.TabIndex = 29;
            // 
            // dtControle
            // 
            this.dtControle.Location = new System.Drawing.Point(197, 48);
            this.dtControle.Name = "dtControle";
            this.dtControle.Size = new System.Drawing.Size(200, 20);
            this.dtControle.TabIndex = 30;
            // 
            // dtDerniereModif
            // 
            this.dtDerniereModif.Location = new System.Drawing.Point(197, 105);
            this.dtDerniereModif.Name = "dtDerniereModif";
            this.dtDerniereModif.Size = new System.Drawing.Size(200, 20);
            this.dtDerniereModif.TabIndex = 31;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(323, 325);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 32;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtPrixHT
            // 
            this.txtPrixHT.Location = new System.Drawing.Point(197, 174);
            this.txtPrixHT.Name = "txtPrixHT";
            this.txtPrixHT.Size = new System.Drawing.Size(201, 20);
            this.txtPrixHT.TabIndex = 27;
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(65, 177);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(132, 13);
            this.lblPrixHT.TabIndex = 23;
            this.lblPrixHT.Text = "Prix hors taxe du contrôle :";
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(196, 148);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(202, 20);
            this.txtResume.TabIndex = 28;
            this.txtResume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(86, 151);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(105, 13);
            this.lblResume.TabIndex = 22;
            this.lblResume.Text = "Resumé du contôle :";
            this.lblResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(197, 325);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(75, 23);
            this.btnAnnul.TabIndex = 33;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            // 
            // cbxEntreprise
            // 
            this.cbxEntreprise.FormattingEnabled = true;
            this.cbxEntreprise.Location = new System.Drawing.Point(196, 215);
            this.cbxEntreprise.Name = "cbxEntreprise";
            this.cbxEntreprise.Size = new System.Drawing.Size(202, 21);
            this.cbxEntreprise.TabIndex = 34;
            // 
            // cbxTypeControle
            // 
            this.cbxTypeControle.FormattingEnabled = true;
            this.cbxTypeControle.Location = new System.Drawing.Point(196, 269);
            this.cbxTypeControle.Name = "cbxTypeControle";
            this.cbxTypeControle.Size = new System.Drawing.Size(202, 21);
            this.cbxTypeControle.TabIndex = 35;
            // 
            // cbxZoneStockage
            // 
            this.cbxZoneStockage.FormattingEnabled = true;
            this.cbxZoneStockage.Location = new System.Drawing.Point(196, 242);
            this.cbxZoneStockage.Name = "cbxZoneStockage";
            this.cbxZoneStockage.Size = new System.Drawing.Size(202, 21);
            this.cbxZoneStockage.TabIndex = 36;
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(130, 223);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(60, 13);
            this.lblEntreprise.TabIndex = 37;
            this.lblEntreprise.Text = "Entreprise :";
            // 
            // lblZoneStockage
            // 
            this.lblZoneStockage.AutoSize = true;
            this.lblZoneStockage.Location = new System.Drawing.Point(91, 250);
            this.lblZoneStockage.Name = "lblZoneStockage";
            this.lblZoneStockage.Size = new System.Drawing.Size(100, 13);
            this.lblZoneStockage.TabIndex = 38;
            this.lblZoneStockage.Text = "Zone de stockage :";
            // 
            // lblTypeControle
            // 
            this.lblTypeControle.AutoSize = true;
            this.lblTypeControle.Location = new System.Drawing.Point(97, 277);
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
            this.Controls.Add(this.dtDerniereModif);
            this.Controls.Add(this.dtControle);
            this.Controls.Add(this.dtCreation);
            this.Controls.Add(this.lblDateControle);
            this.Controls.Add(this.lblDateCreation);
            this.Controls.Add(this.lblDateDerniereModif);
            this.Name = "FormControleRealise";
            this.Text = "Ajout d\'un contrôle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateDerniereModif;
        private System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.Label lblDateControle;
        private System.Windows.Forms.DateTimePicker dtCreation;
        private System.Windows.Forms.DateTimePicker dtControle;
        private System.Windows.Forms.DateTimePicker dtDerniereModif;
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