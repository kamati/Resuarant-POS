namespace MetroTest
{
    partial class NewEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.EmployeeSurname = new MetroFramework.Controls.MetroTextBox();
            this.EmployeePassword = new MetroFramework.Controls.MetroTextBox();
            this.EmployeesAddress1 = new MetroFramework.Controls.MetroTextBox();
            this.EmployeePhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.EmployeesAddress2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EmployeePosition = new MetroFramework.Controls.MetroComboBox();
            this.CloseNewEmployeesFrom = new MetroFramework.Controls.MetroButton();
            this.metroAddNewEmployee = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ImportPicture = new System.Windows.Forms.Button();
            this.PatiantPic = new System.Windows.Forms.PictureBox();
            this.TextBoxPicLoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatiantPic)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(503, 80);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.PromptText = "Name";
            this.EmployeeName.Size = new System.Drawing.Size(228, 23);
            this.EmployeeName.TabIndex = 2;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Location = new System.Drawing.Point(502, 109);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.PromptText = "Surname";
            this.EmployeeSurname.Size = new System.Drawing.Size(229, 23);
            this.EmployeeSurname.TabIndex = 2;
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Location = new System.Drawing.Point(503, 138);
            this.EmployeePassword.Name = "EmployeePassword";
            this.EmployeePassword.PromptText = "Password";
            this.EmployeePassword.Size = new System.Drawing.Size(228, 23);
            this.EmployeePassword.TabIndex = 2;
            // 
            // EmployeesAddress1
            // 
            this.EmployeesAddress1.Location = new System.Drawing.Point(503, 196);
            this.EmployeesAddress1.Name = "EmployeesAddress1";
            this.EmployeesAddress1.PromptText = "Street";
            this.EmployeesAddress1.Size = new System.Drawing.Size(228, 23);
            this.EmployeesAddress1.TabIndex = 2;
            // 
            // EmployeePhoneNumber
            // 
            this.EmployeePhoneNumber.Location = new System.Drawing.Point(503, 167);
            this.EmployeePhoneNumber.Name = "EmployeePhoneNumber";
            this.EmployeePhoneNumber.PromptText = "Number";
            this.EmployeePhoneNumber.Size = new System.Drawing.Size(228, 23);
            this.EmployeePhoneNumber.TabIndex = 2;
            // 
            // EmployeesAddress2
            // 
            this.EmployeesAddress2.Location = new System.Drawing.Point(502, 225);
            this.EmployeesAddress2.Name = "EmployeesAddress2";
            this.EmployeesAddress2.PromptText = "Location";
            this.EmployeesAddress2.Size = new System.Drawing.Size(228, 23);
            this.EmployeesAddress2.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(430, 283);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Position";
            // 
            // EmployeePosition
            // 
            this.EmployeePosition.FormattingEnabled = true;
            this.EmployeePosition.ItemHeight = 23;
            this.EmployeePosition.Items.AddRange(new object[] {
            "Manager",
            "Waiter",
            "Waitress"});
            this.EmployeePosition.Location = new System.Drawing.Point(502, 283);
            this.EmployeePosition.Name = "EmployeePosition";
            this.EmployeePosition.Size = new System.Drawing.Size(227, 29);
            this.EmployeePosition.TabIndex = 4;
            // 
            // CloseNewEmployeesFrom
            // 
            this.CloseNewEmployeesFrom.Location = new System.Drawing.Point(628, 351);
            this.CloseNewEmployeesFrom.Name = "CloseNewEmployeesFrom";
            this.CloseNewEmployeesFrom.Size = new System.Drawing.Size(103, 23);
            this.CloseNewEmployeesFrom.TabIndex = 5;
            this.CloseNewEmployeesFrom.Text = "Cancel";
            this.CloseNewEmployeesFrom.Click += new System.EventHandler(this.CloseNewEmployeesFrom_Click);
            // 
            // metroAddNewEmployee
            // 
            this.metroAddNewEmployee.Location = new System.Drawing.Point(519, 351);
            this.metroAddNewEmployee.Name = "metroAddNewEmployee";
            this.metroAddNewEmployee.Size = new System.Drawing.Size(103, 23);
            this.metroAddNewEmployee.TabIndex = 5;
            this.metroAddNewEmployee.Text = "Add Employee";
            this.metroAddNewEmployee.Click += new System.EventHandler(this.metroAddNewEmployee_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(502, 254);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "City";
            this.metroTextBox1.Size = new System.Drawing.Size(228, 23);
            this.metroTextBox1.TabIndex = 2;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(430, 200);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Address";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(430, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Number";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(430, 138);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(430, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Surname";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(430, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Name";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ImportPicture);
            this.groupBox9.Controls.Add(this.PatiantPic);
            this.groupBox9.Controls.Add(this.TextBoxPicLoc);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Location = new System.Drawing.Point(23, 80);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(369, 228);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Employee Picuter";
            // 
            // ImportPicture
            // 
            this.ImportPicture.Location = new System.Drawing.Point(272, 197);
            this.ImportPicture.Name = "ImportPicture";
            this.ImportPicture.Size = new System.Drawing.Size(91, 23);
            this.ImportPicture.TabIndex = 18;
            this.ImportPicture.Text = "Import Image";
            this.ImportPicture.UseVisualStyleBackColor = true;
            // 
            // PatiantPic
            // 
            this.PatiantPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatiantPic.Location = new System.Drawing.Point(63, 19);
            this.PatiantPic.Name = "PatiantPic";
            this.PatiantPic.Size = new System.Drawing.Size(206, 177);
            this.PatiantPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatiantPic.TabIndex = 17;
            this.PatiantPic.TabStop = false;
            // 
            // TextBoxPicLoc
            // 
            this.TextBoxPicLoc.Location = new System.Drawing.Point(63, 197);
            this.TextBoxPicLoc.Name = "TextBoxPicLoc";
            this.TextBoxPicLoc.Size = new System.Drawing.Size(206, 20);
            this.TextBoxPicLoc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "File Name";
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 397);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroAddNewEmployee);
            this.Controls.Add(this.CloseNewEmployeesFrom);
            this.Controls.Add(this.EmployeePosition);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.EmployeePhoneNumber);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.EmployeesAddress2);
            this.Controls.Add(this.EmployeesAddress1);
            this.Controls.Add(this.EmployeePassword);
            this.Controls.Add(this.EmployeeSurname);
            this.Controls.Add(this.EmployeeName);
            this.Name = "NewEmployeeForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatiantPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox EmployeeName;
        private MetroFramework.Controls.MetroTextBox EmployeeSurname;
        private MetroFramework.Controls.MetroTextBox EmployeePassword;
        private MetroFramework.Controls.MetroTextBox EmployeesAddress1;
        private MetroFramework.Controls.MetroTextBox EmployeePhoneNumber;
        private MetroFramework.Controls.MetroTextBox EmployeesAddress2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox EmployeePosition;
        private MetroFramework.Controls.MetroButton CloseNewEmployeesFrom;
        private MetroFramework.Controls.MetroButton metroAddNewEmployee;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button ImportPicture;
        private System.Windows.Forms.PictureBox PatiantPic;
        private System.Windows.Forms.TextBox TextBoxPicLoc;
        private System.Windows.Forms.Label label7;
    }
}