using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListViewHandler
    {
        void ViewSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo, bool available);
        void ListAddProductToCart(Product product);
        void ListDeleteProductFromCart(Product product);
        void ViewSortProducts(string sortByParameter, bool ascending);
    }
}
