using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class ProductController : IProductListViewHandler, IProductViewHandler
    {
        public void ViewSearchProduct(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {
            throw new NotImplementedException();
        }

        public void ListAddProductToCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public void ListDeleteProductFromCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public void ViewSortProducts(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }

        public void AddProductRating(int value, string review)
        {
            throw new NotImplementedException();
        }

        public void OpenProductImage(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public void AddProductToCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFromCart(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static int GetStock()
        {
            throw new NotImplementedException();
        }

        public static void ReserveProduct(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void ListProducts()
        {
            throw new NotImplementedException();
        }

        public static void ViewProduct()
        {
            throw new NotImplementedException();
        }






    }
}
