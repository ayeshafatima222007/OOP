using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.Utility
{
    public static class Configuration
    {
        private static readonly string connectionString ="Server=localhost\\SQLEXPRESS01;Database=ClothingAppDB;Trusted_Connection=True;";
                     //readonly prevent it from accidental modification

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}