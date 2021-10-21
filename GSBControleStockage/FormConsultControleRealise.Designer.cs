
namespace GSBControleStockage
{
    partial class FormConsultControleRealise
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
            this.dtgControle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgControle
            // 
            this.dtgControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgControle.Location = new System.Drawing.Point(57, 36);
            this.dtgControle.Name = "dtgControle";
            this.dtgControle.Size = new System.Drawing.Size(678, 308);
            this.dtgControle.TabIndex = 0;
            // 
            // FormConsultControleRealise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgControle);
            this.Name = "FormConsultControleRealise";
            this.Text = "FormConsultControleRealise";
            ((System.ComponentModel.ISupportInitialize)(this.dtgControle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgControle;
    }
}