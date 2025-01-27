using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStuffManager
{
    internal static class DatabaseManager
    {
        private static SqlConnection connection;

        public static int CategoryFilterId = 0;
        public static int ProviderFilterId = 0;

        public static void Init()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StationaryComapny;Trusted_Connection=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
        }

        public static void DisplayData(ListView listView)
        {
            listView.Items.Clear();

            

            SqlCommand sqlCommand = connection.CreateCommand();
            //sqlCommand.CommandText = sqlQuery;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem([
                    reader.GetInt32("Id").ToString(),
                    reader.GetString("ProductName"),
                    reader.GetInt32("Amount").ToString(),
                    reader.GetDecimal("OriginalPrice").ToString(),
                    reader.GetString("CategoryName"),
                    reader.GetString("ProviderName")
                ]);

                listView.Items.Add(item);
            }

            reader.Close();
        }

        public static void Close() => connection.Close();
    }
}
