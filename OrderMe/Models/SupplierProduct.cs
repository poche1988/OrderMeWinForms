using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Models
{
    public class SupplierProduct
    {
        public int SupplierProductId { get; set; }

        public Product Product { get; set; }

        public Supplier Supplier { get; set; }
    }
}
