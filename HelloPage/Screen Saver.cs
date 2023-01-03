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
    public partial class Screen_Saver : Form
    {
        public Screen_Saver()
        {
            InitializeComponent();
        }
        int x, y;    
        private void Screen_Saver_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.pictureBox1.Dock = DockStyle.Fill;
            this.TopMost = true;

            timer1.Enabled = true;

        }
        int px = 5, py = 5;


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            pictureBox2.Left += px;
            pictureBox2.Top += py;
            if (pictureBox2.Left <= 0) { px = Math.Abs(px); }
            if (pictureBox2.Right > this.ClientSize.Width) { px = -Math.Abs(px); }
            if (pictureBox2.Top < 0) { py = Math.Abs(py); }
            if (pictureBox2.Bottom > this.ClientSize.Height) { py = -Math.Abs(py); }
        }
    }
}
