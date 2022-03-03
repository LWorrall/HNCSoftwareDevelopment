using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Program_v2
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

        }
    }
}
