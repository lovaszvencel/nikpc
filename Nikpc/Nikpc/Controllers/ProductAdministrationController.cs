using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class ProductAdministrationController: IProductHandler, IProductListHandler
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
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool ReserveProduct(Product product, int quantity)
        {
            throw new NotImplementedException();
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
            db.Product.Add(product);
            db.SaveChanges();
        }
    }
}
