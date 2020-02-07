using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        public static void Prime()
        {
            Console.Write("Enter The Start Number: ");
            int startNumber = Utility.readInt();
            Console.Write("Enter the End Number : ");
            int endNumber = Utility.readInt();
          
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}



            
            
        
    


