using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductCategoryHandler
    {
        void AddCategory(string name, List<Product> products);
        void ModifyCategory(string name);
        void DeleteCategory(ProductCategory category);
        void AddProductsToCategory(List<Product> products);
        void DeleteProductsFromCategory(List<Product> products);
    }
}
