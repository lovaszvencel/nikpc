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
    public class ProductCategoryController : IProductCategoryHandler
    {
        nikpcEntities1 db = new nikpcEntities1();
        public static ObservableCollection<ProductCategory> AllCategories = new ObservableCollection<ProductCategory>();
        public void AddCategory(string name)
        {
            db.ProductCategory.Add(new ProductCategory() { Name = name });
            db.SaveChanges();
            AllCategories.Add(db.ProductCategory.OrderByDescending(e => e.Id).First());            
        }

        public void ModifyCategory(string name, ProductCategory category)
        {
            category.Name = name;
            db.ProductCategory.Find(category.Id).Name = name;
            db.SaveChanges();
        }

        public void DeleteCategory(ProductCategory category)
        {
            AllCategories.Remove(category);
            db.ProductCategory.Remove(db.ProductCategory.Find(category.Id));
            db.SaveChanges();
        }

        public void AddProductsToCategory(List<Product> products, ProductCategory category)
        {
            foreach (Product p in products)
            {
                p.CategoryID = category.Id;
                db.Product.Find(p.Id).CategoryID = category.Id;
                db.SaveChanges();
            }
        }

        public void DeleteProductsFromCategory(List<Product> products)
        {
            foreach (Product p in products)
            {
                p.CategoryID = null;
                db.Product.Find(p.Id).CategoryID = null;
                db.SaveChanges();
            }
        }
    }
}
