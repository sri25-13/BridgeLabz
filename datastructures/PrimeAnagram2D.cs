// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagram2D.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for 2d PrimeAnagram
    /// </summary>
    public class PrimeAnagram2D
    {
        /// <summary>
        /// Primes the anagram.
        /// </summary>
        public static void PrimeAnagram()
        {
            int row = 0, column = 0, tot = 100;
            Console.WriteLine("enter the range of the values to get prime anagrams");
            int min = Utility.ReadInt();
            int max = Utility.ReadInt();
            int[,] array = new int[10, 30];
            int[] temp = Utility.Array(Utility.PrimeNumbers(min, max));
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = i + 1; j < temp.Length - 1; j++)
                {
                    if (Utility.IsAnagram(temp[i], temp[j]))
                    {
                        if (temp[i] >= tot)
                        {
                            tot += 100;
                            row++;
                            column = 0;
                        }

                        array[row, column] = temp[i];
                        column++;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}