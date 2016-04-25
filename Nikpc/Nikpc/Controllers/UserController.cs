using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    public class UserController : Bindable, IDataHandler, ILogInHandler, INewUserHandler
    {
        nikpcEntities1 db = new nikpcEntities1();
        public static User currentUser;
        public static ObservableCollection<User> AllUsers = new ObservableCollection<User>();

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
            AllUsers.Add(user);
            OnPropertyChanged(typeof(UserController), "AllUsers");
            db.User.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            AllUsers.Remove(user);
            OnPropertyChanged(typeof(UserController), "AllUsers");
            db.User.Remove(db.User.Find(user.Id));
            db.SaveChanges();
        }

        public void ModifyUser(User oldUser, User newUser)
        {
            currentUser = newUser;
            db.User.Remove(db.User.Find(oldUser.Id));
            db.User.Add(newUser);
            db.SaveChanges();
        }
    }
}
