using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public static void Wind()
        {
            Console.WriteLine("enter t value");
            double t = Utility.readInt();
            Console.WriteLine("enter v value");
            double v = Utility.readInt();
            if (t < 50 || (v > 3 && v < 120))
            {
                double w = (35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * (Math.Pow(v, 0.16)));
                Console.WriteLine(w);

            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
        }
    }
}
