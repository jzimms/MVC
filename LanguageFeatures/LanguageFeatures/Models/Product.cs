using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        private string name;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get { return ProductID + name; } set { name = value; } }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}