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
    public partial class FrmEntreprise : Form
    {
        private Ville laVille;

        public FrmEntreprise()
        {
            InitializeComponent();
        }

        private void btnAjoutEntreprise_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNom.Text;
                string adresse = txtAdresse.Text;
                string email = txtEmail.Text;
                DateTime dateCreation = dtCreation.Value;
                DateTime dateModif = dtModif.Value;
                int insee = (int) cbxInsee.SelectedValue;
                
                
              

                EntrepriseManager.GetInstance().CreerEntreprise(nom, adresse, email, dateCreation, dateModif, insee, laVille);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            
        }
    }
}
