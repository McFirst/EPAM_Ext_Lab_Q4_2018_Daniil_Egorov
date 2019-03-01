namespace Task_9.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task_9.Interfaces;
    using System.Configuration;
    using System.Data.Common;
    using System.Data;

    class UserRepository : IUserRepository
    {
        private string DBConection;

        public UserRepository(string ConectionString)
        {
            DBConection = ConectionString;
        }

        public bool Delete(int id)
        {
            bool result = false;
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConection];

            if (connectionStringItem == null)
            {
                //Console.WriteLine("Cannot find NorthwindConection in config.");
                return false;
            }

            var connectionString = connectionStringItem.ConnectionString;
            var providerName = connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM [CardIndex].[dbo].[Users] WHERE [UserID] = " + id;

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.RecordsAffected > 0)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public User Get(int id)
        {
            User GetUser = new User();
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConection];

            if (connectionStringItem == null)
            {
                //Console.WriteLine("Cannot find NorthwindConection in config.");
                return null; ;
            }

            var connectionString = connectionStringItem.ConnectionString;
            var providerName = connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "SELECT [UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RegistrationDate],[Password] "
                    + "FROM [dbo].[Users] WHERE [UserID] = " + id;

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {

                        while (reader.Read())
                        {
                            GetUser.UserID = (int)reader["UserID"];
                            GetUser.LastName = (string)reader["LastName"];
                            GetUser.FirstName = (string)reader["FirstName"];
                            GetUser.Email = (string)reader["E-mail"];
                            GetUser.Login = (string)reader["Login"];
                            GetUser.BirthDate = (string)reader["BirthDate"];
                            GetUser.RegistrationDate = (string)reader["RegistrationDate"];
                            GetUser.Password = (string)reader["Password"];
                        }
                    
                }
            }
            return GetUser;
        }

        public List<User> GetAll()
        {
            List<User> UserList = new List<User>(3);
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConection];

            if (connectionStringItem == null)
            {
                //Console.WriteLine("Cannot find NorthwindConection in config.");
                return null; ;
            }

            var connectionString = connectionStringItem.ConnectionString;
            var providerName = connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "SELECT [UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RegistrationDate],[Password] "
                    + "FROM [dbo].[Users]";

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.RecordsAffected == 1)
                    {
                        while (reader.Read())
                        {
                            User GetUser = new User();
                            GetUser.UserID = (int)reader["UserID"];
                            GetUser.LastName = (string)reader["LastName"];
                            GetUser.FirstName = (string)reader["FirstName"];
                            GetUser.Email = (string)reader["E-mail"];
                            GetUser.Login = (string)reader["Login"];
                            GetUser.BirthDate = (string)reader["BirthDate"];
                            GetUser.RegistrationDate = (string)reader["RegistrationDate"];
                            GetUser.Password = (string)reader["Password"];
                            UserList.Add(GetUser);
                        }
                    }
                }
            }
            return UserList;
        }

        public bool Save(User entity)
        {
            bool result = false;
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConection];

            if (connectionStringItem == null)
            {
                //Console.WriteLine("Cannot find NorthwindConection in config.");
                return false;
            }

            var connectionString = connectionStringItem.ConnectionString;
            var providerName = connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Users Values "
                    + "(" + entity.UserID +","+entity.LastName+","+entity.FirstName + "," +entity.Email + "," + entity.Login
                    + "," + entity.BirthDate + "," + entity.RegistrationDate + "," + entity.Password+")";
                //"[UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RegistrationDate],[Password]";

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.RecordsAffected > 0)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }

}
