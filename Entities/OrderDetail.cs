using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; } // Primary Key
        public int OrderId { get; set; } // Foreign Key
        public int ProductId { get; set; } // Foreign Key
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation properties (optional, if you are using Entity Framework)
        public CustomerOrder Order { get; set; } // Reference to CustomerOrder
                                                 // public Product Product { get; set; } // Uncomment if you have a Product class
    }
}
