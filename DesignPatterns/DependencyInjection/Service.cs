using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("service called");
        }
    }
}
