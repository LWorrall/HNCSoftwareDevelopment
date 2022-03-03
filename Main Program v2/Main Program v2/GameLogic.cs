using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Program_v2
{
    class GameLogic
    {
        //Creating a flag that will show true if it is currently the player's turn.
        public static bool playersTurn = false;

        void NewGame()
        {
            //Clear any relevant variables, draw two cards for the dealer and draw two cards for the player.
            Deck.Clear();
            playersTurn = false;
            Deck.Draw();

            playersTurn = true;
            Deck.Draw();

            Deck.Draw();

        }
    }
}
