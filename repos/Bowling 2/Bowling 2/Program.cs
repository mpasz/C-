using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_2
{

    class Program
    {
        static void Main(string[] args)
        {
           
            var path = @"C:\Users\mpasz\source\Bowling.txt";
            var lines = File.ReadAllLines(@"C:\Users\mpasz\source\Bowling.txt");

            int[] points;
            char[] names;
 
            StreamReader reader = new StreamReader(path);

            int n = File.ReadAllLines(path).Length;
            var player = new Player();

            for (int i = 0; i < n/2; i++)
            {
                player.Players = reader.ReadLine().ToArray();
                player.Points = reader.ReadLine().Split(',').Select(Int32.Parse).ToArray();
                
            }

            for (int i = 0; i < player.Players.Length ; i++)
            {
                Console.WriteLine("Suma punktów gracza {0} to : {1} ",   player.Players[i] , player.PointsSum());
            }
            
        }
    }
}

