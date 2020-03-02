using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    class LazyInitialization
    {
        private static LazyInitialization instance;
        private static int counter = 0;
        private LazyInitialization()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static LazyInitialization Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazyInitialization();
                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

