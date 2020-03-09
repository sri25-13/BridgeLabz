// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// class for distributing cards
    /// </summary>
    public class DeckOfCards
    {
        string[] deck = new string[52];
        string[] suit = { "clubs", "diamonds", "spades", "hearts" };
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
        int count = 0;
        int start = 0, end = 13;

        /// <summary>
        /// Plays the cards.
        /// </summary>
        public void PlayCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = start; j < end; j++)
                {
                    deck[j] = suit[i] + "" + rank[count];
                    count++;
                }

                count = 0;
                start = end;
                end = end + 13;
            }

            Shuffling();
        }

        /// <summary>
        /// Shufflings this instance.
        /// </summary>
        public void Shuffling()
        {
            Random rand = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                int r = i + rand.Next(52 - i);
                string temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }

            Print();
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            string[,] strArr1 = new string[4, 13];
           
            for (int x = 0; x < 4; x += 1)
            {
                for (int y = 0; y < 9; y += 1)
                {
                    strArr1[x, y] = deck[x + y];
                    Console.Write(strArr1[x, y] + " ");
                }

            
                Console.WriteLine();
            }
        }
    }
}
