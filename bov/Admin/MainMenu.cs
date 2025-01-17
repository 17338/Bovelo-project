﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bov;
using bov.Schedule;
using bov.Stock;

namespace Bovelo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            TheCatalog catalog = new TheCatalog();
            this.Hide();
            catalog.Show();
        }

        private void Planning_Click(object sender, EventArgs e)
        {
            DoSchedule doScheddule = new DoSchedule();
            this.Close();
            doScheddule.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WorkerSchedule WorkerSchedule = new WorkerSchedule();
            this.Hide();
            WorkerSchedule.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            this.Hide();
            stock.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            OrderParts orderParts = new OrderParts();
            this.Hide();
            orderParts.Show();
        }

        private void UserSettings_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            this.Hide();
            userSetting.Show();
        }

  
    }
}
