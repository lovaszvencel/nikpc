using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IOrderListHandler
    {
        Order SearchOrder(string fullname, int osszeg, Enums.PaymentMethod paymentMethod, List<Classes.Product> products);
        void DeleteOrder(Classes.Order order);
        void SortOrders(string sortByParameter, bool ascending);
    }
}
