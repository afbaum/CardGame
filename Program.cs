using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Would you like to play Sheephead? Yes or No  ");
            // string playAnswer = Console.ReadLine();
            // Console.WriteLine("Your Sheephead hand: ");
            // Console.WriteLine();
            
            // Console.Write("Would you like to pick the blind?  Yes or No  ");
            // string playerBlind = Console.ReadLine();

            GamePlay gameplay = new GamePlay();
            gameplay.PlayRound();
            
             
        }


    }
}
