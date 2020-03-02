using System;

namespace DesignPatterns
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ThreadSafeSingleton");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch(option)
            {
                case 1:
                    CreationalDesignPatterns.Singleton.ThreadSafeSingletonImplementation.Singleton();
                    break;
            }
        }
    }
}
