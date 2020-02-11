using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PrimeFactors
    {
        public static void Prime()
        {
            Console.WriteLine("enter a number:");
            int n = Utility.ReadInt();
            for(int i=2;i<=n;i++)
            {
                while(n%i==0)
                {
                    Console.WriteLine(i);
                    n/=i;
                }
            }
          
        }
    }
}
