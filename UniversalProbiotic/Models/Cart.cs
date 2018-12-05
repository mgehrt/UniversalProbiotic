using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversalProbiotic.Models
{
    public class Cart
    {
        public int CartID { get; set; }

        public decimal OrderTotal { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}