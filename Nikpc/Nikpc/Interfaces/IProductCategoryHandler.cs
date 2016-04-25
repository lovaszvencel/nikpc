using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductCategoryHandler
    {
        void AddCategory(string name);
        void ModifyCategory(string name, ProductCategory category);
        void DeleteCategory(ProductCategory category);
        void AddProductsToCategory(List<Product> products, ProductCategory category);
        void DeleteProductsFromCategory(List<Product> products);
    }
}
