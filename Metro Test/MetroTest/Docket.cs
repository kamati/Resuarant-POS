using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MetroTest
{
    class Docket
    {
        private Panel _orderpanel;
        private FlowLayoutPanel _EmployeeFlowLayout;
        private Button _orderFinishButton;
        private FlowLayoutPanel _flowplanne;
        private Label _ordernumber;
        private DataGridView _orderGrid;
        private DataGridView _orderGrid2;
        private int employeeCount;
        SqlConnection Con2 ;
        
        MetroFramework.Controls.MetroButton EmployeeButton;
       

        public Docket() {
            Con2 = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
            _orderFinishButton = new Button();
            _orderpanel = new Panel();
            _flowplanne = new FlowLayoutPanel();
            _ordernumber = new Label();
            _orderGrid = new DataGridView();
            _orderGrid2 = new DataGridView();
            EmployeeButton = new MetroFramework.Controls.MetroButton();
            employeeCount = 0;
        }

        public FlowLayoutPanel CreateDocket(int i)
        {
            
            _flowplanne.Name = "_flowplanne" + i.ToString();
            _flowplanne.AutoScroll = true;
            _flowplanne.FlowDirection = FlowDirection.TopDown;
            _flowplanne.Size = new System.Drawing.Size(239, 390);
          //  _flowplanne.BackColor = GetColors()[i];




            _ordernumber.AutoSize = true;
            _ordernumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _ordernumber.Location = new System.Drawing.Point(63, 9);
            _ordernumber.Name = "label1";
            _ordernumber.Size = new System.Drawing.Size(101, 20);
            _ordernumber.TabIndex = 11;
            _ordernumber.Text = "Order No. " + i.ToString();
            _ordernumber.AutoSize = true;
            _flowplanne.Controls.Add(_ordernumber);

            _orderGrid.Name = "_orderGrid" + i.ToString();
            _orderGrid.Text = "Order Name";
            _orderGrid.Size = new System.Drawing.Size(230, 319);

            

            DataGridViewColumn _orderGridColum = new DataGridViewColumn();
            _orderGridColum.HeaderText = "Order Name";
            _orderGridColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _orderGridColum.Name = "_orderGridColum" + i.ToString();
            _orderGridColum.ReadOnly = true;

            DataGridViewColumn _orderGridColum2 = new DataGridViewColumn();
            _orderGridColum2.HeaderText = "Order Price";
            _orderGridColum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _orderGridColum2.Name = "OrderPrice" + i.ToString();
            _orderGridColum2.ReadOnly = true;
            DataGridViewColumn[] _orderGridColums = { _orderGridColum, _orderGridColum2 };
            _orderGrid.Columns.AddRange(_orderGridColums);
            


            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM Orders WHERE  ([TableID] =  '" + i + "')", Con2);
            DataTable PDT = new DataTable();
            DataBaseOject.Fill(PDT);
            _orderGrid.Rows.Clear();
            foreach (DataRow item in PDT.Rows)
            {

                int n = _orderGrid.Rows.Add();
                _orderGrid.Rows[n].Cells[0].Value = item[1].ToString();
                _orderGrid.Rows[n].Cells[1].Value = "N$"+item[2].ToString();

            }

            _flowplanne.Controls.Add(_orderGrid);

            _orderFinishButton.Name = i.ToString();
            _orderFinishButton.Text = "Button " + i.ToString();
            _orderFinishButton.Size = new System.Drawing.Size(226, 23);
            _orderFinishButton.Click += new EventHandler(b_Click);

            _flowplanne.Controls.Add(_orderFinishButton);

            return _flowplanne;
        }

        private void b_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("you clicked the button" + _orderFinishButton.Text);
        }

        private List<Color> GetColors() {
            List<Color> colors = new List<Color>();
            colors.Add(Color.AliceBlue);
            colors.Add(Color.Aqua);
            colors.Add(Color.Azure);
            colors.Add(Color.Beige);
            colors.Add(Color.Bisque);
            colors.Add(Color.BlanchedAlmond);
            colors.Add(Color.BurlyWood);
            colors.Add(Color.CadetBlue);
            colors.Add(Color.Coral);
            colors.Add(Color.CornflowerBlue);
            colors.Add(Color.DarkCyan);
            colors.Add(Color.DeepPink);
            colors.Add(Color.DimGray);
            colors.Add(Color.ForestGreen);
            colors.Add(Color.Indigo);
            colors.Add(Color.MistyRose);


            return colors;
        }

        public Button getButton() {

            return _orderFinishButton;
        }

        
    }
}
