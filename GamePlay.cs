using System;
using System.Collections.Generic;

namespace CardGame
{
    public class GamePlay : Hand
    {
        private List<Card> playerHand {get; set;}
        private List<Card> computerHand1 {get; set;}
        private List<Card> computerHand2 {get; set;}
        private List<Card> computerHand3 {get; set;}
        private List<Card> computerHand4 {get; set;}
        private List<Card> blindHand {get; set;}
        
        public GamePlay()
        {
            playerHand = getHand(0,6);
            computerHand1 = getHand(6,12);
            // computerHand2 = getHand(12, 18);
            // computerHand3 = getHand(18, 24);
            // computerHand4 = getHand(24, 30);
            // blindHand = getHand(30, 32);
        }
        public void PlayRound()
        {
            displayHand(playerHand);
            Console.WriteLine();
            displayHand(computerHand1);
        }
    }
}