﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Bovelo
{
    public static class UserManager
    {
        public static void CheckIfUserTableExists()
        {
            MySqlConnection DataBaseConnect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            try
            {
                DataBaseConnect.Open();

                string write =
                     "CREATE TABLE IF NOT EXISTS `user` (" +
                     "`id` int(11) NOT NULL auto_increment," +
                   "`Name` varchar(250)  NOT NULL default ''," +
                   "`LastName` varchar(250)  NOT NULL default ''," +
                   "`UserName` varchar(250)  NOT NULL default ''," +
                   "`Password` varchar(250)  NOT NULL default ''," +
                   "`Job` varchar(250)  NOT NULL default ''," +
                    "PRIMARY KEY(`id`)); ";
                MySqlCommand cmd = new MySqlCommand(write, DataBaseConnect);

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source " + ex).ToString();
            }
            finally
            {
                // Disconnect Database
                DataBaseConnect.Close();
            }
        }
        public static bool CheckIfNewInstallation()
        {
            //server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306
            //server=localhost;user=root;database=group4;port=3306;password=root
            MySqlConnection connect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            try
            {
                connect.Open();
                string commandLine = "SELECT COUNT(*) FROM user";
                MySqlCommand cmd = new MySqlCommand(commandLine, connect);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 0) { return true; }
                else { return false; }
            }

            finally
            {
                connect.Close();
            }
        }
    }

} 
