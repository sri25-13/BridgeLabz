using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Utility
    {
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string ReadString()
        {
            string s = Console.ReadLine();
            return s;
        }
    }
    }
