using System;
using System.Collections.Generic;

namespace CommerceApp.DbFirst.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int Qty { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}
