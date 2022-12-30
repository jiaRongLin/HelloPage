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
            Rectangle ret = Screen.GetWorkingArea(this);
            this.pictureBox1.ClientSize = new Size(ret.Width, ret.Height);
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.BringToFront();

            this.pictureBox2.Location = new Point(x, y);
            this.pictureBox2.BringToFront();
            timer1.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i += 1)
            {
                if (x<400)
                {
                    x += 1;
                    y += 1;
                }
                else
                {
                    x += 1;
                    y -= 1;
                }
                this.pictureBox2.Location = new Point(x, y);
            }
        }
    }
}
