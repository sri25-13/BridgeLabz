using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns
{
     interface ISocketAdapter
    {
       public Volt Get120volt();
      public Volt Get12volt();
        public Volt Get3volt();
    }
}
