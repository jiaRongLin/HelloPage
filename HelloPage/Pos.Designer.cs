namespace HelloPage
{
    partial class Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pos));
            this.gro_order = new System.Windows.Forms.GroupBox();
            this.list_pos = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.gro_pay = new System.Windows.Forms.GroupBox();
            this.lab_credit = new System.Windows.Forms.Label();
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_cash = new System.Windows.Forms.Button();
            this.gro_calculate = new System.Windows.Forms.GroupBox();
            this.tex_sum = new System.Windows.Forms.TextBox();
            this.gro_menu = new System.Windows.Forms.GroupBox();
            this.btn_chicken = new System.Windows.Forms.Button();
            this.btn_cola = new System.Windows.Forms.Button();
            this.btn_fries = new System.Windows.Forms.Button();
            this.btn_Hum = new System.Windows.Forms.Button();
            this.gro_order.SuspendLayout();
            this.gro_pay.SuspendLayout();
            this.gro_calculate.SuspendLayout();
            this.gro_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gro_order
            // 
            this.gro_order.BackColor = System.Drawing.Color.Lavender;
            this.gro_order.Controls.Add(this.list_pos);
            this.gro_order.Controls.Add(this.btn_clear);
            this.gro_order.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gro_order.Location = new System.Drawing.Point(575, 34);
            this.gro_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_order.Name = "gro_order";
            this.gro_order.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_order.Size = new System.Drawing.Size(320, 356);
            this.gro_order.TabIndex = 5;
            this.gro_order.TabStop = false;
            this.gro_order.Text = "購物清單";
            // 
            // list_pos
            // 
            this.list_pos.BackColor = System.Drawing.Color.PapayaWhip;
            this.list_pos.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list_pos.FormattingEnabled = true;
            this.list_pos.ItemHeight = 20;
            this.list_pos.Items.AddRange(new object[] {
            "尚未選購"});
            this.list_pos.Location = new System.Drawing.Point(12, 25);
            this.list_pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_pos.Name = "list_pos";
            this.list_pos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_pos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_pos.Size = new System.Drawing.Size(295, 244);
            this.list_pos.Sorted = true;
            this.list_pos.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clear.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(195, 287);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 48);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "清除清單";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // gro_pay
            // 
            this.gro_pay.BackColor = System.Drawing.SystemColors.Info;
            this.gro_pay.Controls.Add(this.lab_credit);
            this.gro_pay.Controls.Add(this.btn_credit);
            this.gro_pay.Controls.Add(this.btn_cash);
            this.gro_pay.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gro_pay.Location = new System.Drawing.Point(318, 262);
            this.gro_pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_pay.Name = "gro_pay";
            this.gro_pay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_pay.Size = new System.Drawing.Size(241, 129);
            this.gro_pay.TabIndex = 6;
            this.gro_pay.TabStop = false;
            this.gro_pay.Text = "付款方式";
            // 
            // lab_credit
            // 
            this.lab_credit.AutoSize = true;
            this.lab_credit.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_credit.Location = new System.Drawing.Point(115, 101);
            this.lab_credit.Name = "lab_credit";
            this.lab_credit.Size = new System.Drawing.Size(124, 17);
            this.lab_credit.TabIndex = 7;
            this.lab_credit.Text = "刷卡享85折!!";
            // 
            // btn_credit
            // 
            this.btn_credit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_credit.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_credit.Location = new System.Drawing.Point(139, 35);
            this.btn_credit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(89, 48);
            this.btn_credit.TabIndex = 6;
            this.btn_credit.Text = "刷卡";
            this.btn_credit.UseVisualStyleBackColor = false;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // btn_cash
            // 
            this.btn_cash.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cash.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cash.Location = new System.Drawing.Point(8, 34);
            this.btn_cash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(117, 49);
            this.btn_cash.TabIndex = 5;
            this.btn_cash.Text = "現金付款";
            this.btn_cash.UseVisualStyleBackColor = false;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // gro_calculate
            // 
            this.gro_calculate.BackColor = System.Drawing.SystemColors.Info;
            this.gro_calculate.Controls.Add(this.tex_sum);
            this.gro_calculate.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gro_calculate.Location = new System.Drawing.Point(318, 48);
            this.gro_calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_calculate.Name = "gro_calculate";
            this.gro_calculate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_calculate.Size = new System.Drawing.Size(241, 129);
            this.gro_calculate.TabIndex = 4;
            this.gro_calculate.TabStop = false;
            this.gro_calculate.Text = "總金額";
            // 
            // tex_sum
            // 
            this.tex_sum.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tex_sum.ForeColor = System.Drawing.SystemColors.Window;
            this.tex_sum.Location = new System.Drawing.Point(16, 55);
            this.tex_sum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_sum.Name = "tex_sum";
            this.tex_sum.Size = new System.Drawing.Size(213, 32);
            this.tex_sum.TabIndex = 0;
            this.tex_sum.Text = "NT$0";
            this.tex_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gro_menu
            // 
            this.gro_menu.BackColor = System.Drawing.Color.AliceBlue;
            this.gro_menu.Controls.Add(this.btn_chicken);
            this.gro_menu.Controls.Add(this.btn_cola);
            this.gro_menu.Controls.Add(this.btn_fries);
            this.gro_menu.Controls.Add(this.btn_Hum);
            this.gro_menu.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gro_menu.Location = new System.Drawing.Point(9, 34);
            this.gro_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_menu.Name = "gro_menu";
            this.gro_menu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gro_menu.Size = new System.Drawing.Size(287, 382);
            this.gro_menu.TabIndex = 3;
            this.gro_menu.TabStop = false;
            this.gro_menu.Text = "菜單";
            // 
            // btn_chicken
            // 
            this.btn_chicken.BackColor = System.Drawing.Color.White;
            this.btn_chicken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chicken.BackgroundImage")));
            this.btn_chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_chicken.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_chicken.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_chicken.Location = new System.Drawing.Point(151, 50);
            this.btn_chicken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_chicken.Name = "btn_chicken";
            this.btn_chicken.Size = new System.Drawing.Size(95, 122);
            this.btn_chicken.TabIndex = 4;
            this.btn_chicken.Text = "炸雞\r\nNT 80";
            this.btn_chicken.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_chicken.UseVisualStyleBackColor = false;
            this.btn_chicken.Click += new System.EventHandler(this.btn_chicken_Click);
            // 
            // btn_cola
            // 
            this.btn_cola.BackColor = System.Drawing.Color.White;
            this.btn_cola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cola.BackgroundImage")));
            this.btn_cola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cola.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cola.Location = new System.Drawing.Point(23, 50);
            this.btn_cola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cola.Name = "btn_cola";
            this.btn_cola.Size = new System.Drawing.Size(95, 122);
            this.btn_cola.TabIndex = 3;
            this.btn_cola.Text = "可樂\r\nNT 30";
            this.btn_cola.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cola.UseVisualStyleBackColor = false;
            this.btn_cola.Click += new System.EventHandler(this.btn_cola_Click);
            // 
            // btn_fries
            // 
            this.btn_fries.BackColor = System.Drawing.Color.White;
            this.btn_fries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fries.BackgroundImage")));
            this.btn_fries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fries.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_fries.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_fries.Location = new System.Drawing.Point(151, 202);
            this.btn_fries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fries.Name = "btn_fries";
            this.btn_fries.Size = new System.Drawing.Size(95, 122);
            this.btn_fries.TabIndex = 2;
            this.btn_fries.Text = "薯條\r\nNT 60";
            this.btn_fries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fries.UseVisualStyleBackColor = false;
            this.btn_fries.Click += new System.EventHandler(this.btn_fries_Click);
            // 
            // btn_Hum
            // 
            this.btn_Hum.BackColor = System.Drawing.Color.White;
            this.btn_Hum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Hum.BackgroundImage")));
            this.btn_Hum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Hum.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Hum.Location = new System.Drawing.Point(23, 202);
            this.btn_Hum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hum.Name = "btn_Hum";
            this.btn_Hum.Size = new System.Drawing.Size(95, 122);
            this.btn_Hum.TabIndex = 1;
            this.btn_Hum.Text = "漢堡\r\nNT 220";
            this.btn_Hum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Hum.UseVisualStyleBackColor = false;
            this.btn_Hum.Click += new System.EventHandler(this.btn_Hum_Click);
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 475);
            this.Controls.Add(this.gro_order);
            this.Controls.Add(this.gro_pay);
            this.Controls.Add(this.gro_calculate);
            this.Controls.Add(this.gro_menu);
            this.Name = "Pos";
            this.Text = "Pos";
            this.gro_order.ResumeLayout(false);
            this.gro_pay.ResumeLayout(false);
            this.gro_pay.PerformLayout();
            this.gro_calculate.ResumeLayout(false);
            this.gro_calculate.PerformLayout();
            this.gro_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_order;
        private System.Windows.Forms.ListBox list_pos;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox gro_pay;
        private System.Windows.Forms.Label lab_credit;
        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.GroupBox gro_calculate;
        private System.Windows.Forms.TextBox tex_sum;
        private System.Windows.Forms.GroupBox gro_menu;
        private System.Windows.Forms.Button btn_chicken;
        private System.Windows.Forms.Button btn_cola;
        private System.Windows.Forms.Button btn_fries;
        private System.Windows.Forms.Button btn_Hum;
    }
}