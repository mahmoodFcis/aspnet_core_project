using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Data
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public  Order Order{get;set;}
        public  Product Product { get; set; }
        public int Qty { get; set; }
    }
}
