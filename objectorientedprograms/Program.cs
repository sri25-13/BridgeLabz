using System;
namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.InventoryManagement");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch(option)
            {
                case 1:
                    InventoryManagement.Test();
                    break;
            }
        }
    }
}
