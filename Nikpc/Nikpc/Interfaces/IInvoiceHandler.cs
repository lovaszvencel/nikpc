using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IInvoiceHandler
    {
        void SendInvoice(Invoice invoice, string email);
        void PrintInvoice(Invoice invoice);
        void InvoicingPayment(Order order);
    }
}
