using System;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmPrograms
{
    class FindingNumber
    {
        public static void FindingNum()
        {
            Console.WriteLine("enter the number");
            int n = Utility.readInt();
            int N = (int)Math.Pow(2, n);
            Console.WriteLine("Think of a number between 0 and" + (N - 1));
            Number(0, N);
        }
        public static int Number(int low, int high)
        {
            String str1 = "yes";
            String str2 = "no";
            if ((high - low) == 1)
            {
                return low;
            }
            while (low <= high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("type yes or no if it is less than" + mid);
                String str = Utility.readString();
                if (str.Equals(str1))
                {
                    high = mid;
                    return Number(low, high);
                }
                else if (str.Equals(str2))
                {
                    low = mid+1;
                    return Number(low, high);
                }
                else if (high == mid)
                {
                    return mid;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }
            }
        
                return low;
            }
        }
    }
