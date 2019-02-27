using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data;

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
                command.CommandText = "SELECT [FirstName], [E-mail] FROM [CardIndex].[dbo].[Users]";

                connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} - {1}",
                            reader["FirstName"],
                            reader["E-mail"]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
