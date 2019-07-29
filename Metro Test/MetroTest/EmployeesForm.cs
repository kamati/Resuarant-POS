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
    public partial class EmployeesForm : MetroFramework.Forms.MetroForm
    {
        private SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPOS3;Integrated Security=True");
        private SqlCommand cmd;
        private FlowLayoutPanel _EmployeeFlowLayout;
        private Button EmployeeButton;
        //private WifiCommunications wifiAdapter;

        public EmployeesForm()
        {
            InitializeComponent();
          //  createEmployee();
           // wifiAdapter = new WifiCommunications();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createEmployee() 
        {
            Con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT* FROM Employees", Con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            Docket NewEplys = new Docket();
           // MessageBox.Show(dt.Rows.Count.ToString());
            for (int t = 0; t < dt.Rows.Count -2; t++)
            {
                metroTabPage1.Controls.Add(CreateMetroButton(dt, t));
               // MessageBox.Show(dt.Rows.Count.ToString());
            }
            Con.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          //  createEmployee();
          //  wifiAdapter.SendData("kamati");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewEmploy_Click(object sender, EventArgs e)
        {
            NewEmployeeForm NewEmplFrom = new NewEmployeeForm();
            NewEmplFrom.Show();
        }



        public FlowLayoutPanel CreateMetroButton(DataTable data, int i)
        {

            _EmployeeFlowLayout = new FlowLayoutPanel();
            _EmployeeFlowLayout.AutoScroll = true;
            _EmployeeFlowLayout.Location = new System.Drawing.Point(3, 3);
            _EmployeeFlowLayout.Name = "flowLayoutPanel1";
            _EmployeeFlowLayout.Size = new System.Drawing.Size(200, 383);
            _EmployeeFlowLayout.TabIndex = 7;
            foreach (DataRow item in data.Rows)
            {

                EmployeeButton = new Button();
                EmployeeButton.Name = item[1].ToString();
                EmployeeButton.Size = new System.Drawing.Size(194, 28);
              //  EmployeeButton.Style = MetroFramework.MetroColorStyle.Green;
                EmployeeButton.TabIndex = data.Rows.Count;
                EmployeeButton.Text = item[1].ToString();
               // EmployeeButton.Theme = MetroFramework.MetroThemeStyle.Light;

                EmployeeButton.Click += new EventHandler(EmployeeButton_Click);
                _EmployeeFlowLayout.Controls.Add(this.EmployeeButton); ;
            }


            return _EmployeeFlowLayout;
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            SqlDataAdapter DataBaseOject = new SqlDataAdapter("SELECT* FROM Employees WHERE  ([FirstName] LIKE  '" + b.Name + "%')", Con);
            DataTable PDT = new DataTable();
            DataBaseOject.Fill(PDT);
            metroTextName.Text = PDT.Rows[0].ItemArray[1].ToString();
            metroTextSurname.Text = PDT.Rows[0].ItemArray[2].ToString();
            metroTextPassword.Text = PDT.Rows[0].ItemArray[3].ToString();
            metroTextAddress.Text = PDT.Rows[0].ItemArray[5].ToString();
            metroTextPhone.Text = PDT.Rows[0].ItemArray[6].ToString();
            metroTextPostion.Text = PDT.Rows[0].ItemArray[4].ToString();
        }

    

        
        

      
    }
}
