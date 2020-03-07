using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    class Customer :IService
    {

        /// <summary>
        /// Serves this instance.
        /// </summary>
        public void Serve()
        {
            Console.WriteLine("Customer called");
        }
    }
}

