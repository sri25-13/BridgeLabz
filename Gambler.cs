using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Gambler
    {
        public static void Gambling()
        {
            Console.WriteLine("Enter stake value");
            int stake = Utility.ReadInt();
            Console.WriteLine("Enter goal");
            int goal = Utility.ReadInt();
            Console.WriteLine("enter the number of trials");
            int trials = Utility.ReadInt();

            int wins = 0;
            Random rnd = new Random();
            for (int t = 1; t < trials; t++)
            {
                int cash = stake;
                if (cash > 0 && cash < goal)
                {

                    if (rnd.NextDouble() < 0.5)
                    {
                        cash++;
                        wins++;

                    }
                    else
                    {
                        cash--;
                    }
                }

                if (cash >= goal)

                {
                    Console.WriteLine("goal reached");
                }
            }

            Console.WriteLine(wins + "wins of" + trials);
            double a = ((100.0 * wins) / trials);
            Console.WriteLine("percentage of games won:" + a);
            Console.WriteLine("percentage of games lost:" + (100 - a));



        }
    }
}