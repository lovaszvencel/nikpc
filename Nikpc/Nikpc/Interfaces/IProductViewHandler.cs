using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductViewHandler
    {
        void AddProductRating(int value, string review);
        void OpenProductImage(Classes.Product product);
        void AddProductToCart(Classes.Product product);
        void DeleteProductFromCart(Classes.Product product);
    }
}
