
namespace GSBControleStockage
{
    partial class FormModifControleRealise
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
            this.lblTypeControle = new System.Windows.Forms.Label();
            this.lblZoneStockage = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.cbxZoneStockage = new System.Windows.Forms.ComboBox();
            this.cbxTypeControle = new System.Windows.Forms.ComboBox();
            this.cbxEntreprise = new System.Windows.Forms.ComboBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.txtPrixHT = new System.Windows.Forms.TextBox();
            this.lblControle = new System.Windows.Forms.Label();
            this.cbxControle = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.pnlModif = new System.Windows.Forms.Panel();
            this.pnlModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeControle
            // 
            this.lblTypeControle.AutoSize = true;
            this.lblTypeControle.Location = new System.Drawing.Point(65, 147);
            this.lblTypeControle.Name = "lblTypeControle";
            this.lblTypeControle.Size = new System.Drawing.Size(93, 13);
            this.lblTypeControle.TabIndex = 49;
            this.lblTypeControle.Text = "Type de contrôle :";
            // 
            // lblZoneStockage
            // 
            this.lblZoneStockage.AutoSize = true;
            this.lblZoneStockage.Location = new System.Drawing.Point(59, 120);
            this.lblZoneStockage.Name = "lblZoneStockage";
            this.lblZoneStockage.Size = new System.Drawing.Size(100, 13);
            this.lblZoneStockage.TabIndex = 48;
            this.lblZoneStockage.Text = "Zone de stockage :";
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(98, 93);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(60, 13);
            this.lblEntreprise.TabIndex = 47;
            this.lblEntreprise.Text = "Entreprise :";
            // 
            // cbxZoneStockage
            // 
            this.cbxZoneStockage.FormattingEnabled = true;
            this.cbxZoneStockage.Location = new System.Drawing.Point(164, 112);
            this.cbxZoneStockage.Name = "cbxZoneStockage";
            this.cbxZoneStockage.Size = new System.Drawing.Size(202, 21);
            this.cbxZoneStockage.TabIndex = 46;
            // 
            // cbxTypeControle
            // 
            this.cbxTypeControle.FormattingEnabled = true;
            this.cbxTypeControle.Location = new System.Drawing.Point(164, 139);
            this.cbxTypeControle.Name = "cbxTypeControle";
            this.cbxTypeControle.Size = new System.Drawing.Size(202, 21);
            this.cbxTypeControle.TabIndex = 45;
            // 
            // cbxEntreprise
            // 
            this.cbxEntreprise.FormattingEnabled = true;
            this.cbxEntreprise.Location = new System.Drawing.Point(164, 85);
            this.cbxEntreprise.Name = "cbxEntreprise";
            this.cbxEntreprise.Size = new System.Drawing.Size(202, 21);
            this.cbxEntreprise.TabIndex = 44;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(54, 21);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(105, 13);
            this.lblResume.TabIndex = 40;
            this.lblResume.Text = "Resumé du contôle :";
            this.lblResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(164, 18);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(202, 20);
            this.txtResume.TabIndex = 43;
            this.txtResume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(33, 47);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(132, 13);
            this.lblPrixHT.TabIndex = 41;
            this.lblPrixHT.Text = "Prix hors taxe du contrôle :";
            // 
            // txtPrixHT
            // 
            this.txtPrixHT.Location = new System.Drawing.Point(165, 44);
            this.txtPrixHT.Name = "txtPrixHT";
            this.txtPrixHT.Size = new System.Drawing.Size(201, 20);
            this.txtPrixHT.TabIndex = 42;
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Location = new System.Drawing.Point(246, 100);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(105, 13);
            this.lblControle.TabIndex = 51;
            this.lblControle.Text = "Resumé du contôle :";
            this.lblControle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxControle
            // 
            this.cbxControle.FormattingEnabled = true;
            this.cbxControle.Location = new System.Drawing.Point(356, 97);
            this.cbxControle.Name = "cbxControle";
            this.cbxControle.Size = new System.Drawing.Size(202, 21);
            this.cbxControle.TabIndex = 52;
            this.cbxControle.SelectionChangeCommitted += new System.EventHandler(this.cbxControle_SelectionChangeCommitted);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(217, 178);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 53;
            this.btnValider.Text = "Enregistrer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // pnlModif
            // 
            this.pnlModif.Controls.Add(this.cbxZoneStockage);
            this.pnlModif.Controls.Add(this.btnValider);
            this.pnlModif.Controls.Add(this.txtPrixHT);
            this.pnlModif.Controls.Add(this.lblPrixHT);
            this.pnlModif.Controls.Add(this.txtResume);
            this.pnlModif.Controls.Add(this.lblTypeControle);
            this.pnlModif.Controls.Add(this.lblResume);
            this.pnlModif.Controls.Add(this.lblZoneStockage);
            this.pnlModif.Controls.Add(this.cbxEntreprise);
            this.pnlModif.Controls.Add(this.lblEntreprise);
            this.pnlModif.Controls.Add(this.cbxTypeControle);
            this.pnlModif.Location = new System.Drawing.Point(192, 155);
            this.pnlModif.Name = "pnlModif";
            this.pnlModif.Size = new System.Drawing.Size(460, 214);
            this.pnlModif.TabIndex = 54;
            // 
            // FormModifControleRealise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlModif);
            this.Controls.Add(this.cbxControle);
            this.Controls.Add(this.lblControle);
            this.Name = "FormModifControleRealise";
            this.Text = "FormModifControleRealise";
            this.pnlModif.ResumeLayout(false);
            this.pnlModif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeControle;
        private System.Windows.Forms.Label lblZoneStockage;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.ComboBox cbxZoneStockage;
        private System.Windows.Forms.ComboBox cbxTypeControle;
        private System.Windows.Forms.ComboBox cbxEntreprise;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.TextBox txtPrixHT;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.ComboBox cbxControle;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel pnlModif;
    }
}