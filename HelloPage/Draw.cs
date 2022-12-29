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
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            colorDialog1.ShowDialog();
            button2.BackColor = colorDialog1.Color;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.pictureBox1.CreateGraphics();
            g.Dispose();
            Pen draw_pen = new Pen(Color.Black);
            draw_pen.Color = colorDialog1.Color;
            draw_pen.Dispose();
        }
    }
}
