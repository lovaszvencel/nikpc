using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IUserHandler
    {
        void ModifyUser(User oldUser, User newUserData);
        void DeleteUser(User user);
    }
}
