using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class AdminController : Interfaces.INewUserHandler, Interfaces.IUserHandler
    {
        public static void UserDataCheck(string username, string password, string email)
        {
            throw new NotImplementedException();
        }

        public static void AddUser(Classes.User user)
        {
            throw new NotImplementedException();
        }

        public static void ModifyUser(Classes.User oldUser, Classes.User newUserData)
        {
            throw new NotImplementedException();
        }

        public static void DeleteUser(Classes.User user)
        {
            throw new NotImplementedException();
        }
    }
}
