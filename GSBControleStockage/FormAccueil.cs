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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
            //gestion des droits d'accès
            Utilisateur util = UtilisateurManager.GetInstance().UtilisateurApp;
            if (util == null || util.Profil == null) this.Close();
            List<Fonctionnalite> lesFonc = util.Profil.LesFoncAutorises;
            foreach (ToolStripMenuItem mnuItemParent in mnuGSBControleStock.Items)
            {
                if (mnuItemParent.Name == "mnuItemUtilisateur")
                {
                    if (mnuItemParent.Tag != null) mnuItemParent.Visible = lesFonc.Exists(x => x.Code == mnuItemParent.Tag.ToString());
                    else mnuItemParent.Visible = false;
                }
                else if (mnuItemParent.Name != "mnuItemDeconnexion")
                {
                    foreach (ToolStripMenuItem mnuItem in mnuItemParent.DropDownItems)
                    {
                        if (mnuItem.Tag != null) mnuItem.Visible = lesFonc.Exists(x => x.Code == mnuItem.Tag.ToString());
                        else mnuItem.Visible = false;
                    }
                }
            }
        }

        private void ajoutDuneEntrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutEntreprise frmEntreprise = new FrmAjoutEntreprise();
            frmEntreprise.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultEntreprise frmConsult = new FrmConsultEntreprise();
            frmConsult.Show();
        }

        private void ajoutDunControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControleRealise fcr = new FormControleRealise();
            fcr.Show();
        }

        private void ajoutDuneZoneStockageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutZoneStockage frmAjoutZoneStockage = new FormAjoutZoneStockage();
            frmAjoutZoneStockage.Show();
        }

        private void ajoutDunUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutUtilisateur fau = new FormAjoutUtilisateur();
            fau.Show();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
