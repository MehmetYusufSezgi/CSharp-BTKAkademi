using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL _productDAL = new ProductDAL();
        private void LoadProducts()
        {
            dgwUrunler.DataSource = _productDAL.ListProduct();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            DataGridViewColumn idColumn = dgwUrunler.Columns[0];
            idColumn.Visible = false;
        }

        private void dgwUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            _productDAL.AddProduct(new ProductProperty
            {
                ProductName = txtbAd.Text,
                ProductPrice = Convert.ToDecimal(txtbFiyat.Text),
                ProductAmount = Convert.ToInt32(txtbAdet.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün eklendi!");
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            _productDAL.UpdateProduct(new ProductProperty
            {
                Id = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value),
                ProductName = txtbAdUpdate.Text,
                ProductPrice = Convert.ToDecimal(txtbFiyatUpdate.Text),
                ProductAmount = Convert.ToInt32(txtbAdetUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün güncellendi!");
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbAdUpdate.Text = dgwUrunler.CurrentRow.Cells[1].Value.ToString();
            txtbFiyatUpdate.Text = dgwUrunler.CurrentRow.Cells[2].Value.ToString();
            txtbAdetUpdate.Text = dgwUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            _productDAL.DeleteProduct(new ProductProperty
            {
                Id = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Ürün silindi");
        }
    }
}
