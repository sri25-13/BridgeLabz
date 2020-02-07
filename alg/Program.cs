using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.MonthlyPay\n2.TemperatureConversion\n3.SquareRoot\n4.DayofWeek\n5.Binary\n6.BinarySwap\n7.VendingMachine");
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
                case 3:
                    SquareRoot.Sqrt();
                    break;
                case 4:
                    DayofWeek.DayWeekMethod();
                    break;
                case 5:
                    Binary.BinaryM();
                    break;
                case 6:
                    BinarySwap.Swapping();
                    break;
                case 7:
                    VendingMachine.Vending();
                    break;
            }
        }
    }
}
