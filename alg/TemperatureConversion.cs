using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class TemperatureConversion
    {
        public static void TempConversion()
        {
            Console.WriteLine("Enter the temp in fahrenheit");
            int tempinf = Utility.readInt();
            double ftemp = tempinf - 32;
            double fmul = ftemp * 5;
            double fdiv = fmul / 9;
            double tempinc = fdiv;
            Console.WriteLine(tempinf + " temperature in celsius is " + tempinc);

        }
    }
}
