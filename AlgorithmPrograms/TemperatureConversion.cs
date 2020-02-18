// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for conversion of Temperature
    /// </summary>
  public class TemperatureConversion
    {
        /// <summary>
        /// Temporaries the conversion.
        /// </summary>
        public static void TemperatureConversionM()
        {
            Console.WriteLine("Enter the temp in fahrenheit");
            int temperatureFahrenheit = Utility.ReadInt();
            double ftemp = temperatureFahrenheit - 32;
            double fmult = ftemp * 5;
            double fdiv = fmult / 9;
            double temperatureCelsius = fdiv;
            Console.WriteLine(" temperature in celsius is " + temperatureCelsius);
            double outputFahrenheit = ((temperatureCelsius * 9) / 5) + 32;

            Console.WriteLine(outputFahrenheit);
        }
    }
}
