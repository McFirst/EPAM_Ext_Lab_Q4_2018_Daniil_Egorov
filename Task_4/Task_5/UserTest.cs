namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task_4.Users;

    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestMethod_Get_User()
        {
            // Arrange
            int id = 1;
            string login = "Login1";
            UserService uservise = new UserService();
            uservise.LoadUsers();

            // Act
            User testuser = uservise.Get(id);

            // Assert
            string actual = testuser.Login;
            Assert.AreEqual(login, actual, "Invalid result");
        }

        [TestMethod]
        public void TestMethod_GetAll_User()
        {
            // Arrange
            UserService uservise = new UserService();
            uservise.LoadUsers();
            int expect = 2;

            // Act
            List<User> testList = uservise.GetAll();

            // Assert
            int actual = testList.Count;
            Assert.AreEqual(expect, actual, "Invalid result");
        }

        [TestMethod]
        public void TestMethod_Save_User()
        {
            // Arrange
            User user3 = new User(3, "User3", "User3", "SurUser3", "user3@mail.ru", "pass3", "03.03.2003", "guest");
            UserService uservise = new UserService();
            uservise.LoadUsers();
            bool expect = true;

            // Act
            bool actual = uservise.Save(user3);

            // Assert
            Assert.AreEqual(expect, actual, "Invalid result");
        }

        [TestMethod]
        public void TestMethod_Delete_User()
        {
            // Arrange
            UserService uservise = new UserService();
            uservise.LoadUsers();
            bool expect = true;
            int id = 1;

            // Act
            bool actual = uservise.Delete(id);

            // Assert
            Assert.AreEqual(expect, actual, "Invalid result");
        }
    }
}
