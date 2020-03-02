using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static ThreadSafeSingleton obj = null;

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if (obj == null)
                {
                    lock (Instancelock)
                    {
                        if (obj == null)
                        {
                            obj = new ThreadSafeSingleton();
                        }
                    }
                }
                return obj;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

}

