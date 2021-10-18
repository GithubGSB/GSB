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
    public partial class FormAjoutUtilisateur : Form
    {
        public FormAjoutUtilisateur()
        {
            InitializeComponent();

            cbxProfil.DisplayMember = "libelle";
            cbxProfil.DataSource = ProfilManager.GetInstance().GetProfils();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Profil profil = null;
            try
            {
                profil = (Profil)cbxProfil.SelectedItem;
            }
            catch (Exception) { }
            if (UtilisateurManager.GetInstance().AjoutUtilisateur(txtNom.Text, txtPrenom.Text, profil, txtMdp.Text, txtMdpConf.Text))
            {
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtMdp.Text = "";
                txtMdpConf.Text = "";
                cbxProfil.SelectedIndex = -1;
            }
        }
    }
}
