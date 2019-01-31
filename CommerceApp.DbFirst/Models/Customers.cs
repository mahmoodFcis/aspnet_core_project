using System;
using System.Collections.Generic;

namespace CommerceApp.DbFirst.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
            ShoppingCarts = new HashSet<ShoppingCarts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<ShoppingCarts> ShoppingCarts { get; set; }
    }
}
