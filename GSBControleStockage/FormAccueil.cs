﻿using System;
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
        }

        private void ajoutDunContrôleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControleRealise formControleRealise = new FormControleRealise();
            formControleRealise.Show();
        }
    }
}
