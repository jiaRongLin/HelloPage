using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HelloPage
{
    public partial class Pos : Form
    {
        public Pos()
        {
            InitializeComponent();
        }

        int hum_count = 0;
        int fries_count = 0;
        int chicken_count = 0;
        int cola_count = 0;
        int sum = 0;

        private void btn_Hum_Click(object sender, EventArgs e)
        {
            list_pos.Items.Remove("尚未選購");
            int hum_price = 220;
            if (list_pos.Items.Count > 0)
            {
                this.list_pos.Items.Remove("漢堡 x" + hum_count + ",共 NT " + (hum_price * hum_count) + "元");
            }
            hum_count += 1;

            list_pos.Items.Add("漢堡 x" + hum_count + ",共 NT " + (hum_price * hum_count) + "元");
            sum = sum + 220;
            tex_sum.Text = "NT$" + sum;

        }
        private void btn_fries_Click(object sender, EventArgs e)
        {
            list_pos.Items.Remove("尚未選購");
            int fries_price = 60;
            if (list_pos.Items.Count > 0)
            {
                this.list_pos.Items.Remove("薯條 x" + fries_count + ",共 NT " + (fries_price * fries_count) + "元");
            }
            fries_count += 1;

            list_pos.Items.Add("薯條 x" + fries_count + ",共 NT " + (fries_price * fries_count) + "元");
            sum = sum + 60;
            tex_sum.Text = "NT$" + sum;
        }

        private void btn_chicken_Click(object sender, EventArgs e)
        {
            list_pos.Items.Remove("尚未選購");
            int chicken_price = 80;
            if (list_pos.Items.Count > 0)
            {
                this.list_pos.Items.Remove("炸雞 x" + chicken_count + ",共 NT " + (chicken_price * chicken_count) + "元");
            }
            chicken_count += 1;

            list_pos.Items.Add("炸雞 x" + chicken_count + ",共 NT " + (chicken_price * chicken_count) + "元");
            sum = sum + 80;
            tex_sum.Text = "NT$" + sum;
        }

        private void btn_cola_Click(object sender, EventArgs e)
        {
            list_pos.Items.Remove("尚未選購");
            int cola_price = 30;
            if (list_pos.Items.Count > 0)
            {
                this.list_pos.Items.Remove("可樂 x" + cola_count + ",共 NT " + (cola_price * cola_count) + "元");
            }
            cola_count += 1;

            list_pos.Items.Add("可樂 x" + cola_count + ",共 NT " + (cola_price * cola_count) + "元");
            sum = sum + 30;
            tex_sum.Text = "NT$" + sum;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            list_pos.Items.Clear();
            tex_sum.Clear();
            hum_count = 0;
            fries_count = 0;
            chicken_count = 0;
            cola_count = 0;
            sum = 0;
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            if (sum > 0)
            {
                MessageBox.Show("總金額:" + sum);
            }
            else
            {
                MessageBox.Show("尚未點餐!!");
            }

        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            if (sum > 0)
            {
                double money = sum * 0.85;
                int credit = (int)money;
                MessageBox.Show("總金額:" + credit);
            }
            else
            {
                MessageBox.Show("尚未點餐!!");
            }
        }

    }
}
