using System;
using System.Collections.Generic;
using System.Text;

namespace BalbaaShoppingCart
{
    public class Product
    {
        public string Description { get; set; }
        public double Cost { get; set; }
        public int NumberOrdered { get; set; }
        public Product(string description, double cost)
        {
            Description = description;
            Cost = cost;
        }
    }
}
