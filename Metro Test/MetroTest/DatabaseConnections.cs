using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace MetroTest
{
    class DatabaseConnections
    {
       
        private SqlConnection con;
        private SqlCommand cmd;
        public DatabaseConnections() {
            con = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
        
        }

        public void CreateOrder(String OrderName, double ORderCost,int tableid) {

            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT* FROM Orders", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int counts = dt.Rows.Count;
            int id = counts + 1;
            cmd = new SqlCommand(@"INSERT INTO Orders
                         ([OrdersID]
                          ,[OrderName]
                          ,[OrderCost]
                          ,[OrderTime]
                          ,[TableID])
                          VALUES('" + id + "','" + OrderName + "','" + ORderCost + "','"
                              +  DateTime.Now.ToString() + "','" + tableid + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

           // MessageBox.Show("New Order Created");
        }


    }
}
