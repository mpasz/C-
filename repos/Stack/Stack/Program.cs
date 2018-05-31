using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{



    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack();

            stack.Clear();

            stack.Push(1);
            stack.Push("Name");
            stack.Push("Lastname");
            stack.Push(2);
            stack.Push(4);

            //stack.Clear(); test for eexception

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());



        }
    }
}
