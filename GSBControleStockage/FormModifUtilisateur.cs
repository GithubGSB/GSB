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
        public FormModifUtilisateur()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbcUtilisateur_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
