using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.UnorderedList\n2.OrderedList\n3.Calender\n4.Prime2D\n5.PrimeAnagram2D");
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
                case 3:
                    Calender.MethodCalling();
                    break;
                case 4:
                    Prime2D.Prime();
                    
                    break;
                case 5:
                    PrimeAnagram2D.PrimeAnagram();
                    break;
            }
        }
    }
}
