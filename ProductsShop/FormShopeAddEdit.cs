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
    public partial class FormShopeAddEdit : Form
    {
        public FormShopeAddEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ProductsRepo repo = new ProductsRepo())
            {
                var shop = new Shop();
                shop.Name = textBox1.Text;
                repo.Add(shop);
                repo.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
