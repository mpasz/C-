namespace Bowling3
{
    public class Result
    {
        public int GameResult(Player player)
        {
            var bowlingEngine = new BowlingEngine();
            
            string[] result = new string[player.Points.Length + 2];
            var points = 0;
            result[0] += player.PlayerName;
            result[1] += bowlingEngine.SumOfPoints(player).ToString();


            for (int i = 0; i < player.Points.Length; i++)
            {
                points = bowlingEngine.SumOfPoints(player);
            }

            return points;

        }
    }
}
