using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bowling3
{
    class FileReader
    {
        private static string path = @"C:\Users\Michal\source\Bowling.txt";
        int linesCount = File.ReadAllLines(path).Count();
        StreamReader sr = new StreamReader(path);
        Player playerProfile = new Player();

        public List<Player> FillTheList()
        {
            
            List<Player> ListOfPlayers = new List<Player>();

            for (int i = 0; i < linesCount / 2; i++)
            {
                var player = new Player().setName(sr.ReadLine().ToString()).setPoints(sr.ReadLine().Split(',').Select(Int32.Parse).ToArray());
                ListOfPlayers.Add(player);

            }
            return ListOfPlayers;
        }
        
            
    }
}
