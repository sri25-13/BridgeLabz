using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
   public class SecondPerson :IAddressbookDetails
    {
        public void PersonName()
        {
            Console.WriteLine("Amulya");
        }
        public void PersonAge()
        {
            Console.WriteLine("15 years old");
        }
        public void PersonCity()
        {
            Console.WriteLine("Karimnagar");
        }
    }
}
