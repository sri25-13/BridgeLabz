using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Delegates
{
    class Operations
    {
        public delegate void Operation(int x, int y);
        public static void Adding(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public  static void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Subtraction(int a,int b)
        {
            Console.WriteLine(b - a);
        }
    }
}
