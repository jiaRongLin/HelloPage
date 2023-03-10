namespace HelloPage
{
    partial class HelloPage
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.btn_screen = new System.Windows.Forms.Button();
			this.btn_Draw = new System.Windows.Forms.Button();
			this.btn_XO = new System.Windows.Forms.Button();
			this.btn_note = new System.Windows.Forms.Button();
			this.btn_Guess = new System.Windows.Forms.Button();
			this.btn_loan = new System.Windows.Forms.Button();
			this.btn_MyCal = new System.Windows.Forms.Button();
			this.btn_Hello = new System.Windows.Forms.Button();
			this.btn_struct = new System.Windows.Forms.Button();
			this.btn_pos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.BackgroundImage = global::HelloPage.Properties.Resources._4;
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1448, 786);
			this.splitContainer1.SplitterDistance = 142;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.splitContainer2.Panel1.Controls.Add(this.btn_screen);
			this.splitContainer2.Panel1.Controls.Add(this.btn_Draw);
			this.splitContainer2.Panel1.Controls.Add(this.btn_XO);
			this.splitContainer2.Panel1.Controls.Add(this.btn_note);
			this.splitContainer2.Panel1.Controls.Add(this.btn_Guess);
			this.splitContainer2.Panel1.Controls.Add(this.btn_loan);
			this.splitContainer2.Panel1.Controls.Add(this.btn_MyCal);
			this.splitContainer2.Panel1.Controls.Add(this.btn_Hello);
			this.splitContainer2.Panel1.Controls.Add(this.btn_struct);
			this.splitContainer2.Panel1.Controls.Add(this.btn_pos);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.splitContainer2.Size = new System.Drawing.Size(1448, 639);
			this.splitContainer2.SplitterDistance = 166;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 0;
			// 
			// btn_screen
			// 
			this.btn_screen.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_screen.Location = new System.Drawing.Point(1, 429);
			this.btn_screen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_screen.Name = "btn_screen";
			this.btn_screen.Size = new System.Drawing.Size(113, 32);
			this.btn_screen.TabIndex = 9;
			this.btn_screen.Text = "Screen Saver";
			this.btn_screen.UseVisualStyleBackColor = true;
			this.btn_screen.Click += new System.EventHandler(this.btn_screen_Click);
			// 
			// btn_Draw
			// 
			this.btn_Draw.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_Draw.Location = new System.Drawing.Point(1, 377);
			this.btn_Draw.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_Draw.Name = "btn_Draw";
			this.btn_Draw.Size = new System.Drawing.Size(113, 32);
			this.btn_Draw.TabIndex = 8;
			this.btn_Draw.Text = "Draw";
			this.btn_Draw.UseVisualStyleBackColor = true;
			this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
			// 
			// btn_XO
			// 
			this.btn_XO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_XO.Location = new System.Drawing.Point(1, 325);
			this.btn_XO.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_XO.Name = "btn_XO";
			this.btn_XO.Size = new System.Drawing.Size(113, 32);
			this.btn_XO.TabIndex = 7;
			this.btn_XO.Text = "XO Games";
			this.btn_XO.UseVisualStyleBackColor = true;
			this.btn_XO.Click += new System.EventHandler(this.btn_XO_Click);
			// 
			// btn_note
			// 
			this.btn_note.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_note.Location = new System.Drawing.Point(1, 273);
			this.btn_note.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_note.Name = "btn_note";
			this.btn_note.Size = new System.Drawing.Size(113, 32);
			this.btn_note.TabIndex = 6;
			this.btn_note.Text = "Notepad";
			this.btn_note.UseVisualStyleBackColor = true;
			this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
			// 
			// btn_Guess
			// 
			this.btn_Guess.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_Guess.Location = new System.Drawing.Point(1, 221);
			this.btn_Guess.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_Guess.Name = "btn_Guess";
			this.btn_Guess.Size = new System.Drawing.Size(113, 32);
			this.btn_Guess.TabIndex = 5;
			this.btn_Guess.Text = "Guess";
			this.btn_Guess.UseVisualStyleBackColor = true;
			this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
			// 
			// btn_loan
			// 
			this.btn_loan.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_loan.Location = new System.Drawing.Point(1, 13);
			this.btn_loan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_loan.Name = "btn_loan";
			this.btn_loan.Size = new System.Drawing.Size(113, 32);
			this.btn_loan.TabIndex = 1;
			this.btn_loan.Text = "Loan";
			this.btn_loan.UseVisualStyleBackColor = true;
			this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
			// 
			// btn_MyCal
			// 
			this.btn_MyCal.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_MyCal.Location = new System.Drawing.Point(1, 169);
			this.btn_MyCal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_MyCal.Name = "btn_MyCal";
			this.btn_MyCal.Size = new System.Drawing.Size(113, 32);
			this.btn_MyCal.TabIndex = 4;
			this.btn_MyCal.Text = "MyCal";
			this.btn_MyCal.UseVisualStyleBackColor = true;
			this.btn_MyCal.Click += new System.EventHandler(this.btn_MyCal_Click);
			// 
			// btn_Hello
			// 
			this.btn_Hello.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_Hello.Location = new System.Drawing.Point(1, -39);
			this.btn_Hello.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_Hello.Name = "btn_Hello";
			this.btn_Hello.Size = new System.Drawing.Size(113, 32);
			this.btn_Hello.TabIndex = 0;
			this.btn_Hello.Text = "Hello";
			this.btn_Hello.UseVisualStyleBackColor = true;
			this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
			// 
			// btn_struct
			// 
			this.btn_struct.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_struct.Location = new System.Drawing.Point(1, 117);
			this.btn_struct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_struct.Name = "btn_struct";
			this.btn_struct.Size = new System.Drawing.Size(113, 32);
			this.btn_struct.TabIndex = 3;
			this.btn_struct.Text = "Student StructForm";
			this.btn_struct.UseVisualStyleBackColor = true;
			this.btn_struct.Click += new System.EventHandler(this.btn_struct_Click);
			// 
			// btn_pos
			// 
			this.btn_pos.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_pos.Location = new System.Drawing.Point(1, 65);
			this.btn_pos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_pos.Name = "btn_pos";
			this.btn_pos.Size = new System.Drawing.Size(113, 32);
			this.btn_pos.TabIndex = 2;
			this.btn_pos.Text = "POS";
			this.btn_pos.UseVisualStyleBackColor = true;
			this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
			// 
			// HelloPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1448, 786);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "HelloPage";
			this.Text = "HelloPage";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_loan;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Button btn_struct;
        private System.Windows.Forms.Button btn_MyCal;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_note;
        private System.Windows.Forms.Button btn_XO;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.Button btn_screen;
    }
}