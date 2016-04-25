using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Nikpc.Controllers
{
    class ProductController : IProductListViewHandler, IProductViewHandler, IValueConverter
    {
        public static ObservableCollection<Product> AllProducts = new ObservableCollection<Product>();
        public static ObservableCollection<Product> FilteredProducts = new ObservableCollection<Product>();
        public static ObservableCollection<ProductCategory> AllCategories = new ObservableCollection<ProductCategory>();
        nikpcEntities1 db = new nikpcEntities1();
        public void ViewSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo)
        {
            FilteredProducts.Clear();
            foreach (Product p in AllProducts)
        {
                if ((p.Name.ToLower().Contains(productName.ToLower()) || productName == "") && (productCategory == null || p.CategoryID == productCategory.Id) && (p.Price > priceFrom) && (p.Price < priceTo || priceTo == 0))
                    FilteredProducts.Add(p);
            }
        }
        
        // TODO sort
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

        public void ReserveProduct(ProductInCart productInCart)
        {
            db.Product.Find(productInCart.Product.Id).Stock -= productInCart.Quantity;
            db.SaveChanges();
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((int)value == 0)
                return "-";
            int id = (int)value;            
            return db.ProductCategory.Find(id).Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
