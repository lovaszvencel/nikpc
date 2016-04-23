using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikpc.Classes;
using Nikpc.Enums;

namespace Nikpc.Controllers
{
    public class OrderController : IOrderHandler, IOrderListHandler
    {
        public void ModifyOrderPaymentMethod(Enums.PaymentMethod newPaymentMethod)
        {
            throw new NotImplementedException();
        }

        public void EmptyOrderCart()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(List<Classes.Product> cart, Enums.PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(Classes.Order order)
        {
            throw new NotImplementedException();
        }

        public void ModifyOrderProductQuantity(Classes.Product product, int newQuantity)
        {
            throw new NotImplementedException();
        }

        public Order SearchOrder(string fullname, int osszeg, Enums.PaymentMethod paymentMethod, List<Classes.Product> products)
        {
            throw new NotImplementedException();
        }

        public void SortOrders(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }
        
        public void ModifyOrder(Classes.Order oldOrder, Classes.Order newOrderData)
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Cart cart, PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
