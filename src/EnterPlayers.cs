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
    public partial class EnterPlayers : Form
    {
        private Form1 mainForm;
        private StartForm st;

        public EnterPlayers()
        {
            InitializeComponent();
            this.Text = "Connect Four";
            lblWarning.Visible = false;     
            lblWarning2.Visible = false;

            // Design
            this.BackColor = Color.DarkSlateBlue;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            btnBackToMain.BackColor = Color.LightSteelBlue;
            btnStart.BackColor = Color.LightSteelBlue;
            btnBackToMain.ForeColor = Color.DarkSlateBlue;
            btnStart.ForeColor = Color.DarkSlateBlue;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            st = new StartForm();
            st.ShowDialog();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainForm = new Form1();
            mainForm.Player1 = txtPlayer1.Text;
            mainForm.Player2 = txtPlayer2.Text;

            if (NamesAreCompleted())
            {
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Nu ați introdus toate datele necesare înscrierii în joc. Vă rugăm " +
                    "să verificați din nou.", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void EnterPlayers_Load(object sender, EventArgs e)
        {
            txtPlayer1.Focus();
        }
 
        // verifica ca ambele casute sa fie completate
        private bool NamesAreCompleted()
        {
            if (txtPlayer1.Text == "" || txtPlayer2.Text == "")
                return false;

            return true;
        }

        // daca textul depaseste 30 de caractere label-urile cu avertismentele de intrecere a limitei vor
        // deveni vizibile
        private void txtPlayer1_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer1.TextLength > 30)
                lblWarning.Visible = true;
            else
                lblWarning.Visible = false;
        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayer2.TextLength > 30)
                lblWarning2.Visible = true;
            else
                lblWarning2.Visible = false;
        }
    }
}
