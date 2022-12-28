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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mysmpt = new SmtpClient("smtp.gmail.com", 25);
                mysmpt.Credentials = new NetworkCredential("vernalin1422@gmail.com", "tvbmjrwlcsfszdat");
                mysmpt.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.To.Add(text_Mail.Text);
                mail.From = new MailAddress("vernalin1422@gmail.com", "林嘉容", System.Text.Encoding.UTF8);
                mail.Priority = MailPriority.Normal;
                mail.Subject = "Hello Form";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = "收到您的訊息，訊息如下：" + text_message.Text;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mysmpt.Send(mail);
                MessageBox.Show("已收到" + text_Name.Text + "的訊息!" + Environment.NewLine + "請查收您的E-Mail。");
            }
            catch (Exception)
            {
                MessageBox.Show("失敗!!");
            }

        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + text_Name.Text + "!!" + Environment.NewLine + "我是嘉容!!");
        }
    }
}
