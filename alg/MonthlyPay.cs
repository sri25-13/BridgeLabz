﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MonthlyPay
    {
        public static void Month()
        {
            Console.WriteLine("enter loan amount");
            double P = Utility.readInt();
            Console.WriteLine("enter years");
            double Y = Utility.readInt();
            Console.WriteLine("enter interest");
            double R = Utility.readInt();
            double r = R / (12 * 100);
            double n = 12 * Y;
            Console.WriteLine((P * R) / (1 - Math.Pow(1 + r, -n)));
        }
    }
}
