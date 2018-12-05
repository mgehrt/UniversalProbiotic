using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversalProbiotic.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int OrderQuantity { get; set; }

        public int ProductID { get; set; }

        public decimal OrderTotal { get; set; }

        public virtual Product Product { get; set; }

    }
}