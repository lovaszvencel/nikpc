using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductHandler
    {
        void ModifyProduct(Classes.Product oldProduct, Classes.Product newProductData);
        void DeleteProduct(Classes.Product product);
        bool ReserveProduct(Classes.Product product, int quantity);
    }
}
