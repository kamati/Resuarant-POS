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
    public partial class TablesManagment : MetroFramework.Forms.MetroForm
    {
       private  int TableID = 0;
       private string TName; 
      
        public TablesManagment()
        {
            InitializeComponent();
            Updategride();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NewTable nt = new NewTable();
            nt.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Updategride() { 
        
            SqlConnection Con2 = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM OrderTables ", Con2);
            



                  DataTable PDT = new DataTable();
                  DataBaseOject.Fill(PDT);
                  dataGridViewOpenTables1.Rows.Clear();

                  foreach (DataRow item in PDT.Rows)
                  {

                      int n = dataGridViewOpenTables1.Rows.Add();
                      dataGridViewOpenTables1.Rows[n].Cells[0].Value = item[0].ToString();
                      dataGridViewOpenTables1.Rows[n].Cells[1].Value = item[1].ToString();
                      dataGridViewOpenTables1.Rows[n].Cells[2].Value = item[2].ToString();
                      dataGridViewOpenTables1.Rows[n].Cells[3].Value = item[3].ToString();
                      dataGridViewOpenTables1.Rows[n].Cells[4].Value = item[4].ToString();
                      dataGridViewOpenTables1.Rows[n].Cells[5].Value = item[5].ToString();
                      dataGridViewOpenTables1.Rows[n].Cells[6].Value = item[6].ToString();
                  }
                     
        }

        public  int getTableID() {

            return TableID;
        }

        public ToolStripStatusLabel SetTableID()
        {

            return toolStripStatusTN;
        
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Updategride();
        }

        private void dataGridViewOpenTables1_MouseClick(object sender, MouseEventArgs e)
        {
           
            string table_number = dataGridViewOpenTables1.SelectedRows[0].Cells[0].Value.ToString();
            toolStripStatusTN.Text = dataGridViewOpenTables1.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(table_number);
            //int.Parse(table_number);


            if (int.TryParse(table_number, out TableID))
            {
                OrderManagment order = new OrderManagment();
                order.tableName = dataGridViewOpenTables1.SelectedRows[0].Cells[1].Value.ToString();
                order.tableValue = TableID;
                order.Show();

            }
            else {
                MessageBox.Show("Invalide tablenumber");
            }
        }
    }

       
}
