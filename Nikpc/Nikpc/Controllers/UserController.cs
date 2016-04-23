using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class UserController : Interfaces.IDataHandler, Interfaces.ILogInHandler, Interfaces.INewUserHandler
    {
        public static void ModifyMyAddress(string newAddress)
        {
            throw new NotImplementedException();
        }

        public static void ModifyMyEmail(string newEmail)
        {
            throw new NotImplementedException();
        }

        public static void ModifyMyPassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public static bool LogInAuthentication(string username, string password)
        {
            throw new NotImplementedException();
        }

        public static bool CrowdCheck()
        {
            throw new NotImplementedException();
        }

        public static void UserDataCheck(string username, string password, string email)
        {
            throw new NotImplementedException();
        }

        public static void AddUser(Classes.User user)
        {
            throw new NotImplementedException();
        }

        public static void LogIn() //Vendégként
        {
            throw new NotImplementedException();
        }
        
        public static void LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public static bool Register(Classes.User user)
        {
            throw new NotImplementedException();
        }


    }
}
