using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns
{
    public class ObserverDesignPatternImplementation
    {
        public static void ObserverPattern()
        {
            Subject subject = new Subject("SkullCandy Headphone", 1200, "Out of stock");
            Observer observer = new Observer("harshini", subject);
            Observer observer1 = new Observer("amulya", subject);
            Console.WriteLine("SkullCandy Headphone current state : " + subject.getAvailability());
            subject.setAvailability("available");
        }
    }
}
