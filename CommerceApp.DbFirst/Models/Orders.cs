using System;
using System.Collections.Generic;

namespace CommerceApp.DbFirst.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public decimal Net { get; set; }
        public int Status { get; set; }
        public int? CustomerId { get; set; }

        public Customers Customer { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
