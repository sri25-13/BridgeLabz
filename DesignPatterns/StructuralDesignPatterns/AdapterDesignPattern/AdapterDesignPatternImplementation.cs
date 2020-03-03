using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns
{
    public class AdapterDesignPatternImplementation
    {
        public static void AdapterImplementation()
        {
            SocketObjectAdapterImplementation SocketObjectAdapter = new SocketObjectAdapterImplementation();
            Volt get12volt = SocketObjectAdapter.Get12volt();
            Volt get3volt = SocketObjectAdapter.Get3volt();
            Volt get120volt = SocketObjectAdapter.Get120volt();
            Console.WriteLine(get3volt.GetVolt());
            Console.WriteLine(get12volt.GetVolt());
            Console.WriteLine(get120volt.GetVolt());
        }
    }
}
