using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class Hand : Deck
    {
        private List<Card> playerHand = new List<Card>{};
       
        private List<Card> computerHand1 = new List<Card>{};
        private List<Card> computerHand2 = new List<Card>{};
        private List<Card> computerHand3 = new List<Card>{};
        private List<Card> computerHand4 = new List<Card>{};
        private List<Card> blindHand = new List<Card>{};


        public void Deal()
        {
            CreateDeck();
        }

        public void getHand()
        {
            List<Card> getDeck = CreateDeck();
            for (int i=0; i<6; i++)
            {
                playerHand.Add(getDeck[i]);
            }
            
            for (int i=6; i<12; i++)
            {
                computerHand1.Add(getDeck[i]);
            }
        
            for (int i=12; i<18; i++)
            {
                computerHand2.Add(getDeck[i]);
            }
            
            for (int i=18; i<24; i++)
            {
                computerHand3.Add(getDeck[i]);
            }
            
            for (int i=24; i<30; i++)
            {
                computerHand4.Add(getDeck[i]);
            }

            for (int i=30; i<32; i++)
            {
                blindHand.Add(getDeck[i]);
            }

            displayHand(playerHand);
            Console.WriteLine();
            displayHand(computerHand1);
            Console.WriteLine();
            displayHand(computerHand2);
            Console.WriteLine();
            displayHand(computerHand3);
            Console.WriteLine();
            displayHand(computerHand4);
            Console.WriteLine();
            displayHand(blindHand);
        }

        public void displayHand(List<Card> playerHand)
        {
            foreach( Card p in playerHand)
            {
                Card card = new Card(p.Suit, p.Number);
                card.CardName();
            }
        }
    }
}