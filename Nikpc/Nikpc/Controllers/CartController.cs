using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class CartController : Interfaces.IProductViewHandler, Interfaces.IProductListViewHandler
    {

        public static void AddProductRating(int value, string review)
        {
            throw new NotImplementedException();
        }

        public static void OpenProductImage(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void AddProductToCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void DeleteProductFromCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void ViewSearchProduct(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {
            throw new NotImplementedException();
        }

        public static void ListAddProductToCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void ListDeleteProductFromCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void ViewSortProducts(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }
    }
}
