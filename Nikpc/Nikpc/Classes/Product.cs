using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Classes
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool Available { get; set; }
        public double RatingAverage { get; set; }
        public int OnSale { get; set; }
    
        public List<OrderedProduct> OrderedProducts { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Product()
        {
            OrderedProducts = new List<OrderedProduct>();
        }
    }
    }
}
