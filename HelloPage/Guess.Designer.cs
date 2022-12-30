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
            this.SuspendLayout();
            // 
            // lab_guess
            // 
            this.lab_guess.AutoSize = true;
            this.lab_guess.Font = new System.Drawing.Font("微軟正黑體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_guess.Location = new System.Drawing.Point(54, 101);
            this.lab_guess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_guess.Name = "lab_guess";
            this.lab_guess.Size = new System.Drawing.Size(618, 38);
            this.lab_guess.TabIndex = 5;
            this.lab_guess.Text = "Please Select A number between 1 to 100!!";
            // 
            // btn_ans
            // 
            this.btn_ans.Font = new System.Drawing.Font("微軟正黑體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ans.Location = new System.Drawing.Point(383, 240);
            this.btn_ans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ans.Name = "btn_ans";
            this.btn_ans.Size = new System.Drawing.Size(176, 76);
            this.btn_ans.TabIndex = 4;
            this.btn_ans.Text = "Answer";
            this.btn_ans.UseVisualStyleBackColor = true;
            this.btn_ans.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // btn_guess
            // 
            this.btn_guess.Font = new System.Drawing.Font("微軟正黑體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_guess.Location = new System.Drawing.Point(142, 240);
            this.btn_guess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(176, 76);
            this.btn_guess.TabIndex = 3;
            this.btn_guess.Text = "Guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_guess);
            this.Controls.Add(this.btn_ans);
            this.Controls.Add(this.btn_guess);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ans;
        internal System.Windows.Forms.Label lab_guess;
        public System.Windows.Forms.Button btn_guess;
    }
}