using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                ProductName = txbProductName.Text,
                ProductPrice = Convert.ToDecimal(txbProductPrice.Text),
                StockAmount = Convert.ToInt32(txbStockAmount.Text)
            });
            MessageBox.Show("Product has been added.");
            LoadProducts();
        }
    }
}
