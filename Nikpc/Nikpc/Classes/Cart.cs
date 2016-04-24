
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Classes
{
    public class Cart
    {
        public User User { get; set; }
        public List<Product> Products { get; set; }

        public Cart(User user)
        {
            Products = new List<Product>();
        }
    }
}