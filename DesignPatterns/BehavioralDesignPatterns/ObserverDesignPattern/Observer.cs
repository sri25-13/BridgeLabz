using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns
{
   public class Observer :IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName, ISubject subject)
        {
           this.UserName = userName;
            subject.Register(this);
        }

        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Flipkart");
        }

    }
}
