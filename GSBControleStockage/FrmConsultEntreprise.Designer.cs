
namespace GSBControleStockage
{
    partial class FrmConsultEntreprise
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
            this.btnInfoEntreprise = new System.Windows.Forms.Button();
            this.dtgInfoEntreprise = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfoEntreprise
            // 
            this.btnInfoEntreprise.Location = new System.Drawing.Point(294, 317);
            this.btnInfoEntreprise.Name = "btnInfoEntreprise";
            this.btnInfoEntreprise.Size = new System.Drawing.Size(151, 46);
            this.btnInfoEntreprise.TabIndex = 0;
            this.btnInfoEntreprise.Text = "Consultation";
            this.btnInfoEntreprise.UseVisualStyleBackColor = true;
            this.btnInfoEntreprise.Click += new System.EventHandler(this.btnInfoEntreprise_Click);
            // 
            // dtgInfoEntreprise
            // 
            this.dtgInfoEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoEntreprise.Location = new System.Drawing.Point(261, 90);
            this.dtgInfoEntreprise.Name = "dtgInfoEntreprise";
            this.dtgInfoEntreprise.Size = new System.Drawing.Size(240, 150);
            this.dtgInfoEntreprise.TabIndex = 1;
            this.dtgInfoEntreprise.Visible = false;
            // 
            // FrmConsultEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgInfoEntreprise);
            this.Controls.Add(this.btnInfoEntreprise);
            this.Name = "FrmConsultEntreprise";
            this.Text = "FrmConsultEntreprise";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoEntreprise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfoEntreprise;
        private System.Windows.Forms.DataGridView dtgInfoEntreprise;
    }
}