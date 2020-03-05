using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
   public class DependencyInjection
    {
        public static void DependencyInjectionImplementation()
        {
            Service service = new Service();
            Client client = new Client();
            client.start(service);
        }
    }
}
