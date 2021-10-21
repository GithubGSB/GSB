using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleStockBLL;
using ControleStockBO;

namespace GSBControleStockage
{
    public partial class FormModifZoneStockage : Form
    {
        public FormModifZoneStockage()
        {
            InitializeComponent();
        }

        private void btnModifZS_Click(object sender, EventArgs e)
        {
            ZoneStockageManager.GetInstance().ModifZoneStockage();
        }

        
    }
}
