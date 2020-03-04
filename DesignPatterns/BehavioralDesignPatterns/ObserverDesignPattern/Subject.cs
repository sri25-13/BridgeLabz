using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }
        public string getAvailability()
        {
            return Availability;
        }
        public void setAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            this.observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            Console.WriteLine(" Notifying observers...");

            foreach (IObserver observer in observers)
            {
                observer.Update(Availability);
            }
        }

    }
}
