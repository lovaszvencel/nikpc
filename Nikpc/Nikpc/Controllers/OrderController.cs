using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikpc.Enums;
using Nikpc.Classes;
using System.Collections.ObjectModel;

namespace Nikpc.Controllers
{
    public class OrderController : IOrderHandler, IOrderListHandler
    {
        nikpcEntities1 db = new nikpcEntities1();
        public static ObservableCollection<Order> AllOrders = new ObservableCollection<Order>();

        public OrderController()
        {
            /*var orderList = (from a in db.Order
                            join b in db.User on a.UserID equals b.Id
                            select new { a.Id, a.Date, b.Name, b.PhoneNumber, a.DeliveryAddress, a.Total, a.PaymentMethod, a.Delivery}).ToList();*/
            var orderList = db.Order.ToList();

            foreach (var item in orderList)
            {
                AllOrders.Add(item);
            }
        }

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
                Total = (int)(total),
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
            var asd = order.Id;
            db.Order.Remove(db.Order.Find(order.Id));
            db.SaveChanges();
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
