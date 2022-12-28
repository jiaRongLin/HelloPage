namespace HelloPage
{
    partial class MyCal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.bnt_plus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tex_ans = new System.Windows.Forms.TextBox();
            this.tex_num2 = new System.Windows.Forms.TextBox();
            this.tex_num1 = new System.Windows.Forms.TextBox();
            this.lab_ans = new System.Windows.Forms.Label();
            this.lab_num2 = new System.Windows.Forms.Label();
            this.lab_num1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_div);
            this.groupBox1.Controls.Add(this.btn_mult);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.bnt_plus);
            this.groupBox1.Location = new System.Drawing.Point(299, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 171);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(99, 91);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(64, 64);
            this.btn_div.TabIndex = 10;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(18, 91);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(64, 64);
            this.btn_mult.TabIndex = 9;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(99, 16);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(64, 64);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "-";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // bnt_plus
            // 
            this.bnt_plus.Location = new System.Drawing.Point(18, 16);
            this.bnt_plus.Name = "bnt_plus";
            this.bnt_plus.Size = new System.Drawing.Size(64, 64);
            this.bnt_plus.TabIndex = 7;
            this.bnt_plus.Text = "+";
            this.bnt_plus.UseVisualStyleBackColor = true;
            this.bnt_plus.Click += new System.EventHandler(this.bnt_plus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "= = = = = = = = = = = = = = = = = =";
            // 
            // tex_ans
            // 
            this.tex_ans.Location = new System.Drawing.Point(130, 185);
            this.tex_ans.Name = "tex_ans";
            this.tex_ans.ReadOnly = true;
            this.tex_ans.Size = new System.Drawing.Size(116, 25);
            this.tex_ans.TabIndex = 19;
            // 
            // tex_num2
            // 
            this.tex_num2.Location = new System.Drawing.Point(130, 84);
            this.tex_num2.Name = "tex_num2";
            this.tex_num2.Size = new System.Drawing.Size(116, 25);
            this.tex_num2.TabIndex = 18;
            // 
            // tex_num1
            // 
            this.tex_num1.Location = new System.Drawing.Point(130, 37);
            this.tex_num1.Name = "tex_num1";
            this.tex_num1.Size = new System.Drawing.Size(116, 25);
            this.tex_num1.TabIndex = 17;
            // 
            // lab_ans
            // 
            this.lab_ans.AutoSize = true;
            this.lab_ans.Location = new System.Drawing.Point(59, 188);
            this.lab_ans.Name = "lab_ans";
            this.lab_ans.Size = new System.Drawing.Size(50, 15);
            this.lab_ans.TabIndex = 16;
            this.lab_ans.Text = "Answer";
            // 
            // lab_num2
            // 
            this.lab_num2.AutoSize = true;
            this.lab_num2.Location = new System.Drawing.Point(59, 87);
            this.lab_num2.Name = "lab_num2";
            this.lab_num2.Size = new System.Drawing.Size(42, 15);
            this.lab_num2.TabIndex = 15;
            this.lab_num2.Text = "Num2";
            // 
            // lab_num1
            // 
            this.lab_num1.AutoSize = true;
            this.lab_num1.Location = new System.Drawing.Point(59, 46);
            this.lab_num1.Name = "lab_num1";
            this.lab_num1.Size = new System.Drawing.Size(42, 15);
            this.lab_num1.TabIndex = 14;
            this.lab_num1.Text = "Num1";
            // 
            // MyCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex_ans);
            this.Controls.Add(this.tex_num2);
            this.Controls.Add(this.tex_num1);
            this.Controls.Add(this.lab_ans);
            this.Controls.Add(this.lab_num2);
            this.Controls.Add(this.lab_num1);
            this.Name = "MyCal";
            this.Text = "MyCal";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button bnt_plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_ans;
        private System.Windows.Forms.TextBox tex_num2;
        private System.Windows.Forms.TextBox tex_num1;
        private System.Windows.Forms.Label lab_ans;
        private System.Windows.Forms.Label lab_num2;
        private System.Windows.Forms.Label lab_num1;
    }
}