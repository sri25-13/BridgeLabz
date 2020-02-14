﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Permutations
    {
        public static void MethodCalling()
        {
            Console.Write("enter a string to check permutations using recursion:");
            char[] ch = Utility.ReadString().ToCharArray();
            string s1 = Permute(ch, 0);
            Console.WriteLine(s1);
            Console.WriteLine("\n enter a string to check permutations using iteration:");
            string s = Utility.ReadString();
            Console.WriteLine();
            String s2 = PermutationUsingIteration(s);
            Console.WriteLine(s2);
            IsEqual(s1, s2);
        }
        public static void IsEqual(String s1, String s2)
        {
            Boolean result = s1.Contains(s2);
            if (result)
            {
                Console.WriteLine("Two string arrays are equal");
            }
            else
                Console.WriteLine("two string arrays are not equal");

        }
        public static String Permute(char[] ch, int currentIndex)
        {

            String result = "";

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
        public static void Swap(char[] ch, int i, int j)
        {
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;
        }

        public static String PermutationUsingIteration(String s)
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
        private static String Join(char[] a)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(a);
            return builder.ToString();
        }
    }
}


