using ControleStockBLL;
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
    public partial class FormControleRealise : Form
    {
        public FormControleRealise()
        {
            InitializeComponent();
            cbxTypeControle.DisplayMember = "libelle";
            cbxTypeControle.ValueMember = "id";

            cbxEntreprise.DisplayMember = "nom";
            cbxEntreprise.ValueMember = "id";

            cbxZoneStockage.DisplayMember = "nomZone";
            cbxZoneStockage.ValueMember = "id";

            cbxEntreprise.DataSource = EntrepriseManager.GetInstance().GetLesEntreprises();
            cbxTypeControle.DataSource = TypeControleManager.GetInstance().GetLesTypeControles();
            cbxZoneStockage.DataSource = ZoneStockageManager.GetInstance().GetLesZonesStockages();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try {
                int entrepriseId = (int)cbxEntreprise.SelectedValue;
                int zoneStockageId = (int)cbxZoneStockage.SelectedValue;
                int typeControleId = (int)cbxTypeControle.SelectedValue;

                string resume = txtResume.Text;
                string valeurHT = txtPrixHT.Text;
                float montantHT;
                DateTime dateControle = dtControle.Value;
                DateTime dateCreation = dtCreation.Value;
                DateTime derniereModif = dtDerniereModif.Value;

                float.TryParse(valeurHT, out montantHT);
                if (string.IsNullOrWhiteSpace(resume) || string.IsNullOrWhiteSpace(valeurHT)) Logger.LogErreur("Vous devez remplir tous les champs.");
                else
                {
                    ControleRealiseManager.GetInstance().AjoutControle(dateControle, dateCreation, derniereModif, resume, montantHT, typeControleId, entrepriseId, zoneStockageId);
                    Logger.LogInformation("Ajout réussi");
                }
            } 
            catch (Exception ex)
            {
                Logger.LogErreur(ex.Message);
            }
        }
    }
}
