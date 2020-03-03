using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns
{
    public class Volt
    {
        public int volt;
        public Volt()
        {
            this.volt = 120;
        }
        public Volt(int v)
        {
            this.volt = v;
        }
        public int GetVolt()
        {
            return this.volt;
        }
    }
}
