using System;
using System.Linq;
using System.Collections.Generic;

namespace CardGame
{
    public class GameScore
    {
        public int playerHandValue = 0;
        public int computerHand1Value = 0;
        public int computerHand2Value = 0;
        public int computerHand3Value = 0;
        public  int computerHand4Value = 0; 

        public void totalValue(int playerValue, int points)
        {
            if(playerValue == 0)
            {
                playerHandValue += points;
            }
            else if(playerValue == 1)
            {
                computerHand1Value += points;
            }
            else if(playerValue == 2)
            {
                computerHand2Value += points;
            }
            else if(playerValue == 3)
            {
                computerHand3Value += points;
            }
            else if(playerValue == 4)
            {
                computerHand4Value += points;
            }                                  
        }  
        public int WinnerPoints(List<Card> winningRound)
        {
            return winningRound.Sum(x => x.Value);
        }

        public void RoundWinner()
        {
            List<int> finalScore = new List<int>{playerHandValue, computerHand1Value, computerHand2Value, computerHand3Value, computerHand4Value};
            int winner = finalScore.Max();
            if(finalScore[0] == winner)
            {
                Console.WriteLine("Player's score is: " + playerHandValue);
            }
            else if (finalScore[1] == winner)
            {
                Console.WriteLine("Computer1's score is " + computerHand1Value);
            }
            else if(finalScore[2] == winner)
            {
                Console.WriteLine("Computer2's score is " + computerHand2Value);
            }
            else if(finalScore[3] == winner)
            {
                Console.WriteLine("Computer3's score is " + computerHand3Value);
            }
            else if(finalScore[4] == winner)
            {
                Console.WriteLine("Computer4's score is " + computerHand4Value);
            }                        
        }

    }
}