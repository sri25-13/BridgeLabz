﻿using System;

namespace DesignPatterns
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ThreadSafeSingleton\n2.LazyInitializingSingleton\n3.EagerInitializingSingleton");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch(option)
            {
                case 1:
                    CreationalDesignPatterns.Singleton.ThreadSafeSingletonImplementation.Singleton();
                    break;
                case 2:
                    CreationalDesignPatterns.Singleton.LazyInitializationImplementation.LazyInitializingImplementing();
                    break;
                case 3:
                    CreationalDesignPatterns.Singleton.EagerInitializationImplementation.EagerInitializingImplementing();
                    break;
                case 4:
                    CreationalDesignPatterns.FactoryDesignPattern.FactoryDesignPatternImplementation.Implementation();
                    break;
                case 5:
                    CreationalDesignPatterns.PrototypeDesignPattern.PrototypeDesignPatternImplementation.PrototypeImplementing();
                    break;
            }
        }
    }
}
