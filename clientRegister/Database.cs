using MySql.Data.MySqlClient;

namespace clientRegister
{
    internal class Database: Form1
    {
        private bool _success;
        public Database(string? firstName, string? lastName, string? emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public bool ServerIsAvailable()
        {
            _success = false;
            
            var connection = new MySqlConnection(@"server=localhost;userid=root;password=root;database=MyClients");

            try
            {
                Console.WriteLine("Connecting to database: {0}", "MyClients");

                using (connection)
                {
                    var query = "select 1";

                    Console.WriteLine("Executing: {0}", query);

                    var command = new MySqlCommand(query, connection);

                    connection.Open();
                    Console.WriteLine("SQL Connection successful.");

                    command.ExecuteScalar();
                    Console.WriteLine("SQL Query execution successful.");
                }

                _success = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: {0}", ex.Message);

                MessageBox.Show("Le serveur distant est indisponible, impossible de se connecter à la base de données !");
            }

            return _success;
        }
        public bool SendData()
        {
            bool success = false;

            if (ServerIsAvailable() == false)
            {
                return false;
            }

            var connection = new MySqlConnection(@"server=localhost;userid=root;password=root;database=MyClients");

            var statement = "INSERT INTO users (lastname, firstname, email) VALUES (@lastname, @firstname, @email)";

            var command = new MySqlCommand(statement, connection);

            command.Parameters.Add("@lastname", MySqlDbType.Text);
            command.Parameters.Add("@firstname", MySqlDbType.Text);
            command.Parameters.Add("@email", MySqlDbType.VarChar);

            command.Parameters["@lastname"].Value = LastName;
            command.Parameters["@firstname"].Value = FirstName;
            command.Parameters["@email"].Value = EmailAddress;

            connection.Open();

            try
            {
                command.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connection.Close();

            return success;
        }
    }
}
