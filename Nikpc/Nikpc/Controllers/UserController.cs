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
        nikpcEntities1 db = new nikpcEntities1();

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

        //TODO kiegészíteni a specifikációt, hogy User obj-t adjon vissza (hívás oldalon kell a típusa)
        public User LogInAuthentication(string username, string password)
        {
            var user = from akt in db.User
                       where akt.Username == username && akt.Password == password
                       select akt;

            if (user.Count() == 1)
                return user.First();
            return null;

        }

        public bool CrowdCheck()
        {
            throw new NotImplementedException();
        }

        public void UserDataCheck(string username, string password, string email)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
        }
    }
}
