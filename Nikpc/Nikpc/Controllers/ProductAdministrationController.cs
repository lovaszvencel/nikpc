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
    public class ProductAdministrationController: Bindable, IProductHandler, IProductListHandler
    {
        nikpcEntities1 db;
        public ObservableCollection<Product> AllProducts { get; set; }
        public ObservableCollection<Product> FilteredProducts { get; set; }

        public ProductAdministrationController()
        {
            db = new nikpcEntities1();
            AllProducts = new ObservableCollection<Product>();
            FilteredProducts = new ObservableCollection<Product>();
            Feltolt();
        }

        private void Feltolt()
        {
            var products = from akt in db.Product
                           select akt;
            foreach (var item in products)
            {
                AllProducts.Add(item);
                FilteredProducts.Add(item);
            }
        }

        public void ModifyProduct(Product oldProduct, Product newProductData)
        {
            db.Product.Remove(db.Product.Find(oldProduct.Id));
            db.Product.Add(newProductData);
            db.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            AllProducts.Remove(product);
            OnPropertyChanged("AllUsers");
            db.Product.Remove(db.Product.Find(product.Id));
            db.SaveChanges();
        }

        public bool ReserveProduct(Product product, int quantity)
        {
            // TODO adatbázisban kell ehhez módosítani?
            return true;
        }

        public void AdminSearchProduct(string productName, ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {
            //mod FilteredProducts
        }

        public void AdminSortProducts(string sortByParameter, bool ascending)
        {
            //mod FilteredProducts
        }

        public void AddProduct(Product product)
        {
            AllProducts.Add(product);
            OnPropertyChanged("AllProducts");
            db.Product.Add(product);
            db.SaveChanges();
        }
    }
}
