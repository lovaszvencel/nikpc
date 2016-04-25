using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nikpc.Controllers;
using Nikpc.Windows;
using Nikpc;

namespace UnitTest
{
    [TestClass]
    public class RegistrationTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RegTestNullParameter()
        {
            UserController uc = new UserController();
            uc.AddUser(null);
        }

        [TestMethod]
        public void RegTestEmptyUserObject()
        {
            UserController uc = new UserController();
            uc.AddUser(new User());
        }

        [TestMethod]
        public void RegTestFull()
        {
            UserController uc = new UserController();
            uc.AddUser(new User {
                Type = "vasarlo",
                Name = "123",
                Address = "123",
                Email = "123",
                Password = "123",
                PhoneNumber = "123",
                Username = "123"
            });
        }
    }
}
