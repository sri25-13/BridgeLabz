using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Replace\n2.powerof2\n3.PrimeFactors\n4.HarmonicNum\n5.LeapYear\n6.FlipCoin\n7.Distance\n8.Quadratic\n9.WindChill\n10.SumofTrip\n11.twodiArray\n12.Gambler\n13.Coupon\n14.Stopwatch\n15.TicTac1\n16.MonthlyPay");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
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
                    SumOfTrip.Trip();
                    break;
                case 11:
                    TwoDArray.Array2d();
                    break;
                case 12:
                    Gambler.Gambling();
                    break;
                case 13:
                    Coupon.CouponNumber();
                    break;
                case 14:
                    Stopwatch1.Stopwatch();
                    break;
                case 15:
                    TicTac1.InitBoard();
                    TicTac1.DispBoard();
                    TicTac1.PutVal();
                    TicTac1.Win();
                    TicTac1.Play();
                    break;
               
            }
            }

        }
    }
