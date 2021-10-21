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
    public partial class FormConsultControleRealise : Form
    {
        public FormConsultControleRealise()
        {
            InitializeComponent();
            dtgControle.DataSource = ControleRealiseManager.GetInstance().GetLesControlesRealises();
            dtgControle.Columns[0].Visible = false;
            dtgControle.Columns[6].Visible = false;
            dtgControle.Columns[7].Visible = false;
            dtgControle.Columns[8].Visible = false;

        }
    }
}
