namespace Task_9.Users
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Text;
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

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM [CardIndex].[dbo].[Users] WHERE [UserID] = @id";
                command.Parameters.AddWithValue("@id", id);
                
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

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT " + HeaderString("Users",false) + "FROM [dbo].[Users] WHERE [UserID] = @id";
                command.Parameters.AddWithValue("@id", id);

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
            List<User> userlist = new List<User>();

            if (this.connectionStringItem == null)
            {
                return null;
            }

            var connectionString = this.connectionStringItem.ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT " + HeaderString("Users",false) + "FROM [dbo].[Users]";
                
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

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO [Users] ("+ HeaderString("Users", true)+") Values "
                    + "(N'" + entity.LastName + "',N'" + entity.FirstName + "',N'" + entity.Email + "',N'" + entity.Login
                    + "','" + entity.BirthDate + "','" + entity.RegistrationDate + "',N'" + entity.Password + "')";

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

        /// <summary>
        ////возвращает количество строк в таблице Users
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            int result = 0;

            if (this.connectionStringItem == null)
            {
                return result;
            }

            var connectionString = this.connectionStringItem.ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) AS [COUNT] FROM [dbo].[Users] ";

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

        /// <summary>
        //// Возвращает указаное количество пользователей
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public List<User> GetAllByCount(int entity)
        {
            List<User> userlist = new List<User>();

            if (this.connectionStringItem == null)
            {
                return null;
            }

            var connectionString = this.connectionStringItem.ConnectionString;
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "[dbo].[GetAllUsers]";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@amt", entity);

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

        /// <summary>
        ////Возвращает список полей таблицы
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public string HeaderString(string TableName, bool ForInsert)
        {
            StringBuilder result = new StringBuilder();

            if (this.connectionStringItem == null)
            {
                return null;
            }

            var connectionString = this.connectionStringItem.ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT TOP 0 * FROM [dbo].["+TableName+"]";
                //command.Parameters.AddWithValue("@TableName", TableName);

                using (IDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    var tableSchema = reader.GetSchemaTable();
                    
                    foreach (DataRow row in tableSchema.Rows)
                    {
                        result.Append("[" + row["ColumnName"] + "],");
                    }
                    result.Remove(result.Length - 1, 1);
                    if (ForInsert) { result.Remove(0, result.ToString().IndexOf(',') + 1); }
                }
            }
            
            return result.ToString();
        }
    }
}
