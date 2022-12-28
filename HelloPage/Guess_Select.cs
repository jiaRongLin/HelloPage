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
        Guess_Random r= new Guess_Random();
        //LabChange c = new LabChange();
        internal void btn_enter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            /*c.min = 0;
            c.max = 100;
            c.guess = int.Parse(tex_select.Text);
            c.num = r.num;
            var returnGuess = c.ReturnGuess();*/
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
