using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversalProbiotic.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public decimal Price { get; set; }

        public string PictureType { get; set; }

        public byte[] PictureData { get; set; }
    }
}