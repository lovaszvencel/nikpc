using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface INewUserHandler
    {
        string UserDataCheck(string username, string email);
        void AddUser(User user);
    }
}
