using System;
using System.Collections.Generic;

namespace CommerceApp.DbFirst.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetail = new HashSet<OrderDetail>();
            ProductRating = new HashSet<ProductRating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public string ImageUrl { get; set; }

        public Categories Category { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public ICollection<ProductRating> ProductRating { get; set; }
    }
}
