using System;


namespace Polymo_DBConn
{
    public abstract class DbConnection
    {
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new NullReferenceException("Connection string can't be empty!");

            ConnectionString = connectionString;

        }

        private string ConnectionString { get; set; }
        public  TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();  

        public abstract void CloseConnection();

    }
}
