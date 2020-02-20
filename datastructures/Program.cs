using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.UnorderedList\n2.OrderedList\n3.Calender\n4.Prime2D\n5.PrimeAnagram2D\n6.SimpleBalancedParentheses\n7.PrimeAnagramStack\n8.BankingCashCounter\n9.PrimeAnagramQueue\n10.PalindromeChecker\n11.DequeueTest\n12.Hashing");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    UnorderedList<string>.ReadFile();
                    break;
                case 2:
                    OrderedList.ReadFile();
                    
                    break;
                case 3:
                    Calender.MethodCalling();
                    break;
                case 4:
                    Prime2D.Prime();
                    break;
                case 5:
                    PrimeAnagram2D.PrimeAnagram();
                    break;
                case 6:
                    SimpleBalancedParentheses.BalancedParanthesis();
                    break;
                case 7:
                    PrimeAnagramStack.PrimeAnagramsUsingStack();
                    break;
                case 8:
                    BankingCashCounter.Customer();
                    break;
                case 9:
                    PrimeAnagramQueue.PrimeUsingQueue();
                    break;
                case 10:
                    DoubleEndedQueue.PalindromeChecker.IsPalindrome();
                    break;
                case 11:
                    DoubleEndedQueue.Dequeue<string>.DequeueTtest();
                    break;
                case 12:
                    Hashing.HashMap();
                    break;
            }
        }
    }
}
