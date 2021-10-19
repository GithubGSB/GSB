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
    public partial class FrmConsultEntreprise : Form
    {
        public FrmConsultEntreprise()
        {
            InitializeComponent();
        }

        private void btnInfoEntreprise_Click(object sender, EventArgs e)
        {
            try
            {
                dtgInfoEntreprise.Visible = true;
                dtgInfoEntreprise.DataSource = EntrepriseManager.GetInstance();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
