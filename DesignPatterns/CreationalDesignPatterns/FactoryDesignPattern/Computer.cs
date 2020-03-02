using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    public abstract class Computer
    {
        public abstract string GetRAM();
        public abstract string GetHDD();
        public abstract string GetCPU();
    }
    class PC : Computer
    {
        private String ram;
        private String hdd;
        private String cpu;

        public PC(String ram, String hdd, String cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public override string GetCPU()
        {
            return this.cpu;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetRAM()
        {
            return this.ram;
        }
    }
    class Server: Computer
    {
        private String ram;
        private String hdd;
        private String cpu;

        public Server(String ram, String hdd, String cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public override string GetCPU()
        {
            return this.cpu;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetRAM()
        {
            return this.ram;
        }
    }
}


