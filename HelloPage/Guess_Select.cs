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
        public int min =0;
        public int max =100;
        public int guess;
        public int num;

        internal void btn_enter_Click(object sender, EventArgs e)
        {            
            string text = string.Empty;
            string text1 = string.Empty;
            ((Guess)this.Owner).Lab_guess.Text = "Please Select A number between 1to 100!!";
            ((Guess)this.Owner).Lab_num.Text = string.Empty;
            num = ((Guess)this.Owner).num;
            guess = int.Parse(tex_select.Text);
            if (min < guess & guess < max)
            {
                if (num == guess)
                {
                    MessageBox.Show("Bingo!!!");
                    tex_select.Clear();
                    this.Close();
                }
                else if (num > guess)
                {
                    min = guess;
                    text = "Too Small!!!";

                }
                else if (num < guess)
                {
                    max = guess;
                    text = "Too Big!!!";
                }
                text1 = "Between " + min + " to" + max;
            }
            else
            {
                MessageBox.Show("請輸入 " + min + " ~ " + max + " 的數字");
            }
            ((Guess)this.Owner).Lab_guess.Text = text;
            ((Guess)this.Owner).Lab_num.Text = text1;
            tex_select.Clear();
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            min = 0;
            max = 100;
            tex_select.Clear();
            ((Guess)this.Owner).Lab_guess.Text = "Please Select A number between 1to 100!!";
            ((Guess)this.Owner).Lab_num.Text = string.Empty ;
            this.Close();
        }

        private void tex_select_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_enter.Focus();
                btn_enter_Click(sender, e);
                tex_select.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_cancel.Focus();
                btn_cancel_Click(sender, e);
                tex_select.Focus();
            }
        }
    }
}
