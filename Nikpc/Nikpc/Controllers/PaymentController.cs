using Nikpc.Enums;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class PaymentController : IPaymentHandler, IInvoiceHandler
    {
        public void PayOrder(PaymentMethod paymentMethod, Order order)
        {
            throw new NotImplementedException();
        }

        public void InvoicingPayment(Order order)
        {
            throw new NotImplementedException();
        }

        public void SendInvoice(Invoice invoice, string email)
        {
            throw new NotImplementedException();
        }

        public void PrintInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public static void SuccessfulPaymentConfirmation(string email)
        {
            throw new NotImplementedException();
        }

        public static void PaymentFailureAlert()
        {
            throw new NotImplementedException();
        }
    }
}
