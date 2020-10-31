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

        public void showHand()
        {
            displayHand(playerHand);
        }

        public void PickBlind()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================");
            Console.WriteLine("Type 'yes' to pick the blind. ");
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.Black;
            if(Console.ReadLine() == "yes")
            {
                foreach(Card b in blindHand)
                {
                    playerHand.Add(b);
                }
                displayHand(playerHand);  
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==============================");
                Console.WriteLine("Select a card to remove.");
                Console.WriteLine("==============================");
                Console.ForegroundColor = ConsoleColor.Black;
                int card1 = Int32.Parse(Console.ReadLine()) -1;
                playerHand.RemoveAt(card1);
                displayHand(playerHand);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==============================");
                Console.WriteLine("Select a second card to remove.");
                Console.WriteLine("==============================");
                Console.ForegroundColor = ConsoleColor.Black;
                int card2 = Int32.Parse(Console.ReadLine()) -1 ;
                playerHand.RemoveAt(card2);
                displayHand(playerHand);
            }
        }
        public void PlayRound(int roundNumber)
        {
            List<Card> round = new List<Card>{};
            round.Add(playerHand[roundNumber]);
            round.Add(computerHand1[roundNumber]);
            round.Add(computerHand2[roundNumber]);
            round.Add(computerHand3[roundNumber]);
            round.Add(computerHand4[roundNumber]);
            displayHand(round);  
            WinRound(round);
        }

        public int WinRound(List<Card> winner)
        {
            Console.WriteLine();
            var winnerHand = winner.OrderBy(r => r.Rank).ToList();
            Console.WriteLine("The winner is the " + winnerHand[4].Number + " of " + winnerHand[4].Suit);
            Console.WriteLine("----------------------------------------------------------------------");

            return winner.Max(t => t.Rank);
        }

        public void WinGame()
        {

        }
    }
}