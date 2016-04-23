using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class OrderController : Interfaces.IOrderHandler, Interfaces.IOrderListHandler
    {
        public static void ModifyOrderPaymentMethod(Enums.PaymentMethod newPaymentMethod)
        {
            throw new NotImplementedException();
        }

        public static void EmptyOrderCart()
        {
            throw new NotImplementedException();
        }

        public static void PlaceOrder(List<Classes.Product> cart, Enums.PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public static void DeleteOrder(Classes.Order order)
        {
            throw new NotImplementedException();
        }

        public static void ModifyOrderProductQuantity(Classes.Product product, int newQuantity)
        {
            throw new NotImplementedException();
        }

        public static Order SearchOrder(string fullname, int osszeg, Enums.PaymentMethod paymentMethod, List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }

        public static void SortOrders(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }
        
        public static void ModifyOrder(Classes.Order oldOrder, Classes.Order newOrderData)
        {
            throw new NotImplementedException();
        }
    }
}
