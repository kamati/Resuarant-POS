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
    public partial class ItemUpdate : MetroFramework.Forms.MetroForm
    {
        private String[] StockItemList = {"From the Grill","Chicken","Platter","Salads","Break fast","Pizza","Burgers","Desserts","Beverages","liquors",
                                         "Beers","Dry White","SemiSweet","Rose Wines","Merlot","Shiraz","Pinotage","Red Blands","House Wines","Local Beers",
                                         "Import Beers","Drought","Shandy","Ciders"};
        private String ityps = null;
        private int ID;
        private SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPos3;Integrated Security=True");

        public ItemUpdate()
        {
            InitializeComponent();
        }

        private void ItemUpdate_Load(object sender, EventArgs e)
        {

        }

        public void ItemInfo(DataTable table){



            foreach (DataRow item in table.Rows)
            {
                int.TryParse(item[1].ToString(), out ID);
                ityps = item[1].ToString();
                TextBoxItemName.Text = item[2].ToString();
                TextBoxPrice.Text = item[3].ToString();

               decimal cnt = 0;
               if( decimal.TryParse(item[4].ToString(),out cnt));
                numericUpDown1.Value = cnt;
            

            }

        
        }

        private void ItemTypeComb_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void ItemTypeComb_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (string port in StockItemList)
            {
                ItemTypeComb.Items.Add(port);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(ItemTypeComb.SelectedIndex.ToString());
          
            String ItemName = TextBoxItemName.Text;
            String ItemPrice = TextBoxPrice.Text;
            int stockout = (int)numericUpDown1.Value;
            double price = 0;
            double.TryParse(ItemPrice,out price);
            String timeUpdated = DateTime.Now.ToString();

            Con.Open();
            SqlCommand DataBaseOject ;

            if (ItemTypeComb.SelectedIndex != (-1))
            {
                String itemCode = StockItemList[ItemTypeComb.SelectedIndex];
                DataBaseOject = new SqlCommand(@"UPDATE       StockItems
                      SET [ItemCode] = '" + itemCode + "', [ItemName] ='" + ItemName + "', [ItemPrice] ='" + price + "',[StockCount] ='" + stockout + "', [DateUpdated] ='" + timeUpdated + "'WHERE (StockID='" + ID + "')", Con);
            }
            else {
                DataBaseOject = new SqlCommand(@"UPDATE       StockItems
                      SET [ItemCode] = '" + ityps + "', [ItemName] ='" + ItemName + "', [ItemPrice] ='" + price + "',[StockCount] ='" + stockout + "', [DateUpdated] ='" + timeUpdated + "'WHERE (StockID='" + ID + "')", Con);
            }
            DataBaseOject.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Update successfully!!");
            Stock_Managment Sm = new Stock_Managment();
            Sm.Dispose();
            
            this.Dispose();


          
        }
    }
}
