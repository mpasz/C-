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

            //work path
            //var path = @"C:\Users\mpasz\source\Bowling.txt";
            //var lines = File.ReadAllLines(@"C:\Users\mpasz\source\Bowling.txt");

            //Home path
            var path = @"C:\Users\Michal\source\Bowling.txt";
            var lines = File.ReadAllLines(path);
            var content = File.ReadAllText(path);
            //Console.WriteLine("TEST: " + content.Split(',')); 
            

            int pointsContent = 0;

            var player = new Player();

            for (int i = 0; i < lines.Length; i++)
            {
                
                if ( i % 2 == 0)
                {
                    Console.WriteLine("Player Name : " + lines[i]);
                    player.playerName.Add(lines[i]);
                }
                else
                {
                    Console.WriteLine("Points: " + lines[i]);
                    var line = lines[i].Replace(",","");
                    player.playerPoints.Add(Int32.Parse(line.Split(' ')));
                    //pointsContent = line.Select(Int32.Parse).ToList();
                    //player.playerPoints.Add(Int32.Parse(lines[i]));

                }
            }
                       

            foreach (var p in player.playerName)
            {
                Console.WriteLine(p);
            }

            foreach (var score in player.playerPoints)
            {
                Console.WriteLine(score);
            }

            //foreach (var item in pointsContent)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("temp points :" + pointsContent);


            //            int[] points;
            //            char[] names;


            ////# rozwiązanie PB
            //            StreamReader reader = new StreamReader(path);
            //            int n = File.ReadAllLines(path).Length;

            //            var player = new Player();

            //            for (int i = 0; i < n; i++)
            //            {

            //                if (i % 2 == 0)
            //                {
            //                    Console.WriteLine("Player Name :" + reader.ReadLine().ToString());
            //                    player.playerName.Add(reader.ReadLine().ToList().ToString());
            //                 }
            //                else
            //                {
            //                    Console.WriteLine("Player score :" + reader.ReadLine().ToString());
            //                    //player.playerPoints.Add(Int32.Parse(reader.ReadLine().Remove(','))) ;
            //                    player.playerPoints = reader.ReadLine().Split(',').Select(Int32.Parse).ToArray();
            //                }

            //                //Console.WriteLine("Points :" + reader.ReadLine().Select(Int32.Parse).ToArray());

            //                //player.Players = reader.ReadLine().ToList();


            //                //player.Points = reader.ReadLine().Split(',').Select(Int32.Parse).ToArray();


            //            }






        }
    }
}


