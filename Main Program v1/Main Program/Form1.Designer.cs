
namespace Main_Program
{
    partial class frmMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtPlayerTotal = new System.Windows.Forms.TextBox();
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtDealerTotal = new System.Windows.Forms.TextBox();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblCurrentMove = new System.Windows.Forms.Label();
            this.txtCurrentMove = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(132, 496);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(131, 64);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(269, 496);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(131, 64);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStick_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(657, 467);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 93);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(132, 467);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.ReadOnly = true;
            this.txtCardName.Size = new System.Drawing.Size(268, 23);
            this.txtCardName.TabIndex = 5;
            // 
            // txtPlayerTotal
            // 
            this.txtPlayerTotal.Location = new System.Drawing.Point(12, 467);
            this.txtPlayerTotal.Name = "txtPlayerTotal";
            this.txtPlayerTotal.ReadOnly = true;
            this.txtPlayerTotal.Size = new System.Drawing.Size(79, 23);
            this.txtPlayerTotal.TabIndex = 6;
            this.txtPlayerTotal.TextChanged += new System.EventHandler(this.txtPlayerTotal_TextChanged);
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(132, 449);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(35, 15);
            this.lblCardName.TabIndex = 7;
            this.lblCardName.Text = "Card:";
            // 
            // txtDealerTotal
            // 
            this.txtDealerTotal.Location = new System.Drawing.Point(12, 514);
            this.txtDealerTotal.Name = "txtDealerTotal";
            this.txtDealerTotal.ReadOnly = true;
            this.txtDealerTotal.Size = new System.Drawing.Size(79, 23);
            this.txtDealerTotal.TabIndex = 8;
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Location = new System.Drawing.Point(12, 449);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(62, 15);
            this.lblPlayerTotal.TabIndex = 9;
            this.lblPlayerTotal.Text = "Your Total:";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Location = new System.Drawing.Point(12, 496);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(79, 15);
            this.lblDealerTotal.TabIndex = 10;
            this.lblDealerTotal.Text = "Dealer\'s Total:";
            // 
            // lblCurrentMove
            // 
            this.lblCurrentMove.AutoSize = true;
            this.lblCurrentMove.Location = new System.Drawing.Point(12, 405);
            this.lblCurrentMove.Name = "lblCurrentMove";
            this.lblCurrentMove.Size = new System.Drawing.Size(83, 15);
            this.lblCurrentMove.TabIndex = 11;
            this.lblCurrentMove.Text = "Current Move:";
            // 
            // txtCurrentMove
            // 
            this.txtCurrentMove.Location = new System.Drawing.Point(12, 423);
            this.txtCurrentMove.Name = "txtCurrentMove";
            this.txtCurrentMove.ReadOnly = true;
            this.txtCurrentMove.Size = new System.Drawing.Size(644, 23);
            this.txtCurrentMove.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 390);
            this.panel1.TabIndex = 13;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCurrentMove);
            this.Controls.Add(this.lblCurrentMove);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.txtDealerTotal);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.txtPlayerTotal);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Name = "frmMainWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtPlayerTotal;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtDealerTotal;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblCurrentMove;
        private System.Windows.Forms.TextBox txtCurrentMove;
        private System.Windows.Forms.Panel panel1;
    }
}

