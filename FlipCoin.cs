using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class FlipCoin
    {
        public static void Flip()
        {
            Console.WriteLine("enter the number of time to flip:");
            int n = Utility.ReadInt();
            double headco = 0;

            Random rnd = new Random();

            for (int i = 0; i <= n; i++)
            {
                if (rnd.NextDouble() < 0.5)

                {
                    headco++;

                }


            }
            double a = (headco / n) * 100.0;
            Console.WriteLine("percentage of heads:" + a);
            Console.WriteLine("percentage of tails:" + ((n - headco) / n) * 100.0);
        }
    }
}