using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Replace
    {
        public static void ReplaceString()
        {
            String str = "Hello <<username>>,How are you?";
            Console.WriteLine("enter the string you want to replace with username");
            String s = Utility.StringInput();
            if (s.Length <= 3)
            {
                Console.WriteLine("INVALID INPUT");
            }

            else
            {
                String replace = str.Replace("<<username>>", s);
                Console.WriteLine(replace);
            }
        }
    }
}
