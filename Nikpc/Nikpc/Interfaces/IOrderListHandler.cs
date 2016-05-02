using Nikpc.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    public interface IOrderListHandler
    {
        void DeleteOrder(Order order);
    }
}
