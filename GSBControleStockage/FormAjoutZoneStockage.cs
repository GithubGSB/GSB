﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleStockBO;
using ControleStockBLL;




namespace GSBControleStockage
{
    public partial class FormAjoutZoneStockage : Form
    {
        
        public FormAjoutZoneStockage()
        {
            
            InitializeComponent();
            cbxCategProd.DisplayMember = "uneCategProd";
            cbxCategProd.ValueMember = "idCategProd";
            cbxCategProd.DataSource = ZoneStockageManager.GetInstance().GetLesCategoriesProduits();
            cbxCategProd.SelectedIndex = -1;

            cbxVille.DisplayMember = "uneVille";
            cbxVille.ValueMember = "idVille";
            cbxVille.DataSource = ZoneStockageManager.GetInstance().GetLesVilles();
            cbxVille.SelectedIndex = -1;

            //association du dt à la liste


        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtBatiment.Text) || string.IsNullOrWhiteSpace(txtEtage.Text) || string.IsNullOrWhiteSpace(txtNomZone.Text) || cbxCategProd.SelectedIndex == -1 || cbxVille.SelectedIndex == -1)
            {
                MessageBox.Show("Attention, vous devez saisir tous les champs ! ", "Erreur de saisie",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int nbZoneCreer = 0;
                nbZoneCreer = ZoneStockageManager.GetInstance().AjoutZoneStockage(txtNomZone.Text, txtBatiment.Text, txtEtage.Text, txtAdresse.Text, dateAjoutDtp.Value, dateAjoutDtp.Value, cbxVille.ValueMember, cbxCategProd.ValueMember);
                MessageBox.Show("Votre client a été ajouté");
            }
            

        }
    }
}
