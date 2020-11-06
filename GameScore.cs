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

        public int RoundWinner()
        {
            List<int> finalScore = new List<int>{playerHandValue, computerHand1Value, computerHand2Value, computerHand3Value, computerHand4Value};
            int winner = finalScore.Max();
            return finalScore.IndexOf(finalScore.Max());                 
        }
    }
}