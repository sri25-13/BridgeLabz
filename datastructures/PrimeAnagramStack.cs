// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramStack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for primeanagrams using stack
    /// </summary>
    public class PrimeAnagramStack
    {
        /// <summary>
        /// Primes the anagrams using stack.
        /// </summary>
        public static void PrimeAnagramsUsingStack()
        {
            Stack<int> stack = new Stack<int>();
            int[] array = Utility.Array(Utility.PrimeNumbers1(1000));
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Utility.IsAnagram(array[i], array[j]))
                    {
                        stack.Push(array[i]);
                    }
                }
            }

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}