using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    public interface IProductHandler
    {
        void ModifyProduct(Product oldProduct, Product newProductData);
        void DeleteProduct(Product product);
    }
}
