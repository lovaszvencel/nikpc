using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListHandler
    {
        void SearchProduct(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available);
        void SortProducts(string sortByParameter, bool ascending);
        void AddProduct(Classes.Product product);
    }
}
