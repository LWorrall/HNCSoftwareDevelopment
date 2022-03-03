using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //Used for summing object's properties in a list.

namespace Main_Program_v2
{
    class Card
    {
        //Creating a Class 'Card' which will hold a value between 1-52, the card's pip value, the card's name and the suit's name.
        public int cardOrder = 0;
        public int cardNumber = 0;
        public int pipValue = 0;
        public string pipName = ""; //e.g. "Jack" or "7".
        public string suitName = "";
    }

    public class Deck
    {
        //Creating a counter variable to count how many cards have been drawn.
        int drawCount = 0;

        //Instantiating a random number generator.
        Random rng = new Random();

        //Creating a list that will hold the drawn card's numbers.
        List<int> generatedCardNumbers = new List<int>();

        //Creating a list that will hold the player's cards.
        List<Card> playerHand = new List<Card>();


        //Creating a list that will hold the dealer's cards.
        List<Card> dealerHand = new List<Card>();

        //Creating a variable that will hold  the value of a newly generated card number.
        int newCard;


        //Procedure to clear all variables in order to get ready for a new game.
        public void Clear()
        {
            drawCount = 0;
            generatedCardNumbers.Clear();
            playerHand.Clear();
            dealerHand.Clear();
        }

        public void Draw()
        {
            //Generate a card number and check if it has been generated before.
            do
            {
                newCard = rng.Next(1, 52);
            } while (generatedCardNumbers.Contains(newCard) == true);

            //Add that card number to the list of generated cards.
            generatedCardNumbers.Add(newCard);

            //Create a new card with the name card.
            Card card = new Card();

            //Increment the drawn cards counter after a non-duplicate is generated.
            drawCount++;

            //Tell the cardOrder variable what order that card is, i.e. first card drawn, second card drawn etc.
            card.cardOrder = drawCount;

            //If the card number is between 1-13, it's suit is Clubs.
            if ((1 <= newCard) & (newCard <= 13))
            {
                card.cardNumber = newCard;
                card.pipValue = newCard;
                card.suitName = "Clubs";
            }

            //If the card number is between 14-26, it's suit is Diamonds and its pip value is the card number - 13.
            else if ((14 <= newCard) & (newCard <= 26))
            {
                card.cardNumber = newCard;
                card.pipValue = newCard - 13;
                card.suitName = "Diamonds";
            }

            //If the card number is between 27-39, it's suit is Diamonds and its pip value is the card number - 26.
            else if ((27 <= newCard) & (newCard <= 39))
            {
                card.cardNumber = newCard;
                card.pipValue = newCard - 26;
                card.suitName = "Hearts";
            }

            //Else, the card must be bewteen 40-52; it's suit is Spades and its pip value is the card number - 39.
            else
            {
                card.cardNumber = newCard;
                card.pipValue = newCard - 39;
                card.suitName = "Spades";
            }

            //Changing 'pipName' to any face card names if applicable, otherwise pipName is the number of pips.
            switch (Convert.ToString(card.pipValue))
            {
                case "1":
                    //If the card is an Ace, run the function to let the player/dealer choose if it's value is 1 or 11.
                    card.pipValue = 0;
                    AceDecision();
                    break;
                case "11":
                    card.pipName = "Jack";
                    card.pipValue = 10;
                    break;
                case "12":
                    card.pipName = "Queen";
                    card.pipValue = 10;
                    break;
                case "13":
                    card.pipName = "King";
                    card.pipValue = 10;
                    break;
                default:
                    card.pipName = Convert.ToString(card.pipValue);
                    break;

            }

            //If it is the player's card, add it to their hand. Otherwise, add the card to the dealer's hand.
            if (GameLogic.playersTurn == true)
                playerHand.Add(card);
            else
                dealerHand.Add(card);
        }

        public void AceDecision()
        {
            int currentHandValue;
            //If it is the player's turn, sum the pip values of their cards (using LINQ).
            if (GameLogic.playersTurn == true)
                currentHandValue = playerHand.Sum(card => card.pipValue);
            else
                currentHandValue = dealerHand.Sum(card => card.pipValue);


            //If the hand total is 10 or less, make the Ace card into an 11.
            if (currentHandValue <= 10)
            {
                if (GameLogic.playersTurn == true)
                {
                    foreach (Card card in playerHand)
                    {
                        if (card.pipValue == 0)
                            card.pipValue = 11;
                    }
                }

                else
                {
                    foreach (Card card in dealerHand)
                    {
                        if (card.pipValue == 0)
                            card.pipValue = 11;
                    }
                }
            }

            //If the hand total is 11 or more, make the Ace card into a 1.
            if (currentHandValue >= 11)
            {
                if (GameLogic.playersTurn == true)
                {
                    foreach (Card card in playerHand)
                    {
                        if (card.pipValue == 0)
                            card.pipValue = 1;
                    }
                }

                else
                {
                    foreach (Card card in dealerHand)
                    {
                        if (card.pipValue == 0)
                            card.pipValue = 1;
                    }
                }
            }
        }
        public void DisplayCard()
        {
            //Displaying card image by using the 'newCard' variable which holds the number of the latest card genereated.
            string filepath = @"F:\Files\Work\HNC Computing\Assignments\Software Development\Images\Resized\";
            if(GameLogic.playersTurn == false)
            {
                //Get the length of someones hand and use that number to determine which panel to display the image in.
                switch (dealerHand.Count())
                {
                    case 1:
                        frmMainWindow.pnlDealerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                }
            }
            else
            {
                switch (playerHand.Count())
                {
                    case 1:
                        frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 2:
                        frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 3:
                        frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 4:
                        frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 5:
                        frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 6:
                        frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                }
            }
        }
    }
}
