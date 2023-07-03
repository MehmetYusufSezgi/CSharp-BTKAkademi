using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EntityFrameworkDemo
{
    public class ProductDbContext : DbContext
    {
        public DbSet<ProductProperty> ProductProperties { get; set; }
    }
}
