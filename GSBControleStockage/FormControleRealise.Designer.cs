
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
            this.lblResume = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblDateDerniereModif = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixHT = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(94, 231);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(99, 13);
            this.lblResume.TabIndex = 0;
            this.lblResume.Text = "Resumé du contôle";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(94, 261);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(126, 13);
            this.lblPrixHT.TabIndex = 1;
            this.lblPrixHT.Text = "Prix hors taxe du contrôle";
            // 
            // lblDateDerniereModif
            // 
            this.lblDateDerniereModif.AutoSize = true;
            this.lblDateDerniereModif.Location = new System.Drawing.Point(94, 171);
            this.lblDateDerniereModif.Name = "lblDateDerniereModif";
            this.lblDateDerniereModif.Size = new System.Drawing.Size(156, 13);
            this.lblDateDerniereModif.TabIndex = 2;
            this.lblDateDerniereModif.Text = "Date de la dernière modification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date création";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date contrôle";
            // 
            // txtPrixHT
            // 
            this.txtPrixHT.Location = new System.Drawing.Point(226, 254);
            this.txtPrixHT.Name = "txtPrixHT";
            this.txtPrixHT.Size = new System.Drawing.Size(100, 20);
            this.txtPrixHT.TabIndex = 5;
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(226, 224);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(100, 20);
            this.txtResume.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(256, 164);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(301, 351);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 10;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // FormControleRealise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.txtPrixHT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateDerniereModif);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.lblResume);
            this.Name = "FormControleRealise";
            this.Text = "FormControleRealise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblDateDerniereModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixHT;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnAjout;
    }
}