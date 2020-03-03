using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns
{
    public class SocketObjectAdapterImplementation : ISocketAdapter
    {
        Socket socket = new Socket();
        public Volt Get120volt()
        {
            return this.socket.GetVolts();
        }

        public Volt Get12volt()
        {
            Volt volt = this.socket.GetVolts();
           return  this.ConvertVolts(volt, 10);
        }
       public Volt Get3volt()
        {
            Volt volt = this.socket.GetVolts();
            return this.ConvertVolts(volt, 40);
        }

        public Volt ConvertVolts(Volt volt, int i)
        {
            Volt volt1 = new Volt();
            return new Volt(volt1.GetVolt()/ i);
        }
    }
}
