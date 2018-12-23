namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task_4.Users;
    using Task_4.Materials;

    [TestClass]
    public class UserTest
    {
        
        /*public string Name = "User1";
        public string Surname = "SurUser1";
        public string Email = "user1@mail.ru";
        public string Passw = "pass1";
        public string Date = "01.01.2001";
        public string Role = "guest";*/
        //User user1 = new User(1, "User1", "User1", "SurUser1", "user1@mail.ru", "pass1", "01.01.2001", "guest");

        [TestMethod]
        public void TestMethod_Get_User()
        {
            // Arrange
            int ID = 1;
            string Login = "Login1";
            UserService uservise = new UserService();
            uservise.LoadUsers();

            // Act
            User testuser = uservise.Get(ID);

            // Assert
            string actual = testuser.Login;
            Assert.AreEqual(Login, actual, "Invalid result");
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
            int ID = 1;

            // Act
            bool actual = uservise.Delete(ID);

            // Assert
            Assert.AreEqual(expect, actual, "Invalid result");
        }
    }
}
