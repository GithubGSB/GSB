using ControleStockBLL;
using ControleStockBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBControleStockage
{
    public partial class FormModifControleRealise : Form
    {
        public FormModifControleRealise()
        {
            InitializeComponent();
            cbxControle.DisplayMember = "resume";
            cbxControle.ValueMember = "id";
            cbxTypeControle.DisplayMember = "libelle";
            cbxTypeControle.ValueMember = "id";

            cbxEntreprise.DisplayMember = "nom";
            cbxEntreprise.ValueMember = "id";

            cbxZoneStockage.DisplayMember = "nomZone";
            cbxZoneStockage.ValueMember = "id";

            cbxEntreprise.DataSource = EntrepriseManager.GetInstance().GetLesEntreprises();
            cbxTypeControle.DataSource = TypeControleManager.GetInstance().GetLesTypeControles();
            cbxZoneStockage.DataSource = ZoneStockageManager.GetInstance().GetLesZonesStockages();
            cbxControle.DataSource = ControleRealiseManager.GetInstance().GetLesControlesRealises();
            pnlModif.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int id = (int)cbxControle.SelectedValue;
            int idControle = (int)cbxTypeControle.SelectedValue;
            int idEntreprise = (int)cbxEntreprise.SelectedValue;
            int idStockage = (int)cbxZoneStockage.SelectedValue;

            string valeurHT = txtPrixHT.Text;
            float montantHT;
            
            float.TryParse(valeurHT, out montantHT);
            try
            {

                if(string.IsNullOrWhiteSpace(txtResume.Text))
                {
                    Logger.LogAttention("Le résumé du contrôle ne peut pas être vide");
                }
                if(montantHT <= 0 || string.IsNullOrWhiteSpace(valeurHT))
                {
                    Logger.LogAttention("Le prix hors taxe doit être supérieur à 0 euro.");
                }
                
                ControleRealiseManager.GetInstance().ModifControle(id, new DateTime(), new DateTime(), DateTime.Now, txtResume.Text, montantHT, idControle, idEntreprise, idStockage);
                Logger.LogInformation("Modification réussi");
            } catch(Exception ex)
            {
                Logger.LogErreur(ex.Message);
            }
        }

        private void cbxControle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = (int)cbxControle.SelectedValue;

            pnlModif.Visible = true;

            ControleRealise unControle = ControleRealiseManager.GetInstance().RecupererTousControle(id);
            txtPrixHT.Text = unControle.MontantHT.ToString();
            txtResume.Text = unControle.Resume;

            cbxEntreprise.SelectedItem = unControle.UneEntreprise.Id;
            cbxTypeControle.SelectedItem = unControle.UnTypeControle.Id;
            cbxZoneStockage.SelectedItem = unControle.UneZoneStockage.Id;
        }
    }
}
