using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class ProductCategoryController : IProductCategoryHandler
    {
        public void AddCategory(string name, List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }

        public void ModifyCategory(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Classes.ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public void AddProductsToCategory(List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductsFromCategory(List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
