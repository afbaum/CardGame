using System;
using System.Collections.Generic;
using System.Linq;

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
            computerHand2 = getHand(12, 18);
            computerHand3 = getHand(18, 24);
            computerHand4 = getHand(24, 30);
            blindHand = getHand(30, 32);
        }

        public void PickBlind()
        {

        }
        public void PlayRound()
        {
            List<Card> round = new List<Card>{};
            round.Add(playerHand[1]);
            round.Add(computerHand1[1]);
            round.Add(computerHand2[1]);
            round.Add(computerHand3[1]);
            round.Add(computerHand4[1]);
            displayHand(round);  
            WinRound(round);
        }

        public int WinRound(List<Card> winner)
        {
            Console.WriteLine();
            Console.WriteLine(winner.Max(t => t.Rank));
            var winnerHand = winner.OrderBy(r => r.Rank).ToList();
            Console.WriteLine("The winner is the " + winnerHand[4].Number + " of " + winnerHand[4].Suit);

            return winner.Max(t => t.Rank);
        }

        public void WinGame()
        {

        }
    }
}