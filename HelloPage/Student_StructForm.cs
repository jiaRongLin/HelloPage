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
    public partial class Student_StructForm : Form
    {
        public Student_StructForm()
        {
            InitializeComponent();
        }
        int chinese, English, Math;

        private void btn_store_Click(object sender, EventArgs e)
        {
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            bool ChiScore = int.TryParse(tex_chinese.Text, out chinese);
            bool EngScore = int.TryParse(tex_English.Text, out English);
            bool MathScore = int.TryParse(tex_math.Text, out Math);
            this.btn_compare.Click += new System.EventHandler(this.Btn_compare_Click);

            if (ChiScore && EngScore && MathScore)
            {
                list_score.Items.Clear();
                list_score.Items.Add("姓名:" + tex_name.Text);
                list_score.Items.Add("國文:" + chinese+ "分");
                list_score.Items.Add("英文:" +English + "分");
                list_score.Items.Add("數學:" + Math + "分");
            }
            else
            {
                MessageBox.Show("請在欄位輸入正確數字!!");
            }
        }

            private void Btn_compare_Click(object sender, EventArgs e)
        {
            
                int[] values = new int[] { chinese, English, Math };
                int max = values.Max();
                int min = values.Min();
                list_compare.Items.Clear();
                if (max == chinese)
                {
                    list_compare.Items.Add("最高科目為：國文" + chinese + "分");
                }
                else if (max == English)
                {
                    list_compare.Items.Add("最高科目為：英文" + English + "分");
                }
                else
                {
                    list_compare.Items.Add("最高科目為：數學" + Math+ "分");
                }
                if (min == chinese)
                {
                    list_compare.Items.Add("最低科目為：國文" + chinese + "分");
                }
                else if (min == English)
                {
                    list_compare.Items.Add("最低科目為：英文" + English + "分");
                }
                else
                {
                    list_compare.Items.Add("最低科目為：數學" +Math + "分");
                }
        }
    }
}
