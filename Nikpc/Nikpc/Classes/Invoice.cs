using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }

        public Order Order { get; set; }

        public Invoice()
        {

        }
    }
}
