using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
       public static String StringInput()
        {
            String s = Console.ReadLine();
            return s;
             
        }
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
