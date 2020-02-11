using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class VendingMachine
    {
        public static void Vending()
        {
            Console.WriteLine("enter the amount");
            int n = Utility.ReadInt();
            int[] arr = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notecount = new int[arr.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (n >= arr[i])
                {
                    notecount[i] = n / arr[i];
                    n = n - notecount[i] * arr[i];
                    count+= notecount[i];
                }

                if (notecount[i] != 0)
                {
                    Console.WriteLine(arr[i] + " : "
                        + notecount[i]);
                }
            }
                Console.WriteLine("total number of notes:"+ count);
            
        }
    }
}
