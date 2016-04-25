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
    public class ProductAdministrationController: IProductHandler, IProductListHandler
    {
        nikpcEntities1 db;

        public ProductAdministrationController()
        {
            db = new nikpcEntities1();
            
        }

        public void ModifyProduct(Product oldProduct, Product newProductData)
        {
            ProductController.AllProducts.Remove(oldProduct);
            
            db.Product.Remove(db.Product.Find(oldProduct.Id));
            db.Product.Add(newProductData);
            db.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            ProductController.AllProducts.Remove(product);
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
            ProductController.AllProducts.Add(product);
            db.Product.Add(product);
            db.SaveChanges();
        }
    }
}
