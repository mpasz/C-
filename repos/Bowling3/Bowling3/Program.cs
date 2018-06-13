using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling3
{

    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Michal\source\Bowling.txt";
            var linesCount = File.ReadAllLines(path).Count();
            var playerProfile = new Player();
            var gameResult = new Result();
            var sr = new StreamReader(path);

            List<Player> ListOfPlayers = new List<Player>();


            for (int i = 0; i < linesCount / 2 ; i++)
            {
                var player = new Player().setName(sr.ReadLine().ToString()).setPoints(sr.ReadLine().Split(',').Select(Int32.Parse).ToArray());
                ListOfPlayers.Add(player);
                
            }


            for (int i = 0; i < ListOfPlayers.Count; i++)
            {
                Console.WriteLine(gameResult.GameResult(ListOfPlayers[i]));
            }


            //foreach (Player p in ListOfPlayers)
            //{
            //    Console.WriteLine(gameResult.GameResult(p));
            //}

            //for (int i = 0; i < playerProfile.Points.Length; i++)
            //{
            //    Console.WriteLine(playerProfile.Points[i].ToString());
            //}

            //Console.WriteLine(playerProfile.ReturnPlayer());




        }
    }
}
