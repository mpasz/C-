using System;
using System.Text;
using System.Threading.Tasks;


namespace Bowling3
{

    class Program
    {
        static void Main(string[] args)
        {

        var gameResult = new Result();
        var listOfPlayers = new FileReader();


        foreach (var player in listOfPlayers.FillTheList())
            {
                Console.WriteLine(player.PlayerName);
                Console.WriteLine(gameResult.GameResult(player).ToString());
            }

        }
    }
}
