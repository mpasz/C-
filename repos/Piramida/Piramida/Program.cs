using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generator Piramid 1.0");

            Console.WriteLine("Ile ma mieć stopni?");
            int ilosc = int.Parse(Console.ReadLine());

            Console.WriteLine("A z czego ma być zrobiona?");
            char znak = char.Parse(Console.ReadLine());

            Console.WriteLine("Ostatnie pytanie: normalna(1) czy odwrócona(2) ?");
            string input = Console.ReadLine();

            switch (input.ToLower())
            { 
                case "1":
                Console.WriteLine("Wybrałeś normalną:");
                    {
                        for (int rzad = 0; rzad < ilosc; rzad++)
                        {

                            for (int przestrzen = ilosc - rzad; przestrzen > 0 ; przestrzen--)
                            {
                                Console.Write(" ");
                            }

                            for (int kolumna = 0; kolumna < (2 * rzad + 1); kolumna++)
                            {
                                Console.Write(znak);
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine("Zakończono obliczanie.");
                        Console.ReadKey();
                        break;
                    }

                case "2":
                    Console.WriteLine("Płyniesz pod prąd? Oto Twoja 'KONSTRUKCJA':");
                    {
                        for (int rzad = ilosc; rzad > 0; rzad--)
                        {

                            for (int przestrzen = rzad; przestrzen < ilosc  ; przestrzen++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = (2 * rzad - 1); j > 0 ; j--)
                            {
                                Console.Write(znak);
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine("Zakończono obliczanie!");
                        Console.ReadKey();
                        break;
                    }
                default:
                Console.WriteLine("Jesteś pewien co robisz?");
                Console.WriteLine("Policz jeszcze raz i wróć");
                break;
            }
            Console.ReadKey();
        }
    }
}



