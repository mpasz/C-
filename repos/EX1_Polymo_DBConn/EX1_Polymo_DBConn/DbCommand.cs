namespace Polymo_DBConn
{
    public class DbCommand : DbConnection
    {
        public DbCommand(string connectionString , string command) : base(connectionString)
        {
            if (System.String.IsNullOrWhiteSpace(command))
                throw new System.NullReferenceException("Command can't be empty!");

            SqlCommand = command;
        }

        private string SqlCommand { get; set; }

        public void Execute()
        {
            OpenConnection();
            System.Console.WriteLine("Command Executed");
            CloseConnection();
        }

        public override void CloseConnection()
        {
            throw new System.NotImplementedException();
        }

        public override void OpenConnection()
        {
            throw new System.NotImplementedException();
        }
    }
}
