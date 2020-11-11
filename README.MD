This is a very basic simulation of the card game Sheaphead, an old Polish card game.

The object of the game is to get as many points as possible.  You ear points by winning a round or "trick".  Aces are worth 11 points, 10's worth 10, Kings worth 4, Queens worth 3 and Jacks woth 2 points.  You win the trick by playing the highest card.  

The cards are ranked from highest to lowest in the following order. 

    Trump                                   Suits
  -----------------                       ----------
    Queen of Clubs                          Ace
    Queen of Spades                         10
    Queen of Hearts                         King
    Queen of Diamonds                       9
    Jack of Clubs                           8
    Jack of Spades                          7
    Jack of Heart
    Jack of Diamonds
    Ace of Diamonds
    10 of Diamonds
    King of Diamonds
    9 of Diamonds
    8 of Diamonds
    7 of Diamonds
  
Everyone, one player and 4 coumputer players, will be delt 5 cards.  The player has an option to pick the blind.  This means that they can pick up two extra cards to exchange them for two cards in their hand.  If the player picks the blind, by typing "yes", they will be asked to select two cards to remove from their hand.  

The program will play 5 rounds using the cards in everyones hands.  It will identify the winner for each round and it will display the over all winner for the game as well as how many points the winner earned.

To play this game open a Terminal and navigate to the CardGame folder and type dotnet run.  

