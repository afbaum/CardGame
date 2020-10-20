using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class Deck
    {

        public List<Card> CreateDeck()
        {
            List<string> suit = new List<string>(new string[]{"hearts", "clubs", "diamonds", "spades"});
            List<string> number = new List<string>(new string[]{"7", "8", "9", "10", "11", "12", "13", "1"});
            List<Card> DeckofCards = new List<Card>{};

            foreach( string s in suit)
            {
                foreach(string n in number)
                {
                    Card card = new Card(s, n);
                    DeckofCards.Add(card);
                }
            }   
            return DeckofCards;     
        }

        public IOrderedEnumerable<Card> ShuffleDeck(List<Card> DeckofCards)
        {
            return DeckofCards.OrderBy(a => Guid.NewGuid());
        }

        public void DealTheDeck()
        {

        }
    }
}