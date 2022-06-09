﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bov.classes;
using MySql.Data.MySqlClient;

namespace bov.Schedule
{
    public partial class WorkerSchedule : Form
    {
        public WorkerSchedule()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        Database database = new Database();

        private void workerschedule_Load(object sender, EventArgs e)
        {

            List<List<string>> workers = database.getfromdbbyquery("SELECT * FROM bovelo.user WHERE job = 'Assembly worker';");
            foreach (List<string> worker in workers)
            {
                comboBox1.Items.Add(worker[3]);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            string selectinfo = "Select bike_id from schedule inner join bovelo.user as u on user_id = u.id  where u.UserName= '" + comboBox1.SelectedItem + "' AND week LIKE '" + dateTimePicker1.Text + "';";
            myDbConn.Open();
            MySqlCommand cmd = new MySqlCommand(selectinfo, myDbConn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string selectmodel = "Select modelbike_idmodelbike from bikes  where idbikes = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "';";

                MySqlCommand cmd2 = new MySqlCommand(selectmodel, myDbConn);
                cmd2.CommandType = CommandType.Text;
                MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                sda2.Fill(dt);
            }


            myDbConn.Close();










        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[0].Value);

                if (s == true)
                {
                    string updatestatus = "UPDATE bikes SET status='1' WHERE idbikes ='" + row.Cells[1].Value + "'";


                    MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                    myDbConn.Open();
                    MySqlCommand cmd = new MySqlCommand(updatestatus, myDbConn);
                    cmd.ExecuteNonQuery();
                    myDbConn.Close();

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}