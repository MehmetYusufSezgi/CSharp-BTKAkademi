using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EntityFrameworkDemo
{
    public class ProductDAL
    {
        public List<ProductProperty> ListProduct()
        {
            using(ProductDbContext db = new ProductDbContext())
            {
                return db.ProductProperties.ToList();
            }
        }
        public void AddProduct(ProductProperty productProperty) 
        {
            using(ProductDbContext db = new ProductDbContext())
            {
                var entity = db.Entry(productProperty);
                entity.State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public void DeleteProduct(ProductProperty productProperty)
        {
            using(ProductDbContext db = new ProductDbContext())
            {
                var entity = db.Entry(productProperty);
                entity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void UpdateProduct(ProductProperty productProperty)
        {
            using(ProductDbContext db = new ProductDbContext())
            {
                var entity = db.Entry(productProperty);
                entity.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
