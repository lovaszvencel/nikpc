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
            if(newProductData.ImageURL!="")
            {
                db.Product.Find(oldProduct.Id).ImageURL = newProductData.ImageURL;
                oldProduct.ImageURL = newProductData.ImageURL;
            }
            db.Product.Find(oldProduct.Id).Name = newProductData.Name;
            db.Product.Find(oldProduct.Id).OnSale = newProductData.OnSale;
            db.Product.Find(oldProduct.Id).Price = newProductData.Price;
            db.Product.Find(oldProduct.Id).RatingAverage = newProductData.RatingAverage;
            db.Product.Find(oldProduct.Id).Stock = newProductData.Stock;
            db.Product.Find(oldProduct.Id).CategoryID = newProductData.CategoryID;
            db.Product.Find(oldProduct.Id).Available = newProductData.Available;
            db.Product.Find(oldProduct.Id).Details = newProductData.Details;
            oldProduct.Name = newProductData.Name;
            oldProduct.OnSale = newProductData.OnSale;
            oldProduct.Price = newProductData.Price;
            oldProduct.RatingAverage = newProductData.RatingAverage;
            oldProduct.Stock = newProductData.Stock;
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
        public void AddProduct(Product product)
        {
            ProductController.AllProducts.Add(product);
            db.Product.Add(product);
            db.SaveChanges();
        }
    }
}
