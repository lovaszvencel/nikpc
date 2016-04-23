using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IInvoiceHandler
    {
        void SendInvoice(Classes.Invoice invoice, string email);
        void PrintInvoice(Classes.Invoice invoice);
        void InvoicingPayment(Classes.Order order);
    }
}
