﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySwap
    {
        public static void Swapping()
        {
            Console.WriteLine("enter number for swapping");
            int x = Utility.readInt();
            
          methodcalling(x);
            int y = ((x & 0x0F )<<4|(x & 0xF0)>>4);
           

            Console.WriteLine(y);
            methodcalling(y);
           

        }
        public static void methodcalling(int n)
        {
            String str = "";
            while (n > 0)
            {

                int num = n % 2;
                n = n / 2;
                str = num + str;
            }

            Console.WriteLine(str);


        }
    }
}