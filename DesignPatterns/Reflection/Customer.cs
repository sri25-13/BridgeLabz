using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Reflection
{
   public class Customer
    {
        public Customer()
        {
            Id = 0;
            Name = null;
        }
        public Customer(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public void Display(Customer customer)
        {
            Console.WriteLine("Customer ID :" + Id);
            Console.WriteLine("Customer name :" + Name);
        }
    }
}
