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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(UtilisateurManager.GetInstance().ConnexionUtilisateur(txtIdentifiant.Text, txtMdp.Text))
            {
                this.Close();
                new FormAccueil().Show();
            }
        }
    }
}
