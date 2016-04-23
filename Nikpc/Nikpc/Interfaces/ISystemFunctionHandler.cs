using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface ISystemFunctionHandler
    {
        List<Classes.Product> ChooseProductsOnSale();
        void ViewLog();
        void ViewStats();
        void SetStatsToDefault();
    }
}