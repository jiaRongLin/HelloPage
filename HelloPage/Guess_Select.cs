using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HelloPage
{
    public partial class Guess_Select : Form
    {
     
        public Guess_Select()
        {
            InitializeComponent();
        }
        public int min;
        public int max;
        public int guess;
        public int num;
        internal void btn_enter_Click(object sender, EventArgs e)
        {
            Guess g = new Guess();
            if (min < guess & guess < max)
            {
                if (num == guess)
                {
                    MessageBox.Show("Bingo!!!");
                }
                else if (num > guess)
                {
                    min = guess;
                    g.lab_guess.Text = "Too Small!!!";

                }
                else if (num < guess)
                {
                    max = guess;
                    g.lab_guess.Text = "Too Big!!!";
                }
                g.lab_num.Text = "Between " + min + " to" + max;
            }
            else
            {
                MessageBox.Show("請輸入 " + min + " ~ " + max + " 的數字");
            }
            var result = Tuple.Create<int, int, int, int>(min, max, num, guess);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
