using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikpc.Enums;
using Nikpc.Classes;

namespace Nikpc.Controllers
{
    public class OrderController : IOrderHandler, IOrderListHandler
    {
        public void ModifyOrderPaymentMethod(PaymentMethod newPaymentMethod)
        {
            throw new NotImplementedException();
        }

        public void EmptyOrderCart()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(List<Product> cart, PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void ModifyOrderProductQuantity(Product product, int newQuantity)
        {
            throw new NotImplementedException();
        }

        public Order SearchOrder(string fullname, int osszeg, PaymentMethod paymentMethod, List<Product> products)
        {
            throw new NotImplementedException();
        }

        public void SortOrders(string sortByParameter, bool ascending)
        {
            throw new NotImplementedException();
        }
        
        public void ModifyOrder(Order oldOrder, Order newOrderData)
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Cart cart, PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
