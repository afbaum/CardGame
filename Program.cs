using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> newDeck = deck.CreateDeck();
            IEnumerable<Card> ShuffledDeck = deck.ShuffleDeck(newDeck);

            foreach (Card d in ShuffledDeck)
            {
                d.CardName();
            }                                      
        }
    }
}
