using Nikpc.Classes;
using Nikpc.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IOrderHandler
    {
        void ModifyOrderPaymentMethod(PaymentMethod newPaymentMethod);
        void EmptyOrderCart();
        void PlaceOrder(bool? delivery, int total, PaymentMethod paymentMethod);
        void DeleteOrder(Order order);
        void ModifyOrderProductQuantity(Product product, int newQuantity);
    }
}
