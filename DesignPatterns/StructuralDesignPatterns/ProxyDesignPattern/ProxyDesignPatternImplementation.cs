using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    public class ProxyDesignPatternImplementation
    {
       public static void ProxyDesignPattern()
        {
            MathProxy proxy = new MathProxy();
            Console.WriteLine(proxy.Adding(4, 2));
            Console.WriteLine(proxy.Subtracting(4, 2));
        }
    }
}
