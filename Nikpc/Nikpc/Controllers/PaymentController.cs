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
        public void PayOrder(Enums.PaymentMethod paymentMethod, Classes.Order order)
        {
            throw new NotImplementedException();
        }

        public void InvoicingPayment(Classes.Order order)
        {
            throw new NotImplementedException();
        }

        public void SendInvoice(Classes.Invoice invoice, string email)
        {
            throw new NotImplementedException();
        }

        public void PrintInvoice(Classes.Invoice invoice)
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
