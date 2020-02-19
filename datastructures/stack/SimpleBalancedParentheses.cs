// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleBalancedParentheses.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for showing balanced parentheses
    /// </summary>
   public class SimpleBalancedParentheses
    {
        static Stack<char> stack = new Stack<char>();

        /// <summary>
        /// Balances the paranthesis.
        /// </summary>
        public static void BalancedParanthesis()
        {
            string s = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            Console.WriteLine("expression is" + s);
            bool check = CheckIfBalanced(s);
            if (check)
            {
                Console.WriteLine("paranthesis are balanced");
            }
            else
            {
                Console.WriteLine("paranthesis are not balanced");
            }
        }

        /// <summary>
        /// Checks if balanced.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        public static bool CheckIfBalanced(string s)
        {
            char[] ch = s.ToCharArray();
            int length = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(')
                {
                    stack.Push(ch[i]);
                    length++;
                }
                else if (ch[i] == ')')
                {
                    if (length == 0)
                    {
                        return false;
                    }

                    char c = stack.Pop();
                    length--;
                }
            }

            return stack.IsEmpty();
        }
    }
}