using System;
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
            Console.WriteLine("Give my details to connect:   ");
            var cs = Console.ReadLine();
            var command = @"Select * from tableA";


            DbCommand SQldbCommand = new DbCommand(new SqlConnection(cs), command);
            SQldbCommand.Execute();
            

            DbCommand OracaledbCommand = new DbCommand(new OracleConnection(cs), command);
            OracaledbCommand.Execute();



        }
    }
}
