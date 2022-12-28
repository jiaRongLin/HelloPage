namespace HelloPage
{
    partial class Student_StructForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_StructForm));
            this.group_score = new System.Windows.Forms.GroupBox();
            this.list_compare = new System.Windows.Forms.ListBox();
            this.list_score = new System.Windows.Forms.ListBox();
            this.btn_compare = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            this.tex_math = new System.Windows.Forms.TextBox();
            this.lab_math = new System.Windows.Forms.Label();
            this.tex_English = new System.Windows.Forms.TextBox();
            this.lab_English = new System.Windows.Forms.Label();
            this.tex_chinese = new System.Windows.Forms.TextBox();
            this.lab_chinese = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.group_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_score
            // 
            this.group_score.BackColor = System.Drawing.Color.LightSkyBlue;
            this.group_score.Controls.Add(this.list_compare);
            this.group_score.Controls.Add(this.list_score);
            this.group_score.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group_score.Location = new System.Drawing.Point(560, 31);
            this.group_score.Margin = new System.Windows.Forms.Padding(4);
            this.group_score.Name = "group_score";
            this.group_score.Padding = new System.Windows.Forms.Padding(4);
            this.group_score.Size = new System.Drawing.Size(372, 365);
            this.group_score.TabIndex = 25;
            this.group_score.TabStop = false;
            this.group_score.Text = "成績";
            // 
            // list_compare
            // 
            this.list_compare.BackColor = System.Drawing.Color.Bisque;
            this.list_compare.FormattingEnabled = true;
            this.list_compare.ItemHeight = 26;
            this.list_compare.Location = new System.Drawing.Point(21, 260);
            this.list_compare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.list_compare.Name = "list_compare";
            this.list_compare.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_compare.Size = new System.Drawing.Size(325, 82);
            this.list_compare.TabIndex = 1;
            // 
            // list_score
            // 
            this.list_score.BackColor = System.Drawing.Color.Bisque;
            this.list_score.FormattingEnabled = true;
            this.list_score.ItemHeight = 26;
            this.list_score.Location = new System.Drawing.Point(18, 39);
            this.list_score.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.list_score.Name = "list_score";
            this.list_score.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_score.Size = new System.Drawing.Size(328, 186);
            this.list_score.TabIndex = 0;
            // 
            // btn_compare
            // 
            this.btn_compare.BackColor = System.Drawing.SystemColors.Info;
            this.btn_compare.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_compare.Location = new System.Drawing.Point(687, 415);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(234, 45);
            this.btn_compare.TabIndex = 24;
            this.btn_compare.Text = "最高分/最低分科目";
            this.btn_compare.UseVisualStyleBackColor = false;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.Info;
            this.btn_show.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show.Location = new System.Drawing.Point(267, 370);
            this.btn_show.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(182, 52);
            this.btn_show.TabIndex = 23;
            this.btn_show.Text = "顯示儲存內容";
            this.btn_show.UseVisualStyleBackColor = false;
            // 
            // btn_store
            // 
            this.btn_store.BackColor = System.Drawing.SystemColors.Info;
            this.btn_store.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_store.Location = new System.Drawing.Point(142, 370);
            this.btn_store.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(76, 52);
            this.btn_store.TabIndex = 22;
            this.btn_store.Text = "儲存";
            this.btn_store.UseVisualStyleBackColor = false;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // tex_math
            // 
            this.tex_math.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_math.Location = new System.Drawing.Point(215, 295);
            this.tex_math.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tex_math.Name = "tex_math";
            this.tex_math.Size = new System.Drawing.Size(176, 39);
            this.tex_math.TabIndex = 21;
            this.tex_math.Text = "0";
            this.tex_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_math
            // 
            this.lab_math.AutoSize = true;
            this.lab_math.BackColor = System.Drawing.Color.Transparent;
            this.lab_math.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_math.Location = new System.Drawing.Point(120, 301);
            this.lab_math.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_math.Name = "lab_math";
            this.lab_math.Size = new System.Drawing.Size(80, 26);
            this.lab_math.TabIndex = 20;
            this.lab_math.Text = "數學:";
            // 
            // tex_English
            // 
            this.tex_English.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_English.Location = new System.Drawing.Point(215, 231);
            this.tex_English.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tex_English.Name = "tex_English";
            this.tex_English.Size = new System.Drawing.Size(176, 39);
            this.tex_English.TabIndex = 19;
            this.tex_English.Text = "0";
            this.tex_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.BackColor = System.Drawing.Color.Transparent;
            this.lab_English.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(120, 237);
            this.lab_English.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(80, 26);
            this.lab_English.TabIndex = 18;
            this.lab_English.Text = "英文:";
            // 
            // tex_chinese
            // 
            this.tex_chinese.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_chinese.Location = new System.Drawing.Point(215, 162);
            this.tex_chinese.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tex_chinese.Name = "tex_chinese";
            this.tex_chinese.Size = new System.Drawing.Size(176, 39);
            this.tex_chinese.TabIndex = 17;
            this.tex_chinese.Text = "0";
            this.tex_chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_chinese
            // 
            this.lab_chinese.AutoSize = true;
            this.lab_chinese.BackColor = System.Drawing.Color.Transparent;
            this.lab_chinese.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_chinese.Location = new System.Drawing.Point(119, 167);
            this.lab_chinese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_chinese.Name = "lab_chinese";
            this.lab_chinese.Size = new System.Drawing.Size(80, 26);
            this.lab_chinese.TabIndex = 16;
            this.lab_chinese.Text = "國文:";
            // 
            // tex_name
            // 
            this.tex_name.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_name.Location = new System.Drawing.Point(215, 96);
            this.tex_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(176, 39);
            this.tex_name.TabIndex = 15;
            this.tex_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.BackColor = System.Drawing.Color.Transparent;
            this.lab_name.Font = new System.Drawing.Font("標楷體", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_name.Location = new System.Drawing.Point(119, 100);
            this.lab_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(80, 26);
            this.lab_name.TabIndex = 14;
            this.lab_name.Text = "姓名:";
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 509);
            this.Controls.Add(this.group_score);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.tex_math);
            this.Controls.Add(this.lab_math);
            this.Controls.Add(this.tex_English);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.tex_chinese);
            this.Controls.Add(this.lab_chinese);
            this.Controls.Add(this.tex_name);
            this.Controls.Add(this.lab_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.group_score.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_score;
        private System.Windows.Forms.ListBox list_compare;
        private System.Windows.Forms.ListBox list_score;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.TextBox tex_math;
        private System.Windows.Forms.Label lab_math;
        private System.Windows.Forms.TextBox tex_English;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.TextBox tex_chinese;
        private System.Windows.Forms.Label lab_chinese;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Label lab_name;
    }
}