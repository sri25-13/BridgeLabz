using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class DeckOfCards
    {
        public static void DistributeCards()
        {
            String[] suits = { "Club", "Diamond", "Heart", "Spade" };
            String[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            String[,] cards = new String[4, 13];
            String[,] players = new String[4, 13];
            Utility.CardArray(suits, cards, rank);

            Utility.ShufflingCards(cards);

           
            Utility.DistributingCards(cards, players);

            
            Utility.PrintString2DArray(players);
        }
    }
}
