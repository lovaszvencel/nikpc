using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListViewHandler
    {
        void ViewSearchProduct(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available);
        void ListAddProductToCart(Classes.Product product);
        void ListDeleteProductFromCart(Classes.Product product);
        void ViewSortProducts(string sortByParameter, bool ascending);
    }
}
