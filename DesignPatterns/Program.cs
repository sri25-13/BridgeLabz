// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
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

    /// <summary>
    /// class for main program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        [Obsolete]
       public static void Main(string[] args)
        {
            Console.WriteLine("1.ThreadSafeSingleton\n2.LazyInitializingSingleton\n3.EagerInitializingSingleton\n4.FactoryDesignPattern\n5.PrototypeDesignPatter\n6.AdapterDesignPattern\n7.FacadeDesignPattern\n8.ObserverDesignPattern\n9.MediatorDesignPattern\n10.ProxyDesignPattern\n11.VisitorDesignPattern\n12.Reflection\n13.DependencyInjection\n14.AutoMapper");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
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
                    FacadeDesignPattern.FacadeDesignPatternImplementation();
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
                    VisitorDesignPattern.VisitorDesignPatternImplementation();
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
