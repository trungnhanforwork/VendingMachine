using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerOrder
    {
        public int OrderId { get; set; } // Primary Key
        public DateTime OrderDate { get; set; } = DateTime.Now; // Default GETDATE()
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending"; // Default 'Pending'
    }
}
