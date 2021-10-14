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
            
        }

        private void ajoutDunControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControleRealise formControleRealise = new FormControleRealise();
            formControleRealise.Show();
        }

        private void ajoutDeLaZoneDeStockageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutZoneStockage frmAjoutZoneStockage = new FormAjoutZoneStockage();
            frmAjoutZoneStockage.Show();
        }
    }
}