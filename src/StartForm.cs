using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.Text = "Connect Four";

            // Design
            this.BackColor = Color.DarkSlateBlue;
            btnNewGame.BackColor = Color.LightSteelBlue;
            btnRules.BackColor = Color.LightSteelBlue;
            btnGameTable.BackColor = Color.LightSteelBlue;
            btnExit.BackColor = Color.LightSteelBlue;
            btnNewGame.ForeColor = Color.DarkSlateBlue;
            btnRules.ForeColor = Color.DarkSlateBlue;
            btnGameTable.ForeColor = Color.DarkSlateBlue;
            btnExit.ForeColor = Color.DarkSlateBlue;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterPlayers ep = new EnterPlayers();
            ep.ShowDialog();
            this.Close();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules r = new Rules();
            r.ShowDialog();
            this.Close();
        }

        private void btnGameTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesForm gf = new GamesForm();
            gf.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
