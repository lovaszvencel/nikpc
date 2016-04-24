using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class InvoiceController : IInvoiceHandler
    {
        public void SendInvoice(Invoice invoice, string email)
        {
            throw new NotImplementedException();
        }

        public void PrintInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void InvoicingPayment(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
