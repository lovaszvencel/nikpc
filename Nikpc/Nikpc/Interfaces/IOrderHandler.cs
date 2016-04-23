using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IOrderHandler
    {
        void ModifyPaymentMethod(Enums.PaymentMethod newPaymentMethod);
        void EmptyCart();
        void PlaceOrder(List<Classes.Product> cart, Enums.PaymentMethod paymentMethod);
        void DeleteOrder(Classes.Order);
        void ModifyProductQuantity(Classes.Product product, int newQuantity);
    }
}
