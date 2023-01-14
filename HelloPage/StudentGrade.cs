using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloPage
{
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }

        Grade grade;
        //string result;

        private void btn_add_Click(object sender, EventArgs e)
        {
            grade.Name = tex_name.Text; ;
            grade.Chinese = tex_chinese.Text;
            grade.English = tex_English.Text;
            grade.Math = tex_Math.Text;
            int chinese = 0, English = 0, Math = 0,sum = 0;
            bool isChi = int.TryParse(tex_chinese.Text, out chinese);
            bool isEng = int.TryParse(tex_English.Text, out English);
            bool isMath = int.TryParse(tex_Math.Text, out Math);
            sum = chinese+English+Math;
            int[] values = new int[] { chinese, English, Math };
            int max = values.Max();
            int min = values.Min();
            if (isChi & isEng & isMath)
            {
                this.list_score.BeginUpdate();
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(tex_name.Text);
                item.SubItems.Add(tex_chinese.Text);
                item.SubItems.Add(tex_English.Text);
                item.SubItems.Add(tex_Math.Text);
                this.list_score.EndUpdate();
            }
            else
            {
                MessageBox.Show("請在欄位輸入正確的數字!!");
            }
        }

        
    }
}
