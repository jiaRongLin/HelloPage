namespace HelloPage
{
    partial class loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loan));
            this.tex_money = new System.Windows.Forms.TextBox();
            this.lab_money = new System.Windows.Forms.Label();
            this.btn_detial = new System.Windows.Forms.Button();
            this.btn_sumcal = new System.Windows.Forms.Button();
            this.btn_monthcal = new System.Windows.Forms.Button();
            this.tex_rate = new System.Windows.Forms.TextBox();
            this.tex_time = new System.Windows.Forms.TextBox();
            this.tex_totalmoney = new System.Windows.Forms.TextBox();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_rate = new System.Windows.Forms.Label();
            this.lab_totalmoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_money
            // 
            this.tex_money.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_money.Location = new System.Drawing.Point(450, 160);
            this.tex_money.Margin = new System.Windows.Forms.Padding(4);
            this.tex_money.Name = "tex_money";
            this.tex_money.Size = new System.Drawing.Size(282, 54);
            this.tex_money.TabIndex = 38;
            this.tex_money.Text = "0";
            // 
            // lab_money
            // 
            this.lab_money.AutoSize = true;
            this.lab_money.BackColor = System.Drawing.Color.Transparent;
            this.lab_money.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_money.Location = new System.Drawing.Point(262, 160);
            this.lab_money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_money.Name = "lab_money";
            this.lab_money.Size = new System.Drawing.Size(161, 39);
            this.lab_money.TabIndex = 37;
            this.lab_money.Text = "頭期款:";
            // 
            // btn_detial
            // 
            this.btn_detial.BackColor = System.Drawing.Color.Olive;
            this.btn_detial.Font = new System.Drawing.Font("標楷體", 11.22078F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_detial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_detial.Location = new System.Drawing.Point(638, 414);
            this.btn_detial.Margin = new System.Windows.Forms.Padding(4);
            this.btn_detial.Name = "btn_detial";
            this.btn_detial.Size = new System.Drawing.Size(159, 58);
            this.btn_detial.TabIndex = 36;
            this.btn_detial.Text = "明細";
            this.btn_detial.UseVisualStyleBackColor = false;
            this.btn_detial.Click += new System.EventHandler(this.btn_detial_Click);
            // 
            // btn_sumcal
            // 
            this.btn_sumcal.BackColor = System.Drawing.Color.Olive;
            this.btn_sumcal.Font = new System.Drawing.Font("標楷體", 11.22078F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sumcal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sumcal.Location = new System.Drawing.Point(432, 414);
            this.btn_sumcal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sumcal.Name = "btn_sumcal";
            this.btn_sumcal.Size = new System.Drawing.Size(159, 58);
            this.btn_sumcal.TabIndex = 35;
            this.btn_sumcal.Text = "總付款";
            this.btn_sumcal.UseVisualStyleBackColor = false;
            this.btn_sumcal.Click += new System.EventHandler(this.btn_sumcal_Click);
            // 
            // btn_monthcal
            // 
            this.btn_monthcal.BackColor = System.Drawing.Color.Olive;
            this.btn_monthcal.Font = new System.Drawing.Font("標楷體", 11.22078F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_monthcal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_monthcal.Location = new System.Drawing.Point(207, 414);
            this.btn_monthcal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_monthcal.Name = "btn_monthcal";
            this.btn_monthcal.Size = new System.Drawing.Size(178, 58);
            this.btn_monthcal.TabIndex = 34;
            this.btn_monthcal.Text = "平均月付款";
            this.btn_monthcal.UseVisualStyleBackColor = false;
            this.btn_monthcal.Click += new System.EventHandler(this.btn_monthcal_Click);
            // 
            // tex_rate
            // 
            this.tex_rate.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_rate.Location = new System.Drawing.Point(450, 305);
            this.tex_rate.Margin = new System.Windows.Forms.Padding(4);
            this.tex_rate.Name = "tex_rate";
            this.tex_rate.Size = new System.Drawing.Size(282, 54);
            this.tex_rate.TabIndex = 33;
            this.tex_rate.Text = "10";
            // 
            // tex_time
            // 
            this.tex_time.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_time.Location = new System.Drawing.Point(450, 230);
            this.tex_time.Margin = new System.Windows.Forms.Padding(4);
            this.tex_time.Name = "tex_time";
            this.tex_time.Size = new System.Drawing.Size(282, 54);
            this.tex_time.TabIndex = 32;
            this.tex_time.Text = "2";
            // 
            // tex_totalmoney
            // 
            this.tex_totalmoney.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_totalmoney.Location = new System.Drawing.Point(450, 95);
            this.tex_totalmoney.Margin = new System.Windows.Forms.Padding(4);
            this.tex_totalmoney.Name = "tex_totalmoney";
            this.tex_totalmoney.Size = new System.Drawing.Size(282, 54);
            this.tex_totalmoney.TabIndex = 31;
            this.tex_totalmoney.Text = "100000";
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.BackColor = System.Drawing.Color.Transparent;
            this.lab_time.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_time.Location = new System.Drawing.Point(138, 233);
            this.lab_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(285, 39);
            this.lab_time.TabIndex = 30;
            this.lab_time.Text = "貸款期限(年):";
            // 
            // lab_rate
            // 
            this.lab_rate.AutoSize = true;
            this.lab_rate.BackColor = System.Drawing.Color.Transparent;
            this.lab_rate.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_rate.Location = new System.Drawing.Point(209, 308);
            this.lab_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_rate.Name = "lab_rate";
            this.lab_rate.Size = new System.Drawing.Size(223, 39);
            this.lab_rate.TabIndex = 29;
            this.lab_rate.Text = "貸款利率%:";
            // 
            // lab_totalmoney
            // 
            this.lab_totalmoney.AutoSize = true;
            this.lab_totalmoney.BackColor = System.Drawing.Color.Transparent;
            this.lab_totalmoney.Font = new System.Drawing.Font("標楷體", 18.23377F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_totalmoney.Location = new System.Drawing.Point(180, 98);
            this.lab_totalmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_totalmoney.Name = "lab_totalmoney";
            this.lab_totalmoney.Size = new System.Drawing.Size(243, 39);
            this.lab_totalmoney.TabIndex = 28;
            this.lab_totalmoney.Text = "房屋總金額:";
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.tex_money);
            this.Controls.Add(this.lab_money);
            this.Controls.Add(this.btn_detial);
            this.Controls.Add(this.btn_sumcal);
            this.Controls.Add(this.btn_monthcal);
            this.Controls.Add(this.tex_rate);
            this.Controls.Add(this.tex_time);
            this.Controls.Add(this.tex_totalmoney);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.lab_rate);
            this.Controls.Add(this.lab_totalmoney);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loan";
            this.Text = "loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tex_money;
        private System.Windows.Forms.Label lab_money;
        private System.Windows.Forms.Button btn_detial;
        internal System.Windows.Forms.Button btn_sumcal;
        internal System.Windows.Forms.Button btn_monthcal;
        internal System.Windows.Forms.TextBox tex_rate;
        internal System.Windows.Forms.TextBox tex_time;
        internal System.Windows.Forms.TextBox tex_totalmoney;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_rate;
        private System.Windows.Forms.Label lab_totalmoney;
    }
}