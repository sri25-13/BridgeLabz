// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Permutations.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Text;

    /// <summary>
    /// class for printing permutation of a string
    /// </summary>
    public class Permutations
    {
        /// <summary>
        /// Methods the calling.
        /// </summary>
        public static void MethodCalling()
        {
            Console.Write("enter a string to check permutations using recursion:");
            char[] ch = Utility.ReadString().ToCharArray();
            string s1 = Permute(ch, 0);
            Console.WriteLine(s1);
            Console.WriteLine("\n enter a string to check permutations using iteration:");
            string s = Utility.ReadString();
            Console.WriteLine();
            string s2 = PermutationUsingIteration(s);
            Console.WriteLine(s2);
            IsEqual(s1, s2);
        }

        /// <summary>
        /// Determines whether the specified s1 is equal.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        public static void IsEqual(string s1, string s2)
        {
            bool res = s1.Contains(s2);
            if (res)
            {
                Console.WriteLine("Two string arrays are equal");
            }
            else
            {
                Console.WriteLine("two string arrays are not equal");
            }
        }

        /// <summary>
        /// Permutes the specified ch.
        /// </summary>
        /// <param name="ch">The ch.</param>
        /// <param name="currentIndex">Index of the current.</param>
        /// <returns></returns>
        public static string Permute(char[] ch, int currentIndex)
        {
            string result = "";
            if (currentIndex == ch.Length - 1)
            {
                result = new string(ch);
                Console.Write(result);
                Console.Write(" ");
            }
            for (int i = currentIndex; i < ch.Length; i++)
            {
                Swap(ch, currentIndex, i);
                Permute(ch, currentIndex + 1);
                Swap(ch, currentIndex, i);
            }

            return result;
        }

        /// <summary>
        /// Swaps the specified ch.
        /// </summary>
        /// <param name="ch">The ch.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        public static void Swap(char[] ch, int i, int j)
        {
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;
        }

        /// <summary>
        /// Permutations the using iteration.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        public static string PermutationUsingIteration(string s)
        {
            string result = "";
            char[] chars = s.ToCharArray();
            int[] p = new int[s.Length];
            Console.WriteLine(s);
            int i = 1;
            while (i < chars.Length)
            {
                if (p[i] < i)
                {
                    int j = ((i % 2) == 0) ? 0 : p[i];
                    Swap(chars, i, j);
                    result = new string(Join(chars));
                    Console.WriteLine(result);
                    p[i]++;
                    i = 1;
                }
                else
                {
                    p[i] = 0;
                    i++;
                }
            }

            return "";
        }

        /// <summary>
        /// Joins the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static string Join(char[] a)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(a);
            return builder.ToString();
        }
    }
}