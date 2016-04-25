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
        nikpcEntities1 db = new nikpcEntities1();

        public void ModifyOrderPaymentMethod(PaymentMethod newPaymentMethod)
        {
            throw new NotImplementedException();
        }

        public void EmptyOrderCart()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(bool? delivery, int total, PaymentMethod paymentMethod)
        {
            //új rekord felvétele az order táblába
            var newOrder = new Order()
            {
                Date = System.DateTime.Now,
                UserID = UserController.currentUser.Id,
                Total = total,
                Delivery = true,
                DeliveryAddress = UserController.currentUser.Address,
                PaymentMethod = paymentMethod.ToString()
            };

            db.Order.Add(newOrder);
            db.SaveChanges();

            foreach (var item in UserController.currentUser.Cart)
            {
                var newOrderedProduct = new OrderedProduct()
                {
                    OrderID = newOrder.Id,
                    ProductID = item.Product.Id,
                    Quantity = item.Quantity
                };
                db.OrderedProduct.Add(newOrderedProduct);

                db.Product.Find(item.Product.Id).Stock -= item.Quantity;

                db.SaveChanges();
                item.Product.Stock -= item.Quantity;
            }
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
