using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
   public class Math:IMath
    {
        public int Adding(int x,int y)
        {
            return (x + y);
        }
        public int Subtracting(int x,int y)
        {
            return (x - y);
        }
    }
}
