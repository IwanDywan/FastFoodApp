/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restauracja_Fast_Food
{
    class Database
    {

        public Database()
        {
            connection = new MySqlConnection(_connectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {

                }
                else
                {
                    MessageBox.Show("Couldn't connect to the database");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following exception has occured " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void test()
        {
            string query = "SELECT * FROM Users";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Process each row of data
                // Example: string value = reader.GetString(0);
                string value = reader.GetString(0);
                Console.WriteLine("\n\n\n\n\n\\n\n\n\n\n\n\n\n\n" + value + "\n\n\n\n\\nn\n\n\n\n\n\n\n\\n\n\n");
            }
            reader.Close();
        }

        public void Disconnect()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private readonly MySqlConnection connection;
        private readonly string _connectionString = "server=db4free.net;port=3306;database=online_com;uid=online_com;password=QV@LL#2Bc6YNUra";
    }
}
*/