using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductCategoryHandler
    {
        void AddCategory(string name, List<Classes.Product> products);
        void ModifyCategory(string name);
        void DeleteCategory(Classes.ProductCategory category);
        void AddProductsToCategory(List<Classes.Product> products);
        void DeleteProductsFromCategory(List<Classes.Product> products);
    }
}
