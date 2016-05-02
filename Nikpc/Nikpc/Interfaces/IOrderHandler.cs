using Nikpc.Classes;
using Nikpc.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    public interface IOrderHandler
    {
        void PlaceOrder(bool? delivery, int total, PaymentMethod paymentMethod);
        void DeleteOrder(Order order);
    }
}
