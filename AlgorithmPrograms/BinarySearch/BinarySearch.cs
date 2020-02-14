using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        public static string[] ReadingFile()
        {

            string[] words = File.ReadAllLines(@"C:\Users\Bridgelabz\source\repos\input.txt");

            Console.WriteLine("enter a word to search");
            string word = Utility.ReadString();
            string[] sortedWords = SortWords(words);
            int result = SearchBinary(sortedWords, word);
          

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);
        
            return words;
        }
        static string[] SortWords(string[] ar1)
        {
            string[] arr = new string[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                arr[i] = ar1[i].ToLower();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }
       static int SearchBinary(string[] arr, string str)
        {
            int res = 0; 
                int length = arr.Length - 1;
            while (res <= length)
            {
                int m = res + (length - res) / 2;

                int result = str.CompareTo(arr[m]);
                if (result == 0)
                    return m;
                if (result > 0)
                    res = m + 1;
                else
                    length = m - 1;
            }

            return -1;
        }

    }
}


