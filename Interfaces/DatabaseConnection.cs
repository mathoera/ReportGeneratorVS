using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SQLite;

namespace RPP_Test_Report_Suite.Interfaces
{
    public class DatabaseConnection
    {
        static void testconnection()
        {
            // Connection string to the SQLite database
            string connectionString = "Data Source=mydatabase.db;Version=3;";

            // Create a new connection to the database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create a new table if it doesn't exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                // Add a new record to the table
                string name = "John";
                int age = 30;
                string insertQuery = "INSERT INTO MyTable (Name, Age) VALUES (@Name, @Age)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Age", age);
                    insertCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Record added successfully!");

                connection.Close();
            }
        }
    }
}
