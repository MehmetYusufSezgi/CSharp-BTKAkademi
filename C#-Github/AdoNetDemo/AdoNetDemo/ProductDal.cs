using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    internal class ProductDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TABLEPRODUCTS",_sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    ProductName = Convert.ToString(sqlDataReader["ProductName"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    ProductPrice = Convert.ToDecimal(sqlDataReader["ProductPrice"])
                };
                products.Add(product);
            }

            sqlDataReader.Close();
            _sqlConnection.Close();
            return products;
        }

        public DataTable GetAll2()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TABLEPRODUCTS", _sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            _sqlConnection.Close();
            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TABLEPRODUCTS VALUES(@ProductName, @ProductPrice, @StockAmount)",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
            sqlCommand.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
            sqlCommand.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("UPDATE TABLEPRODUCTS SET ProductName = @ProductName, ProductPrice = @ProductPrice, StockAmount = @StockAmount WHERE Id = @Id", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
            sqlCommand.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
            sqlCommand.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@Id", product.Id);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void ConnectionControl()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }
    }
}
