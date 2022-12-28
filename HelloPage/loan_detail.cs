using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloPage
{
    public partial class loan_detail : Form
    {
        public loan_detail()
        {
            InitializeComponent();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mysmtp = new SmtpClient("smtp.gmail.com", 25);
                mysmtp.Credentials = new NetworkCredential("vernalin1422@gmail.com", "tvbmjrwlcsfszdat");
                mysmtp.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.To.Add(tex_mail.Text);
                mail.From = new MailAddress("vernalin1422@gmail.com", "林嘉容", Encoding.UTF8);
                mail.Priority = MailPriority.Normal;
                mail.Subject = "房貸試算表";
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Body = "房貸試算:" + lab_totalmoney.Text + tex_totalmoney.Text
                             + lab_rate.Text + tex_rate.Text + lab_time.Text + tex_time.Text
                             + lab_per.Text + tex_per.Text + lab_sum.Text + tex_sum.Text;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mysmtp.Send(mail);
                MessageBox.Show("發送成功!!");
            }
            catch (Exception)
            {
                MessageBox.Show("失敗!!!");
            }
        }

    }
}
