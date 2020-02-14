using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Binary
    {
        public static void BinaryM()
        {
            Console.WriteLine("enter a number");
            int n = Utility.ReadInt();
            
            string str = "";
            while(n>0)
            {
               
                int num = n % 2;
                n /= 2;
                str = num + str;
            }
          
            Console.WriteLine(str);

        }
    }
}
