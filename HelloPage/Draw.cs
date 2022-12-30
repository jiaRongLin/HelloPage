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
        Graphics g;
        Pen draw_pen;
        int x, y,penpoint;
        Bitmap b;
        Color pencolor;
        
        public Draw()
        {
            InitializeComponent();
        }
        
        private void btn_color_Click(object sender, EventArgs e)
        {
            
            colorDialog1.ShowDialog();
            btn_imag.BackColor = colorDialog1.Color;
            btn_color.ForeColor= colorDialog1.Color;
            pencolor= colorDialog1.Color;

        }

        private void Draw_Load(object sender, EventArgs e)
        {
            draw_pen = new Pen(pencolor, penpoint);
            pencolor = Color.Black;
            penpoint = 2;
            b = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(b);
            picture_draw.Size = new Size(this.Width, this.Height);
            picture_draw.Location = new Point(0, 25);
            g.Clear(Color.White);
            picture_draw.Image = b;
            picture_draw.Refresh();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picture_draw.Refresh();

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            penpoint =trackBar.Value+2;
        }

        private void picture_draw_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        private void picture_draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw_pen = new Pen(pencolor, penpoint);
                g = Graphics.FromImage(b);
                g.DrawLine(draw_pen, x, y, e.X, e.Y);
                x = e.X; y = e.Y;
                picture_draw.Refresh();
            }
        }

        


    }
}
