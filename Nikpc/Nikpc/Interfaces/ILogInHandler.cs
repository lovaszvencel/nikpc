using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface ILogInHandler
    {
        bool Authentication(string username, string password);
        bool CrowdCheck();
    }
}
