using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public string Company { get; set; }

        public string Contact { get; set; }
    }
}
