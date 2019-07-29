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
    public partial class NewEmployeeForm : MetroFramework.Forms.MetroForm
    {
       private SqlConnection Con;
       private SqlCommand cmd;
       private String[] RestuarantPositions = { "Manager", "Waiter", "Waitress" };
        public NewEmployeeForm()
        {
            InitializeComponent();
            Con = new SqlConnection("Data Source=.;Initial Catalog=RestuarantPos3;Integrated Security=True");
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void metroAddNewEmployee_Click(object sender, EventArgs e)
        {
            
                String Name = EmployeeName.Text;
                String Surname = EmployeeSurname.Text;
                String Password = EmployeePassword.Text;
                String Address1 = EmployeesAddress1.Text;
                String Address2 = EmployeesAddress2.Text;
                String Position = RestuarantPositions[EmployeePosition.SelectedIndex];
                String Number = EmployeePhoneNumber.Text;
                int IntNumber = 0;

                String AddressFull = Address1 + " " + Address2;
                int.TryParse(Number, out IntNumber);

                Con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT* FROM Employees", Con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                int counts = dt.Rows.Count;
                int id = counts + 1;
                cmd = new SqlCommand(@"INSERT INTO Employees
                         ([employeeID]
                          ,[FirstName]
                          ,[LastName]
                          ,[Password]
                          ,[Position]
                          ,[Address]
                          ,[PhoneNumber])
                          VALUES('" + id + "','" + Name + "','" + Surname + "','"
                                  + Password + "','" + Position + "','"
                                  + AddressFull + "','" + IntNumber + "')", Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                EmployeesForm _emplyForm = new EmployeesForm();
                _emplyForm.Show();

                this.Dispose();
          
             
               
        }

        private void CloseNewEmployeesFrom_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
