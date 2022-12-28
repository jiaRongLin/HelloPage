namespace HelloPage
{
    partial class loan_detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tex_loan = new System.Windows.Forms.TextBox();
            this.lab_loan = new System.Windows.Forms.Label();
            this.tex_money = new System.Windows.Forms.TextBox();
            this.lab_money = new System.Windows.Forms.Label();
            this.lab_mail = new System.Windows.Forms.Label();
            this.tex_mail = new System.Windows.Forms.TextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.tex_per = new System.Windows.Forms.TextBox();
            this.lab_per = new System.Windows.Forms.Label();
            this.tex_sum = new System.Windows.Forms.TextBox();
            this.lab_sum = new System.Windows.Forms.Label();
            this.tex_rate = new System.Windows.Forms.TextBox();
            this.tex_time = new System.Windows.Forms.TextBox();
            this.tex_totalmoney = new System.Windows.Forms.TextBox();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_rate = new System.Windows.Forms.Label();
            this.lab_totalmoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_loan
            // 
            this.tex_loan.Location = new System.Drawing.Point(339, 153);
            this.tex_loan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_loan.Name = "tex_loan";
            this.tex_loan.ReadOnly = true;
            this.tex_loan.Size = new System.Drawing.Size(282, 30);
            this.tex_loan.TabIndex = 40;
            // 
            // lab_loan
            // 
            this.lab_loan.AutoSize = true;
            this.lab_loan.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_loan.Location = new System.Drawing.Point(168, 149);
            this.lab_loan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_loan.Name = "lab_loan";
            this.lab_loan.Size = new System.Drawing.Size(146, 30);
            this.lab_loan.TabIndex = 39;
            this.lab_loan.Text = "貸款金額:";
            // 
            // tex_money
            // 
            this.tex_money.Location = new System.Drawing.Point(339, 91);
            this.tex_money.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_money.Name = "tex_money";
            this.tex_money.ReadOnly = true;
            this.tex_money.Size = new System.Drawing.Size(282, 30);
            this.tex_money.TabIndex = 38;
            // 
            // lab_money
            // 
            this.lab_money.AutoSize = true;
            this.lab_money.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_money.Location = new System.Drawing.Point(198, 94);
            this.lab_money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_money.Name = "lab_money";
            this.lab_money.Size = new System.Drawing.Size(115, 30);
            this.lab_money.TabIndex = 37;
            this.lab_money.Text = "頭期款:";
            // 
            // lab_mail
            // 
            this.lab_mail.AutoSize = true;
            this.lab_mail.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_mail.Location = new System.Drawing.Point(254, 510);
            this.lab_mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_mail.Name = "lab_mail";
            this.lab_mail.Size = new System.Drawing.Size(95, 30);
            this.lab_mail.TabIndex = 36;
            this.lab_mail.Text = "Email:";
            // 
            // tex_mail
            // 
            this.tex_mail.Location = new System.Drawing.Point(375, 510);
            this.tex_mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_mail.Name = "tex_mail";
            this.tex_mail.Size = new System.Drawing.Size(282, 30);
            this.tex_mail.TabIndex = 35;
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(690, 462);
            this.btn_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(192, 80);
            this.btn_email.TabIndex = 34;
            this.btn_email.Text = "EMAIL";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // tex_per
            // 
            this.tex_per.Location = new System.Drawing.Point(339, 341);
            this.tex_per.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_per.Name = "tex_per";
            this.tex_per.ReadOnly = true;
            this.tex_per.Size = new System.Drawing.Size(282, 30);
            this.tex_per.TabIndex = 33;
            // 
            // lab_per
            // 
            this.lab_per.AutoSize = true;
            this.lab_per.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_per.Location = new System.Drawing.Point(138, 341);
            this.lab_per.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_per.Name = "lab_per";
            this.lab_per.Size = new System.Drawing.Size(177, 30);
            this.lab_per.TabIndex = 32;
            this.lab_per.Text = "平均月付款:";
            // 
            // tex_sum
            // 
            this.tex_sum.Location = new System.Drawing.Point(339, 399);
            this.tex_sum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_sum.Name = "tex_sum";
            this.tex_sum.ReadOnly = true;
            this.tex_sum.Size = new System.Drawing.Size(282, 30);
            this.tex_sum.TabIndex = 31;
            // 
            // lab_sum
            // 
            this.lab_sum.AutoSize = true;
            this.lab_sum.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_sum.Location = new System.Drawing.Point(198, 402);
            this.lab_sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(115, 30);
            this.lab_sum.TabIndex = 30;
            this.lab_sum.Text = "總付款:";
            // 
            // tex_rate
            // 
            this.tex_rate.Location = new System.Drawing.Point(339, 276);
            this.tex_rate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_rate.Name = "tex_rate";
            this.tex_rate.ReadOnly = true;
            this.tex_rate.Size = new System.Drawing.Size(282, 30);
            this.tex_rate.TabIndex = 29;
            // 
            // tex_time
            // 
            this.tex_time.Location = new System.Drawing.Point(339, 214);
            this.tex_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_time.Name = "tex_time";
            this.tex_time.ReadOnly = true;
            this.tex_time.Size = new System.Drawing.Size(282, 30);
            this.tex_time.TabIndex = 28;
            // 
            // tex_totalmoney
            // 
            this.tex_totalmoney.Location = new System.Drawing.Point(339, 28);
            this.tex_totalmoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_totalmoney.Name = "tex_totalmoney";
            this.tex_totalmoney.ReadOnly = true;
            this.tex_totalmoney.Size = new System.Drawing.Size(282, 30);
            this.tex_totalmoney.TabIndex = 27;
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_time.Location = new System.Drawing.Point(118, 217);
            this.lab_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(197, 30);
            this.lab_time.TabIndex = 26;
            this.lab_time.Text = "貸款期限(年):";
            // 
            // lab_rate
            // 
            this.lab_rate.AutoSize = true;
            this.lab_rate.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_rate.Location = new System.Drawing.Point(144, 279);
            this.lab_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_rate.Name = "lab_rate";
            this.lab_rate.Size = new System.Drawing.Size(170, 30);
            this.lab_rate.TabIndex = 25;
            this.lab_rate.Text = "貸款利率%:";
            // 
            // lab_totalmoney
            // 
            this.lab_totalmoney.AutoSize = true;
            this.lab_totalmoney.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_totalmoney.Location = new System.Drawing.Point(138, 28);
            this.lab_totalmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_totalmoney.Name = "lab_totalmoney";
            this.lab_totalmoney.Size = new System.Drawing.Size(177, 30);
            this.lab_totalmoney.TabIndex = 24;
            this.lab_totalmoney.Text = "房屋總金額:";
            // 
            // loan_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.tex_loan);
            this.Controls.Add(this.lab_loan);
            this.Controls.Add(this.tex_money);
            this.Controls.Add(this.lab_money);
            this.Controls.Add(this.lab_mail);
            this.Controls.Add(this.tex_mail);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.tex_per);
            this.Controls.Add(this.lab_per);
            this.Controls.Add(this.tex_sum);
            this.Controls.Add(this.lab_sum);
            this.Controls.Add(this.tex_rate);
            this.Controls.Add(this.tex_time);
            this.Controls.Add(this.tex_totalmoney);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.lab_rate);
            this.Controls.Add(this.lab_totalmoney);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loan_detail";
            this.Text = "loan_detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tex_loan;
        private System.Windows.Forms.Label lab_loan;
        internal System.Windows.Forms.TextBox tex_money;
        private System.Windows.Forms.Label lab_money;
        private System.Windows.Forms.Label lab_mail;
        internal System.Windows.Forms.TextBox tex_mail;
        private System.Windows.Forms.Button btn_email;
        internal System.Windows.Forms.TextBox tex_per;
        private System.Windows.Forms.Label lab_per;
        internal System.Windows.Forms.TextBox tex_sum;
        private System.Windows.Forms.Label lab_sum;
        internal System.Windows.Forms.TextBox tex_rate;
        internal System.Windows.Forms.TextBox tex_time;
        internal System.Windows.Forms.TextBox tex_totalmoney;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_rate;
        private System.Windows.Forms.Label lab_totalmoney;
    }
}