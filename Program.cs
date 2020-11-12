using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gameplay = new GamePlay();
            GameScore gameScore = new GameScore();
       
            gameplay.showHand();  
            gameplay.PickBlind(); 

            // Play all five rounds of the game
            int i =0;
            while(i<5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************");
                Console.WriteLine("Round " + (i+1));
                Console.WriteLine("*************");
                Console.ForegroundColor = ConsoleColor.Green;
                List<Card> round = gameplay.PlayRound(i);
                i++;

                gameScore.totalValue(gameplay.WinRound(round), gameScore.WinnerPoints(round));
                gameScore.RoundWinner();
            }  
            
            int winner = gameScore.RoundWinner();
            string winningPlayer = "";
            int score = 0;
            if(winner == 0 )
            {
                winningPlayer = "Player";
                score = gameScore.playerHandValue;
            }
            else if (winner == 1)
            {
                winningPlayer = "Computer 1";
                score = gameScore.computerHand1Value;
            }
            else if (winner == 2)
            {
                winningPlayer = "Computer 2";
                score = gameScore.computerHand2Value;
            }
            else if (winner == 3)
            {
                winningPlayer = "Computer 3";
                score = gameScore.computerHand3Value;
            }
            else if (winner == 4)
            {
                winningPlayer = "Computer 4";
                score = gameScore.computerHand4Value;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("And the winner is: " + winningPlayer); 
            Console.WriteLine("With a score of: " + score);
        }
    }
}
