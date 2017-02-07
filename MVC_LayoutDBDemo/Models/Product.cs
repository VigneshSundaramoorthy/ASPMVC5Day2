using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_LayoutDBDemo.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public double? Price { get; set; }
    }
}