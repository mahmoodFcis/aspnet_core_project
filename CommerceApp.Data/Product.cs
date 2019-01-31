using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommerceApp.Data
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
       
        public Category Category { get; set; }
        public List<ProductRating> Ratings { get; set; }
        public string ImageUrl { get; set; }

    }
}
