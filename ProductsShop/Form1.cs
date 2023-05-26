using ProductsShop.Data.Context;
using ProductsShop.Data.Data;
using System.Data;
using System.Linq;

namespace ProductsShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
            UpdateCombo();
        }
        private void UpdateCombo()
        {
            using (ProductsRepo repo = new ProductsRepo())
            {
                var combo = repo.Shop.ToList();
                comboBox1.DataSource = combo;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                //comboBox1.Items.Insert(-1, "");
            }
        }


        private void UpdateListBox()
        {
            ProductListView.Items.Clear();
            ShopListView.Items.Clear();
            using (ProductsRepo db = new ProductsRepo())
            {

                var products = db.Products;
                var shops = db.Shop;

                foreach (var product in products)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        product.Id.ToString(),
                        product.Name,
                        product.Price.ToString(),
                        product.Ammount.ToString(),
                        product.ShopID.ToString(),
                    });
                    ProductListView.Items.Add(item);
                }
                foreach (var shop in shops)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                       shop.Id.ToString(),
                       shop.Name,
                    });
                    ShopListView.Items.Add(item);

                }
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            FormAddProduct formAdd = new FormAddProduct();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Product Added!");
            }
            UpdateListBox();

        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Item To Edit");
            }
            int id = int.Parse(ProductListView.SelectedItems[0].SubItems[0].Text);
            Product product = new Product();
            using (ProductsRepo db = new ProductsRepo())
            {

                product = db.Products.Where(c => c.Id == id).FirstOrDefault();
            }

            FormEditProducts formAdd = new FormEditProducts(product);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Product Edited!");
            }
            UpdateListBox();
        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            FormShopeAddEdit formShope = new FormShopeAddEdit();
            if (formShope.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Shop Added");
            }
            UpdateListBox();

        }
    }
}