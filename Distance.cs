﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public static void Dist()
        {
            Console.WriteLine("enter x value:");
        
            Console.WriteLine("enter y value:");
            int x= Utility.readInt();

            int y =Utility.readInt();
            int a =(x*x)+(y*y);
            Double res = Math.Pow(a, 0.5);
            Console.WriteLine(res);
        }
    }
}
