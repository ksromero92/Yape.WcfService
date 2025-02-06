using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Yape.WcfService.Data
{
    public class DatabaseContext : IDisposable
    {
        private readonly MySqlConnection _connection;

        public DatabaseContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
