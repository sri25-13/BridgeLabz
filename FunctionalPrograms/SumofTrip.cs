// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SumofTrip.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for finding sum of distinct triplets
    /// </summary>
    public class SumOfTrip
    {
        /// <summary>
        /// Trips this instance.
        /// </summary>
        public static void Trip()
        {
            int[] arr = Utility.ReadArray();
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine(arr[i] + "," + arr[j] + "," + arr[k]);
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine("number of distinct triples are:" + count);
        }
    }
}