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
            cbxEntreprise.ValueMember = "insee";

            cbxEntreprise.DataSource = EntrepriseManager.GetInstance().
            cbxTypeControle.DataSource = TypeControleManager.GetInstance().GetLesTypeControles();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {

            int entrepriseId = (int)cbxEntreprise.SelectedValue;
            int zoneStockageId = (int) cbxZoneStockage.SelectedValue;
            int typeControleId = (int) cbxTypeControle.SelectedValue;

            string resume = lblResume.Text;
            string valeurHT = lblPrixHT.Text;
            float montantHT;
            DateTime dateControle = dtControle.Value;
            DateTime dateCreation = dtCreation.Value;
            DateTime derniereModif = dtDerniereModif.Value;

            float.TryParse(valeurHT, out montantHT);

            ControleRealiseManager.GetInstance().AjoutControle(dateControle, dateCreation, derniereModif, resume, montantHT, typeControleId, entrepriseId, zoneStockageId);
        }
    }
}
