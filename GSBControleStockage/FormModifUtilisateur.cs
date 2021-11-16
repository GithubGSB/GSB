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
    public partial class FormModifUtilisateur : Form
    {
        private Utilisateur edit;

        public FormModifUtilisateur()
        {
            InitializeComponent();
            edit = null;
            cbxProfil.DisplayMember = "libelle";
            cbxProfil.DataSource = ProfilManager.GetInstance().GetProfils();
            pnlModif.Hide();

            cbxUtilisateur.DisplayMember = "NomPrenom";
            cbxUtilisateur.DataSource = UtilisateurManager.GetInstance().ConsultationUtilisateur();
            cbxUtilisateur.SelectedIndex = -1;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Profil profil = null;
            try
            {
                profil = (Profil)cbxProfil.SelectedItem;
            }
            catch (Exception) { }
            if (UtilisateurManager.GetInstance().ModifUtilisateur(edit, txtNom.Text, txtPrenom.Text, profil))
            {
                cbxUtilisateur.SelectedIndex = -1;
                pnlModif.Hide();
                edit = null;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbxUtilisateur.SelectedIndex = -1;
            pnlModif.Hide();
            edit = null;
        }

        private void cbcUtilisateur_SelectionChangeCommitted(object sender, EventArgs e)
        {
            edit = null;
            try
            {
                edit = (Utilisateur)cbxUtilisateur.SelectedItem;
            }
            catch (Exception) { }
            if(edit != null)
            {
                txtNom.Text = edit.Nom;
                txtPrenom.Text = edit.Prenom;
                cbxProfil.SelectedItem = edit.Profil;
                pnlModif.Show();
            }
            else pnlModif.Hide();
        }
    }
}
