// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class for InsertionSort
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// Insertions this instance.
        /// </summary>
        public static void Insertion()
        {
            List<string> myList = new List<string>() { "harshini", "amulya", "lucky", "teju" };
            int n = myList.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (myList[i].CompareTo(myList[j]) > 0)
                    {
                        string temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;
                    }
                }

                Console.WriteLine(myList[i]);
            }
        }
    }
}