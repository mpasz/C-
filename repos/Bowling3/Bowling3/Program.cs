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

            var sr = new StreamReader(path);

            var playerProfile = new Player();

            List <Player> ListOfPlayers = new List<Player>();

            int[] points = new int[linesCount];

            for (int i = 0; i < linesCount / 2 ; i++)
            {
                var player = new Player().setName(sr.ReadLine().ToString()).setPoints(sr.ReadLine().Split(',').Select(Int32.Parse).ToArray());
                ListOfPlayers.Add(player);
                
            }


            foreach (Player item in  ListOfPlayers)
            {
                Console.WriteLine(item.PlayerName );

            }

            for (int i = 0; i < playerProfile.Points.Length; i++)
            {
                Console.WriteLine(playerProfile.Points[i].ToString());
            }
            
            //Console.WriteLine(playerProfile.ReturnPlayer());
            



        }
    }
}
