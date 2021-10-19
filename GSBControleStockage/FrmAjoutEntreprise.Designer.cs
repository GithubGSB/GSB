namespace GSBControleStockage
{
    partial class FrmAjoutEntreprise
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAjoutEntreprise = new System.Windows.Forms.Button();
            this.dtCreation = new System.Windows.Forms.DateTimePicker();
            this.dtModif = new System.Windows.Forms.DateTimePicker();
            this.lblCreation = new System.Windows.Forms.Label();
            this.lblDateModif = new System.Windows.Forms.Label();
            this.lblInsee = new System.Windows.Forms.Label();
            this.cbxInsee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(214, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(214, 131);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 1;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(211, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(280, 90);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(280, 131);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(280, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnAjoutEntreprise
            // 
            this.btnAjoutEntreprise.Location = new System.Drawing.Point(280, 344);
            this.btnAjoutEntreprise.Name = "btnAjoutEntreprise";
            this.btnAjoutEntreprise.Size = new System.Drawing.Size(100, 23);
            this.btnAjoutEntreprise.TabIndex = 6;
            this.btnAjoutEntreprise.Text = "Ajouter";
            this.btnAjoutEntreprise.UseVisualStyleBackColor = true;
            this.btnAjoutEntreprise.Click += new System.EventHandler(this.btnAjoutEntreprise_Click);
            // 
            // dtCreation
            // 
            this.dtCreation.Location = new System.Drawing.Point(280, 207);
            this.dtCreation.Name = "dtCreation";
            this.dtCreation.Size = new System.Drawing.Size(200, 20);
            this.dtCreation.TabIndex = 7;
            // 
            // dtModif
            // 
            this.dtModif.Location = new System.Drawing.Point(280, 240);
            this.dtModif.Name = "dtModif";
            this.dtModif.Size = new System.Drawing.Size(200, 20);
            this.dtModif.TabIndex = 8;
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Location = new System.Drawing.Point(198, 207);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(72, 13);
            this.lblCreation.TabIndex = 9;
            this.lblCreation.Text = "Date Création";
            // 
            // lblDateModif
            // 
            this.lblDateModif.AutoSize = true;
            this.lblDateModif.Location = new System.Drawing.Point(198, 247);
            this.lblDateModif.Name = "lblDateModif";
            this.lblDateModif.Size = new System.Drawing.Size(59, 13);
            this.lblDateModif.TabIndex = 10;
            this.lblDateModif.Text = "Date Modif";
            // 
            // lblInsee
            // 
            this.lblInsee.AutoSize = true;
            this.lblInsee.Location = new System.Drawing.Point(201, 297);
            this.lblInsee.Name = "lblInsee";
            this.lblInsee.Size = new System.Drawing.Size(33, 13);
            this.lblInsee.TabIndex = 11;
            this.lblInsee.Text = "Insee";
            // 
            // cbxInsee
            // 
            this.cbxInsee.FormattingEnabled = true;
            this.cbxInsee.Location = new System.Drawing.Point(280, 297);
            this.cbxInsee.Name = "cbxInsee";
            this.cbxInsee.Size = new System.Drawing.Size(121, 21);
            this.cbxInsee.TabIndex = 12;
            // 
            // FrmEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxInsee);
            this.Controls.Add(this.lblInsee);
            this.Controls.Add(this.lblDateModif);
            this.Controls.Add(this.lblCreation);
            this.Controls.Add(this.dtModif);
            this.Controls.Add(this.dtCreation);
            this.Controls.Add(this.btnAjoutEntreprise);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmEntreprise";
            this.Text = "Gestion Entreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAjoutEntreprise;
        private System.Windows.Forms.DateTimePicker dtCreation;
        private System.Windows.Forms.DateTimePicker dtModif;
        private System.Windows.Forms.Label lblCreation;
        private System.Windows.Forms.Label lblDateModif;
        private System.Windows.Forms.Label lblInsee;
        private System.Windows.Forms.ComboBox cbxInsee;
    }
}