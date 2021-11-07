using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleStockBLL;
using ControleStockBO;

namespace GSBControleStockage
{
    public partial class FormModifZoneStockage : Form
    {
        public FormModifZoneStockage()
        {
            InitializeComponent();

            cbxNomZoneStockage.DisplayMember = "nomZone";
            cbxNomZoneStockage.ValueMember = "id";
            cbxNomZoneStockage.DataSource = ZoneStockageManager.GetInstance().GetLesZonesStockages();

            cbxVille.DisplayMember = "nom";
            cbxVille.ValueMember = "insee";
            cbxVille.DataSource = VilleManager.GetInstance().GetLesVilles();

            cbxCategProduit.DisplayMember = "libelle";
            cbxCategProduit.ValueMember = "id";
            cbxCategProduit.DataSource = CategProdManager.GetInstance().GetLesCategoriesProduits();

            
            
        }

        private void cbxNomZoneStockage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idZoneStockage = (int)cbxNomZoneStockage.SelectedValue;
                ZoneStockage uneZoneStockage = ZoneStockageManager.GetInstance().GetLaZoneStockage(idZoneStockage);

                txtAdresse.Text = uneZoneStockage.Adresse;
                txtBatiment.Text = uneZoneStockage.Batiment;
                txtEtage.Text = uneZoneStockage.Etage;
                txtNomZoneStockage.Text = uneZoneStockage.NomZone;
                cbxCategProduit.Text = uneZoneStockage.LibelleCategProd;
                cbxVille.Text = uneZoneStockage.NomVille;

            }
            catch (Exception ex)
            {
                Logger.LogErreur(ex);
            }
        }

        private void btnModifZS_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateDernModif = DateTime.Today;
                int idZoneStockage = (int)cbxNomZoneStockage.SelectedValue;
                char insee = (char)cbxVille.SelectedValue;
                int idCategProd = (int)cbxCategProduit.SelectedValue;
                ZoneStockageManager.GetInstance().ModifZoneStockage(idZoneStockage, txtNomZoneStockage.Text, txtBatiment.Text, txtEtage.Text, txtAdresse.Text, dateDernModif, insee, idCategProd);
                Logger.LogInformation("Modification effectué");
            }
            catch (Exception ex)
            {

                Logger.LogErreur(ex);
            }
        }
    }
}
