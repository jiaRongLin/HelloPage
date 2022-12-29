namespace HelloPage
{
    partial class Guess
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
            this.lab_guess = new System.Windows.Forms.Label();
            this.btn_ans = new System.Windows.Forms.Button();
            this.btn_guess = new System.Windows.Forms.Button();
            this.lab_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_guess
            // 
            this.lab_guess.AutoSize = true;
            this.lab_guess.Location = new System.Drawing.Point(158, 87);
            this.lab_guess.Name = "lab_guess";
            this.lab_guess.Size = new System.Drawing.Size(248, 15);
            this.lab_guess.TabIndex = 5;
            this.lab_guess.Text = "Please Select A number between 1to 100!!";
            // 
            // btn_ans
            // 
            this.btn_ans.Location = new System.Drawing.Point(346, 204);
            this.btn_ans.Name = "btn_ans";
            this.btn_ans.Size = new System.Drawing.Size(141, 60);
            this.btn_ans.TabIndex = 4;
            this.btn_ans.Text = "Answer";
            this.btn_ans.UseVisualStyleBackColor = true;
            this.btn_ans.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // btn_guess
            // 
            this.btn_guess.Location = new System.Drawing.Point(153, 204);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(141, 60);
            this.btn_guess.TabIndex = 3;
            this.btn_guess.Text = "Guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(158, 134);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(0, 15);
            this.lab_num.TabIndex = 6;
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 355);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.lab_guess);
            this.Controls.Add(this.btn_ans);
            this.Controls.Add(this.btn_guess);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ans;
        internal System.Windows.Forms.Label lab_guess;
        internal System.Windows.Forms.Label lab_num;
        public System.Windows.Forms.Button btn_guess;
    }
}