namespace HelloPage
{
    partial class Guess_Select
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tex_select = new System.Windows.Forms.TextBox();
            this.lab_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(316, 98);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 36);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(316, 21);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(119, 36);
            this.btn_enter.TabIndex = 6;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tex_select
            // 
            this.tex_select.Location = new System.Drawing.Point(30, 84);
            this.tex_select.Name = "tex_select";
            this.tex_select.Size = new System.Drawing.Size(227, 25);
            this.tex_select.TabIndex = 5;
            this.tex_select.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_select_KeyDown);
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_num.Location = new System.Drawing.Point(26, 38);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(176, 20);
            this.lab_num.TabIndex = 4;
            this.lab_num.Text = "Please input a number.";
            // 
            // Guess_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 152);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tex_select);
            this.Controls.Add(this.lab_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Guess_Select";
            this.Text = "Guess_Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lab_num;
        public System.Windows.Forms.TextBox tex_select;
    }
}