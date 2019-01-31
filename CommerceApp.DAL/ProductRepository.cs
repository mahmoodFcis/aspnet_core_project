using CommerceApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CommerceApp.DAL
{
    public class ProductRepository
    {
        CommerceContext db;
        public ProductRepository()
        {
            db = new CommerceContext();
        }
        public void Add(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return db.Products.FromSql<Product>("select * from Products").ToList();
        }
        public void AddRange(ICollection products)
        {
            db.AddRange(products);
            db.SaveChanges();

            
        }
    }
}
