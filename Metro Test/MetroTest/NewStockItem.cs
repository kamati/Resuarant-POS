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
    public partial class NewStockItem : MetroFramework.Forms.MetroForm
    {
         private String[] StockItemList = {"From the Grill","Chicken","Platter","Salads","Break fast","Pizza","Burgers","Desserts","Beverages","liquors",
                                         "Beers","Dry White","SemiSweet","Rose Wines","Merlot","Shiraz","Pinotage","Red Blands","House Wines","Local Beers",
                                         "Import Beers","Drought","Shandy","Ciders"};
        private SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPos3;Integrated Security=True");
        private SqlCommand cmd;
        public NewStockItem()
        {
            InitializeComponent();
        }

        private void NewStockItem_Load(object sender, EventArgs e)
        {
            
            foreach (string port in StockItemList)
            {
                metroComboBoxItemType.Items.Add(port);
            }
        }

        private void metroButtonNewStockItem_Click(object sender, EventArgs e)
        {
            String itemCode = StockItemList[metroComboBoxItemType.SelectedIndex];
            String ItemName = TextBoxItemName.Text;
            String ItemPrice = TextBoxPrice.Text;
            int stockout = (int)numericUpDown1.Value;
            double price = 0;
            String timeUpdated = DateTime.Now.ToString();

            if (double.TryParse(ItemPrice, out price))
            {

                try {
                    Con.Open();
                    SqlDataAdapter ada = new SqlDataAdapter("SELECT* FROM StockItems", Con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    int counts = dt.Rows.Count;
                    int id = counts + 1;
                    cmd = new SqlCommand(@"INSERT INTO StockItems
                         ([StockID]
                          ,[ItemCode]
                          ,[ItemName]
                          ,[ItemPrice]
                          ,[StockCount]
                          ,[DateUpdated])
                          VALUES('" + id + "','" + itemCode + "','" + ItemName + "','"
                                      + ItemPrice + "','" + stockout + "','" + timeUpdated + "')", Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Stock_Managment _emplyForm = new Stock_Managment();
                    _emplyForm.Show();

                    this.Dispose();
                
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                    Con.Close();
                }
            
            }
            else
            {
                MessageBox.Show("invalide Price");
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
