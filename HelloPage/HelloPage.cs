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
    public partial class HelloPage : Form
    {
        public HelloPage()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            Hello hello = new Hello();
            hello.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(hello);
            hello.Show();
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            loan loan = new loan();
            loan.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(loan);
            loan.Show();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            Pos pos = new Pos();
            pos.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(pos);
            pos.Show();
        }

        private void btn_struct_Click(object sender, EventArgs e)
        {
            Student_StructForm SSF = new Student_StructForm();
            SSF.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(SSF);
            SSF.Show();
        }

        private void btn_MyCal_Click(object sender, EventArgs e)
        {
            MyCal myCal = new MyCal();
            myCal.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(myCal);
            myCal.Show();
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(guess);
            guess.Show();
        }

        private void btn_note_Click(object sender, EventArgs e)
        {
            Notepad n = new Notepad();
            this.splitContainer2.Panel2.Controls.Clear();
            n.Show();
        }

        private void btn_XO_Click(object sender, EventArgs e)
        {
            XOGames xo = new XOGames();
            xo.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(xo);
            xo.Show();
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            Draw d = new Draw();
            d.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(d);
            d.Show();
        }

        private void btn_screen_Click(object sender, EventArgs e)
        {
            Screen_Saver s = new Screen_Saver();
            s.Show();
        }
    }
   
}
