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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
            //gestion des droits d'accès
            Utilisateur util = UtilisateurManager.GetInstance().UtilisateurApp;
            if (util == null || util.Profil == null) this.Close();
            List<Fonctionnalite> lesFonc = util.Profil.LesFoncAutorises;

            foreach(ToolStripMenuItem mnuItemParent in mnuGSBControleStock.Items)
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


        private void mnuitemAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            FormAjoutUtilisateur fau = new FormAjoutUtilisateur();
            fau.Show();
        }

        private void mnuItemAjoutControle_Click(object sender, EventArgs e)
        {
            FormControleRealise fcr = new FormControleRealise();
            fcr.Show();
        }

        private void mnuItemAjoutEntreprise_Click(object sender, EventArgs e)
        {
            FrmEntreprise frmEntreprise = new FrmEntreprise();
            frmEntreprise.Show();
        }

        private void mnuItemAjoutZoneStock_Click(object sender, EventArgs e)
        {
            FormAjoutZoneStockage faz = new FormAjoutZoneStockage();
            faz.Show();
        }

        private void mnuItemDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}