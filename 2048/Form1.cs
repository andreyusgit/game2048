using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        public play2048 newgame = new play2048();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text22_TextChanged(object sender, EventArgs e)
        {

        }

        private void right_Click(object sender, EventArgs e)
        {
            newgame.right();
            fprint();
            GetScore();
            if (newgame.CheckEnd() == true)
            {
                Lose();
            }
            else if (newgame.end == true)
            {
                Finaly();
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            newgame.down();
            fprint();
            GetScore(); 
            if (newgame.CheckEnd() == true)
            {
                Lose();
            }
            else if (newgame.end == true)
            {
                Finaly();
            }
        }

        private void text44_TextChanged(object sender, EventArgs e)
        {

        }

        private void text43_TextChanged(object sender, EventArgs e)
        {

        }

        private void text42_TextChanged(object sender, EventArgs e)
        {

        }

        private void text41_TextChanged(object sender, EventArgs e)
        {

        }

        private void text34_TextChanged(object sender, EventArgs e)
        {

        }

        private void text33_TextChanged(object sender, EventArgs e)
        {

        }

        private void text32_TextChanged(object sender, EventArgs e)
        {

        }

        private void text31_TextChanged(object sender, EventArgs e)
        {

        }

        private void text24_TextChanged(object sender, EventArgs e)
        {

        }

        private void text23_TextChanged(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {
            newgame.left();
            fprint();
            GetScore();
            if (newgame.CheckEnd() == true)
            {
                Lose();
            }
            else if (newgame.end == true)
            {
                Finaly();
            }
        }

        private void text21_TextChanged(object sender, EventArgs e)
        {

        }

        private void text14_TextChanged(object sender, EventArgs e)
        {

        }

        private void text13_TextChanged(object sender, EventArgs e)
        {

        }

        private void text12_TextChanged(object sender, EventArgs e)
        {

        }

        private void text11_TextChanged(object sender, EventArgs e)
        {

        }
        public void fprint()
        {
            text11.Text = newgame.playing_field[0, 0].ToString();
            text12.Text = newgame.playing_field[0, 1].ToString();
            text13.Text = newgame.playing_field[0, 2].ToString();
            text14.Text = newgame.playing_field[0, 3].ToString();
            text21.Text = newgame.playing_field[1, 0].ToString();
            text22.Text = newgame.playing_field[1, 1].ToString();
            text23.Text = newgame.playing_field[1, 2].ToString();
            text24.Text = newgame.playing_field[1, 3].ToString();
            text31.Text = newgame.playing_field[2, 0].ToString();
            text32.Text = newgame.playing_field[2, 1].ToString();
            text33.Text = newgame.playing_field[2, 2].ToString();
            text34.Text = newgame.playing_field[2, 3].ToString();
            text41.Text = newgame.playing_field[3, 0].ToString();
            text42.Text = newgame.playing_field[3, 1].ToString();
            text43.Text = newgame.playing_field[3, 2].ToString();
            text44.Text = newgame.playing_field[3, 3].ToString();
        }
        public void GetScore()
        {
            scoreBoard.Text = newgame.score.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void up_Click_1(object sender, EventArgs e)
        {
            newgame.up();
            fprint();
            GetScore();
            if (newgame.CheckEnd() == true)
            {
                Lose();
            }
            else if (newgame.end == true)
            {
                Finaly();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newgame.newplay();
            fprint();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void text11_Click(object sender, EventArgs e)
        {

        }
        public void Lose()
        {
            DialogResult dialogResult = MessageBox.Show(
            "Sory, but you lose :(\nDo you want start new game?",
            "Ooops",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (dialogResult == DialogResult.Yes)
            {
                newgame.newplay();
                fprint();
                GetScore();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        public void Finaly()
        {
            DialogResult dialogResult = MessageBox.Show(
            "Congratulations, you've completed the game.\nDo you want start new game?",
            "Сongratulations",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (dialogResult == DialogResult.Yes)
            {
                newgame.newplay();
                fprint();
                GetScore();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
