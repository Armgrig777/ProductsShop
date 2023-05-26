using ProductsShop.Data.Context;
using ProductsShop.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsShop
{
    public partial class FormEditProducts : Form
    {
        Product Product;
        public FormEditProducts()
        {
            InitializeComponent();
        }
        public FormEditProducts(Product product)
        {
            Product = product;

            using (ProductsRepo products = new ProductsRepo())
            {
                textBox1.Text = product.Name;
                textBox2.Text = product.Price.ToString();
                textBox3.Text = product.Ammount.ToString();
                comboBoxAdd.SelectedItem = product.ShopID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ProductsRepo products = new ProductsRepo())
            {

                Product.Name = textBox1.Text;
                Product.Price = Decimal.Parse(textBox2.Text);
                Product.Ammount = int.Parse(textBox3.Text);
                Product.ShopID = Convert.ToInt32(comboBoxAdd.SelectedValue);
                products.Update(Product);
                products.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormEditProducts_Load(object sender, EventArgs e)
        {
            using(ProductsRepo shops = new ProductsRepo())
            {
                var shop = shops.Shop.ToList();
                comboBoxAdd.DataSource = shop;
                comboBoxAdd.DisplayMember = "Name";
                comboBoxAdd.ValueMember="Id";
            }
        }
    }
}
