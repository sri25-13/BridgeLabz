using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.MonthlyPay\n2.TemperatureConversion");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.readInt();
            switch (option)
            {
                case 1:
                    MonthlyPay.Month();
                    break;
                case 2:
                    TemperatureConversion.TempConversion();
                    break;

            }
        }
    }
}
