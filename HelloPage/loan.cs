using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HelloPage
{
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }
        Cal c = new Cal();
        public void loan_Load()
        {
            c.totalmoney = int.Parse(tex_totalmoney.Text);
            c.money = int.Parse(tex_money.Text);
            c.rate = int.Parse(tex_rate.Text);
            c.time = int.Parse(tex_time.Text);
            var returnedvalues = c.ReturnMultipleValues();

        }

        internal void btn_monthcal_Click(object sender, EventArgs e)
        {
            loan_Load();

            MessageBox.Show("每月應繳總額:" + (int)c.per_month);
        }

        internal void btn_sumcal_Click(object sender, EventArgs e)
        {
            loan_Load();

            MessageBox.Show("總付款：" + (int)c.sum);
        }

        private void btn_detial_Click(object sender, EventArgs e)
        {
            loan_Load();

            loan_detail DL = new loan_detail();
            DL.tex_totalmoney.Text = tex_totalmoney.Text;
            DL.tex_time.Text = tex_time.Text;
            DL.tex_money.Text = tex_money.Text;
            DL.tex_rate.Text = tex_rate.Text;
            DL.tex_loan.Text = Convert.ToString(c.loan);
            DL.tex_per.Text = Convert.ToString((int)c.per_month);
            DL.tex_sum.Text = Convert.ToString((int)c.sum);
            DL.Show();
        }

        
    }
}
