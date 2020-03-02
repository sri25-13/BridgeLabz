using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    class FactoryDesignPatternImplementation
    {
        public static void Implementation()
        {
            Console.WriteLine("enter your object type");
            string type = Utility.ReadString();
            Computer computer = ComputerFactory.getComputer(type);
            Console.WriteLine("RAM of " + type + " is " + computer.GetRAM());
            Console.WriteLine("HDD of " + type + " is " + computer.GetHDD());
            Console.WriteLine("CPU of " + type + " is " + computer.GetCPU());
        }
    }
}
