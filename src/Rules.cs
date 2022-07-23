using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Connect4
{
    public partial class Rules : Form
    {
        private string path = null;
        private Image[] image;
        private string[] files = null;
        private int counter = 0;

        public Rules()
        {
            InitializeComponent();
            this.Text = "Reguli";

            path = Directory.GetCurrentDirectory();
            path += @"\Images\Rules\";
            files = Directory.GetFiles(path);

            image = new Image[2];
            image[0] = Image.FromFile(files[0]);
            image[1] = Image.FromFile(files[1]);
            pbRules.Image = image[0];
            pbRules.SizeMode = PictureBoxSizeMode.StretchImage;

            // Design
            this.BackColor = Color.DarkSlateBlue;
            btnBack.BackColor = Color.LightSteelBlue;
            btnMenu.BackColor = Color.LightSteelBlue;
            btnNext.BackColor = Color.LightSteelBlue;
            btnBack.ForeColor = Color.DarkSlateBlue;
            btnMenu.ForeColor = Color.DarkSlateBlue;
            btnNext.ForeColor = Color.DarkSlateBlue;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter > image.Length - 1)
                counter = 0;
            pbRules.Image = image[counter];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            counter--;

            if (counter < 0)
                counter = image.Length - 1;
            pbRules.Image = image[counter];
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm sf = new StartForm();
            sf.ShowDialog();
            this.Close();
        }
    }
}
