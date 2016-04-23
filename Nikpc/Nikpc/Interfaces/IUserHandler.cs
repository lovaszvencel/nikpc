using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    interface IUserHandler
    {
        void ModifyUser(Classes.User oldUser, Classes.User newUserData);
        void DeleteUser(Classes.User user);
    }
}
