using System;
using System.Diagnostics;

namespace FunctionalPrograms
{
    class Stopwatch1
    {
        public static void Stopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }

           
            stopwatch.Stop();

            
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }

}

    

