namespace Polymo_DBConn
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Sql connection closed.");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Sql connection is open.");
        }
    }
}
