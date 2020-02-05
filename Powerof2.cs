using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Powerof2
    {
        public static void Power()
        {
            Console.WriteLine("enter the number:");
            int n = Utility.PowerInput();
            int power = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("2^" + i + "=" + power);
                power = power * 2;
            }
        }
    }
}
