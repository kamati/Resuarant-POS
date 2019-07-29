namespace MetroTest
{
    partial class NewTable
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
            this.metroComboBoxLocation = new MetroFramework.Controls.MetroComboBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddTable = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroComboBoxLocation
            // 
            this.metroComboBoxLocation.FormattingEnabled = true;
            this.metroComboBoxLocation.ItemHeight = 23;
            this.metroComboBoxLocation.Items.AddRange(new object[] {
            "Inside",
            "Outside"});
            this.metroComboBoxLocation.Location = new System.Drawing.Point(104, 58);
            this.metroComboBoxLocation.Name = "metroComboBoxLocation";
            this.metroComboBoxLocation.Size = new System.Drawing.Size(252, 29);
            this.metroComboBoxLocation.TabIndex = 0;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(23, 58);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 29);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.Text = "Location";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(104, 93);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(252, 23);
            this.textName.TabIndex = 2;
            this.textName.Text = "Name";
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(23, 87);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(75, 29);
            this.metroLink2.TabIndex = 1;
            this.metroLink2.Text = "Table Name";
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(374, 177);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(123, 23);
            this.metroButtonCancel.TabIndex = 3;
            this.metroButtonCancel.Text = "Cancel";
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // metroButtonAddTable
            // 
            this.metroButtonAddTable.Location = new System.Drawing.Point(245, 177);
            this.metroButtonAddTable.Name = "metroButtonAddTable";
            this.metroButtonAddTable.Size = new System.Drawing.Size(123, 23);
            this.metroButtonAddTable.TabIndex = 3;
            this.metroButtonAddTable.Text = "Add";
            this.metroButtonAddTable.Click += new System.EventHandler(this.metroButtonAddTable_Click);
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 223);
            this.Controls.Add(this.metroButtonAddTable);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroComboBoxLocation);
            this.Name = "NewTable";
            this.Text = "New Table";
            this.Load += new System.EventHandler(this.NewTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxLocation;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonAddTable;
    }
}