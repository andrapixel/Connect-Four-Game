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
    public partial class GamesForm : Form
    {
        public GamesForm()
        {
            InitializeComponent();
            this.Text = "Jocuri Trecute";

            // Design
            this.BackColor = Color.DarkSlateBlue;
            btnBackToMenu.BackColor = Color.LightSteelBlue;
            btnBackToMenu.ForeColor = Color.DarkSlateBlue;
        }

        private void GamesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesDBDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gamesDBDataSet.Games);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm sf = new StartForm();
            sf.ShowDialog();
            this.Close();
        }
    }
}
