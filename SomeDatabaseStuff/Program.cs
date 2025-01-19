// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Connecting to the database...");

string connectionRequest = "Server=(localdb)\\MSSQLLocalDB;Database=StudentMarks;Trusted_Connection=True";
SqlConnection connection = new SqlConnection(connectionRequest);

try
{
    connection.Open();
    Console.WriteLine("Connected!\n\n");

    string query = "select * from Marks";
    SqlCommand cmd = connection.CreateCommand();
    cmd.CommandText = query;
    SqlDataReader reader = cmd.ExecuteReader();

    Console.WriteLine("(ID, Firstname, Lastname, Avg Mark, Min Avg Mark, Max Avg Mark)");
    ReadData(reader);

    string anotherQuery = "select * from Marks where subjectMinAvgMark > 6";
    SqlCommand anotherCmd = connection.CreateCommand();
    anotherCmd.CommandText = anotherQuery;
    SqlDataReader anotherReader = anotherCmd.ExecuteReader();

    Console.WriteLine("\n\nStudents with min avg mark greater than 5");
    ReadData(anotherReader);
}
catch (Exception ex)
{
    Console.WriteLine($"Server fault: {ex.Message}");
}
finally
{
    connection.Close();
}

static void ReadData(SqlDataReader reader)
{
    while (reader.Read())
    {
        int id = reader.GetInt32("id");
        string firstname = reader.GetString("firstname");
        string lastname = reader.GetString("lastname");
        int avgMark = reader.GetInt32("avgMark");
        int avgMinMark = reader.GetInt32("subjectMinAvgMark");
        int avgMaxMark = reader.GetInt32("subjectMaxAvgMark");

        Console.WriteLine($"{id}:\t{firstname}\t{lastname}\t{avgMark}\t{avgMinMark}\t{avgMaxMark}");
    }

    reader.Close();
}
