namespace HelloPage
{
    partial class StudentGrade
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
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_Chinese = new System.Windows.Forms.Label();
            this.lab_English = new System.Windows.Forms.Label();
            this.lab_Math = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.tex_chinese = new System.Windows.Forms.TextBox();
            this.tex_English = new System.Windows.Forms.TextBox();
            this.tex_Math = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_random20 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.list_score = new System.Windows.Forms.ListView();
            this.Header_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_CHI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_ENG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_MATH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_SUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_AVG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(50, 24);
            this.lab_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(41, 15);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "姓名:";
            // 
            // lab_Chinese
            // 
            this.lab_Chinese.AutoSize = true;
            this.lab_Chinese.Location = new System.Drawing.Point(50, 54);
            this.lab_Chinese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Chinese.Name = "lab_Chinese";
            this.lab_Chinese.Size = new System.Drawing.Size(41, 15);
            this.lab_Chinese.TabIndex = 1;
            this.lab_Chinese.Text = "國文:";
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Location = new System.Drawing.Point(50, 84);
            this.lab_English.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(41, 15);
            this.lab_English.TabIndex = 2;
            this.lab_English.Text = "英文:";
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Location = new System.Drawing.Point(50, 111);
            this.lab_Math.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(41, 15);
            this.lab_Math.TabIndex = 3;
            this.lab_Math.Text = "數學:";
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(97, 22);
            this.tex_name.Margin = new System.Windows.Forms.Padding(2);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(102, 25);
            this.tex_name.TabIndex = 4;
            // 
            // tex_chinese
            // 
            this.tex_chinese.Location = new System.Drawing.Point(97, 52);
            this.tex_chinese.Margin = new System.Windows.Forms.Padding(2);
            this.tex_chinese.Name = "tex_chinese";
            this.tex_chinese.Size = new System.Drawing.Size(102, 25);
            this.tex_chinese.TabIndex = 5;
            // 
            // tex_English
            // 
            this.tex_English.Location = new System.Drawing.Point(97, 81);
            this.tex_English.Margin = new System.Windows.Forms.Padding(2);
            this.tex_English.Name = "tex_English";
            this.tex_English.Size = new System.Drawing.Size(102, 25);
            this.tex_English.TabIndex = 6;
            // 
            // tex_Math
            // 
            this.tex_Math.Location = new System.Drawing.Point(97, 108);
            this.tex_Math.Margin = new System.Windows.Forms.Padding(2);
            this.tex_Math.Name = "tex_Math";
            this.tex_Math.Size = new System.Drawing.Size(102, 25);
            this.tex_Math.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(44, 174);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 32);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "加入學生資料";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(44, 211);
            this.btn_random.Margin = new System.Windows.Forms.Padding(2);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(155, 32);
            this.btn_random.TabIndex = 9;
            this.btn_random.Text = "隨機儲存資料";
            this.btn_random.UseVisualStyleBackColor = true;
            // 
            // btn_cal
            // 
            this.btn_cal.Enabled = false;
            this.btn_cal.Location = new System.Drawing.Point(44, 248);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(155, 32);
            this.btn_cal.TabIndex = 10;
            this.btn_cal.Text = "各科統計";
            this.btn_cal.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(44, 306);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 32);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "重設所有資料";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_random20
            // 
            this.btn_random20.Location = new System.Drawing.Point(44, 344);
            this.btn_random20.Margin = new System.Windows.Forms.Padding(2);
            this.btn_random20.Name = "btn_random20";
            this.btn_random20.Size = new System.Drawing.Size(155, 32);
            this.btn_random20.TabIndex = 12;
            this.btn_random20.Text = "隨機加入20筆";
            this.btn_random20.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(232, 296);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(485, 94);
            this.listBox2.TabIndex = 14;
            // 
            // list_score
            // 
            this.list_score.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header_Name,
            this.Header_CHI,
            this.Header_ENG,
            this.Header_MATH,
            this.Header_SUM,
            this.Header_AVG,
            this.Header_Max,
            this.Header_Min});
            this.list_score.HideSelection = false;
            this.list_score.Location = new System.Drawing.Point(232, 31);
            this.list_score.Name = "list_score";
            this.list_score.Size = new System.Drawing.Size(485, 241);
            this.list_score.TabIndex = 15;
            this.list_score.UseCompatibleStateImageBehavior = false;
            this.list_score.View = System.Windows.Forms.View.Details;
            // 
            // Header_Name
            // 
            this.Header_Name.Text = "姓名";
            // 
            // Header_CHI
            // 
            this.Header_CHI.Text = "國文";
            // 
            // Header_ENG
            // 
            this.Header_ENG.Text = "英文";
            // 
            // Header_MATH
            // 
            this.Header_MATH.Text = "數學";
            // 
            // Header_SUM
            // 
            this.Header_SUM.Text = "總分";
            // 
            // Header_AVG
            // 
            this.Header_AVG.Text = "平均";
            // 
            // Header_Max
            // 
            this.Header_Max.Text = "最高";
            // 
            // Header_Min
            // 
            this.Header_Min.Text = "最低";
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 439);
            this.Controls.Add(this.list_score);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_random20);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tex_Math);
            this.Controls.Add(this.tex_English);
            this.Controls.Add(this.tex_chinese);
            this.Controls.Add(this.tex_name);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.lab_Chinese);
            this.Controls.Add(this.lab_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_Chinese;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.TextBox tex_chinese;
        private System.Windows.Forms.TextBox tex_English;
        private System.Windows.Forms.TextBox tex_Math;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_random20;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListView list_score;
        private System.Windows.Forms.ColumnHeader Header_Name;
        private System.Windows.Forms.ColumnHeader Header_CHI;
        private System.Windows.Forms.ColumnHeader Header_ENG;
        private System.Windows.Forms.ColumnHeader Header_MATH;
        private System.Windows.Forms.ColumnHeader Header_SUM;
        private System.Windows.Forms.ColumnHeader Header_AVG;
        private System.Windows.Forms.ColumnHeader Header_Max;
        private System.Windows.Forms.ColumnHeader Header_Min;
    }
}