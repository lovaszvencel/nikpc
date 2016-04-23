using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IDataHandler
    {
        void ModifyAddress(string newAddress);
        void ModifyEmail(string newEmail);
        void ModifyPassword(string newPassword);
    }
}