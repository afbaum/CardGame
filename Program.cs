using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gameplay = new GamePlay();
       
            gameplay.showHand();  
            gameplay.PickBlind(); 

            int i =0;
            while(i<5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************");
                Console.WriteLine("Round " + (i+1));
                Console.WriteLine("*************");
                Console.ForegroundColor = ConsoleColor.Black;
                gameplay.PlayRound(i);
                i++;
            }   
        }


    }
}
