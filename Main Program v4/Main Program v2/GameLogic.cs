using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program_v4
{
    class GameLogic
    {
        static public int winCount = 0;

        //Creating a flag that will show true if it is currently the player's turn.
        static public bool playersTurn = false;

        static public void NewGame()
        {
            //Clear any relevant variables, draw two cards for the dealer and draw two cards for the player.
            //Deck.Clear();
            
            playersTurn = false;
            Deck.Draw();
            //Deck.DisplayCard();
            playersTurn = true;
            Deck.Draw();
            //Deck.DisplayCard();
            Deck.Draw();
            //Deck.DisplayCard();

            //frmMainWindow.txtPlayerTotal.Text = Convert.ToString(Deck.GetPlayerSum());
            //frmMainWindow.txtDealerTotal.Text = Convert.ToString(Deck.GetDealerSum());
            //frmMainWindow.btnHit.Enabled = true;
            //frmMainWindow.btnStand.Enabled = true;
        }

        void DealerDraw()
        {
            while (Deck.GetDealerSum() < 17)
            {
                Deck.Draw();
                //Deck.DisplayCard();
                Deck.TotalCheck();
            }
            if (Deck.CompareHands() == true)
            {
                //Player wins.
                winCount++;
            }
            else
            {
                //Dealer wins.
            }
        }

        static public void EndGame()
        {
            //frmMainWindow.btnHit.Enabled = false;
            //frmMainWindow.btnStand.Enabled = false;
        }

        //Procedure to create the card's name to be displayed in a text box when the mouse is hovered over a card's image.
        static public void MouseHover(int panelNumber)
        {
            switch (panelNumber)
            {
                case 1:
                    foreach (Card card in Deck.dealerHand)
                        if(card.cardOrder == 1)
                        {
                            //frmMainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                        } 
                    break;
                case 2:
                    foreach (Card card in Deck.playerHand)
                        if (card.cardOrder == 2)
                        {
                            //frmMainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                        }
                    break;
                case 3:
                    foreach (Card card in Deck.playerHand)
                        if (card.cardOrder == 3)
                        {
                            //frmMainWindow.txtHighlightedCard.Text = card.pipName + " of " + card.suitName;
                        }
                    break;
            }
        }

    }
}
