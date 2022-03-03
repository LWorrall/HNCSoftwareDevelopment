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
            this.lblWins = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.lblDealersHand = new System.Windows.Forms.Label();
            this.lblPlayersHand = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.picDealerCard4 = new System.Windows.Forms.PictureBox();
            this.picDealerCard5 = new System.Windows.Forms.PictureBox();
            this.picDealerCard6 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard6 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            this.SuspendLayout();
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
            // picDealerCard1
            // 
            this.picDealerCard1.Location = new System.Drawing.Point(12, 25);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(90, 138);
            this.picDealerCard1.TabIndex = 19;
            this.picDealerCard1.TabStop = false;
            this.picDealerCard1.MouseEnter += new System.EventHandler(this.picDealerCard1_MouseEnter);
            this.picDealerCard1.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.Location = new System.Drawing.Point(108, 25);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(90, 138);
            this.picDealerCard2.TabIndex = 20;
            this.picDealerCard2.TabStop = false;
            this.picDealerCard2.MouseEnter += new System.EventHandler(this.picDealerCard2_MouseEnter);
            this.picDealerCard2.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.Location = new System.Drawing.Point(204, 25);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(90, 138);
            this.picDealerCard3.TabIndex = 21;
            this.picDealerCard3.TabStop = false;
            this.picDealerCard3.MouseEnter += new System.EventHandler(this.picDealerCard3_MouseEnter);
            this.picDealerCard3.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picDealerCard4
            // 
            this.picDealerCard4.Location = new System.Drawing.Point(300, 25);
            this.picDealerCard4.Name = "picDealerCard4";
            this.picDealerCard4.Size = new System.Drawing.Size(90, 138);
            this.picDealerCard4.TabIndex = 22;
            this.picDealerCard4.TabStop = false;
            this.picDealerCard4.MouseEnter += new System.EventHandler(this.picDealerCard4_MouseEnter);
            this.picDealerCard4.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picDealerCard5
            // 
            this.picDealerCard5.Location = new System.Drawing.Point(396, 25);
            this.picDealerCard5.Name = "picDealerCard5";
            this.picDealerCard5.Size = new System.Drawing.Size(90, 138);
            this.picDealerCard5.TabIndex = 23;
            this.picDealerCard5.TabStop = false;
            this.picDealerCard5.MouseEnter += new System.EventHandler(this.picDealerCard5_MouseEnter);
            this.picDealerCard5.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picDealerCard6
            // 
            this.picDealerCard6.Location = new System.Drawing.Point(492, 25);
            this.picDealerCard6.Name = "picDealerCard6";
            this.picDealerCard6.Size = new System.Drawing.Size(90, 138);
            this.picDealerCard6.TabIndex = 24;
            this.picDealerCard6.TabStop = false;
            this.picDealerCard6.MouseEnter += new System.EventHandler(this.picDealerCard6_MouseEnter);
            this.picDealerCard6.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picPlayerCard6
            // 
            this.picPlayerCard6.Location = new System.Drawing.Point(492, 178);
            this.picPlayerCard6.Name = "picPlayerCard6";
            this.picPlayerCard6.Size = new System.Drawing.Size(90, 138);
            this.picPlayerCard6.TabIndex = 30;
            this.picPlayerCard6.TabStop = false;
            this.picPlayerCard6.MouseEnter += new System.EventHandler(this.picPlayerCard6_MouseEnter);
            this.picPlayerCard6.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picPlayerCard5
            // 
            this.picPlayerCard5.Location = new System.Drawing.Point(396, 178);
            this.picPlayerCard5.Name = "picPlayerCard5";
            this.picPlayerCard5.Size = new System.Drawing.Size(90, 138);
            this.picPlayerCard5.TabIndex = 29;
            this.picPlayerCard5.TabStop = false;
            this.picPlayerCard5.MouseEnter += new System.EventHandler(this.picPlayerCard5_MouseEnter);
            this.picPlayerCard5.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picPlayerCard4
            // 
            this.picPlayerCard4.Location = new System.Drawing.Point(300, 178);
            this.picPlayerCard4.Name = "picPlayerCard4";
            this.picPlayerCard4.Size = new System.Drawing.Size(90, 138);
            this.picPlayerCard4.TabIndex = 28;
            this.picPlayerCard4.TabStop = false;
            this.picPlayerCard4.MouseEnter += new System.EventHandler(this.picPlayerCard4_MouseEnter);
            this.picPlayerCard4.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.Location = new System.Drawing.Point(204, 178);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(90, 138);
            this.picPlayerCard3.TabIndex = 27;
            this.picPlayerCard3.TabStop = false;
            this.picPlayerCard3.MouseEnter += new System.EventHandler(this.picPlayerCard3_MouseEnter);
            this.picPlayerCard3.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Location = new System.Drawing.Point(108, 178);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(90, 138);
            this.picPlayerCard2.TabIndex = 26;
            this.picPlayerCard2.TabStop = false;
            this.picPlayerCard2.MouseEnter += new System.EventHandler(this.picPlayerCard2_MouseEnter);
            this.picPlayerCard2.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.Location = new System.Drawing.Point(12, 178);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(90, 138);
            this.picPlayerCard1.TabIndex = 25;
            this.picPlayerCard1.TabStop = false;
            this.picPlayerCard1.MouseEnter += new System.EventHandler(this.picPlayerCard1_MouseEnter);
            this.picPlayerCard1.MouseLeave += new System.EventHandler(this.picDealerCard1_MouseLeave);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(598, 490);
            this.Controls.Add(this.picPlayerCard6);
            this.Controls.Add(this.picPlayerCard5);
            this.Controls.Add(this.picPlayerCard4);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.picDealerCard6);
            this.Controls.Add(this.picDealerCard5);
            this.Controls.Add(this.picDealerCard4);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPlayersHand);
            this.Controls.Add(this.lblDealersHand);
            this.DoubleBuffered = true;
            this.Name = "frmMainWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.MouseHover += new System.EventHandler(this.frmMainWindow_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentMove;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblHighlightedCard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblWins;
        public System.Windows.Forms.Button btnHit;
        public System.Windows.Forms.Button btnStand;
        public System.Windows.Forms.TextBox txtPlayerTotal;
        public System.Windows.Forms.TextBox txtDealerTotal;
        public System.Windows.Forms.TextBox txtHighlightedCard;
        public System.Windows.Forms.TextBox txtWins;
        public System.Windows.Forms.TextBox txtCurrentMove;
        private System.Windows.Forms.Label lblDealersHand;
        private System.Windows.Forms.Label lblPlayersHand;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox picDealerCard1;
        public System.Windows.Forms.PictureBox picDealerCard2;
        public System.Windows.Forms.PictureBox picDealerCard3;
        public System.Windows.Forms.PictureBox picDealerCard4;
        public System.Windows.Forms.PictureBox picDealerCard5;
        public System.Windows.Forms.PictureBox picDealerCard6;
        public System.Windows.Forms.PictureBox picPlayerCard6;
        public System.Windows.Forms.PictureBox picPlayerCard5;
        public System.Windows.Forms.PictureBox picPlayerCard4;
        public System.Windows.Forms.PictureBox picPlayerCard3;
        public System.Windows.Forms.PictureBox picPlayerCard2;
        public System.Windows.Forms.PictureBox picPlayerCard1;
    }
}

