﻿using bov.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bov
{
    public partial class PurchaseConfirmation : Form
    {
        TheCatalog catalog;
        public PurchaseConfirmation(TheCatalog catalog)
        {
            InitializeComponent();
            
            this.catalog = catalog;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TheCatalog new_catalog = new TheCatalog();
            new_catalog.Show();
        }

        private void BackToTheCatalogBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            TheCatalog new_catalog = new TheCatalog();
            new_catalog.Show();
        }

        private void PurchaseConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
