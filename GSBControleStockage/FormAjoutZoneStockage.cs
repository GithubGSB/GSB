using System;
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
            //réglage des combobox
            cbxCategProd.DisplayMember = "libelle";
            cbxCategProd.ValueMember = "id";
            cbxCategProd.DataSource = CategProdManager.GetInstance().GetLesCategoriesProduits();
            cbxCategProd.SelectedIndex = -1;

            cbxVille.DisplayMember = "nom";
            cbxVille.ValueMember = "insee";
            cbxVille.DataSource = VilleManager.GetInstance().GetLesVilles();
            cbxVille.SelectedIndex = -1;

            //association du dt à la liste


        }
        
        private void btnAjout_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtBatiment.Text) || string.IsNullOrWhiteSpace(txtEtage.Text) || string.IsNullOrWhiteSpace(txtNomZone.Text) || cbxCategProd.SelectedIndex == -1 || cbxVille.SelectedIndex == -1)
            {
                Logger.LogErreur("Attention, vous devez saisir tous les champs !");
            }
            else
            {
                int idVille = (int)cbxVille.SelectedValue;
                int idCategProd = (int)cbxCategProd.SelectedValue;
                int nbZoneCreer = 0;
                nbZoneCreer = ZoneStockageManager.GetInstance().AjoutZoneStockage(txtNomZone.Text, txtBatiment.Text, txtEtage.Text, dateAjoutDtp.Value, dateDernModifDtp.Value, txtAdresse.Text, idCategProd, idVille);
                Logger.LogInformation("Ajout réussi !");
            }
            

        }
    }
}
