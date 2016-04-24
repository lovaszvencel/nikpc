using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListHandler
    {
        void AdminSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo, bool available);
        void AdminSortProducts(string sortByParameter, bool ascending);
        void AddProduct(Product product);
    }
}
