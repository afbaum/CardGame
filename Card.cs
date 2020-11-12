using System;

namespace CardGame
{
    public class Card
    {
        public string Suit {get; set;}
        public string Number {get; set;}
        public int Value {get; private set;}
        public int Rank {get; private set;}

        // Create each card giving it a number, suit and rank (higher ranked card winn over lower ranked card), 
        // and giving each card a point value so a winner can be determined. 
        public Card(string suit, string number)
        {
            Suit = suit;
            Number = number;
            Rank = CardRank();
            Value = CardValue();
        }

        public string CardSuit()
        {
            return Suit;
        }

        // Change numbers from 11-13 to Jack, Queen and King and also change 1 to Ace
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
        // Set the point value for each card with points
        public int CardValue()
        {
            ToCardName();
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
        // Set the rank for cards based on their suit and number
        public int CardRank()
        {
            ToCardName();
            if(Number == "Queen" && Suit == "clubs")
            {
                Rank = 14;
            }
            else if (Number == "Queen" && Suit == "spades")
            {
                Rank = 13;
            }
            else if (Number == "Queen" && Suit == "hearts")
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
            else if (Number == "King" && Suit != "diamonds")
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
            Console.WriteLine("The " + Number + " of " + Suit);
        }
    }
}