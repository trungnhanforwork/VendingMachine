using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }

        // Optional: Navigation property to the Category
        public Category Category { get; set; } 
    }
}
