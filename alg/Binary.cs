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
            int n = Utility.readInt();
            
            String str = "";
            while(n>0)
            {
               
                int num = n % 2;
                n = n / 2;
                str = num + str;
            }
          
            Console.WriteLine(str);

        }
    }
}
