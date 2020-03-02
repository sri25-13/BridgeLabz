using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    class EagerInitialization
    {
        private static int counter = 0;
        private static readonly EagerInitialization instance = new EagerInitialization();

        private EagerInitialization()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static EagerInitialization Instance
        {
            get
            {
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
