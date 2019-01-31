using CommerceApp.Data;
using System;
using System.Collections;

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

        public void AddRange(ICollection products)
        {
            db.AddRange(products);
            db.SaveChanges();

            
        }
    }
}
