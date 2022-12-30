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
        public Label Lab_guess => this.lab_guess;
        Guess_Select s = new Guess_Select();
        
        public static int ReturnMultipleValues(int a,int b)
        {
            Random random = new Random();
            return random.Next(a, b);
        }
        public int num;
        internal void btn_guess_Click(object sender, EventArgs e)
        {
            num = ReturnMultipleValues(0,100);
            s.Owner = this;
            s.ShowDialog();
        }
        private void btn_ans_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer:"+num);
        }

    }
}
