
namespace GSBControleStockage
{
    partial class FormConsultZonesStockages
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
            this.dtgZoneStockage = new System.Windows.Forms.DataGridView();
            this.btnConsultZoneStockage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgZoneStockage)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgZoneStockage
            // 
            this.dtgZoneStockage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgZoneStockage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgZoneStockage.Location = new System.Drawing.Point(61, 48);
            this.dtgZoneStockage.Name = "dtgZoneStockage";
            this.dtgZoneStockage.Size = new System.Drawing.Size(670, 252);
            this.dtgZoneStockage.TabIndex = 0;
            // 
            // btnConsultZoneStockage
            // 
            this.btnConsultZoneStockage.Location = new System.Drawing.Point(299, 335);
            this.btnConsultZoneStockage.Name = "btnConsultZoneStockage";
            this.btnConsultZoneStockage.Size = new System.Drawing.Size(201, 48);
            this.btnConsultZoneStockage.TabIndex = 1;
            this.btnConsultZoneStockage.Text = "Afficher les zones de stockages";
            this.btnConsultZoneStockage.UseVisualStyleBackColor = true;
            this.btnConsultZoneStockage.Click += new System.EventHandler(this.btnConsultZoneStockage_Click);
            // 
            // FormConsultZonesStockages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultZoneStockage);
            this.Controls.Add(this.dtgZoneStockage);
            this.Name = "FormConsultZonesStockages";
            this.Text = "FormConsultZonesStockages";
            ((System.ComponentModel.ISupportInitialize)(this.dtgZoneStockage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgZoneStockage;
        private System.Windows.Forms.Button btnConsultZoneStockage;
    }
}