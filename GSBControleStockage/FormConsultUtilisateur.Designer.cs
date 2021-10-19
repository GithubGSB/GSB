
namespace GSBControleStockage
{
    partial class FormConsultUtilisateur
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
            this.dtgUtiliateur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtiliateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUtiliateur
            // 
            this.dtgUtiliateur.AllowUserToAddRows = false;
            this.dtgUtiliateur.AllowUserToDeleteRows = false;
            this.dtgUtiliateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUtiliateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUtiliateur.Location = new System.Drawing.Point(0, 0);
            this.dtgUtiliateur.Name = "dtgUtiliateur";
            this.dtgUtiliateur.ReadOnly = true;
            this.dtgUtiliateur.RowHeadersWidth = 51;
            this.dtgUtiliateur.RowTemplate.Height = 24;
            this.dtgUtiliateur.Size = new System.Drawing.Size(800, 450);
            this.dtgUtiliateur.TabIndex = 0;
            // 
            // FormConsultUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgUtiliateur);
            this.Name = "FormConsultUtilisateur";
            this.Text = "Consultation des utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtiliateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUtiliateur;
    }
}