using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //Used for summing object's properties in a list.

namespace Main_Program_v4
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

    class Deck
    {
        //Creating a counter variable to count how many cards have been drawn.
        static int drawCount = 0;

        //Instantiating a random number generator.
        static Random rng = new Random();

        //Creating a list that will hold the drawn card's numbers.
        static List<int> generatedCardNumbers = new List<int>();

        //Creating a list that will hold the player's cards.
        public static List<Card> playerHand = new List<Card>();


        //Creating a list that will hold the dealer's cards.
        public static List<Card> dealerHand = new List<Card>();

        //Creating a variable that will hold  the value of a newly generated card number.
        static int newCard;

        static public bool softHandFlag = false;


        //Procedure to clear all variables in order to get ready for a new game.
        public void Clear()
        {
            drawCount = 0;
            generatedCardNumbers.Clear();
            playerHand.Clear();
            dealerHand.Clear();
        }

        public static  string Draw()
        {
            //Check if the player has 6 cards.
            if (playerHand.Count() == 6)
            {
                GameLogic.EndGame();
                GameLogic.winCount++;
            }
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
                    //If the card is an Ace, run the function return a value of either 11 or 1.
                    card.pipValue = 0;
                    if (GameLogic.playersTurn == true)
                        card.pipValue = AceDecision(playerHand);
                    else
                        card.pipValue = AceDecision(dealerHand);
                    if (card.pipValue == 1)
                        card.pipName = "Ace";
                    else
                        card.pipName = "11";
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

            //Code to display createdvariables to a test text box on the form.
            return "Card order: " + card.cardOrder + ". Card number: " + card.cardNumber + ". Pip value: "+ card.pipValue + ". Card name: " + card.pipName + " of " + card.suitName;
            //frmMainWindow.txtTest.Text = card.cardOrder + card.cardNumber + card.pipValue + card.pipName + card.suitName;
        }

        static public string CardNumber()
        {
            string contents = "";
            foreach (Card card in playerHand)
            {
                contents = contents + Convert.ToString(card.cardNumber) + " ";
            }
            return contents;
        }

        static public int AceDecision(List<Card> hand)
        {
            //Sum the pip values of the cards in the hand.(using LINQ).
            //If the total is less than or equal to 10, make the ace an 11.
            if (hand.Sum(card => card.pipValue) <= 10)
                return 11;
            //The card is made a 1, otherwise it would mean bust.
            else
                return 1;
        }

        static public void DisplayCard()
        {
            //Displaying card image by using the 'newCard' variable which holds the number of the latest card genereated.
            string filepath = @"F:\Files\Work\HNC Computing\Assignments\Software Development\Images\Resized\";
            if (GameLogic.playersTurn == false)
            {
                //Get the length of someones hand and use that number to determine which panel to display the image in.
                switch (dealerHand.Count())
                {
                    case 1:
                        //frmMainWindow.pnlDealerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                }
            }
            else
            {
                switch (playerHand.Count())
                {
                    case 1:
                        //frmMainWindow.pnlPlayerCard1.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 2:
                        //frmMainWindow.pnlPlayerCard2.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 3:
                        //frmMainWindow.pnlPlayerCard3.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 4:
                        //frmMainWindow.pnlPlayerCard4.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 5:
                        //frmMainWindow.pnlPlayerCard5.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                    case 6:
                        //frmMainWindow.pnlPlayerCard6.BackgroundImage = System.Drawing.Image.FromFile(@filepath + newCard + ".png");
                        break;
                }
            }
        }

        //Returns true if the player's hand is greater than the dealer's hand, otherwise return false.
        static public bool CompareHands()
        {
            if (GetPlayerSum() > GetDealerSum())
                return true;
            else
                return false;
        }

        //getters for hand values.
        static public int GetDealerSum()
        {
            return dealerHand.Sum(card => card.pipValue);
        }
        static public int GetPlayerSum()
        {
            return playerHand.Sum(card => card.pipValue);
        }

        //Check if a hand is either 21 or bust. If neither, the game keeps going.
        static public void TotalCheck()
        {
            int handValue;
            if (GameLogic.playersTurn == true)
                handValue = GetPlayerSum();
            else
                handValue = GetDealerSum();
            if (handValue == 21)
            {
                //Blackjack
                GameLogic.EndGame();
                if (GameLogic.playersTurn == true)
                    GameLogic.winCount++;
            }
            else if (handValue > 21)
            {
                //Perform a check to see if the hand is a soft hand (i.e. includes an Ace of 11, which will be changed to 1).
                SoftHandCheck();
                //If the hand is not soft, then it is bust. If it isn't the player's turn, then the dealers hand must be bust. The player wins.
                if (softHandFlag == false)
                {
                    GameLogic.EndGame();
                    if (GameLogic.playersTurn == false)
                        GameLogic.winCount++;
                }
            }
        }

        //Check if a hand has any 11s and turn them into 1s. If this is performed, the softHandFlag is true, otherwise it is false.
        static public void SoftHandCheck()
        {
            softHandFlag = false;
            if (GameLogic.playersTurn == true)
            {
                foreach (Card card in playerHand)
                {
                    if (card.pipValue == 0)
                        card.pipValue = 1;
                        softHandFlag = true;
                }
            }
            else
            {
                foreach (Card card in dealerHand)
                {
                    if (card.pipValue == 0)
                        card.pipValue = 1;
                        softHandFlag = true;
                }
            }
        }

    }
}
