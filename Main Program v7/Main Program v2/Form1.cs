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
            Deck.TotalCheck();
            Deck.FullHandCheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            GameLogic.DealersTurn();
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

        private void pnlDealerCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void picDealerCard1_Click(object sender, EventArgs e)
        {

        }

        private void frmMainWindow_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picDealerCard1_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(1);
        }

        private void picDealerCard1_MouseLeave(object sender, EventArgs e)
        {
            txtHighlightedCard.Text = "";
        }

        private void picDealerCard2_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(2);
        }

        private void picDealerCard2_MouseLeave_1(object sender, EventArgs e)
        {
            txtHighlightedCard.Text = "";
        }

        private void picDealerCard3_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(3);
        }

        private void picDealerCard3_MouseLeave(object sender, EventArgs e)
        {
            txtHighlightedCard.Text = "";
        }

        private void picDealerCard4_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(4);
        }

        private void picDealerCard4_MouseLeave(object sender, EventArgs e)
        {
            txtHighlightedCard.Text = "";
        }

        private void picDealerCard5_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(5);
        }

        private void picDealerCard5_MouseLeave(object sender, EventArgs e)
        {
            txtHighlightedCard.Text = "";
        }

        private void picDealerCard6_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(6);
        }

        private void picDealerCard6_MouseLeave(object sender, EventArgs e)
        {
            txtHighlightedCard.Text = "";
        }

        private void picPlayerCard1_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(7);
        }

        private void picPlayerCard2_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(8);
        }

        private void picPlayerCard3_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(9);
        }

        private void picPlayerCard4_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(10);
        }

        private void picPlayerCard5_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(11);
        }

        private void picPlayerCard6_MouseEnter(object sender, EventArgs e)
        {
            GameLogic.MouseHover(12);
        }
    }
}
