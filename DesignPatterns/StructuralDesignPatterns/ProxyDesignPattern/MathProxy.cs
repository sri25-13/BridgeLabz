using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
   public class MathProxy:IMath
    {
        private Math math = new Math();
        public int Adding(int x,int y)
        {
            return math.Adding(x, y);
        }
        public int Subtracting(int x, int y)
        {
            return math.Subtracting(x, y);
        }
    }
}