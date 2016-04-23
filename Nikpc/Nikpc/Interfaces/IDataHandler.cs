using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IDataHandler
    {
        void ModifyMyAddress(string newAddress);
        void ModifyMyEmail(string newEmail);
        void ModifyMyPassword(string newPassword);
    }
}