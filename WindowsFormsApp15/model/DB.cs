using MySql.Data.MySqlClient;

namespace WindowsFormsApp15
{


    class DB
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_users_db");

        // function to open connection to db
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // function to close connection to db
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // function to return connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
