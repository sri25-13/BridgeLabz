using System;

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
                case 6:
                    StructuralDesignPatterns.AdapterDesignPatternImplementation.AdapterImplementation();
                    break;
                case 7:
                    StructuralDesignPatterns.FacadeDesignPattern.AddressBook.AddressBookMethods();
                    break;
                case 8:
                    BehavioralDesignPatterns.ObserverDesignPatternImplementation.ObserverPattern();
                    break;
                case 9:
                    BehavioralDesignPatterns.MediatorDesignPattern.MediatorDesignPatternImplementation.MediatorDesignPattern();
                    break;
                case 10:
                    StructuralDesignPatterns.ProxyDesignPattern.ProxyDesignPatternImplementation.ProxyDesignPattern();
                    break;
                    
            }
        }
    }
}
