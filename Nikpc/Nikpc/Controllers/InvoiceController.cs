using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class InvoiceController : Interfaces.IInvoiceHandler
    {
        public void SendInvoice(Classes.Invoice invoice, string email)
        {
            throw new NotImplementedException();
        }

        public void PrintInvoice(Classes.Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void InvoicingPayment(Classes.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
