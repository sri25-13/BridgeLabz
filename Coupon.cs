using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Coupon
    {
        public static void CouponNumber()
        {
            Console.WriteLine("enter the coupon no length u need:");
            int n= Utility.readInt();
            Console.WriteLine("enter how many values u need:");
            int n1 = Utility.readInt();
String    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[n];

            Random rnd = new Random();
            for (int j = 0; j < n1; j++)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[rnd.Next(chars.Length)];
                }


               

                Console.WriteLine(stringChars);

            }
        }
    }
}
