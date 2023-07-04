using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gbxSearch_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();

        }
        private void ListProducts()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProducts.DataSource = northwindContext.Products.ToList();
            }
        }
        private void ListProductsByCategoryId(int categoryId)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProducts.DataSource = northwindContext.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                cbxCategory.DataSource = northwindContext.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProducts.DataSource = northwindContext.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSearch.Text))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(txbSearch.Text);
            }
        }
    }
}
