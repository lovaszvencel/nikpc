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
        public static List<Product> productList = new List<Product>();
        public static List<ProductCategory> categoryList = new List<ProductCategory>();

        public void ViewSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo, bool available)
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

        public void OpenProductImage(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddProductToCart(Product product)
        {
            int i = 0;
            while (i < UserController.currentUser.Cart.Count && !UserController.currentUser.Cart[i].Product.Equals(product))
                i++;
            if (i < UserController.currentUser.Cart.Count)
                UserController.currentUser.Cart[i].Quantity++;
            else
                UserController.currentUser.Cart.Add(new ProductInCart(product));
        }
        
        public static int GetStock()
        {
            throw new NotImplementedException();
        }

        public static void ReserveProduct(Product product)
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
