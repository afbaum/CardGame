using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class Hand : Deck
    {
        private List<Card> Deck = new List<Card>{};
       
        public Hand()
        {
            Deck = CreateDeck();
        }

        public List<Card> getHand(int min, int max)
        {
            List<Card> playerHand = new List<Card>{};
            for (int i=min; i<max; i++)
            {
                playerHand.Add(Deck[i]);
            }

            return playerHand;
        }

        public void displayHand(List<Card> playerHand)
        {
            int i = 1;
            foreach( Card p in playerHand)
            {
                Card card = new Card(p.Suit, p.Number);
                Console.Write(i + ". ");
                card.CardName();
                i++;
            }
        }
    }
}