

namespace DesignPatterns
{
    using System;
    using CreationalDesignPatterns.Singleton;
    using CreationalDesignPatterns.FactoryDesignPattern;
    using CreationalDesignPatterns.PrototypeDesignPattern;
    using StructuralDesignPatterns.FacadeDesignPattern;
    using StructuralDesignPatterns.ProxyDesignPattern;
    using BehavioralDesignPatterns.MediatorDesignPattern;
    using BehavioralDesignPatterns.VisitorDesignPattern;
    using AutoMappers;

   public class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Console.WriteLine("1.ThreadSafeSingleton\n2.LazyInitializingSingleton\n3.EagerInitializingSingleton");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch(option)
            {
                case 1:
                    ThreadSafeSingletonImplementation.Singleton();
                    break;
                case 2:
                    LazyInitializationImplementation.LazyInitializingImplementing();
                    break;
                case 3:
                   EagerInitializationImplementation.EagerInitializingImplementing();
                    break;
                case 4:
                    FactoryDesignPatternImplementation.Implementation();
                    break;
                case 5:
                    PrototypeDesignPatternImplementation.PrototypeImplementing();
                    break;
                case 6:
                    StructuralDesignPatterns.AdapterDesignPatternImplementation.AdapterImplementation();
                    break;
                case 7:
                    AddressBook.AddressBookMethods();
                    break;
                case 8:
                 BehavioralDesignPatterns.ObserverDesignPatternImplementation.ObserverPattern();
                    break;
                case 9:
                    MediatorDesignPatternImplementation.MediatorDesignPattern();
                    break;
                case 10:
                    ProxyDesignPatternImplementation.ProxyDesignPattern();
                    break;
                case 11:
                    ShoppingCartClient.ShoppingCart();
                    break;
                case 12:
                    Reflection.Reflection.ReflectionImplementing();
                    break;
                case 13:
                  DependencyInjection.DependencyInjection.DependencyInjectionImplementation();
                    break;
                case 14:
                    AutoMapperImplementation.AutoMapperImplementing();
                    break;
            }
        }
    }
}
