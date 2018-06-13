namespace Bowling3
{
    public class BowlingEngine
    {
        public int SumOfPoints(Player player)
        {
            var points = 0;
            var modulo = 0;


            if (player.Points.Length % 2 == 0)
                modulo = 0;
            else
                modulo = 1;


            switch (modulo)
            {
                case 0:
                    for (int i = 0; i < player.Points.Length - 1  ; i++)
                    {
                        if (player.Points[i] + player.Points[i + 1] == 10)
                        {
                            for (int j = 0; j <= 3; j++)
                            {
                                points += player.Points[j];
                            }
                        }
                        else if
                          (player.Points[i] == 10)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                points += player.Points[j];
                            }
                        }
                        else
                        {
                            points += player.Points[i];
                        }

                    }

                    break;
                case 1:

                    for (int i = 0; i < player.Points.Length - 1; i++)
                    {
                        if (player.Points[i] + player.Points[i + 1] == 10)
                        {
                            for (int j = 0; j <= 3; j++)
                            {
                                points += player.Points[j];
                            }
                        }
                        else if
                          (player.Points[i] == 10)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                points += player.Points[j];
                            }
                        }
                        else
                        {
                            points += player.Points[i];
                        }

                    }



                    break;
             }
           
            return points;

        }
    }
}
