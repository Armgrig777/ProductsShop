namespace ProductsShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ProductListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabPage2 = new TabPage();
            ShopListView = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            AddProductBtn = new Button();
            label1 = new Label();
            EditProductBtn = new Button();
            comboBox1 = new ComboBox();
            AddShopBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(AddProductBtn);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(EditProductBtn);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(AddShopBtn);
            splitContainer1.Size = new Size(675, 450);
            splitContainer1.SplitterDistance = 352;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(348, 446);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ProductListView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(340, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProductListView
            // 
            ProductListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            ProductListView.Dock = DockStyle.Fill;
            ProductListView.GridLines = true;
            ProductListView.Location = new Point(3, 3);
            ProductListView.Name = "ProductListView";
            ProductListView.Size = new Size(334, 412);
            ProductListView.TabIndex = 12;
            ProductListView.UseCompatibleStateImageBehavior = false;
            ProductListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Count";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Shop";
            columnHeader5.Width = 100;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ShopListView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(340, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sellers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShopListView
            // 
            ShopListView.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
            ShopListView.Dock = DockStyle.Fill;
            ShopListView.GridLines = true;
            ShopListView.Location = new Point(3, 3);
            ShopListView.Name = "ShopListView";
            ShopListView.Size = new Size(334, 412);
            ShopListView.TabIndex = 0;
            ShopListView.UseCompatibleStateImageBehavior = false;
            ShopListView.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            columnHeader6.Width = 35;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Seller Name";
            columnHeader7.Width = 180;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(13, 362);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(138, 38);
            AddProductBtn.TabIndex = 7;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 11;
            label1.Text = "Filter By Shop";
            // 
            // EditProductBtn
            // 
            EditProductBtn.Location = new Point(167, 362);
            EditProductBtn.Name = "EditProductBtn";
            EditProductBtn.Size = new Size(138, 38);
            EditProductBtn.TabIndex = 8;
            EditProductBtn.Text = "Edit Product";
            EditProductBtn.UseVisualStyleBackColor = true;
            EditProductBtn.Click += EditProductBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 23);
            comboBox1.TabIndex = 10;
            // 
            // AddShopBtn
            // 
            AddShopBtn.Location = new Point(167, 38);
            AddShopBtn.Name = "AddShopBtn";
            AddShopBtn.Size = new Size(138, 23);
            AddShopBtn.TabIndex = 9;
            AddShopBtn.Text = "Add Seller";
            AddShopBtn.UseVisualStyleBackColor = true;
            AddShopBtn.Click += AddShopBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(675, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView ProductListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button AddProductBtn;
        private Label label1;
        private Button EditProductBtn;
        private ComboBox comboBox1;
        private Button AddShopBtn;
        private ColumnHeader columnHeader5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView ShopListView;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}