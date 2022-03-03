namespace Main_Program_v4
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDealerCard1 = new System.Windows.Forms.Panel();
            this.txtCurrentMove = new System.Windows.Forms.TextBox();
            this.txtHighlightedCard = new System.Windows.Forms.TextBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblCurrentMove = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.txtPlayerTotal = new System.Windows.Forms.TextBox();
            this.txtDealerTotal = new System.Windows.Forms.TextBox();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblHighlightedCard = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnlPlayerCard1 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard2 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard3 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard4 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard5 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard6 = new System.Windows.Forms.Panel();
            this.lblWins = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtPlayerHandTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlDealerCard1
            // 
            this.pnlDealerCard1.Location = new System.Drawing.Point(12, 12);
            this.pnlDealerCard1.Name = "pnlDealerCard1";
            this.pnlDealerCard1.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard1.TabIndex = 0;
            this.pnlDealerCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCurrentMove
            // 
            this.txtCurrentMove.Location = new System.Drawing.Point(12, 313);
            this.txtCurrentMove.Name = "txtCurrentMove";
            this.txtCurrentMove.ReadOnly = true;
            this.txtCurrentMove.Size = new System.Drawing.Size(570, 20);
            this.txtCurrentMove.TabIndex = 1;
            this.txtCurrentMove.TextChanged += new System.EventHandler(this.txtCurrentMove_TextChanged);
            // 
            // txtHighlightedCard
            // 
            this.txtHighlightedCard.Location = new System.Drawing.Point(92, 352);
            this.txtHighlightedCard.Name = "txtHighlightedCard";
            this.txtHighlightedCard.ReadOnly = true;
            this.txtHighlightedCard.Size = new System.Drawing.Size(324, 20);
            this.txtHighlightedCard.TabIndex = 2;
            this.txtHighlightedCard.TextChanged += new System.EventHandler(this.txtHighlightedCard_TextChanged);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(93, 378);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(159, 72);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(258, 378);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(159, 72);
            this.btnStand.TabIndex = 4;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblCurrentMove
            // 
            this.lblCurrentMove.AutoSize = true;
            this.lblCurrentMove.Location = new System.Drawing.Point(12, 297);
            this.lblCurrentMove.Name = "lblCurrentMove";
            this.lblCurrentMove.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentMove.TabIndex = 5;
            this.lblCurrentMove.Text = "Current Move:";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Location = new System.Drawing.Point(12, 336);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(59, 13);
            this.lblPlayerTotal.TabIndex = 6;
            this.lblPlayerTotal.Text = "Your Total:";
            // 
            // txtPlayerTotal
            // 
            this.txtPlayerTotal.Location = new System.Drawing.Point(12, 352);
            this.txtPlayerTotal.Name = "txtPlayerTotal";
            this.txtPlayerTotal.ReadOnly = true;
            this.txtPlayerTotal.Size = new System.Drawing.Size(74, 20);
            this.txtPlayerTotal.TabIndex = 7;
            this.txtPlayerTotal.TextChanged += new System.EventHandler(this.txtPlayerTotal_TextChanged);
            // 
            // txtDealerTotal
            // 
            this.txtDealerTotal.Location = new System.Drawing.Point(12, 391);
            this.txtDealerTotal.Name = "txtDealerTotal";
            this.txtDealerTotal.ReadOnly = true;
            this.txtDealerTotal.Size = new System.Drawing.Size(74, 20);
            this.txtDealerTotal.TabIndex = 9;
            this.txtDealerTotal.TextChanged += new System.EventHandler(this.txtDealerTotal_TextChanged);
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Location = new System.Drawing.Point(12, 375);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(75, 13);
            this.lblDealerTotal.TabIndex = 8;
            this.lblDealerTotal.Text = "Dealer\'s Total:";
            this.lblDealerTotal.Click += new System.EventHandler(this.lblDealerTotal_Click);
            // 
            // lblHighlightedCard
            // 
            this.lblHighlightedCard.AutoSize = true;
            this.lblHighlightedCard.Location = new System.Drawing.Point(89, 336);
            this.lblHighlightedCard.Name = "lblHighlightedCard";
            this.lblHighlightedCard.Size = new System.Drawing.Size(88, 13);
            this.lblHighlightedCard.TabIndex = 10;
            this.lblHighlightedCard.Text = "Highlighted Card:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(421, 339);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(160, 111);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pnlPlayerCard1
            // 
            this.pnlPlayerCard1.Location = new System.Drawing.Point(12, 156);
            this.pnlPlayerCard1.Name = "pnlPlayerCard1";
            this.pnlPlayerCard1.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard1.TabIndex = 1;
            this.pnlPlayerCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pnlPlayerCard2
            // 
            this.pnlPlayerCard2.Location = new System.Drawing.Point(108, 156);
            this.pnlPlayerCard2.Name = "pnlPlayerCard2";
            this.pnlPlayerCard2.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard2.TabIndex = 2;
            // 
            // pnlPlayerCard3
            // 
            this.pnlPlayerCard3.Location = new System.Drawing.Point(204, 156);
            this.pnlPlayerCard3.Name = "pnlPlayerCard3";
            this.pnlPlayerCard3.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard3.TabIndex = 3;
            // 
            // pnlPlayerCard4
            // 
            this.pnlPlayerCard4.Location = new System.Drawing.Point(300, 156);
            this.pnlPlayerCard4.Name = "pnlPlayerCard4";
            this.pnlPlayerCard4.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard4.TabIndex = 4;
            // 
            // pnlPlayerCard5
            // 
            this.pnlPlayerCard5.Location = new System.Drawing.Point(396, 156);
            this.pnlPlayerCard5.Name = "pnlPlayerCard5";
            this.pnlPlayerCard5.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard5.TabIndex = 5;
            // 
            // pnlPlayerCard6
            // 
            this.pnlPlayerCard6.Location = new System.Drawing.Point(492, 156);
            this.pnlPlayerCard6.Name = "pnlPlayerCard6";
            this.pnlPlayerCard6.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard6.TabIndex = 6;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(12, 414);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(34, 13);
            this.lblWins.TabIndex = 14;
            this.lblWins.Text = "Wins:";
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(12, 430);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(74, 20);
            this.txtWins.TabIndex = 15;
            this.txtWins.TextChanged += new System.EventHandler(this.txtWins_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(108, 12);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(473, 20);
            this.txtTest.TabIndex = 12;
            // 
            // txtPlayerHandTest
            // 
            this.txtPlayerHandTest.Location = new System.Drawing.Point(110, 38);
            this.txtPlayerHandTest.Multiline = true;
            this.txtPlayerHandTest.Name = "txtPlayerHandTest";
            this.txtPlayerHandTest.Size = new System.Drawing.Size(279, 110);
            this.txtPlayerHandTest.TabIndex = 16;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 462);
            this.Controls.Add(this.txtPlayerHandTest);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.pnlPlayerCard6);
            this.Controls.Add(this.pnlPlayerCard5);
            this.Controls.Add(this.pnlPlayerCard4);
            this.Controls.Add(this.pnlPlayerCard3);
            this.Controls.Add(this.pnlPlayerCard2);
            this.Controls.Add(this.pnlPlayerCard1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblHighlightedCard);
            this.Controls.Add(this.txtDealerTotal);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.txtPlayerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.lblCurrentMove);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.txtHighlightedCard);
            this.Controls.Add(this.txtCurrentMove);
            this.Controls.Add(this.pnlDealerCard1);
            this.DoubleBuffered = true;
            this.Name = "frmMainWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurrentMove;
        private System.Windows.Forms.Label lblCurrentMove;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblHighlightedCard;
        private System.Windows.Forms.Button btnNewGame;
        public System.Windows.Forms.Panel pnlPlayerCard1;
        public System.Windows.Forms.Panel pnlPlayerCard2;
        public System.Windows.Forms.Panel pnlPlayerCard3;
        public System.Windows.Forms.Panel pnlPlayerCard4;
        public System.Windows.Forms.Panel pnlPlayerCard5;
        public System.Windows.Forms.Panel pnlPlayerCard6;
        public System.Windows.Forms.Panel pnlDealerCard1;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtPlayerHandTest;
        public System.Windows.Forms.Button btnHit;
        public System.Windows.Forms.Button btnStand;
        public System.Windows.Forms.TextBox txtPlayerTotal;
        public System.Windows.Forms.TextBox txtDealerTotal;
        public System.Windows.Forms.TextBox txtHighlightedCard;
    }
}

