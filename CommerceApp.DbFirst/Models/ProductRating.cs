using System;
using System.Collections.Generic;

namespace CommerceApp.DbFirst.Models
{
    public partial class ProductRating
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int Rating { get; set; }

        public Products Product { get; set; }
    }
}
