using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class AnagramDetection
    {
        public static void Anagram()
        {
            Console.WriteLine("enter first string");
            string str1 = Utility.ReadString();
            Console.WriteLine("enter second string");
            string str2 = Utility.ReadString();
            char[] s1Array= str1.ToLower().ToCharArray();
            char[] s2Array = str2.ToLower().ToCharArray();
            Array.Sort(s1Array);
            Array.Sort(s2Array);
            string res1 = new string(s1Array);
            string res2 = new string(s2Array);

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


    

