using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class UserController : IDataHandler, ILogInHandler, INewUserHandler
    {
        public void ModifyMyAddress(string newAddress)
        {
            throw new NotImplementedException();
        }

        public void ModifyMyEmail(string newEmail)
        {
            throw new NotImplementedException();
        }

        public void ModifyMyPassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool LogInAuthentication(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool CrowdCheck()
        {
            throw new NotImplementedException();
        }

        public void UserDataCheck(string username, string password, string email)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Classes.User user)
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
