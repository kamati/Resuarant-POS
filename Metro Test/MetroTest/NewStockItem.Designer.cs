namespace MetroTest
{
    partial class NewStockItem
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxItemType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxItemName = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButtonNewStockItem = new MetroFramework.Controls.MetroButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Item Type";
            // 
            // metroComboBoxItemType
            // 
            this.metroComboBoxItemType.FormattingEnabled = true;
            this.metroComboBoxItemType.ItemHeight = 23;
            this.metroComboBoxItemType.Location = new System.Drawing.Point(111, 64);
            this.metroComboBoxItemType.Name = "metroComboBoxItemType";
            this.metroComboBoxItemType.Size = new System.Drawing.Size(289, 29);
            this.metroComboBoxItemType.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Item Name";
            // 
            // TextBoxItemName
            // 
            this.TextBoxItemName.Location = new System.Drawing.Point(111, 101);
            this.TextBoxItemName.Name = "TextBoxItemName";
            this.TextBoxItemName.Size = new System.Drawing.Size(289, 23);
            this.TextBoxItemName.TabIndex = 3;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(110, 140);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(289, 23);
            this.TextBoxPrice.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Item Price";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Stock Count";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(279, 239);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonNewStockItem
            // 
            this.metroButtonNewStockItem.Location = new System.Drawing.Point(152, 239);
            this.metroButtonNewStockItem.Name = "metroButtonNewStockItem";
            this.metroButtonNewStockItem.Size = new System.Drawing.Size(121, 23);
            this.metroButtonNewStockItem.TabIndex = 9;
            this.metroButtonNewStockItem.Text = "Add";
            this.metroButtonNewStockItem.Click += new System.EventHandler(this.metroButtonNewStockItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(110, 173);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(290, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // NewStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 285);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.metroButtonNewStockItem);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TextBoxItemName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBoxItemType);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewStockItem";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "NewStockItem";
            this.Load += new System.EventHandler(this.NewStockItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxItemType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextBoxItemName;
        private MetroFramework.Controls.MetroTextBox TextBoxPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButtonNewStockItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}