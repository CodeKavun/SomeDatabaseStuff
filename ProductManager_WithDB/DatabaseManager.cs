using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager_WithDB
{
    internal static class DatabaseManager
    {
        private static SqlConnection connection;

        public static int CategoryFilterId = 0;
        public static int ProviderFilterId = 0;

        public static void Init()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Storage;Trusted_Connection=True";
            connection = new SqlConnection(connectionString);

            connection.Open();
        }

        public static void DisplayData(ListView listView)
        {
            listView.Items.Clear();

            string sqlQuery = "SELECT Products.*, Categories.CategoryName, Providers.ProviderName"
                + " FROM Products JOIN Categories ON Products.CategoryId = Categories.Id"
                + " JOIN Providers ON Products.ProviderId = Providers.Id "
                + GetConditionQuery();

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = sqlQuery;

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

        public static void DisplayToComboBox(ComboBox comboBox, string field, string table)
        {
            string sqlQuery = $"SELECT {field} FROM {table}";
            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = sqlQuery;

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString(field));
            }

            reader.Close();
        }

        public static void AddProduct(string productName, int amount, decimal price, int categoryId, int providerId)
        {
            string sqlQuery = $"INSERT INTO Products VALUES (N'{productName}', {amount}, {price.ToString().Replace(',', '.')}, {categoryId}, {providerId});";

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = sqlQuery;
            sqlCommand.ExecuteNonQuery();
        }

        public static void Close() => connection.Close();

        private static string GetConditionQuery()
        {
            if (CategoryFilterId == 0 && ProviderFilterId == 0) return string.Empty;

            string condition = " WHERE ";

            if (CategoryFilterId != 0) condition += $" Products.CategoryId = {CategoryFilterId}";

            if (ProviderFilterId != 0)
                condition += (CategoryFilterId != 0 ? "AND" : "") + $" Products.ProviderId = {ProviderFilterId}";

            return condition;
        }
    }
}
