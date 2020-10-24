using System;

namespace CardGame
{
    public class Card
    {
        public string Suit {get; set;}
        public string Number {get; set;}
        public int Value {get; private set;}
        public int Rank {get; private set;}

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

        public int CardRank()
        {
            if(Number == "Queen" && Suit == "clubs")
            {
                Rank = 14;
            }
            else if (Number == "Queen" && Suit == "spades")
            {
                Rank = 13;
            }
            else if (Number == "Queen" && Suit == "heats")
            {
                Rank = 12;
            }
            else if (Number == "Queen" && Suit == "diamonds")
            {
                Rank = 11;
            }       
            else if (Number == "Jack" && Suit == "clubs")
            {
                Rank = 10;
            }
            else if (Number == "Jack" && Suit == "spades")
            {
                Rank = 9;
            }
            else if (Number == "Jack" && Suit == "hearts")
            {
                Rank = 8;
            }
            else if (Number == "Jack" && Suit == "diamonds")
            {
                Rank = 7;
            }    
            else if (Number == "Ace" && Suit == "diamonds")
            {
                Rank = 6;
            }  
            else if (Number == "10" && Suit == "diamonds")
            {
                Rank = 5;
            }  
            else if (Number == "King" && Suit == "diamonds")
            {
                Rank = 4;
            }  
            else if (Number == "9" && Suit == "diamonds")
            {
                Rank = 3;
            }     
            else if (Number == "8" && Suit == "diamonds")
            {
                Rank = 2;
            }  
            else if (Number == "7" && Suit == "diamonds")
            {
                Rank = 1;
            }     
            else if (Number == "Ace" && Suit != "diamonds")
            {
                Rank = 0;
            }       
            else if (Number == "10" && Suit != "diamonds")
            {
                Rank = -1;
            }   
            else if (Number == "Kind" && Suit != "diamonds")
            {
                Rank = -2;
            }      
            else if (Number == "9" && Suit != "diamonds")
            {
                Rank = -3;
            }      
            else if (Number == "8" && Suit != "diamonds")
            {
                Rank = -4;
            }     
            else if (Number == "7" && Suit != "diamonds")
            {
                Rank = -5;
            }       
            return Rank;
        }

        public void CardName()
        {
            ToCardName();
            CardValue();
            CardRank();
            Console.WriteLine("The " + Number + " of " + Suit + " Rank of " + Rank);
        }
    }
}