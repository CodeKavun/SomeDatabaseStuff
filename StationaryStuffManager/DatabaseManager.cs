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

            string query = "SELECT Stationaries.*, StationaryTypes.TypeName, StationaryTypes.Amount, Companies.CompanyName, Managers.ManagerName"
                + " FROM Stationaries JOIN StationaryTypes ON Stationaries.TypeId = StationaryTypes.Id"
                + " JOIN Companies ON Stationaries.CompanyId = Companies.Id"
                + " JOIN Managers ON Stationaries.ManagerId = Managers.Id ";

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = query;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            int line = 0;

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem([
                    reader.GetInt64("Id").ToString(),
                    reader.GetString("StationaryName"),
                    reader.GetDecimal("Price").ToString(),
                    reader.GetString("TypeName"),
                    reader.GetString("CompanyName"),
                    reader.GetString("ManagerName"),
                    reader.GetDateTime("SellDate").ToString()
                ]);

                listView.Items.Add(item);
                
                line++;
            }

            reader.Close();
        }

        public static void Close() => connection.Close();
    }
}
