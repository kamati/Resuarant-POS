namespace MetroTest
{
    partial class OrderManagment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBox1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTileLiquors = new MetroFramework.Controls.MetroTile();
            this.metroTileBevarages = new MetroFramework.Controls.MetroTile();
            this.metroTilePizza = new MetroFramework.Controls.MetroTile();
            this.metroTilePLatters = new MetroFramework.Controls.MetroTile();
            this.metroTileBeer = new MetroFramework.Controls.MetroTile();
            this.metroTileWine = new MetroFramework.Controls.MetroTile();
            this.metroTileBreakFast = new MetroFramework.Controls.MetroTile();
            this.metroTileDesserts = new MetroFramework.Controls.MetroTile();
            this.metroTileBurgers = new MetroFramework.Controls.MetroTile();
            this.metroTileSalad = new MetroFramework.Controls.MetroTile();
            this.metroTileChicken = new MetroFramework.Controls.MetroTile();
            this.metroTileFromTheGril = new MetroFramework.Controls.MetroTile();
            this.metroTileStarters = new MetroFramework.Controls.MetroTile();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTableName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroTextBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 474);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Total";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridViewBill);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(397, 89);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(454, 502);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OPrice,
            this.Column1,
            this.Column2});
            this.dataGridViewBill.GridColor = System.Drawing.Color.Chartreuse;
            this.dataGridViewBill.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(445, 461);
            this.dataGridViewBill.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // OPrice
            // 
            this.OPrice.HeaderText = "Order Name";
            this.OPrice.Name = "OPrice";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Price";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Added";
            this.Column2.Name = "Column2";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(45, 470);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(403, 23);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Text = "metroTextBox2";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTileLiquors);
            this.metroPanel2.Controls.Add(this.metroTileBevarages);
            this.metroPanel2.Controls.Add(this.metroTilePizza);
            this.metroPanel2.Controls.Add(this.metroTilePLatters);
            this.metroPanel2.Controls.Add(this.metroTileBeer);
            this.metroPanel2.Controls.Add(this.metroTileWine);
            this.metroPanel2.Controls.Add(this.metroTileBreakFast);
            this.metroPanel2.Controls.Add(this.metroTileDesserts);
            this.metroPanel2.Controls.Add(this.metroTileBurgers);
            this.metroPanel2.Controls.Add(this.metroTileSalad);
            this.metroPanel2.Controls.Add(this.metroTileChicken);
            this.metroPanel2.Controls.Add(this.metroTileFromTheGril);
            this.metroPanel2.Controls.Add(this.metroTileStarters);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 89);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(368, 502);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTileLiquors
            // 
            this.metroTileLiquors.Location = new System.Drawing.Point(113, 363);
            this.metroTileLiquors.Name = "metroTileLiquors";
            this.metroTileLiquors.Size = new System.Drawing.Size(104, 60);
            this.metroTileLiquors.TabIndex = 15;
            this.metroTileLiquors.Text = "Liquors";
            // 
            // metroTileBevarages
            // 
            this.metroTileBevarages.Location = new System.Drawing.Point(113, 306);
            this.metroTileBevarages.Name = "metroTileBevarages";
            this.metroTileBevarages.Size = new System.Drawing.Size(104, 51);
            this.metroTileBevarages.TabIndex = 14;
            this.metroTileBevarages.Text = "Bevarages";
            // 
            // metroTilePizza
            // 
            this.metroTilePizza.Location = new System.Drawing.Point(223, 306);
            this.metroTilePizza.Name = "metroTilePizza";
            this.metroTilePizza.Size = new System.Drawing.Size(139, 117);
            this.metroTilePizza.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTilePizza.TabIndex = 13;
            this.metroTilePizza.Text = "Pizza";
            // 
            // metroTilePLatters
            // 
            this.metroTilePLatters.Location = new System.Drawing.Point(113, 231);
            this.metroTilePLatters.Name = "metroTilePLatters";
            this.metroTilePLatters.Size = new System.Drawing.Size(249, 69);
            this.metroTilePLatters.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTilePLatters.TabIndex = 12;
            this.metroTilePLatters.Text = "Platters";
            // 
            // metroTileBeer
            // 
            this.metroTileBeer.Location = new System.Drawing.Point(3, 429);
            this.metroTileBeer.Name = "metroTileBeer";
            this.metroTileBeer.Size = new System.Drawing.Size(359, 69);
            this.metroTileBeer.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileBeer.TabIndex = 11;
            this.metroTileBeer.Text = "Beer";
            // 
            // metroTileWine
            // 
            this.metroTileWine.Location = new System.Drawing.Point(3, 231);
            this.metroTileWine.Name = "metroTileWine";
            this.metroTileWine.Size = new System.Drawing.Size(104, 192);
            this.metroTileWine.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileWine.TabIndex = 10;
            this.metroTileWine.Text = "Wines";
            // 
            // metroTileBreakFast
            // 
            this.metroTileBreakFast.Location = new System.Drawing.Point(223, 156);
            this.metroTileBreakFast.Name = "metroTileBreakFast";
            this.metroTileBreakFast.Size = new System.Drawing.Size(139, 69);
            this.metroTileBreakFast.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTileBreakFast.TabIndex = 9;
            this.metroTileBreakFast.Text = "Breakfast";
            // 
            // metroTileDesserts
            // 
            this.metroTileDesserts.Location = new System.Drawing.Point(113, 156);
            this.metroTileDesserts.Name = "metroTileDesserts";
            this.metroTileDesserts.Size = new System.Drawing.Size(104, 69);
            this.metroTileDesserts.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileDesserts.TabIndex = 8;
            this.metroTileDesserts.Text = "Desserts";
            // 
            // metroTileBurgers
            // 
            this.metroTileBurgers.Location = new System.Drawing.Point(3, 156);
            this.metroTileBurgers.Name = "metroTileBurgers";
            this.metroTileBurgers.Size = new System.Drawing.Size(104, 69);
            this.metroTileBurgers.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileBurgers.TabIndex = 7;
            this.metroTileBurgers.Text = "Burgers";
            // 
            // metroTileSalad
            // 
            this.metroTileSalad.Location = new System.Drawing.Point(223, 81);
            this.metroTileSalad.Name = "metroTileSalad";
            this.metroTileSalad.Size = new System.Drawing.Size(139, 69);
            this.metroTileSalad.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileSalad.TabIndex = 6;
            this.metroTileSalad.Text = "Salads";
            // 
            // metroTileChicken
            // 
            this.metroTileChicken.Location = new System.Drawing.Point(3, 81);
            this.metroTileChicken.Name = "metroTileChicken";
            this.metroTileChicken.Size = new System.Drawing.Size(214, 69);
            this.metroTileChicken.TabIndex = 5;
            this.metroTileChicken.Text = "Chicken";
            // 
            // metroTileFromTheGril
            // 
            this.metroTileFromTheGril.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroTileFromTheGril.Location = new System.Drawing.Point(113, 6);
            this.metroTileFromTheGril.Name = "metroTileFromTheGril";
            this.metroTileFromTheGril.Size = new System.Drawing.Size(249, 69);
            this.metroTileFromTheGril.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTileFromTheGril.TabIndex = 4;
            this.metroTileFromTheGril.Text = "From The Grid";
            this.metroTileFromTheGril.Click += new System.EventHandler(this.metroTileFromTheGril_Click);
            // 
            // metroTileStarters
            // 
            this.metroTileStarters.Location = new System.Drawing.Point(3, 6);
            this.metroTileStarters.Name = "metroTileStarters";
            this.metroTileStarters.Size = new System.Drawing.Size(104, 69);
            this.metroTileStarters.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTileStarters.TabIndex = 2;
            this.metroTileStarters.Text = "Starters";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTableName.Location = new System.Drawing.Point(347, 39);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(129, 47);
            this.labelTableName.TabIndex = 4;
            this.labelTableName.Text = "Table 1";
            // 
            // OrderManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 636);
            this.Controls.Add(this.labelTableName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "OrderManagment";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.OrderManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroTextBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile metroTileLiquors;
        private MetroFramework.Controls.MetroTile metroTileBevarages;
        private MetroFramework.Controls.MetroTile metroTilePizza;
        private MetroFramework.Controls.MetroTile metroTilePLatters;
        private MetroFramework.Controls.MetroTile metroTileBeer;
        private MetroFramework.Controls.MetroTile metroTileWine;
        private MetroFramework.Controls.MetroTile metroTileBreakFast;
        private MetroFramework.Controls.MetroTile metroTileDesserts;
        private MetroFramework.Controls.MetroTile metroTileBurgers;
        private MetroFramework.Controls.MetroTile metroTileSalad;
        private MetroFramework.Controls.MetroTile metroTileChicken;
        private MetroFramework.Controls.MetroTile metroTileFromTheGril;
        private MetroFramework.Controls.MetroTile metroTileStarters;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Label labelTableName;
    }
}