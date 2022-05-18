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
    public partial class FormConsultZonesStockages : Form
    {
        public FormConsultZonesStockages()
        {
            InitializeComponent();
        }

        private void btnConsultZoneStockage_Click(object sender, EventArgs e)
        {
            try
            {

                dtgZoneStockage.DataSource = ZoneStockageManager.GetInstance().ConsultZonesStockages();
                dtgZoneStockage.Columns[0].Visible = false;
                dtgZoneStockage.Columns[5].Visible = false;
                dtgZoneStockage.Columns[6].Visible = false;
                //dtgZoneStockage.Columns[7].Visible = false;
                //dtgZoneStockage.Columns[8].Visible = false;
            }
            
            catch (Exception except)
            {
                Logger.LogErreur(except);
                
            }
        }
    }
}
