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
    public partial class NewTable : MetroFramework.Forms.MetroForm
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private String[] RestuarantPositions = { "Inside", "Outside"};
        public NewTable()
        {
            InitializeComponent();
            Con = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPos3;Integrated Security=True");
        }

        private void NewTable_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonAddTable_Click(object sender, EventArgs e)
        {
            String Name = textName.Text;
            String Location = RestuarantPositions[metroComboBoxLocation.SelectedIndex];

            Con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT* FROM OrderTables", Con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            int counts = dt.Rows.Count;
            int id = counts + 1;
            string timeCreated = DateTime.Now.ToString();
            cmd = new SqlCommand(@"INSERT INTO OrderTables
                         ([ID]
                          ,[TableName]
                          ,[TimeCreated]
                          ,[TableLocation])
                          VALUES('" + id + "','" + Name + "','" + timeCreated + "','"
                              + Location + "')", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            TablesManagment _tableForm = new TablesManagment();
            _tableForm.Show();

            this.Dispose();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
