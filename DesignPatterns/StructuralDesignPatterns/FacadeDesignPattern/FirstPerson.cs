using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
   public class FirstPerson:IAddressbookDetails
    {
       public void PersonName()
        {
            Console.WriteLine("Harshini");
        }
        public void PersonAge()
        {
            Console.WriteLine("22 years old");
        }
        public void PersonCity()
        {
            Console.WriteLine("Bangalore");
        }
    }
}

