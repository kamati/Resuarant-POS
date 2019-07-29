using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroTest
{
    public partial class OrderManagment : MetroFramework.Forms.MetroForm
    {
        private string TName;
        private int Tnumber;
        public string  tableName
        {
            get { return TName; }
            set { TName = value; }

        }

        public int tableValue
        {
            get { return Tnumber; }
            set { Tnumber = value; }

        }

        public OrderManagment()
        {
            InitializeComponent();
            
        }

        private void OrderManagment_Load(object sender, EventArgs e)
        {
            Refreshinf1();
        }

        private void metroTabPage8_Click(object sender, EventArgs e)
        {

        }

        private void metroTileFromTheGril_Click(object sender, EventArgs e)
        {
            Refreshinf1();
        }

        private void Refreshinf1() {
            labelTableName.Text = TName;

            SqlConnection Con2 = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM Orders WHERE  ([TableID] = '" + Tnumber + "')", Con2);




            DataTable PDT = new DataTable();
            DataBaseOject.Fill(PDT);
            dataGridViewBill.Rows.Clear();

            foreach (DataRow item in PDT.Rows)
            {

                int n = dataGridViewBill.Rows.Add();
                dataGridViewBill.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridViewBill.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridViewBill.Rows[n].Cells[2].Value = item[2].ToString();
               
            }
        
        }

        
      

    }
}
