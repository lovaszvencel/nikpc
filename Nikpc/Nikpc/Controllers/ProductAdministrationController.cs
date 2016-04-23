using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class ProductAdministrationController: Interfaces.IProductHandler, Interfaces.IProductListHandler
    {

        public static void ModifyProduct(Classes.Product oldProduct, Classes.Product newProductData)
        {
            throw new NotImplementedException();
        }

        public static void DeleteProduct(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static bool ReserveProduct(Classes.Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        public static void AdminSearchProduct(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {
            throw new NotImplementedException();
        }

        public static void AdminSortProducts(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }

        public static void AddProduct(Classes.Product product)
        {
            throw new NotImplementedException();
        }

        public static void ImportProducts(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public static List<Product> ExportProducts()
        {
            throw new NotImplementedException();
        }

        public static void ModifyStock(Classes.Product product, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
