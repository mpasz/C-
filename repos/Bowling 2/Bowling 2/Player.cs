namespace Bowling_2
{
    public class Player
    {
        public char [] Players { get; set; }
        public int [] Points { get; set; }
        private int sum = 0;
        private char player;

        public Player()
        {

        }

        public int PointsSum()
        {   
            for (int i = 0; i < Players.Length; i++)
            {
                sum += Points[i];
                //player = Players[i];
            }
            return sum; 
        }

        //public char PlayerName()
        //{
        //    foreach (var player in Players)
        //        return player;

        //}
    }
}

