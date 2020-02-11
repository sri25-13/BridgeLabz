using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TwoDArray
    {
        public static void Array2d()
        {
            Console.WriteLine("enter the no of rows");
            int m = Utility.ReadInt();
            Console.WriteLine("enter no of columns");
            int n = Utility.ReadInt();
            Console.WriteLine("enter the array elements");
            int[,] arr = Utility.Read2dArray(m, n);
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
