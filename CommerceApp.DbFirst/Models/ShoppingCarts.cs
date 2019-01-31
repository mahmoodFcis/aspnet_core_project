using System;
using System.Collections.Generic;

namespace CommerceApp.DbFirst.Models
{
    public partial class ShoppingCarts
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }

        public Customers Customer { get; set; }
    }
}
