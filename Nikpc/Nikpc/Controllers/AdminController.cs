﻿using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class AdminController : INewUserHandler, IUserHandler
    {
        public void UserDataCheck(string username, string password, string email)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Classes.User user)
        {
            throw new NotImplementedException();
        }

        public  void ModifyUser(Classes.User oldUser, Classes.User newUserData)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Classes.User user)
        {
            throw new NotImplementedException();
        }
    }
}