namespace Task_9.Users
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using Task_9.Interfaces;
    
    public class UserRepository : IUserRepository
    {
        private ConnectionStringSettings connectionStringItem;

        public UserRepository(ConnectionStringSettings conectionString)
        {
            this.connectionStringItem = conectionString;
        }

        public bool Delete(int id)
        {
            bool result = false;
            
            if (this.connectionStringItem == null)
            {
                return false;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            var providerName = this.connectionStringItem.ProviderName;
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
            User getuser = new User();
            
            if (this.connectionStringItem == null)
            {
                return null;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            var providerName = this.connectionStringItem.ProviderName;
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
                        getuser.UserID = (int)reader["UserID"];
                        getuser.LastName = (string)reader["LastName"];
                        getuser.FirstName = (string)reader["FirstName"];
                        getuser.Email = (string)reader["E-mail"];
                        getuser.Login = (string)reader["Login"];
                        getuser.BirthDate = (DateTime)reader["BirthDate"];
                        getuser.RegistrationDate = (DateTime)reader["RegistrationDate"];
                        getuser.Password = (string)reader["Password"];
                    }
                }
            }

            return getuser;
        }

        public List<User> GetAll()
        {
            List<User> userlist = new List<User>;
            
            if (this.connectionStringItem == null)
            {
                return null;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            var providerName = this.connectionStringItem.ProviderName;
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
                        while (reader.Read())
                        {
                            User getuser = new User();
                            getuser.UserID = (int)reader["UserID"];
                            getuser.LastName = (string)reader["LastName"];
                            getuser.FirstName = (string)reader["FirstName"];
                            getuser.Email = (string)reader["E-mail"];
                            getuser.Login = (string)reader["Login"];
                            getuser.BirthDate = (DateTime)reader["BirthDate"];
                            getuser.RegistrationDate = (DateTime)reader["RegistrationDate"];
                            getuser.Password = (string)reader["Password"];
                            userlist.Add(getuser);
                        }
                }
            }

            return userlist;
        }

        public bool Save(User entity)
        {
            bool result = false;
            
            if (this.connectionStringItem == null)
            {
                return false;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            var providerName = this.connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Users Values "
                    + "(" + entity.UserID + ",N'" + entity.LastName + "',N'" + entity.FirstName + "',N'" + entity.Email + "',N'" + entity.Login
                    + "','" + entity.BirthDate + "','" + entity.RegistrationDate + "',N'" + entity.Password + "')";
                
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

        public int Count()
        {
            int result = 0;

            if (this.connectionStringItem == null)
            {
                return result;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            var providerName = this.connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT([UserID]) AS [COUNT] FROM [dbo].[Users] ";

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = (int)reader["COUNT"];
                    }
                }
            }
            return result;
        }

        public List<User> GetAllByCount(int entity)
        {
            List<User> userlist = new List<User>();

            if (this.connectionStringItem == null)
            {
                return null;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            var providerName = this.connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                command.CommandText = "exec [dbo].[GetAllUsers] @amt="+entity;

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User getuser = new User();
                        getuser.UserID = (int)reader["UserID"];
                        getuser.LastName = (string)reader["LastName"];
                        getuser.FirstName = (string)reader["FirstName"];
                        getuser.Email = (string)reader["E-mail"];
                        getuser.Login = (string)reader["Login"];
                        getuser.BirthDate = (DateTime)reader["BirthDate"];
                        getuser.RegistrationDate = (DateTime)reader["RegistrationDate"];
                        getuser.Password = (string)reader["Password"];
                        userlist.Add(getuser);
                    }
                }
            }
            return userlist;
        }
    }
}
