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
            cbxNomZoneStockage.SelectedIndex = -1;

            cbxVille.DisplayMember = "nom";
            cbxVille.ValueMember = "insee";
            cbxVille.DataSource = VilleManager.GetInstance().GetLesVilles();
            cbxVille.SelectedIndex = -1;

            
            cbxCategProduit.DisplayMember = "libelle";
            cbxCategProduit.ValueMember = "id";
            cbxCategProduit.DataSource = CategProdManager.GetInstance().GetLesCategoriesProduits();
            cbxCategProduit.SelectedIndex = -1;

        }
        private void cbxNomZoneStockage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idZoneStockage = (int)cbxNomZoneStockage.SelectedValue;
            ZoneStockage uneZoneStockage = ZoneStockageManager.GetInstance().RecupererZoneStockage(idZoneStockage);
            txtAdresse.Text = uneZoneStockage.Adresse;
            txtBatiment.Text = uneZoneStockage.Batiment;
            txtEtage.Text = uneZoneStockage.Etage;
            txtNomZoneStockage.Text = uneZoneStockage.NomZone;
            cbxCategProduit.SelectedValue = uneZoneStockage.UneCategProd.Id;
            cbxVille.SelectedValue = uneZoneStockage.UneVille.Insee;
        }
        private void btnModifZS_Click(object sender, EventArgs e)
        {
            string error = "";
            DateTime dateDernModif = DateTime.Today;
            int idZoneStockage = (int)cbxNomZoneStockage.SelectedValue;
            int insee = (int)cbxVille.SelectedValue;
            int idCategProd = (int)cbxCategProduit.SelectedValue;
            try
            {
                if (string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtBatiment.Text) || string.IsNullOrWhiteSpace(txtEtage.Text) || string.IsNullOrWhiteSpace(txtNomZoneStockage.Text) || cbxCategProduit.SelectedIndex == -1 || cbxVille.SelectedIndex == -1)
                {

                    if (string.IsNullOrWhiteSpace(txtAdresse.Text))
                    {
                        error = "adresse;";
                    }
                    if (string.IsNullOrWhiteSpace(txtBatiment.Text))
                    {
                        error = error + " batiment;";
                    }
                    if (string.IsNullOrWhiteSpace(txtEtage.Text))
                    {
                        error = error + " etage;";
                    }
                    if (string.IsNullOrWhiteSpace(txtNomZoneStockage.Text))
                    {
                        error = error + " nom de la Zone;";
                    }
                    if (cbxCategProduit.SelectedIndex == -1)
                    {
                        error = error + " Choisir une catégorie de produit !";
                    }
                    if (cbxVille.SelectedIndex == -1)
                    {
                        error = error + " Choisir une ville !";
                    }
                    Logger.LogErreur("Attention, vous devez saisir : " + error);
                }
                else
                {
                    
                    ZoneStockageManager.GetInstance().ModifZoneStockage(idZoneStockage, txtNomZoneStockage.Text, txtBatiment.Text, txtEtage.Text, dateDernModif, txtAdresse.Text, idCategProd, insee);
                    Logger.LogInformation("Modification effectué");
                }
            }
            catch (Exception ex)
            {

                Logger.LogErreur(ex);
            }
        }

        
    }
}
