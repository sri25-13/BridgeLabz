using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSort
    {
        public static void Merge()
        {
            Console.WriteLine("enter the arraysize");
            int n = Utility.ReadInt();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Utility.ReadInt();
            }
            Sorting(arr, 0, n - 1);
           Console.WriteLine ("after sorting");
            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine(arr[i]);
            }
        }

        public static void Sorting(int[] arr, int start, int end)
        {
            if (start != end)
            {
                int mid = (start + end) / 2;
                Sorting(arr, start, mid);
                Sorting(arr, mid + 1, end);
                Merging(arr, start, end);

            }

             static void Merging(int[] arr, int start, int end)
            {
                int mid = (start + end) / 2;
                int i = start;
                int j = mid + 1;
                int k = start;
                int[] temp = new int[10];
                while (i <= mid && j <= end)
                {
                    if (arr[i] < arr[j])
                    {
                        temp[k] = arr[i];
                        i++;
                    }
                    else
                    {
                        temp[k] = arr[j];
                        j++;
                    }
                    k++;
                }
                while (i <= mid)
                {
                    temp[k++] = arr[i++];

                }
                while (j <= end)
                {
                    temp[k++] = arr[j++];

                }
                for (i = start; i <= end; i++)
                {
                    arr[i] = temp[i];

                }
            }
        }
    }
}
