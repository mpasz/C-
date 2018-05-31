using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("Welcome to Stopwatch. Press 1 to Start measure time");
            var x = Console.ReadLine();
            DateTime y; ;

            if(String.IsNullOrWhiteSpace(x))
                Console.WriteLine("Why don't you listen to me?!");

            for (var i = 1; i <= 4; i++ )
            {
                if (i == 1)
                {
                    stopwatch.Start();

                    Console.WriteLine("Stopwatch is running.Press 2 to stop");
                    x = Console.ReadLine();
                   
                }
                if (i == 2)
                {
                        stopwatch.Stop();
                        Console.WriteLine("Stopwatch stopped. What do you want to do ? (1 to start again or 3 to see duration)");
                        x = Console.ReadLine();
                        if( Convert.ToInt32(x) == 1)
                        i = 0;
                            else i = 3;
                }
                if (i == 3)
                {
                        {
                            i = 3;
                            stopwatch.Duration();
                            Console.WriteLine("Press 4 to exit");
                            var q = Console.ReadLine();
                            if (i == Convert.ToInt32(q))
                            {
                                i = 4;
                                return;
                            }
                        }
                }
                
            }

        }
    }
}
