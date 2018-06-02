namespace Polymo_DBConn
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Oracle connection closed.");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Oraacle connection is open.");
        }
    }
}
