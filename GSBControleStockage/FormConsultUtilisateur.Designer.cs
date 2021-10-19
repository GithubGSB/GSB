
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
            this.dtgUtilisateur = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateDerModif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUtilisateur
            // 
            this.dtgUtilisateur.AllowUserToAddRows = false;
            this.dtgUtilisateur.AllowUserToDeleteRows = false;
            this.dtgUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNom,
            this.ColumnPrenom,
            this.ColumnProfil,
            this.ColumnDateCreation,
            this.ColumnDateDerModif});
            this.dtgUtilisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.dtgUtilisateur.Name = "dtgUtilisateur";
            this.dtgUtilisateur.ReadOnly = true;
            this.dtgUtilisateur.RowHeadersWidth = 51;
            this.dtgUtilisateur.RowTemplate.Height = 24;
            this.dtgUtilisateur.Size = new System.Drawing.Size(800, 450);
            this.dtgUtilisateur.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Numéro";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNom
            // 
            this.ColumnNom.DataPropertyName = "Nom";
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.MinimumWidth = 6;
            this.ColumnNom.Name = "ColumnNom";
            this.ColumnNom.ReadOnly = true;
            // 
            // ColumnPrenom
            // 
            this.ColumnPrenom.DataPropertyName = "Prenom";
            this.ColumnPrenom.HeaderText = "Prénom";
            this.ColumnPrenom.MinimumWidth = 6;
            this.ColumnPrenom.Name = "ColumnPrenom";
            this.ColumnPrenom.ReadOnly = true;
            // 
            // ColumnProfil
            // 
            this.ColumnProfil.DataPropertyName = "LibelleProfil";
            this.ColumnProfil.HeaderText = "Profil";
            this.ColumnProfil.MinimumWidth = 6;
            this.ColumnProfil.Name = "ColumnProfil";
            this.ColumnProfil.ReadOnly = true;
            // 
            // ColumnDateCreation
            // 
            this.ColumnDateCreation.DataPropertyName = "DateCreation";
            this.ColumnDateCreation.HeaderText = "Date de création";
            this.ColumnDateCreation.MinimumWidth = 6;
            this.ColumnDateCreation.Name = "ColumnDateCreation";
            this.ColumnDateCreation.ReadOnly = true;
            // 
            // ColumnDateDerModif
            // 
            this.ColumnDateDerModif.DataPropertyName = "DateDerniereModif";
            this.ColumnDateDerModif.HeaderText = "Date de dernière modfiication";
            this.ColumnDateDerModif.MinimumWidth = 6;
            this.ColumnDateDerModif.Name = "ColumnDateDerModif";
            this.ColumnDateDerModif.ReadOnly = true;
            // 
            // FormConsultUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgUtilisateur);
            this.Name = "FormConsultUtilisateur";
            this.Text = "Consultation des utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateDerModif;
    }
}