using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nikpc.Controllers;
using Nikpc.Windows;

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
    }
}
