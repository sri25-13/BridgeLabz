using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
   public class Client
    {
         IService service;
        public void start(IService service)
        {
            Console.WriteLine("start");
           service.Serve();
        }
    }
}
