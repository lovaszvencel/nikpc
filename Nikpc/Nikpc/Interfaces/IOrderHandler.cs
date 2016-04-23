using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IOrderHandler
    {
        void ModifyOrderPaymentMethod(Enums.PaymentMethod newPaymentMethod);
        void EmptyOrderCart();
        void PlaceOrder(Classes.Cart cart, Enums.PaymentMethod paymentMethod);
        void DeleteOrder(Classes.Order order);
        void ModifyOrderProductQuantity(Classes.Product product, int newQuantity);
    }
}
