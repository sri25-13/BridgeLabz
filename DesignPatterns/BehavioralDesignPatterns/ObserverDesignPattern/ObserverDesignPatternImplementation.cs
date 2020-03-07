// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObserverDesignPatternImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns
{
    using System;

    /// <summary>
    /// class for implementing ObserverDesignPattern
    /// </summary>
    public class ObserverDesignPatternImplementation
    {
        /// <summary>
        /// Observers the pattern.
        /// </summary>
        public static void ObserverPattern()
        {
            Subject subject = new Subject("SkullCandy Headphone", 1200, "Out of stock");
            Observer observer = new Observer("harshini", subject);
            Observer observer1 = new Observer("amulya", subject);
            Console.WriteLine("SkullCandy Headphone current state : " + subject.GetAvailability());
            subject.SetAvailability("available");
        }
    }
}
