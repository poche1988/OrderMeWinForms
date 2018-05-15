using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new Collection<OrderDetail>();
        }
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public string Company { get; set; }

        public string Contact { get; set; }

        public OrderState OrderStatus { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public void AddDetail(OrderDetail od)
        {
            od.Order = this;
            OrderDetails.Add(od);
        }
    }

    

    public enum OrderState
    {
        Created,
        Sent
    }
}
