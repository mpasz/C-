using System.Collections.Generic;

namespace Bowling3
{
    public class BowlingEngine
    {

        //public List<Player> fillList()
        //{

        //}

        public int SumOfPoints(Player player)
        {
            var points = 0;


                    for (int i = 0; i < player.Points.Length; i++)
                    {
                        if (i != player.Points.Length - 1 && (player.Points[i] + player.Points[i + 1] == 10))

                        {
                            for (int j = i; j <= i + 2; j++)
                            {
                                points += player.Points[j];
                            }
                            i++;
                        }
                        else if
                           (i == player.Points.Length - 1)
                        {
                            points += player.Points[i];
                        }

                        else if
                          (player.Points[i] == 10)
                        {
                            for (int j = i; j <= i+3 ; j++)
                            {
                                points += player.Points[j];
                            }
                        }
                        else
                        {
                            points += player.Points[i];
                        }

                    }

 
            return points;

        }
    }
}
