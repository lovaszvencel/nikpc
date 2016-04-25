using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class ProductController : Bindable, IProductListViewHandler, IProductViewHandler
    {
        public static ObservableCollection<Product> AllProducts = new ObservableCollection<Product>();
        public static ObservableCollection<Product> FilteredProducts = new ObservableCollection<Product>();
        public static ObservableCollection<ProductCategory> AllCategories = new ObservableCollection<ProductCategory>();        

        public void ViewSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo)
        {
            FilteredProducts.Clear();
            foreach (Product p in AllProducts)
        {
                if ((p.Name.ToLower().Contains(productName.ToLower()) || productName == "") && (productCategory == null || p.CategoryID == productCategory.Id) && (p.Price > priceFrom) && (p.Price < priceTo || priceTo == 0))
                    FilteredProducts.Add(p);
            }
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

            // db.Product.Find(product.Id).Stock = product.Stock - 1;
            //db.Product.Find(product.Id).Stock = db.Product.Find(product.Id).Stock - 1;
            UserController.currentUser.Cart.Add(new ProductInCart(product));

            /*int i = 0;
            while (i < UserController.currentUser.Cart.Count && !UserController.currentUser.Cart[i].Product.Equals(product))
                i++;
            if (i < UserController.currentUser.Cart.Count)
                UserController.currentUser.Cart[i].Quantity++;
            else
                UserController.currentUser.Cart.Add(new ProductInCart(product));*/
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
