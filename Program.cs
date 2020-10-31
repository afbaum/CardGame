using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gameplay = new GamePlay();
            // int i =0;
            // while(i<5)
            // {
            //     Console.ForegroundColor = ConsoleColor.DarkGreen;
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.WriteLine("*************");
            //     Console.WriteLine("Round " + (i+1));
            //     Console.WriteLine("*************");
            //     gameplay.PlayRound(i);
            //     i++;
            // }          

            gameplay.showHand();  
            gameplay.PickBlind(); 
        }


    }
}
