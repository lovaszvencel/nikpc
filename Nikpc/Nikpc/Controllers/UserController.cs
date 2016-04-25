using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Nikpc.Controllers
{
    public class UserController : ILogInHandler, INewUserHandler
    {
        nikpcEntities1 db = new nikpcEntities1();
        public static User currentUser;
        public static ObservableCollection<User> AllUsers = new ObservableCollection<User>();

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

        public string UserDataCheck(string username, string email)
        {
            bool van = false;
            for (int i = 0; i < AllUsers.Count && !van; i++)
            {
                van = (username == AllUsers[i].Username);
            }
            if (van)
                return "Már foglalt ez a felhasználónév!";
            else if (!(new EmailAddressAttribute().IsValid(email)))
                return "Nem megfelelő email formátum";
            return "";
        }

        public void AddUser(User user)
        {
            AllUsers.Add(user);
            db.User.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            AllUsers.Remove(user);
            db.User.Remove(db.User.Find(user.Id));
            db.SaveChanges();
        }

        public void ModifyUser(User oldUser, User newUserData)
        {
            oldUser.Address = newUserData.Address;
            oldUser.Email = newUserData.Email;
            oldUser.Name = newUserData.Name;
            oldUser.Password = newUserData.Password;
            oldUser.PhoneNumber = newUserData.PhoneNumber;
            db.User.Find(oldUser.Id).Address = newUserData.Address;
            db.User.Find(oldUser.Id).Email = newUserData.Email;
            db.User.Find(oldUser.Id).Name = newUserData.Name;
            db.User.Find(oldUser.Id).Password = newUserData.Password;
            db.User.Find(oldUser.Id).PhoneNumber = newUserData.PhoneNumber;
            db.SaveChanges();
            
        }
    }
}
