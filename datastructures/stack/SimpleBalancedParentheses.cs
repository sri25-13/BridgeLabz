using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class SimpleBalancedParentheses
    {
        static Stack<char> st = new Stack<char>();

        public static void balancedParanthesis()
        {
            String s = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
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
        public static Boolean CheckIfBalanced(String s)
        {

            char[] ch = s.ToCharArray();
            int length = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(')
                {
                    st.Push(ch[i]);
                    length++;
                }
                else if (ch[i] == ')')
                {
                    if (length == 0)
                    {
                        return false;
                    }
                    char c = st.Pop();
                    length--;
                }

            }
            return st.IsEmpty();
        }
    }
}