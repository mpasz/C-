using System;

namespace Exercise1
{
    public class Stopwatch
    {

        private DateTime x;
        private DateTime y;



        public void Start()
        {
            x = DateTime.Now;
        }



        public void Stop()
        {
            y = DateTime.Now;
        }

        public void Duration()
        {
            TimeSpan span = y.Subtract(x);
            Console.WriteLine("Duration :"+span);
        }

    }
}
