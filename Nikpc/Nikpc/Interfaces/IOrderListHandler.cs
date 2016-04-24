using Nikpc.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IOrderListHandler
    {
        Order SearchOrder(string fullname, int osszeg, PaymentMethod paymentMethod, List<Product> products);
        void DeleteOrder(Order order);
        void SortOrders(string sortByParameter, bool ascending);
        void ModifyOrder(Order oldOrder, Order newOrderData);

    }
}
