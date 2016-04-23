using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class ProductCategoryController : Interfaces.IProductCategoryHandler
    {
        public static void AddCategory(string name, List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }

        public static void ModifyCategory(string name)
        {
            throw new NotImplementedException();
        }

        public static void DeleteCategory(Classes.ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public static void AddProductsToCategory(List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }

        public static void DeleteProductsFromCategory(List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
