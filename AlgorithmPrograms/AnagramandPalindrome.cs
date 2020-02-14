using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class AnagramandPalindrome
    {
        public static void PrimePalindrome()
        {
          
            Console.Write("Enter the End Number : ");
            int endNumber = Utility.ReadInt();


            for (int i = 2; i <= endNumber; i++)
            {

                bool b = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    
                    if (i % j == 0)
                    {
                        b = false;
                        break;


                    }
                    else
                        b = true;
                }

                    if (b && Utility.IsPalindrome(i))
                    {

                        Console.WriteLine(i);
                    }
                
            }
        }
        public static void PrimeAnagram()
        {

        }
    }
}








