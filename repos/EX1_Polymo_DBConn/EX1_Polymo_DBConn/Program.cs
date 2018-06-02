using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polymo_DBConn
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give my details for connect to Oracle:  ");
            OracleConnection oracleConnection = new OracleConnection(System.Console.ReadLine());
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            System.Console.WriteLine("Give my details for connect to SQL:  ");
            SqlConnection sqlConnection = new SqlConnection(System.Console.ReadLine());
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

        }
    }
}
