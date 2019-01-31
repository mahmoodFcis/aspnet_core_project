using System;
using System.Collections.Generic;

namespace CommerceApp.Data
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<ShoppingCart> Carts { get; set; }
    }
}
