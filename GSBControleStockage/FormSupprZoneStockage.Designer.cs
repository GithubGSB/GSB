
namespace GSBControleStockage
{
    partial class FormSupprZoneStockage
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
            this.lblZoneStockage = new System.Windows.Forms.Label();
            this.cbxZoneStockage = new System.Windows.Forms.ComboBox();
            this.dtgZoneStockage = new System.Windows.Forms.DataGridView();
            this.btnSuppr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgZoneStockage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZoneStockage
            // 
            this.lblZoneStockage.AutoSize = true;
            this.lblZoneStockage.Location = new System.Drawing.Point(189, 26);
            this.lblZoneStockage.Name = "lblZoneStockage";
            this.lblZoneStockage.Size = new System.Drawing.Size(90, 13);
            this.lblZoneStockage.TabIndex = 0;
            this.lblZoneStockage.Text = "nom de la Zone : ";
            // 
            // cbxZoneStockage
            // 
            this.cbxZoneStockage.FormattingEnabled = true;
            this.cbxZoneStockage.Location = new System.Drawing.Point(285, 23);
            this.cbxZoneStockage.Name = "cbxZoneStockage";
            this.cbxZoneStockage.Size = new System.Drawing.Size(121, 21);
            this.cbxZoneStockage.TabIndex = 1;
            this.cbxZoneStockage.SelectionChangeCommitted += new System.EventHandler(this.cbxZoneStockage_SelectionChangeCommitted);
            // 
            // dtgZoneStockage
            // 
            this.dtgZoneStockage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgZoneStockage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgZoneStockage.Location = new System.Drawing.Point(49, 84);
            this.dtgZoneStockage.Name = "dtgZoneStockage";
            this.dtgZoneStockage.Size = new System.Drawing.Size(700, 65);
            this.dtgZoneStockage.TabIndex = 2;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(255, 213);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(201, 36);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // FormSupprZoneStockage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.dtgZoneStockage);
            this.Controls.Add(this.cbxZoneStockage);
            this.Controls.Add(this.lblZoneStockage);
            this.Name = "FormSupprZoneStockage";
            this.Text = "FormSupprZoneStockage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgZoneStockage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZoneStockage;
        private System.Windows.Forms.ComboBox cbxZoneStockage;
        private System.Windows.Forms.DataGridView dtgZoneStockage;
        private System.Windows.Forms.Button btnSuppr;
    }
}