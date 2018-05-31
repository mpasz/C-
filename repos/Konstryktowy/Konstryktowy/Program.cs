using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstryktowy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaje dwie liczby:" );
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
           

           var punkt = new Punkt(x, y);
        }
    }
}
