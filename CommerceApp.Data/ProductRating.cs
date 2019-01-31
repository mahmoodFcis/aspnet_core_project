using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Data
{
    public class ProductRating
    {
        public int ID { get; set; }
        public  Product Product { get; set; }
        public int Rating { get; set; }
    }
}
