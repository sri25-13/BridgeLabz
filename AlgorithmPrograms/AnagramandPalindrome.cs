// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AnagramandPalindrome.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for finding prime anagrams and palindromes
    /// </summary>
    public class AnagramandPalindrome
    {
        /// <summary>
        /// Primes the palindrome.
        /// </summary>
        public static void PrimePalindrome()
        {
            Console.Write("Enter the range: ");
            int startnumber = Utility.ReadInt();
            int endNumber = Utility.ReadInt();
            bool b = true;
            for (int i = startnumber; i < endNumber; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        b = true;
                    }
                }

                if (b && Utility.IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}