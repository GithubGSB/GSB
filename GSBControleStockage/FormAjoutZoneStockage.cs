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
    /// <summary>
    /// Formulaire du sous menu Ajout Zone stockage
    /// </summary>
    public partial class FormAjoutZoneStockage : Form
    {
        /// <summary>
        /// Constructeur du formulaire de l'ajout. Elle initialise les combobox et appelle les catégories de produit et les villes
        /// </summary>
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
        /// <summary>
        /// Méthode d'ajout, contrôle la saisie de l'utilisateur
        /// </summary>
    
        private void btnAjout_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            
            
            if (string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtBatiment.Text) || string.IsNullOrWhiteSpace(txtEtage.Text) || string.IsNullOrWhiteSpace(txtNomZone.Text) || cbxCategProd.SelectedIndex == -1 || cbxVille.SelectedIndex == -1)
            {
                Logger.LogErreur("Attention, vous devez saisir tous les champs !");
=======
            DateTime dateAjoutDtp = DateTime.Today;
            DateTime dateDernModifDtp = DateTime.Today;
            int idVille = (int)cbxVille.SelectedValue;
            int idCategProd = (int)cbxCategProd.SelectedValue;
            string error = "";
            
            if (string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtBatiment.Text) || string.IsNullOrWhiteSpace(txtEtage.Text) || string.IsNullOrWhiteSpace(txtNomZone.Text) || cbxCategProd.SelectedIndex == -1 || cbxVille.SelectedIndex == -1)
            {
                
                if (string.IsNullOrWhiteSpace(txtAdresse.Text))
                {
                    error = "saisir le champs 'adresse', ";
                }
                if (string.IsNullOrWhiteSpace(txtBatiment.Text))
                {
                    error = error + "saisir le champs 'batiment', ";
                }
                if (string.IsNullOrWhiteSpace(txtEtage.Text))
                {
                    error = error + " saisir le champs 'etage', ";
                }
                if (string.IsNullOrWhiteSpace(txtNomZone.Text))
                {
                    error = error + "saisir le champs 'nom de la Zone', ";
                }
                if (cbxCategProd.SelectedIndex == -1)
                {
                    error = error + " choisir une catégorie de produit, ";
                }
                if (cbxVille.SelectedIndex == -1)
                {
                    error = error + " choisir une ville, ";
                }
                Logger.LogErreur("Attention, vous devez : "+error+"pour enregistrer votre saisi !");
            }
            if (dateAjoutDtp > DateTime.Today )
            {
                Logger.LogErreur("La date ne peut pas être postérieur à aujourd'hui !");
>>>>>>> Stashed changes
            }
            else
            {
                
                
                int nbZoneCreer = 0;
                nbZoneCreer = ZoneStockageManager.GetInstance().AjoutZoneStockage(txtNomZone.Text, txtBatiment.Text, txtEtage.Text, dateAjoutDtp, dateDernModifDtp, txtAdresse.Text, idCategProd, idVille);
                Logger.LogInformation("Ajout réussi !");
            }
            

        }
    }
}
