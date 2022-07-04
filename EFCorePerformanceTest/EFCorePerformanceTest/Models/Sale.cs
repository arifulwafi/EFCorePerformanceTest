using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePerformanceTest.Models
{
    public class Sale
    {
        [Key]
        public int SalesID { get; set; }

        public int SalesPersonID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee SalesPerson { get; set; }
    }
}
