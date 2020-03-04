using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns
{
   public interface ISubject
    {
        public void Register(IObserver observer);
        public void UnRegister(IObserver observer);
        public void NotifyObservers();
    }
}
