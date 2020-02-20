using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleEndedQueue
{
   public class PalindromeChecker
    {
        public static void IsPalindrome()
        {
            Console.WriteLine("enter a string to check whether it is palindrome :");
            string s = Utility.ReadString();
            char[] ch = s.ToCharArray();
            bool result = CheckIfPalindrome(ch);
            if (result)
            {
                Console.WriteLine(s + " is a palindrome");
            }
            else
            {
                Console.WriteLine(s + " is not a palindrome");
            }
        }
        public static bool CheckIfPalindrome(char[] ch)
        {
            Dequeue<char> dq = new Dequeue<char>();
            for (int i = 0; i < ch.Length; i++)
            {
                dq.AddRear(ch[i]);
            }
            dq.PrintDeQueue();
            int k = 0;
            while (k < ch.Length)
            {
                
                 char c = dq.DeleteRear();
                if (ch[k] != c)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine(ch[k]);
                    k++;
                    return true;
                }
            }
            return dq.IsEmpty();
        }
    }
}