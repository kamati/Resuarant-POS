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
    public partial class Stock_Managment : MetroFramework.Forms.MetroForm
    {
        private String[] StockItemList = {"From the Grill","Chicken","Platter","Salads","Break fast","Pizza","Burgers","Desserts","Beverages","liquors",
                                         "Beers","Dry White","SemiSweet","Rose Wines","Merlot","Shiraz","Pinotage","Red Blands","House Wines","Local Beers",
                                         "Import Beers","Drought","Shandy","Ciders","Exras"};
        public Stock_Managment()
        {
            InitializeComponent();
        }

        private void Stock_Managment_Load(object sender, EventArgs e)
        {
            UpdateStockTablealll();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile27_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[0]);
        }

        private void UpdateStockTable(String orderCode)
        {
            
            SqlConnection Con2 = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM StockItems WHERE  ([ItemCode] LIKE  '" + orderCode + "')", Con2);




            DataTable PDT = new DataTable();
            DataBaseOject.Fill(PDT);
            dataGridViewStockItems.Rows.Clear();

            foreach (DataRow item in PDT.Rows)
            {

                int n = dataGridViewStockItems.Rows.Add();
                dataGridViewStockItems.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridViewStockItems.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridViewStockItems.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridViewStockItems.Rows[n].Cells[3].Value = "N$" + item[3].ToString();
                dataGridViewStockItems.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridViewStockItems.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridViewStockItems.Rows[n].Cells[6].Value = item[6].ToString();


            }

        }

        private void UpdateStockTablealll()
        {

            SqlConnection Con2 = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM StockItems ", Con2);




            DataTable PDT = new DataTable();
            DataBaseOject.Fill(PDT);
            dataGridViewStockItems.Rows.Clear();

            foreach (DataRow item in PDT.Rows)
            {

                int n = dataGridViewStockItems.Rows.Add();
                dataGridViewStockItems.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridViewStockItems.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridViewStockItems.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridViewStockItems.Rows[n].Cells[3].Value = "N$"+item[3].ToString();
                dataGridViewStockItems.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridViewStockItems.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridViewStockItems.Rows[n].Cells[6].Value = item[6].ToString();


            }

        }

        private void metroTileChicken_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[1]);
        }

        private void metroTilePlatter_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[2]);
        }

        private void metroTileSalads_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[3]);
        }

        private void metroTileBreakfast_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[4]);
        }

        private void metroTilePizza_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[5]);
        }

        private void metroTileBurgers_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[6]);
        }

        private void metroTileDeserts_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[7]);
        }

        private void metroTileBeverages_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[8]);
        }

        private void metroTileLiquors_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[9]);
        }

        private void metroTileBeer_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[10]);
        }

        private void metroTileDryWhite_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[11]);
        }

        private void metroTileSemiSweet_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[12]);
        }

        private void metroTileRose_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[13]);
        }

        private void metroTileMerlot_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[14]);
        }

        private void metroTileShiraz_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[15]);
        }

        private void metroTilePinotage_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[16]);
        }

        private void metroTileRedBlends_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[17]);
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[18]);
        }

        private void metroTileLocalBeer_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[19]);
        }

        private void metroTileImportBeer_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[20]);
        }

        private void metroTileDrought_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[21]);
        }

        private void metroTileShandy_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[22]);
        }

        private void metroTileCiders_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[23]);
        }

        private void metroTileStarter_Click(object sender, EventArgs e)
        {
            UpdateStockTable(StockItemList[24]);
        }

        private void metroButtonAddNewItem_Click(object sender, EventArgs e)
        {
            NewStockItem sti = new NewStockItem();
            sti.Show();
        }

        private void metroTileChicken_MouseEnter(object sender, EventArgs e)
        {

        }

        private void metroTileChicken_MouseLeave(object sender, EventArgs e)
        {

        }

        private void metroTile27_MouseEnter(object sender, EventArgs e)
        {

        }

        private void metroTile27_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void metroTilePlatter_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dataGridViewStockItems_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void dataGridViewStockItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String ItemId = dataGridViewStockItems.SelectedRows[0].Cells[0].Value.ToString();

            int id = 0;
            int.TryParse(ItemId, out id);
            SqlConnection Con2 = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM StockItems WHERE  ([StockID] =  '" + id + "')", Con2);

            DataTable PDT = new DataTable();
            DataBaseOject.Fill(PDT);

            ItemUpdate it = new ItemUpdate();
            it.ItemInfo(PDT);
            it.Show();
        }
    }
}
