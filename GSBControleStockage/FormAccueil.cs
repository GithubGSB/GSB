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
            SqlConnection maConnexion;
            string strConnect = ConfigurationManager.ConnectionStrings["GSBControleStockage"].ConnectionString;
            maConnexion = new SqlConnection(strConnect);
            maCommand = new SqlCommand("", maConnexion);
        }

        private void AjoutZoneStockageMnuItem_Click(object sender, EventArgs e)
        {
            FormAjoutProd leFormAppele = new FormAjoutProd(maCommand);
            leFormAppele.Show();
        }
    }
}
