using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IPaymentHandler
    {
        void Pay(Enums.PaymentMethod paymentMethod, Classes.Order order);
        void Invoicing(Classes.Order order);
    }
}
