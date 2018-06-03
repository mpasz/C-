namespace Polymo_DBConn
{
    public class DbCommand 
    {
        public DbCommand(DbConnection connectionString, string command) 
        {
            if (System.String.IsNullOrWhiteSpace(command))
                throw new System.NullReferenceException("Command can't be empty!");

            _sqlCommand = command;
            _connectionString = connectionString;
            
        }

        private DbConnection _connectionString;
        private string _sqlCommand;
        

        public void Execute()
        {          
            _connectionString.OpenConnection();
            System.Console.WriteLine("Command : "+_sqlCommand +" executed");
            _connectionString.CloseConnection();
        }

    }

}
