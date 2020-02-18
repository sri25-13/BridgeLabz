// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for MainProgram
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            Console.WriteLine("1.MonthlyPay\n2.TemperatureConversion\n3.SquareRoot\n4.DayofWeek\n5.Binary\n6.BinarySwap\n7.VendingMachine\n8.AnagramDetection\n9.PrimeNumbers\n10.BubbleSort\n11.InsertionSort\n12.Permutations\n13.FindingNumber\n14.BinarySearch\n15.AnagramandPalindrome\n16.MergeSort");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    MonthlyPay.Month();
                    break;
                case 2:
                    TemperatureConversion.TemperatureConversionM();
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
                case 8:
                    AnagramDetection.Anagram();
                    break;
                case 9:
                    PrimeNumbers.Prime();
                    break;
                case 10:
                    BubbleSort.Bubble();
                    break;
                case 11:
                    InsertionSort.Insertion();
                    break;
                case 12:
                    Permutations.MethodCalling();
                    break;
                case 13:
                    FindingNumber.FindingNum();
                    break;
                case 14:
                    BinarySearch.ReadingFile();
                    break;
                case 15:
                    AnagramandPalindrome.PrimePalindrome();
                    /*AnagramandPalindrome.PrimeAnagram();*/
                    break;
                case 16:
                    MergeSort.Merge();
                    break;
            }
        }
    }
}