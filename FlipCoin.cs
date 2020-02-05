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
            int n = Utility.readInt();
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
            Console.WriteLine(a);
            Console.WriteLine(((n - headco) / n) * 100.0);
        }
    }
}