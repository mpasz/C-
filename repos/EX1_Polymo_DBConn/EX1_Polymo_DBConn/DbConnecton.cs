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
        private TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();  //we can change abstract methed's body from other class wgo derive form this. 

        public abstract void CloseConnection();

    }
}
