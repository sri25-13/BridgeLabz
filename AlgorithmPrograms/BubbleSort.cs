// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class for BubbleSort
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Bubbles this instance.
        /// </summary>
        public static void Bubble()
        {
            int temp;
            List<int> myList = new List<int>() { 1, 6, 9, 3 };
            for (int i = 0; i <= myList.Count; i++)
            {
                for (int j = 1; j <= myList.Count - 1; j++)
                {
                    if (myList[j - 1] > myList[j])
                    {
                        temp = myList[j - 1];
                        myList[j - 1] = myList[j];
                        myList[j] = temp;
                    }
                }
            }

            Console.WriteLine("after sorting");
            for (int p = 0; p < myList.Count; p++)
            {
                Console.WriteLine(myList[p] + "");
            }
        }
    }
}