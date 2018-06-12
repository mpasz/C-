using System.Collections.Generic;

namespace Bowling3
{
    public class Player
    {

        public string PlayerName;
        public int[] Points;

        public Player()
        {
        }

        public Player setName (string playerName)
        {
            this.PlayerName = playerName;
            return this;
        }

        public Player setPoints(int[] points)
        {
            this.Points = points;
            return this;
        }

    }
}
