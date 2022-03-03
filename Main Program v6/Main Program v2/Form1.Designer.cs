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
            this.pnlDealerCard2 = new System.Windows.Forms.Panel();
            this.pnlDealerCard4 = new System.Windows.Forms.Panel();
            this.pnlDealerCard3 = new System.Windows.Forms.Panel();
            this.pnlDealerCard6 = new System.Windows.Forms.Panel();
            this.pnlDealerCard5 = new System.Windows.Forms.Panel();
            this.lblDealersHand = new System.Windows.Forms.Label();
            this.lblPlayersHand = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDealerCard1
            // 
            this.pnlDealerCard1.Location = new System.Drawing.Point(12, 25);
            this.pnlDealerCard1.Name = "pnlDealerCard1";
            this.pnlDealerCard1.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard1.TabIndex = 0;
            this.pnlDealerCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCurrentMove
            // 
            this.txtCurrentMove.Location = new System.Drawing.Point(11, 17);
            this.txtCurrentMove.Name = "txtCurrentMove";
            this.txtCurrentMove.ReadOnly = true;
            this.txtCurrentMove.Size = new System.Drawing.Size(570, 20);
            this.txtCurrentMove.TabIndex = 1;
            this.txtCurrentMove.TabStop = false;
            this.txtCurrentMove.Text = "Click ‘New Game’ to start a new game.";
            this.txtCurrentMove.TextChanged += new System.EventHandler(this.txtCurrentMove_TextChanged);
            // 
            // txtHighlightedCard
            // 
            this.txtHighlightedCard.Location = new System.Drawing.Point(91, 56);
            this.txtHighlightedCard.Name = "txtHighlightedCard";
            this.txtHighlightedCard.ReadOnly = true;
            this.txtHighlightedCard.Size = new System.Drawing.Size(324, 20);
            this.txtHighlightedCard.TabIndex = 2;
            this.txtHighlightedCard.TabStop = false;
            this.txtHighlightedCard.TextChanged += new System.EventHandler(this.txtHighlightedCard_TextChanged);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(92, 82);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(159, 72);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Location = new System.Drawing.Point(257, 82);
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
            this.lblCurrentMove.Location = new System.Drawing.Point(11, 1);
            this.lblCurrentMove.Name = "lblCurrentMove";
            this.lblCurrentMove.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentMove.TabIndex = 5;
            this.lblCurrentMove.Text = "Current Move:";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Location = new System.Drawing.Point(11, 40);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(59, 13);
            this.lblPlayerTotal.TabIndex = 6;
            this.lblPlayerTotal.Text = "Your Total:";
            // 
            // txtPlayerTotal
            // 
            this.txtPlayerTotal.Location = new System.Drawing.Point(11, 56);
            this.txtPlayerTotal.Name = "txtPlayerTotal";
            this.txtPlayerTotal.ReadOnly = true;
            this.txtPlayerTotal.Size = new System.Drawing.Size(74, 20);
            this.txtPlayerTotal.TabIndex = 7;
            this.txtPlayerTotal.TabStop = false;
            this.txtPlayerTotal.TextChanged += new System.EventHandler(this.txtPlayerTotal_TextChanged);
            // 
            // txtDealerTotal
            // 
            this.txtDealerTotal.Location = new System.Drawing.Point(11, 95);
            this.txtDealerTotal.Name = "txtDealerTotal";
            this.txtDealerTotal.ReadOnly = true;
            this.txtDealerTotal.Size = new System.Drawing.Size(74, 20);
            this.txtDealerTotal.TabIndex = 9;
            this.txtDealerTotal.TabStop = false;
            this.txtDealerTotal.TextChanged += new System.EventHandler(this.txtDealerTotal_TextChanged);
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Location = new System.Drawing.Point(11, 79);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(75, 13);
            this.lblDealerTotal.TabIndex = 8;
            this.lblDealerTotal.Text = "Dealer\'s Total:";
            this.lblDealerTotal.Click += new System.EventHandler(this.lblDealerTotal_Click);
            // 
            // lblHighlightedCard
            // 
            this.lblHighlightedCard.AutoSize = true;
            this.lblHighlightedCard.Location = new System.Drawing.Point(88, 40);
            this.lblHighlightedCard.Name = "lblHighlightedCard";
            this.lblHighlightedCard.Size = new System.Drawing.Size(88, 13);
            this.lblHighlightedCard.TabIndex = 10;
            this.lblHighlightedCard.Text = "Highlighted Card:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(420, 43);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(160, 111);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pnlPlayerCard1
            // 
            this.pnlPlayerCard1.Location = new System.Drawing.Point(12, 182);
            this.pnlPlayerCard1.Name = "pnlPlayerCard1";
            this.pnlPlayerCard1.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard1.TabIndex = 1;
            this.pnlPlayerCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pnlPlayerCard2
            // 
            this.pnlPlayerCard2.Location = new System.Drawing.Point(108, 182);
            this.pnlPlayerCard2.Name = "pnlPlayerCard2";
            this.pnlPlayerCard2.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard2.TabIndex = 2;
            // 
            // pnlPlayerCard3
            // 
            this.pnlPlayerCard3.Location = new System.Drawing.Point(204, 182);
            this.pnlPlayerCard3.Name = "pnlPlayerCard3";
            this.pnlPlayerCard3.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard3.TabIndex = 3;
            // 
            // pnlPlayerCard4
            // 
            this.pnlPlayerCard4.Location = new System.Drawing.Point(300, 182);
            this.pnlPlayerCard4.Name = "pnlPlayerCard4";
            this.pnlPlayerCard4.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard4.TabIndex = 4;
            // 
            // pnlPlayerCard5
            // 
            this.pnlPlayerCard5.Location = new System.Drawing.Point(396, 182);
            this.pnlPlayerCard5.Name = "pnlPlayerCard5";
            this.pnlPlayerCard5.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard5.TabIndex = 5;
            // 
            // pnlPlayerCard6
            // 
            this.pnlPlayerCard6.Location = new System.Drawing.Point(492, 182);
            this.pnlPlayerCard6.Name = "pnlPlayerCard6";
            this.pnlPlayerCard6.Size = new System.Drawing.Size(90, 138);
            this.pnlPlayerCard6.TabIndex = 6;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(11, 118);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(34, 13);
            this.lblWins.TabIndex = 14;
            this.lblWins.Text = "Wins:";
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(11, 134);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(74, 20);
            this.txtWins.TabIndex = 15;
            this.txtWins.TabStop = false;
            this.txtWins.TextChanged += new System.EventHandler(this.txtWins_TextChanged);
            // 
            // pnlDealerCard2
            // 
            this.pnlDealerCard2.Location = new System.Drawing.Point(108, 25);
            this.pnlDealerCard2.Name = "pnlDealerCard2";
            this.pnlDealerCard2.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard2.TabIndex = 1;
            // 
            // pnlDealerCard4
            // 
            this.pnlDealerCard4.Location = new System.Drawing.Point(300, 25);
            this.pnlDealerCard4.Name = "pnlDealerCard4";
            this.pnlDealerCard4.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard4.TabIndex = 3;
            // 
            // pnlDealerCard3
            // 
            this.pnlDealerCard3.Location = new System.Drawing.Point(204, 25);
            this.pnlDealerCard3.Name = "pnlDealerCard3";
            this.pnlDealerCard3.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard3.TabIndex = 2;
            // 
            // pnlDealerCard6
            // 
            this.pnlDealerCard6.Location = new System.Drawing.Point(492, 25);
            this.pnlDealerCard6.Name = "pnlDealerCard6";
            this.pnlDealerCard6.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard6.TabIndex = 5;
            this.pnlDealerCard6.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDealerCard6_Paint);
            // 
            // pnlDealerCard5
            // 
            this.pnlDealerCard5.Location = new System.Drawing.Point(396, 25);
            this.pnlDealerCard5.Name = "pnlDealerCard5";
            this.pnlDealerCard5.Size = new System.Drawing.Size(90, 138);
            this.pnlDealerCard5.TabIndex = 4;
            // 
            // lblDealersHand
            // 
            this.lblDealersHand.AutoSize = true;
            this.lblDealersHand.Location = new System.Drawing.Point(12, 9);
            this.lblDealersHand.Name = "lblDealersHand";
            this.lblDealersHand.Size = new System.Drawing.Size(77, 13);
            this.lblDealersHand.TabIndex = 16;
            this.lblDealersHand.Text = "Dealer\'s Hand:";
            // 
            // lblPlayersHand
            // 
            this.lblPlayersHand.AutoSize = true;
            this.lblPlayersHand.Location = new System.Drawing.Point(12, 166);
            this.lblPlayersHand.Name = "lblPlayersHand";
            this.lblPlayersHand.Size = new System.Drawing.Size(61, 13);
            this.lblPlayersHand.TabIndex = 17;
            this.lblPlayersHand.Text = "Your Hand:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtWins);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.lblHighlightedCard);
            this.panel1.Controls.Add(this.txtDealerTotal);
            this.panel1.Controls.Add(this.lblDealerTotal);
            this.panel1.Controls.Add(this.txtPlayerTotal);
            this.panel1.Controls.Add(this.lblPlayerTotal);
            this.panel1.Controls.Add(this.lblCurrentMove);
            this.panel1.Controls.Add(this.btnStand);
            this.panel1.Controls.Add(this.btnHit);
            this.panel1.Controls.Add(this.txtHighlightedCard);
            this.panel1.Controls.Add(this.txtCurrentMove);
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 168);
            this.panel1.TabIndex = 18;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(598, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPlayersHand);
            this.Controls.Add(this.lblDealersHand);
            this.Controls.Add(this.pnlDealerCard6);
            this.Controls.Add(this.pnlDealerCard5);
            this.Controls.Add(this.pnlDealerCard4);
            this.Controls.Add(this.pnlDealerCard3);
            this.Controls.Add(this.pnlDealerCard2);
            this.Controls.Add(this.pnlPlayerCard6);
            this.Controls.Add(this.pnlPlayerCard5);
            this.Controls.Add(this.pnlPlayerCard4);
            this.Controls.Add(this.pnlPlayerCard3);
            this.Controls.Add(this.pnlPlayerCard2);
            this.Controls.Add(this.pnlPlayerCard1);
            this.Controls.Add(this.pnlDealerCard1);
            this.DoubleBuffered = true;
            this.Name = "frmMainWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public System.Windows.Forms.Button btnHit;
        public System.Windows.Forms.Button btnStand;
        public System.Windows.Forms.TextBox txtPlayerTotal;
        public System.Windows.Forms.TextBox txtDealerTotal;
        public System.Windows.Forms.TextBox txtHighlightedCard;
        public System.Windows.Forms.Panel pnlDealerCard2;
        public System.Windows.Forms.Panel pnlDealerCard4;
        public System.Windows.Forms.Panel pnlDealerCard3;
        public System.Windows.Forms.Panel pnlDealerCard6;
        public System.Windows.Forms.Panel pnlDealerCard5;
        public System.Windows.Forms.TextBox txtWins;
        public System.Windows.Forms.TextBox txtCurrentMove;
        private System.Windows.Forms.Label lblDealersHand;
        private System.Windows.Forms.Label lblPlayersHand;
        private System.Windows.Forms.Panel panel1;
    }
}

