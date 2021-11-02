using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniORM
{
    public class DatabaseConnection
    {
        public static string GetConnectionString()
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());

            String FilePath = $"{directory.Parent.Parent.Parent.FullName}\\MySettings.json";
            IConfigurationRoot configuartion = new ConfigurationBuilder().
                AddJsonFile(FilePath, false).Build();

            return configuartion.GetConnectionString("MyDatabaseConnection");
        }
        public static void CheckConnectionAndOpen(ref SqlConnection sqlConnection)
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
    }
}
