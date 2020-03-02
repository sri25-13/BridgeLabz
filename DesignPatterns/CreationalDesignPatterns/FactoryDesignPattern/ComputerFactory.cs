using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    class ComputerFactory
    {
        public static Computer getComputer(String obj)
        {
          Computer obje= null;
            if ("PC".Equals(obj))
            {
                Console.WriteLine("enter RAM,HDD,CPU values for Pc");
                string ram = Utility.ReadString();
                string hdd = Utility.ReadString();
                string cpu = Utility.ReadString();
                obje = new PC(ram, hdd, cpu);
            }

            else if ("Server".Equals(obj))
            {
                Console.WriteLine("enter RAM,HDD,CPU values for Server");
                string ram = Utility.ReadString();
                string hdd = Utility.ReadString();
                string cpu = Utility.ReadString();
                obje = new Server(ram, hdd, cpu);
            }

            return obje;
        }
    }
}
