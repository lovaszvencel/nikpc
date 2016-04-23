using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListViewHandler
    {
        void SearchProduct(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available);
        void AddProductToCart(Classes.Product product);
        void DeleteProductFromCart(Classes.Product product);
        void SortProducts(string sortByParameter, bool ascending);
    }
}
