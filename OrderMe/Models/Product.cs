using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Models
{
    public class Product
    {
        [Key]
        public string SKU { get; set; }

        public string ProductName { get; set; }

        public ProductCategory Category { get; set; }
    }
}
