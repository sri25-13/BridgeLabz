using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Delegates
{
    class Addition
    {
        public delegate int Operation(int x, int y);
       public static int adding(int a,int b)
        {
            return a + b;
        }
        public static int Multiplication(int a ,int b)
        {
            return a * b;
        }
    }
}
