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
    public partial class FormSupprZoneStockage : Form
    {
        public FormSupprZoneStockage()
        {
            InitializeComponent();
            cbxZoneStockage.DisplayMember = "nomZone";
            cbxZoneStockage.ValueMember = "id";
            cbxZoneStockage.DataSource = ZoneStockageManager.GetInstance().GetLesZonesStockages();
            cbxZoneStockage.SelectedIndex = -1;
        }

        private void cbxZoneStockage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idZoneStockage = (int)cbxZoneStockage.SelectedValue;
            //ZoneStockage uneZoneStockage = ZoneStockageManager.GetInstance().RecupererZoneStockage(idZoneStockage);
            try
            {
                List<ZoneStockage> lesZonesStockages = new List<ZoneStockage>();
                lesZonesStockages.Add(ZoneStockageManager.GetInstance().RecupererZoneStockage(idZoneStockage));
                dtgZoneStockage.DataSource = lesZonesStockages;
                dtgZoneStockage.Columns[0].Visible = false;
                dtgZoneStockage.Columns[5].Visible = false;
                dtgZoneStockage.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                Logger.LogErreur(ex);
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            int idZoneStockage = (int)cbxZoneStockage.SelectedValue;
            try
            {
                if (idZoneStockage > 0)
                {
                    ZoneStockageManager.GetInstance().SupprZoneStockage(idZoneStockage);
                    Logger.LogInformation("Suppression effectué");
                }
                else
                {
                    Logger.LogAttention("Vous devez sélectionner un champs");
                }
            }
            catch (Exception ex)
            {

                Logger.LogErreur(ex);
            }

        }
    }
}
