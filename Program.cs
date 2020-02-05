using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Replace\n2.powerof2\n3.PrimeFactors");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    Replace.ReplaceString();
                    break;
                case 2:
                    Powerof2.Power();
                    break;
                case 3:
                    PrimeFactors.Prime();
                    break;
            }

        }
    }
}
