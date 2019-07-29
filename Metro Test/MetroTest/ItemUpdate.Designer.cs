namespace MetroTest
{
    partial class ItemUpdate
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.UpdateItemButton = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ItemTypeComb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 201);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(290, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Location = new System.Drawing.Point(239, 262);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(121, 23);
            this.UpdateItemButton.TabIndex = 20;
            this.UpdateItemButton.Text = "Add";
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(366, 262);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(121, 23);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(78, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Stock Count";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(165, 168);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(289, 23);
            this.TextBoxPrice.TabIndex = 17;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Item Price";
            // 
            // TextBoxItemName
            // 
            this.TextBoxItemName.Location = new System.Drawing.Point(166, 129);
            this.TextBoxItemName.Name = "TextBoxItemName";
            this.TextBoxItemName.Size = new System.Drawing.Size(289, 23);
            this.TextBoxItemName.TabIndex = 15;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(79, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Item Name";
            // 
            // ItemTypeComb
            // 
            this.ItemTypeComb.FormattingEnabled = true;
            this.ItemTypeComb.ItemHeight = 23;
            this.ItemTypeComb.Location = new System.Drawing.Point(166, 92);
            this.ItemTypeComb.Name = "ItemTypeComb";
            this.ItemTypeComb.Size = new System.Drawing.Size(289, 29);
            this.ItemTypeComb.TabIndex = 13;
            this.ItemTypeComb.SelectedIndexChanged += new System.EventHandler(this.ItemTypeComb_SelectedIndexChanged);
            this.ItemTypeComb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemTypeComb_MouseClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(79, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Item Type";
            // 
            // ItemUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 300);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.UpdateItemButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TextBoxItemName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ItemTypeComb);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ItemUpdate";
            this.Text = "Item Update";
            this.Load += new System.EventHandler(this.ItemUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroButton UpdateItemButton;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TextBoxPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TextBoxItemName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ItemTypeComb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}