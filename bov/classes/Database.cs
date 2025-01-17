﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bov.classes
{
    public class Database
    {
        string DataBaseConnect = "server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo";
        
        public List<List<string>> getfromdb(string DBTable)
        { 
            var listFromDB = new List<List<string>>();
        
           // string connStr = "server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo";
            MySqlConnection conn = new MySqlConnection(DataBaseConnect);
            conn.Open();
            string sql = "SELECT * FROM " + DBTable + ";";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var col = new List<string>();
                for (int j = 0; j < rdr.FieldCount; j++)
                {
                    col.Add(rdr[j].ToString());
                }
                listFromDB.Add(col);
            }
            rdr.Close();
            conn.Close();
            return listFromDB;
        }

        public List<List<string>> getfromdbbyquery(string query)
        {
            var listFromDB = new List<List<string>>();
            //string connStr = "server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo";
            MySqlConnection conn = new MySqlConnection(DataBaseConnect);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var col = new List<string>();
                for (int j = 0; j < rdr.FieldCount; j++)
                {
                    col.Add(rdr[j].ToString());
                }
                listFromDB.Add(col);
            }
            rdr.Close();
            conn.Close();
            return listFromDB;
        }
        public List<string> getBikeModelList()
        {
            List<string> bikeList = new List<string>();
            List<List<string>> bikemodel = getfromdb("modelbike");
            for (int i=0; i < bikemodel.Count(); i++ )
            {
                bikeList.Add(bikemodel[i][1]);
            }
            
            return bikeList;
        }

        public void sendToDB(string query) 
        {
            //string connStr = "server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo";
            MySqlConnection Connection = new MySqlConnection(DataBaseConnect);
            Console.WriteLine("Connecting to MySQL to send new element...");
            Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader read = cmd.ExecuteReader();
            Console.WriteLine("Element added to DB");
            read.Dispose();
            Connection.Close();
        }

        public List<List<string>> getIdCustomer(Customer customer)
        {
            string queryOB = "SELECT * FROM customer WHERE firstName = '"
                + customer.firstName +
                "' AND lastName = '" + customer.lastName + "' AND address = '" +
                customer.adress + "' AND TVA = '" + customer.tva + "' ;";
            return getfromdbbyquery(queryOB);
        }

        public void AddCustomerInDb(Customer customer) 
        {
            if (getIdCustomer(customer).Count() ==0 )
            { 
                
            string queryOB = "INSERT INTO customer (lastname,firstname,address,TVA) VALUES('"
                + customer.lastName + "', '" +
               customer.firstName + "', '" +
                customer.adress + "', '" +
                customer.tva + "');" ;
            sendToDB(queryOB);
            }
        }

        

        public void AddOrderInDb(Order order) 
        {
            Console.WriteLine(getIdCustomer(order.customer)[0][0]);
                string queryOB = "INSERT INTO bovelo.order (date,deliveryEstimateDate,totalPrice,status,customer_idcustomer) VALUES ('"
                + order.date.ToString("yyyy-M-dd hh:mm:ss") + "', '" + 
                order.estimateDate?.ToString("yyyy-M-dd hh:mm:ss") + "', '" + 
                order.totalPrice + "', '" +
                0 + "', '" +
                getIdCustomer(order.customer)[0][0] + "'); ";
            
            sendToDB(queryOB);
        }


        public void AddOrderLineInDb(OrderLine orderLine)
        {
            int index = getfromdb("bovelo.order").Count - 1;
            string queryOB = "INSERT INTO bovelo.orderline (quantity,order_idorder,size_idsize, color_idcolor, modelbike_idmodelbike) VALUES ('"
                + orderLine.quantity + "', '" +
                getfromdb("bovelo.order")[index][0] + "', '" +
                getfromdbbyquery("SELECT * FROM bovelo.size WHERE sizecol = '"
                + orderLine.size + "'; ")[0][0] + "', '" +
                getfromdbbyquery("SELECT * FROM bovelo.color WHERE name = '"
                + orderLine.color + "'; ")[0][0] + "', '" +
                getfromdbbyquery("SELECT * FROM bovelo.modelbike WHERE name = '"
                + orderLine.bikeModel.name + "'; ")[0][0] +
                "'); ";

            sendToDB(queryOB);
        }

        public void AddPartLineInDb(Part part)
        {
            int index = getfromdb("bovelo.orderline").Count - 1;
        }

        public void AddBikeInDb(Bike bike)
        {

            int index = getfromdb("bovelo.orderline").Count - 1;
            string queryOB = "INSERT INTO bovelo.bikes (status, modelbike_idmodelbike, orderline_idorderline) VALUES ('"
                + bike.bikeStatus + "', '" +
                getfromdbbyquery("SELECT * FROM bovelo.modelbike WHERE name = '"
                + bike.bikeModel.name + "'; ")[0][0] + "', '" +
                getfromdb("bovelo.orderline")[index][0] +
                "'); ";

            sendToDB(queryOB);
        }





    }
}
