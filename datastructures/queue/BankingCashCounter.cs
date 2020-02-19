// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankingCashCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for banking
    /// </summary>
  public class BankingCashCounter
    {
       /* Node front;*/
        static int bankBalance = 200000;

        /// <summary>
        /// Customers this instance.
        /// </summary>
        public static void Customer()
        {
            Queue<string> q = new Queue<string>();
            Console.Write("enter number of customers\t");
            int num = Utility.ReadInt();
            for (int i = 1; i <= num; i++)
            {
                Console.Write("enter name of Customer " + i + "\t");
                string name = Utility.ReadString();
                q.Enqueue(name);
            }

            q.PrintQueue();
            for (int i = 1; i <= num; i++)
            {
                string s = q.First();
                Console.WriteLine("Customer " + s);
                Console.WriteLine("enter any option to make transactions");
                Console.WriteLine("1.With Drawl");
                Console.WriteLine("2.Deposit");
                int option = Utility.ReadInt();
                switch (option)
                {
                    case 1:
                        int amount;
                        Console.WriteLine("Enter Amount U Want to Withdraw : ");
                        amount = Utility.ReadInt();
                        BankBalance(option, amount);
                        q.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount to Deposit");
                        amount = Utility.ReadInt();
                        BankBalance(option, amount);
                        q.Dequeue();
                        break;
                    default:
                        Console.WriteLine("enter correct option");
                        break;
                }
            }

            Console.WriteLine("Total Bank Balancce is:" + bankBalance);
        }

        /// <summary>
        /// Banks the balance.
        /// </summary>
        /// <param name="option">The option.</param>
        /// <param name="amount">The amount.</param>
        public static void BankBalance(int option, int amount)
        {
            if (option == 1)
            {
                bankBalance -= amount;
            }
            else
            {
                bankBalance += amount;
            }
        }
    }
}