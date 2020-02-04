using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Replace");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    Replace.ReplaceString();
                    break;
            }

        }
    }
}
