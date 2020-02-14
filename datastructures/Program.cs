using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.UnorderedList\n2.OrderedList");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    UnorderedList<string>.ReadFile();
                    break;
                case 2:
                    OrderedList.ReadFile();
                    
                    break;
            }
        }
    }
}
