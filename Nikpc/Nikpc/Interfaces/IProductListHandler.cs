using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IProductListHandler
    { 
        void Search(string productName, Classes.ProductCategory productCategory, int priceFrom, int priceTo, bool available)
        {

        }

        void Sort(string sortByParameter, bool ascending)
        {

        }

        void AddProduct(Classes.Product product)
        {

        }
    }
}
