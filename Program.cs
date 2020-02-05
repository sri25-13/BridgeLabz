using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Replace\n2.powerof2\n3.PrimeFactors\n4.HarmonicNum\n5.LeapYear\n6.FlipCoin\n7.Distance\n8.Quadratic\n9.WindChill\n10.SumofTrip\n11.twodiArray");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.readInt();
            switch (option)
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
                case 4:
                    HarmonicNum.Harmonic();
                    break;
                case 5:
                    LeapYear.Leap();
                    break;
                case 6:
                    FlipCoin.Flip();
                    break;
                case 7:
                    Distance.Dist();
                    break;
                case 8:
                    Quadratic.Quad();
                    break;
                case 9:
                    WindChill.Wind();
                    break;
                case 10:
                    SumofTrip.Trip();
                    break;
                case 11:
                    twodiArray.array2d();
                    break;
            }
            }

        }
    }
