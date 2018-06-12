using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
  

    class Program
    {
        static void Main(string[] args)
        {


            var content = File.ReadAllText(@"C:\Users\Michal\source\Test\BowlingResults.txt");
            //content.Replace('\r\n', ' ');
            //var content = File.ReadAllText(@"C:\Bowling.txt");

            string [] numbers = content.Replace('\r',' ').Replace('\n',' ').Split(new char[] {',' });
            //var numbers = content.Replace('\r', ' ').Replace('\n',' ').Split(',');
            
            
            var sum = 0;
                

                for (int j = 0; j < 20 ; j++)
                {
                    sum += Convert.ToInt32(numbers[j]);
                }


            Console.WriteLine(sum);
           
        
         }

    }
}


        


               
            
