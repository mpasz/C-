using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstryktowy
{
    public class Punkt
    {

                private int wysokosc = 0;
                private int szerokosc = 0;


        public Punkt(int x, int y)  //kontruktor!!
        {
            PodajPolozenie(x, y);
        }

        public void PodajPolozenie(int x, int y)
        {
            Console.WriteLine("Twoje położenie to {0} , {1}:", x, y);
        }

    }
}
