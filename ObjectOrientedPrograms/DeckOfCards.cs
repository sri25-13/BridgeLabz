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
        /// <summary>
        /// The deck
        /// </summary>
        public readonly string[] Deck = new string[52];

        /// <summary>
        /// The suit
        /// </summary>
        public readonly string[] Suit = { "clubs", "diamonds", "spades", "hearts" };

        /// <summary>
        /// The rank
        /// </summary>
        public readonly string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
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
                    Deck[j] = Suit[i] + "" + Rank[count];
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
            for (int i = 0; i < Deck.Length; i++)
            {
                int r = i + rand.Next(52 - i);
                string temp = Deck[r];
                Deck[r] = Deck[i];
                Deck[i] = temp;
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
                    strArr1[x, y] = Deck[x + y];
                    Console.Write(strArr1[x, y] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
