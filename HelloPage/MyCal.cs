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
    public partial class MyCal : Form
    {
        public MyCal()
        {
            InitializeComponent();
        }

        private void bnt_plus_Click(object sender, EventArgs e)
        {
            
            if (tex_num1.Text.Length>0 & tex_num2.Text.Length>0)
            {
                int ans = int.Parse(tex_num1.Text)+ int.Parse(tex_num2.Text);
                tex_ans.Text = Convert.ToString(ans);
            }
            else
            {
                MessageBox.Show("尚未輸入值!!");
            }
           
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            
            if (tex_num1.Text.Length > 0 & tex_num2.Text.Length > 0)
            {
                int ans = int.Parse(tex_num1.Text) - int.Parse(tex_num2.Text);
                tex_ans.Text = Convert.ToString(ans);
            }
            else
            {
                MessageBox.Show("尚未輸入值!!");
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (tex_num1.Text.Length > 0 & tex_num2.Text.Length > 0)
            {
                int ans = int.Parse(tex_num1.Text) * int.Parse(tex_num2.Text);
                tex_ans.Text = Convert.ToString(ans);
            }
            else
            {
                MessageBox.Show("尚未輸入值!!");
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (tex_num1.Text.Length > 0 & tex_num2.Text.Length > 0)
            {
                int ans = int.Parse(tex_num1.Text) / int.Parse(tex_num2.Text);
            tex_ans.Text = Convert.ToString(ans);
        }
            else
            {
                MessageBox.Show("尚未輸入值!!");
            }
}
    }
}
