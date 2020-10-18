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
            foreach (Card d in newDeck)
            {
                d.CardName();
            }                                      
        }
    }
}
