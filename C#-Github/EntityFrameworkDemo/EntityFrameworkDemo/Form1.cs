using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txbProductName.Text,
                UnitPrice = Convert.ToDecimal(txbProductPrice.Text),
                StockAmount = Convert.ToInt32(txbStockAmount.Text),
            });
            LoadProducts();
            MessageBox.Show("Ürün Eklendi.");
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            dgwProducts.DataSource = _productDal.GetByName(key);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txbProductNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(txbProductPriceUpdate.Text),
                StockAmount = Convert.ToInt32(txbStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün güncellendi.");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txbProductPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txbStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Ürün silindi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txbSearch.Text);
        }
    }
}
