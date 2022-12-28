using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloPage
{
    public partial class XOGames : Form
    {
        public XOGames()
        {
            InitializeComponent();
        }
        int count = 0;
        XOGamesWinner winner = new XOGamesWinner();
        private void IfWin()
        {
            winner.Winner(button1.Text, button2.Text, button3.Text
                        , button4.Text, button5.Text, button6.Text
                        , button7.Text, button8.Text, button9.Text);
        }
        private void ClearAll()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            winner.win = false;
            count = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button1.Text = "X";
                button1.ForeColor = Color.SkyBlue;
            }
            else
            {
                button1.Text = "O";
                button1.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button2.Text = "X";
                button2.ForeColor = Color.SkyBlue;
            }
            else
            {
                button2.Text = "O";
                button2.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button3.Text = "X";
                button3.ForeColor = Color.SkyBlue;
            }
            else
            {
                button3.Text = "O";
                button3.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button4.Text = "X";
                button4.ForeColor = Color.SkyBlue;
            }
            else
            {
                button4.Text = "O";
                button4.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button5.Text = "X";
                button5.ForeColor = Color.SkyBlue;
            }
            else
            {
                button5.Text = "O";
                button5.ForeColor = Color.White;
               
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button6.Text = "X";
                button6.ForeColor = Color.SkyBlue;
            }
            else
            {
                button6.Text = "O";
                button6.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button7.Text = "X";
                button7.ForeColor = Color.SkyBlue;
            }
            else
            {
                button7.Text = "O";
                button7.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button8.Text = "X";
                button8.ForeColor = Color.SkyBlue;
            }
            else
            {
                button8.Text = "O";
                button8.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            count++;
            if (count % 2 == 1)
            {
                button9.Text = "X";
                button9.ForeColor = Color.SkyBlue;
            }
            else
            {
                button9.Text = "O";
                button9.ForeColor = Color.White;
            }
            IfWin();

            if (winner.win && count % 2 == 1)
            {
                MessageBox.Show("X Win");
                ClearAll();
            }
            else if (winner.win && count % 2 == 0)
            {
                MessageBox.Show("O Win");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show("平手");
                ClearAll();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
