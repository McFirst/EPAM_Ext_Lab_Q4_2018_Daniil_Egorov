namespace Test_9
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
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
            int id = 8;

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
            int id = 0;
            
            // Arrange
            UserRepository urepo = new UserRepository(connectionStringItem);
            using (var connection = new SqlConnection(connectionStringItem.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO [Users] (" + urepo.HeaderString("Users", true) + ") Values "
                    + "(N'Adam',N'Sinkler',N'a.sinkler@mail.com',N'sadom','1966-05-05 00:00:00.000','1976-01-05 00:00:00.000',N'')";
                command.ExecuteReader();
            }
            using (var connection = new SqlConnection(connectionStringItem.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT [UserID] FROM [dbo].[Users] WHERE [E-mail]='a.sinkler@mail.com'";
                id = (int)command.ExecuteScalar();

            }

            // Act
            bool result = urepo.Delete(id);

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
