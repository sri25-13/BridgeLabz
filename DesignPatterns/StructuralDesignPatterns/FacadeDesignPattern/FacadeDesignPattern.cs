// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadeDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// class for implementing FacadeDesignPattern
    /// </summary>
    public class FacadeDesignPattern
    {
        /// <summary>
        /// Facades the design pattern implementation.
        /// </summary>
        public static void FacadeDesignPatternImplementation()
        {
            FirstPerson firstPerson = new FirstPerson();
            Console.WriteLine("Firstperson details:");
            firstPerson.PersonName();
            firstPerson.PersonAge();
            firstPerson.PersonCity();
            Console.WriteLine("Secondperson details:");
            SecondPerson secondPerson = new SecondPerson();
            secondPerson.PersonName();
            secondPerson.PersonAge();
            secondPerson.PersonCity();
        }
    }
}
