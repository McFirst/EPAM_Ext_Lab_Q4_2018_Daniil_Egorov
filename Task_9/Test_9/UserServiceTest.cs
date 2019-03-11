namespace Test_9
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task_9.Users;

    [TestClass]
    public class UserServiceTest
    {
        private const string DBConnectionString = "CardIndexConection";
        
        [TestMethod]
        public void GetUser()
        {
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConnectionString];

            // Arrange
            UserRepository urepo = new UserRepository(connectionStringItem);
            User usr = new User();
            int id = 3;

            // Act
            usr = urepo.Get(id);

            // Assert
            Assert.AreEqual(usr.UserID, id, "Invalid get");
        }

        [TestMethod]
        public void SaveUser()
        {
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConnectionString];

            // Arrange
            UserRepository urepo = new UserRepository(connectionStringItem);
            User usr = new User
            {
                UserID = 10,
                LastName = "Adam",
                FirstName = "Sinkler",
                Email = "a.sinkler@mail.com",
                Login = "sadom",
                BirthDate = new DateTime(1966, 6, 30),
                RegistrationDate = new DateTime(1976, 6, 30),
                Password = null
            };

            // Act
            bool result = urepo.Save(usr);

            // Assert
            Assert.AreEqual(true, result, "Invalid save");
        }

        [TestMethod]
        public void DeleteUser()
        {
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConnectionString];

            // Arrange
            UserRepository urepo = new UserRepository(connectionStringItem);

            // Act
            bool result = urepo.Delete(10);

            // Assert
            Assert.AreEqual(true, result, "Invalid delete");
        }

        [TestMethod]
        public void GetAllUsers()
        {
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConnectionString];

            // Arrange
            UserRepository urepo = new UserRepository(connectionStringItem);
            int expect = urepo.Count();

            // Act
            List<User> result = urepo.GetAll();

            // Assert
            Assert.AreEqual(expect, result.Count, "Invalid count");
        }
    }
}
