﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UsernameInput.Text = "Admin";
            PasswordInput.PasswordChar = '*';


        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            var username = UsernameInput.Text;
            var password = PasswordInput.Text;
            MySqlConnection connect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            string query = "Select * from user Where UserName = '" + username.Trim() + "' and Password = '" + password.Trim() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connect);
            DataTable LoginData = new DataTable();
            sda.Fill(LoginData);

            if (LoginData.Rows.Count == 1)
            {
                MainMenu menu = new MainMenu();
                this.Hide();
                menu.Show();
            }
            else
            {
                LoginErrorMsg loginError = new LoginErrorMsg();
                loginError.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
