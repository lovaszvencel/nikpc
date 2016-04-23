using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListViewHandler
    { 
        void Search(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {

        }

        void AddToCart(Classes.Product product)
        {

        }

        void DeleteFromCart(Classes.Product product)
        {

        }

        void Sort(string sortByParameter, bool ascending)
        {

        }
    }
}
