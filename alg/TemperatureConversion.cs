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
            int temperatureFahrenheit = Utility.ReadInt();
            double ftemp = temperatureFahrenheit - 32;
            double fmul = ftemp * 5;
            double fdiv = fmul / 9;
            double temperatureCelsius = fdiv;
            Console.WriteLine(" temperature in celsius is " + temperatureCelsius);
            double outputFahrenheit =( (((temperatureCelsius * 9) / 5) + 32));

            Console.WriteLine(outputFahrenheit);
        }
    }
}
