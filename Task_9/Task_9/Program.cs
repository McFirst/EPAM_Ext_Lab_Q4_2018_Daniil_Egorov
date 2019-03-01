using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data;
using Task_9.Users;

namespace Task_9
{
    class Program
    {
        private const string DBConnectionString = "CardIndexConection";
        
        static void Main(string[] args)
        {
            var connectionStringItem = ConfigurationManager.ConnectionStrings[DBConnectionString];

            if (connectionStringItem == null)
            {
                Console.WriteLine("Cannot find NorthwindConection in config.");
                return;
            }

            var connectionString = connectionStringItem.ConnectionString;
            var providerName = connectionStringItem.ProviderName;
            var factory = DbProviderFactories.GetFactory(providerName);

            using (IDbConnection connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                var command = connection.CreateCommand();
                /*command.CommandText = "SELECT [FirstName], [E-mail] FROM [CardIndex].[dbo].[Users]";

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} - {1}",
                            reader["FirstName"],
                            reader["E-mail"]);
                    }
                }*/

                User GetUser = new User();
                command.CommandText = "SELECT [UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RegistrationDate],[Password] "
                    + "FROM [dbo].[Users] WHERE [UserID] = " + 2;

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    //if (reader.RecordsAffected == 1)
                    //{
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
                    //}
                }

            }

            /*UserRepository ur = new UserRepository(DBConnectionString);
            User usr = new User();
            usr = ur.Get(1);
            /*usr.UserID = 10;
            usr.LastName = "Adam";
            usr.FirstName = "Sinkler";
            usr.Email = "a.sinkler@mail.com";
            usr.Login = "sadom";
            usr.BirthDate = (DateTime)"30.06.1966";
            usr.RegistrationDate = "";
            usr.Password = null;*/

            //Console.WriteLine(GetUser.BirthDate);
            Console.ReadKey();
        }
    }
}
