using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class HarmonicNum
    {
        public static void Harmonic()
        {
            Console.WriteLine("enter the number:");
            int n = Utility.readInt();
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
                Console.WriteLine(n + "harmonic value is:"+sum);
            }
        }
    }
