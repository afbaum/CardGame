using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card("hearts", "10");
            card1.CardName();
            Card card2 = new Card("hearts", "11");
            card2.CardName();
            Card card3 = new Card("hearts", "12");
            card3.CardName();
            Card card4 = new Card("hearts", "13");
            card4.CardName();
            Card card5 = new Card("hearts", "1");
            card5.CardName();       
            Card card6 = new Card("hearts", "8");
            card6.CardName();                                          
        }
    }
}
