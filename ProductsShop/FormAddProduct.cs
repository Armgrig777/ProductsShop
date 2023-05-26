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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProductsShop
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ProductsRepo products = new ProductsRepo())
            {
                var product = new Product();
                product.Name = textBox1.Text;
                product.Price = Decimal.Parse(textBox2.Text);
                product.Ammount = int.Parse(textBox3.Text);
                product.ShopID = Convert.ToInt32(comboBoxAdd.SelectedValue);
                products.Add(product);
                products.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            using (ProductsRepo db = new ProductsRepo())
            {

                var supplyers = db.Shop.ToList();
                comboBoxAdd.DataSource = supplyers;
                comboBoxAdd.DisplayMember = "Name";
                comboBoxAdd.ValueMember = "Id";
            }
        }
    }
}
