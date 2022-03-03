using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Main_Program_v4
{
    class GameLogic
    {
        static public int winCount = 0;

        //Creating a flag that will show true if it is currently the player's turn.
        static public bool playersTurn = false;

        static public void NewGame()
        {
            //Clear any relevant variables, draw one card for the dealer and draw two cards for the player.
            Deck.Clear();
            
            playersTurn = false;
            Deck.Draw();
            Deck.DisplayCard();
            Program.mainWindow.txtDealerTotal.Text = Convert.ToString(Deck.GetDealerSum());

            playersTurn = true;
            Deck.Draw();
            Deck.DisplayCard();

            Deck.Draw();
            Deck.DisplayCard();
            Program.mainWindow.txtPlayerTotal.Text = Convert.ToString(Deck.GetPlayerSum());
            Program.mainWindow.btnHit.Enabled = true;
            Program.mainWindow.btnStand.Enabled = true;
            Program.mainWindow.txtCurrentMove.Text = "Your Turn: Click 'Hit' to draw a card, or 'Stand' to end your turn.";
            Deck.TotalCheck();
        }

        static public void DealersTurn()
        {
            Program.mainWindow.btnHit.Enabled = false;
            Program.mainWindow.btnStand.Enabled = false;
            Program.mainWindow.txtCurrentMove.Text = "Dealer’s Turn: Cards are being delt to the dealer’s hand.";
            playersTurn = false;
            //Draw cards for the dealer until the hand is 17 or more.
            while (Deck.GetDealerSum() < 17)
            {
                Deck.Draw();
                Deck.DisplayCard();
                Deck.TotalCheck();
            }
            if (Deck.CompareHands() == "win")
            {
                //Player wins.
                EndGame();
                winCount++;
                Program.mainWindow.txtCurrentMove.Text = "You have the higher hand. You win! Click 'New Game' to start a new game.";
                Program.mainWindow.txtWins.Text = Convert.ToString(winCount);
            }
            else if (Deck.CompareHands() == "draw")
            {
                //Hands are the dame value, no one wins.
                EndGame();
                Program.mainWindow.txtCurrentMove.Text = "Draw. No one wins. Click 'New Game' to start a new game.";
            }
            else
            {
                //Dealer wins.
                EndGame();
            }
        }

        static public void EndGame()
        {
            Program.mainWindow.btnHit.Enabled = false;
            Program.mainWindow.btnStand.Enabled = false;
        }

        //Procedure to create the card's name to be displayed in a text box when the mouse is hovered over a card's image.
        static public void MouseHover(int panelNumber)
        {
            int tagNumber = 0;
            switch (panelNumber)
            {
                case 1:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picDealerCard1.Tag);
                    foreach (Card card in Deck.dealerHand)                    
                    if (card.cardNumber == tagNumber)                      
                        Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 2:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picDealerCard2.Tag);
                    foreach (Card card in Deck.dealerHand)
                    if (card.cardNumber == tagNumber)
                        Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 3:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picDealerCard3.Tag);
                    foreach (Card card in Deck.dealerHand)      
                    if (card.cardNumber == tagNumber)
                        Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 4:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picDealerCard4.Tag);
                    foreach (Card card in Deck.dealerHand)
                    if (card.cardNumber == tagNumber)
                        Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 5:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picDealerCard5.Tag);
                    foreach (Card card in Deck.dealerHand)
                    if (card.cardNumber == tagNumber)
                        Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 6:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picDealerCard6.Tag);
                    foreach (Card card in Deck.dealerHand)
                    if (card.cardNumber == tagNumber)
                        Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;

                case 7:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picPlayerCard1.Tag);
                    foreach (Card card in Deck.playerHand)
                        if (card.cardNumber == tagNumber)
                            Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 8:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picPlayerCard2.Tag);
                    foreach (Card card in Deck.playerHand)
                        if (card.cardNumber == tagNumber)
                            Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 9:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picPlayerCard3.Tag);
                    foreach (Card card in Deck.playerHand)
                        if (card.cardNumber == tagNumber)
                            Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 10:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picPlayerCard4.Tag);
                    foreach (Card card in Deck.playerHand)
                        if (card.cardNumber == tagNumber)
                            Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 11:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picPlayerCard5.Tag);
                    foreach (Card card in Deck.playerHand)
                        if (card.cardNumber == tagNumber)
                            Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;
                case 12:
                    tagNumber = Convert.ToInt32(Program.mainWindow.picPlayerCard6.Tag);
                    foreach (Card card in Deck.playerHand)
                        if (card.cardNumber == tagNumber)
                            Program.mainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                    break;

            }
        }

    }
}
