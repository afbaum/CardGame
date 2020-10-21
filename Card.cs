using System;

namespace CardGame
{
    public class Card
    {
        public string Suit {get; set;}
        public string Number {get; set;}
        public int Value {get; private set;}

        public Card(string suit, string number)
        {
            Suit = suit;
            Number = number;
        }

        public string CardSuit()
        {
            return Suit;
        }

        public void ToCardName()
        {
            switch(Number)
            {
                case "11":
                {
                    Number = "Jack";
                    break;
                }
                case "12":
                {
                    Number = "Queen";
                    break;
                }
                case "13":
                {
                    Number = "King";
                    break;
                }
                case "1":
                {
                    Number = "Ace";
                    break;
                }
            }
        }

        public int CardValue()
        {
            if (Number == "Jack")
            {
                Value = 2;
            }
            else if (Number == "Queen")
            {
                Value = 3;
            }
            else if (Number == "King")
            {
                Value = 4;
            }
            else if (Number == "Ace")
            {
                Value = 11;
            }
            else if (Number == "10")
            {
                Value = 10;
            }
            return Value;
        }

        public void CardName()
        {
            ToCardName();
            CardValue();
            Console.WriteLine("The " + Number + " of " + Suit);
        }
    }
}