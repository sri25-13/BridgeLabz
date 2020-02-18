// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AnagramDetection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for detecting two strings are anagram or not
    /// </summary>
    public class AnagramDetection
    {
        /// <summary>
        /// Anagrams this instance.
        /// </summary>
        public static void Anagram()
        {
            Console.WriteLine("enter first string");
            string s1 = Utility.ReadString();
            Console.WriteLine("enter second string");
            string s2 = Utility.ReadString();
            char[] array1 = s1.ToLower().ToCharArray();
            char[] array2 = s2.ToLower().ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);
            string res1 = new string(array1);
            string res2 = new string(array2);
            if (res1 == res2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }
}