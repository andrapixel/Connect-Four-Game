namespace Connect4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameBoard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTurn = new System.Windows.Forms.Panel();
            this.lblNextPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.panelBg = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameBoard
            // 
            this.gameBoard.Location = new System.Drawing.Point(30, 39);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(507, 447);
            this.gameBoard.TabIndex = 0;
            this.gameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.gameBoard_Paint);
            this.gameBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameBoard_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(594, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Este rândul lui:";
            // 
            // panelTurn
            // 
            this.panelTurn.Location = new System.Drawing.Point(598, 96);
            this.panelTurn.Name = "panelTurn";
            this.panelTurn.Size = new System.Drawing.Size(35, 34);
            this.panelTurn.TabIndex = 2;
            this.panelTurn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTurn_Paint);
            // 
            // lblNextPlayer
            // 
            this.lblNextPlayer.AutoSize = true;
            this.lblNextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNextPlayer.Location = new System.Drawing.Point(662, 130);
            this.lblNextPlayer.Name = "lblNextPlayer";
            this.lblNextPlayer.Size = new System.Drawing.Size(0, 24);
            this.lblNextPlayer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(646, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Location = new System.Drawing.Point(598, 337);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(218, 53);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Joc nou";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMenu.Location = new System.Drawing.Point(598, 396);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(218, 53);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Înapoi la meniu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblScore2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblScore1);
            this.panel2.Location = new System.Drawing.Point(588, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 80);
            this.panel2.TabIndex = 8;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore2.ForeColor = System.Drawing.Color.Gold;
            this.lblScore2.Location = new System.Drawing.Point(131, 33);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(40, 38);
            this.lblScore2.TabIndex = 2;
            this.lblScore2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore1.ForeColor = System.Drawing.Color.Red;
            this.lblScore1.Location = new System.Drawing.Point(55, 33);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(40, 38);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "0";
            // 
            // panelBg
            // 
            this.panelBg.Controls.Add(this.gameBoard);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(565, 489);
            this.panelBg.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 489);
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNextPlayer);
            this.Controls.Add(this.panelTurn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTurn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblNextPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Panel panelBg;
        private System.Windows.Forms.Timer timer;
    }
}

