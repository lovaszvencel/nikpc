using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Classes
{
    class Product
    {
        public Product()
        {
            OrderedProducts = new List<OrderedProduct>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool Available { get; set; }
        public Nullable<double> RatingAverage { get; set; }
        public Nullable<int> OnSale { get; set; }
    
        public List<OrderedProduct> OrderedProducts { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
    }
}
