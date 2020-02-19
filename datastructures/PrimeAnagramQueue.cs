// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for primeanagrams using queue
    /// </summary>
    public class PrimeAnagramQueue
    {
        /// <summary>
        /// Primes the using queue.
        /// </summary>
        public static void PrimeUsingQueue()
        {
            Queue<int> q = new Queue<int>();
            Console.WriteLine("enter range of numbers to print prime anagrams");
            int num = Utility.ReadInt();
            int[] array = Utility.Array(Utility.PrimeNumbers1(num));
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (Utility.IsAnagram(array[i], array[j]))
                    {
                        q.Enqueue(array[i]);
                    }
                }
            }

            while (!q.IsEmpty())
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}