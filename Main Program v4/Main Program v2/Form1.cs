using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Program_v4
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameLogic.NewGame();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
 
        }

        private void lblDealerTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Deck.Draw();
            Deck.DisplayCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameLogic.playersTurn = true;
            txtTest.Text = Deck.Draw();
            txtPlayerHandTest.Text = Deck.CardNumber();

            txtPlayerTotal.Text = Convert.ToString(Deck.GetPlayerSum());
        }

        private void btnStand_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrentMove_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWins_TextChanged(object sender, EventArgs e)
        {
            txtWins.Text = Convert.ToString(GameLogic.winCount);
        }

        private void txtDealerTotal_TextChanged(object sender, EventArgs e)
        {
            txtDealerTotal.Text = Convert.ToString(Deck.GetDealerSum());
        }

        private void txtPlayerTotal_TextChanged(object sender, EventArgs e)
        {
            txtPlayerTotal.Text = Convert.ToString(Deck.GetPlayerSum());
        }

        private void txtHighlightedCard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
