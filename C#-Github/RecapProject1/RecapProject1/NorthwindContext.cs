﻿using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{
    public class NorthwindContext:DbContext
    { 
        public DbSet<Product> Products { get; set; } //The product class is the "Products" table in the db (No mapping)
        public DbSet<Category> Categories { get; set; }    
    }
}
