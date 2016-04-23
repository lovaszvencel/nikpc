using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public int Total { get; set; }
        public bool Delivery { get; set; }
        public string DeliveryAddress { get; set; }
        public string PaymentMethod { get; set; }

        public List<Invoice> Invoices { get; set; }
        public User User { get; set; }
        public List<OrderedProduct> OrderedProducts { get; set; }

        public Order()
        {
            Invoices = new List<Invoice>();
            OrderedProducts = new List<OrderedProduct>();
        }
    }
}
