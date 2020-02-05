using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class LeapYear
    {
        public static void Leap()
        {
            Console.WriteLine("enter a year:");
            int n = Utility.readInt();
            if (n % 400 == 0)
            {
                Console.WriteLine(n + "is as leapyear");
            }
            else if (n % 4 == 0)
            {
                if (n % 100 != 0)
                {
                    Console.WriteLine(n + "is a leapyear");
                }
                else
                {
                    Console.WriteLine(n + "is not a aleapyear");
                }
            }
            else
            {
                Console.WriteLine(n + "is not a aleapyear");
            }

            }
        }
    }
