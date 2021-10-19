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
using ControleStockBLL;
using ControleStockBO;

namespace GSBControleStockage
{
    public partial class FrmAjoutEntreprise : Form
    {

        public FrmAjoutEntreprise()
        {
            InitializeComponent();
            cbxInsee.DisplayMember = "nom";
            cbxInsee.ValueMember = "insee";
            cbxInsee.DataSource = VilleManager.GetInstance().GetLesVilles();

            //association du dt à la liste
        }


        /// <summary>
        /// Sur le formulaire, Une fonction permettant de Saisir les informations concernants l'entreprise et en cas de non-Saisi un message erreur;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutEntreprise_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNom.Text;
                string adresse = txtAdresse.Text;
                string email = txtEmail.Text;
                DateTime dateCreation = dtCreation.Value;
                DateTime dateModif = dtModif.Value;
                int insee = (int)cbxInsee.SelectedValue;


                //string idVille = (string)cbxInsee.SelectedValue;
                if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Vous devez saisir tous les champs ! ", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nb = 0;
                    nb = EntrepriseManager.GetInstance().CreerEntreprise(nom, adresse, email, dateCreation, dateModif, insee);
                    MessageBox.Show("Votre Entreprise a été ajouté");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}
