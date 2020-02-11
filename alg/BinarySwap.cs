using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySwap
    {
        public static void Swapping()
        {
            Console.WriteLine("enter number for swapping");
            int x = Utility.ReadInt();

            BinaryConversion(x);
            int y = ((x & 0x0F )<<4|(x & 0xF0)>>4);
           

            Console.WriteLine(y);
            BinaryConversion(y);
           

        }
        public static void BinaryConversion(int n)
        {
            string str = "";
            while (n > 0)
            {

                int num = n % 2;
                n /= 2;
                str = num + str;
            }

            Console.WriteLine(str);


        }
    }
}