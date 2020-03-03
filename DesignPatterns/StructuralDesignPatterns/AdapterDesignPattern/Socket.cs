using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns
{
   public class Socket
    {
        public  Volt GetVolts()
        {
            return new Volt();
        }
    }
}
