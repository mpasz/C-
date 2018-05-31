using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {

        static void Ex1()
        {
            Console.WriteLine("Enter a few numbers separeted by a hyphen");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            foreach (var str in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(str));
            }

            numbers.Sort();

            var isConsecutive = true;

            for (var i = 1; i < numbers.Count(); i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        static void Ex2()
        {
            Console.WriteLine("Enter a few numbers separeted by a hyphen");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;

                var numbers = new List<int>();
                foreach(var str in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(str));
                }

                //numbers.Sort();

                for(var i = 1; i < numbers.Count(); i++)
                {
                    if(numbers[i] != numbers[i+1]-1)
                    {
                        Console.WriteLine("Duplicate!!" + numbers[i]);
                        break;
                    }
                }
            }
            else
            {
                return;
            }

            
            
        }
            



        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            /*builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Michal Pasz");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);*/

            //lub bardziej wydajny i efektywny kod - ponieważ stringbuilder zwraca typ stringbuilder

            //builder
            //        .Append('-', 10)
            //        .AppendLine()
            //        .Append("Michal Pasz")
            //        .AppendLine()
            //        .Append('-', 10);

            //Console.WriteLine(builder);

            //Ex1();
            Ex2();

            

        }
    }
}
