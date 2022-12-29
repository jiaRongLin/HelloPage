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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }
        Guess_Random r = new Guess_Random();
        Guess_Select s = new Guess_Select();
        int min = 0;
        int max = 100;
        int guess = 0;
        //string select;
        public void Guess_Load(object sender, EventArgs e)
        {
        }
        private void btn_guess_Click(object sender, EventArgs e)
        {
            //ReturnMultipleValues();
            //s.MdiParent = this;
            //s.ShowDialog(this);
            if (s.ShowDialog(this) == DialogResult.OK)
            {
                guess = int.Parse(s.tex_select.Text);
                if (min < guess & guess < max)
                {
                    int num = 0;
                    //int num = r.num;
                    if (num == guess)
                    {
                        MessageBox.Show("Bingo!!!");
                    }
                    else if (num > guess)
                    {
                        min = guess;
                        lab_guess.Text = "Too Small!!!";

                    }
                    else
                    {
                        max = guess;
                        lab_guess.Text = "Too Big!!!";
                    }
                    lab_num.Text = "Between " + min + " to" + max;
                }
                else
                {
                    MessageBox.Show("請輸入 " + min + " ~ " + max + " 的數字");
                }
            }
        }
        private void btn_ans_Click(object sender, EventArgs e)
        {
            int num = 0; //r.num;
            MessageBox.Show("Answer:" );//+r.num);
        }

        
            
    }
}
