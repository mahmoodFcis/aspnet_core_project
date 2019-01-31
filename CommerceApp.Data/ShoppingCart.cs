using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Data
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime CreationDate { get; set; }
        public CartStatus Status { get; set; }
    }
}

namespace CommerceApp.Data
{
    public enum CartStatus
    {
        Open,Expired,Wishlisted
    }
}