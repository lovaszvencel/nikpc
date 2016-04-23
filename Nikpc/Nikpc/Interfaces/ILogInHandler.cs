using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface ILogInHandler
    {
        bool LogInAuthentication(string username, string password);
        bool CrowdCheck();
    }
}
