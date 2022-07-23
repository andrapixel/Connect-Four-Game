using Connect4.GamesDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        private Graphics g1, g2;
        private Rectangle[] boardCol;   
        private int[,] board;   // board[i][j] = 1 -> jucatorul 1 a pus discul pe pozitia (i, j) de pe tabla de joc
        private int turn;   // turn = 1 (e randul primului jucator); turn = 2 (e randul celui de-al doilea jucator)
        private bool won = false;
        private string winner;  // retine numele jucatorului castigator
        private int score1, score2; // scorurile celor 2 jucatori

        private GamesTableAdapter gamesTableAdapter;
        private GamesDBDataSet gamesDataSet;

        public string Player1
        {
            get; set;
        }

        public string Player2
        {
            get; set;
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "Connect Four";

            g1 = gameBoard.CreateGraphics();
            g2 = panelTurn.CreateGraphics();
            g1.SmoothingMode = SmoothingMode.AntiAlias;
            g2.SmoothingMode = SmoothingMode.AntiAlias;

            board = new int[6, 7]; 
            turn = 1;
            score1 = 0;
            score2 = 0;
            label2.Text = "";

            // Design
            this.BackColor = Color.DarkSlateBlue;
            panelBg.BackColor = Color.LightSteelBlue;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            btnBackToMenu.BackColor = Color.LightSteelBlue;
            btnRestart.BackColor = Color.LightSteelBlue;
            btnBackToMenu.ForeColor = Color.DarkSlateBlue;
            btnRestart.ForeColor = Color.DarkSlateBlue;
        }

        // model gradient pentru golurile din tabla de joc
        public void CreateDiagonalGradientEllipse(PaintEventArgs e, int i, int j)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(300, 500),
                Color.DarkSlateBlue,
                Color.Black);

            e.Graphics.FillEllipse(brush, 5 + j * (gameBoard.Width / 7),
                        5 + i * (gameBoard.Height / 6), 42, 42);
        }

        private void gameBoard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkBlue, gameBoard.ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            boardCol = new Rectangle[7];

            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 7; ++j)
                {
                    if (i == 0)
                    {
                        boardCol[j] = new Rectangle(j * (gameBoard.Width / 7), 0, gameBoard.Width / 7,
                            gameBoard.Height);
                    }

                    CreateDiagonalGradientEllipse(e, i, j);
                }
        }

        // functie care returneaza indexul coloanei pe care se apasa cu mouse-ul
        private int GetColumnIndex(Point mousePos)
        {
            for (int i = 0; i < boardCol.Length; ++i)
            {
                if ((mousePos.X >= boardCol[i].X && mousePos.X <= boardCol[i].X + boardCol[i].Width) &&
                    (mousePos.Y >= boardCol[i].Y && mousePos.Y <= boardCol[i].Y + boardCol[i].Height))
                    return i;
            }
            
            return -1;
        }

        // returneaza urmatoarul rand liber de pe coloana apasata/ urmatoarul spatiu gol pe tabla
        private int NextEmptyRow(int col)
        {
            for (int i = 5; i >= 0; --i)
            {
                if (board[i, col] == 0)
                    return i;
            }
            return -1;
        }

        private void gameBoard_MouseClick(object sender, MouseEventArgs e)
        {
            int colIndex = GetColumnIndex(e.Location);
    
            if (colIndex != -1)
            {
                int rowIndex = NextEmptyRow(colIndex);
                if (rowIndex != -1)
                {
                    board[rowIndex, colIndex] = turn;

                    // se verifică dacă a câștigat cineva dupa fiecare mutare
                    if (turn == 1)
                    {
                        label2.Text = Player2;
                        g1.FillEllipse(Brushes.Red, 5 + colIndex * (gameBoard.Width / 7),
                            5 + rowIndex * (gameBoard.Height / 6), 42, 42);

                        g2.FillRectangle(Brushes.Gold, g2.ClipBounds);

                        // dacă s-a format unul din modelele câștigătoare, se afiseaza mesajul,
                        // creste scorul castigatorului si variabila winner retine numele castigatorului
                        if ((CheckHorizontal() != -1 || CheckVertical() != -1 || CheckForwardDiagonal() != -1 
                            || CheckBackwardDiagonal() != -1) && board[rowIndex, colIndex] == 1)
                        {
                            MessageBox.Show(Player1 + " a câștigat!", "Felicitări!");
                            winner = Player1;
                            score1++;
                            lblScore1.Text = score1.ToString();
                            won = true;
                        }
                            
                        turn = 2;   // daca nu, este randul urmatorului jucator, iar jocul continua
                    }
                    else if (turn == 2)
                    {
                        label2.Text = Player1;
                        g1.FillEllipse(Brushes.Gold, 5 + colIndex * (gameBoard.Width / 7),
                            5 + rowIndex * (gameBoard.Height / 6), 42, 42);
                        
                        g2.FillRectangle(Brushes.Red, g2.ClipBounds);

                        if ((CheckHorizontal() != -1 || CheckVertical() != -1 || CheckForwardDiagonal() != -1
                            || CheckBackwardDiagonal() != -1) && board[rowIndex, colIndex] == 2)
                        {
                            MessageBox.Show(Player2 + " a câștigat!", "Felicitări!");
                            winner = Player2;
                            score2++;
                            lblScore2.Text = score2.ToString();
                            won = true;
                        }

                        turn = 1;
                    }
                }
            }
        }

     
        private void panelTurn_Paint(object sender, PaintEventArgs e)
        {
            g2.FillRectangle(Brushes.Red, g2.ClipBounds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Player1;
        }

        // Salvarea datelor jocului in urma inceperii unui joc nou/ intoarcerii la meniu/ inchiderii ferestrei
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (won)
            {
                // daca jocul este castigat de cineva, elementele matricii board redevin 0, iar elipsele se redeseneaza
                for (int i = 0; i < 6; ++i)
                    for (int j = 0; j < 7; ++j)
                    {
                        g1.FillEllipse(Brushes.DarkSlateBlue, 5 + j * (gameBoard.Width / 7),
                        5 + i * (gameBoard.Height / 6), 42, 42);
                        board[i, j] = 0;
                    }
                won = false;

                if (winner == Player1)
                {
                    turn = 1;
                    label2.Text = Player1;
                    g2.FillRectangle(Brushes.Red, g2.ClipBounds);
                }
                else if (winner == Player2)
                {
                    turn = 2;
                    label2.Text = Player2;
                    g2.FillRectangle(Brushes.Gold, g2.ClipBounds);
                }
                    
                // salvare date
                gamesTableAdapter = new GamesTableAdapter();
                gamesDataSet = new GamesDBDataSet();
                gamesTableAdapter.InsertGame(Player1, Player2, winner);
                gamesTableAdapter.Fill(gamesDataSet.Games);
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            if (won)
            {
                gamesTableAdapter = new GamesTableAdapter();
                gamesDataSet = new GamesDBDataSet();
                gamesTableAdapter.InsertGame(Player1, Player2, winner);
                gamesTableAdapter.Fill(gamesDataSet.Games);
            }
            else
            {
                gamesTableAdapter = new GamesTableAdapter();
                gamesDataSet = new GamesDBDataSet();
                gamesTableAdapter.InsertGame(Player1, Player2, "-");
                gamesTableAdapter.Fill(gamesDataSet.Games);
            }
            
            score1 = 0;
            score2 = 0;

            this.Hide();
            StartForm sf = new StartForm();
            sf.ShowDialog();
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
             if (won)
             {
                 gamesTableAdapter = new GamesTableAdapter();
                 gamesDataSet = new GamesDBDataSet();
                 gamesTableAdapter.InsertGame(Player1, Player2, winner);
                 gamesTableAdapter.Fill(gamesDataSet.Games);
             }
             else
             {
                 gamesTableAdapter = new GamesTableAdapter();
                 gamesDataSet = new GamesDBDataSet();
                 gamesTableAdapter.InsertGame(Player1, Player2, "-");
                 gamesTableAdapter.Fill(gamesDataSet.Games);
             }
            score1 = 0;
            score2 = 0;
        }


        // Verificari metode de castigare a jocului
        // model pt linie orizontala
        private int CheckHorizontal()
        {
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 7; ++j)
                {
                    if (j + 3 <= 6)
                    {
                        if (board[i, j] != 0 && board[i, j + 1] == board[i, j] && board[i, j + 2] == board[i, j]
                        && board[i, j + 3] == board[i, j])
                            return 1;
                    }
                }

            return -1;
        }

        // model castigator pt linie verticala
        private int CheckVertical()
        {
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 7; ++j)
                {
                    if (i - 3 >= 0)
                    {
                        if (board[i, j] != 0 && board[i - 1, j] == board[i, j] && board[i - 2, j] == board[i, j]
                        && board[i - 3, j] == board[i, j])
                            return 1;
                    }
                }

            return -1;
        }

        // model pt diagonala in fata
        private int CheckForwardDiagonal()
        {
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 7; ++j)
                {
                    if (i - 3 >= 0 && j + 3 <= 6)
                    {
                        if (board[i, j] != 0 && board[i - 1, j + 1] == board[i, j] && board[i - 2, j + 2] == board[i, j]
                        && board[i - 3, j + 3] == board[i, j])
                            return 1;
                    }
                }

            return -1;
        }

        // model pentru diagonala din spate
        private int CheckBackwardDiagonal()
        {
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 7; ++j)
                {
                    if (i - 3 >= 0 && j - 3 >= 0)
                    {
                        if (board[i, j] != 0 && board[i - 1, j - 1] == board[i, j] && board[i - 2, j - 2] == board[i, j]
                        && board[i - 3, j - 3] == board[i, j])
                            return 1;
                    }
                }

            return -1;
        }
    }
}