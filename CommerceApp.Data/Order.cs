using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Data
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public decimal VAT { get; set; }
        public decimal Discount { get; set; }
        public decimal Net { get; set; }
        public OrderStatus Status { get; set; }
        public  Customer Customer { get; set; }
        public  List<OrderDetail> OrderDetails { get; set; }
    }
}

namespace CommerceApp.Data
{
    public enum OrderStatus
    {
        Open,CheckedOut,Cancelled,Returned
    }
}