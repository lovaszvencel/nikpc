using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface INewUserHandler
    {
        void UserDataCheck(string username, string password, string email);
        void AddUser(Classes.User user);
    }
}
