using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class twodiArray
    {
        public static void array2d()
        {
            Console.WriteLine("enter the no of rows");
            int m = Utility.readInt();
            Console.WriteLine("enter no of columns");
            int n = Utility.readInt();
            Console.WriteLine("enter the array elements");
            int[,] arr = Utility.read2dArray(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

            }
        }

    }
}
