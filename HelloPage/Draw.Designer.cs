namespace HelloPage
{
    partial class Draw
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
            this.btn_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_imag = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.picture_draw = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_draw)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_color
            // 
            this.btn_color.Font = new System.Drawing.Font("標楷體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.Location = new System.Drawing.Point(821, 56);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(132, 65);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "顏色";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // btn_imag
            // 
            this.btn_imag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_imag.Enabled = false;
            this.btn_imag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imag.ForeColor = System.Drawing.Color.Transparent;
            this.btn_imag.Location = new System.Drawing.Point(821, 143);
            this.btn_imag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imag.Name = "btn_imag";
            this.btn_imag.Size = new System.Drawing.Size(132, 63);
            this.btn_imag.TabIndex = 1;
            this.btn_imag.UseVisualStyleBackColor = false;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar.Location = new System.Drawing.Point(850, 239);
            this.trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(72, 199);
            this.trackBar.TabIndex = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // picture_draw
            // 
            this.picture_draw.BackColor = System.Drawing.Color.White;
            this.picture_draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_draw.Location = new System.Drawing.Point(0, 0);
            this.picture_draw.Name = "picture_draw";
            this.picture_draw.Size = new System.Drawing.Size(1000, 570);
            this.picture_draw.TabIndex = 3;
            this.picture_draw.TabStop = false;
            this.picture_draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_draw_MouseDown);
            this.picture_draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_draw_MouseMove);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(835, 473);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 53);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btn_imag);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.picture_draw);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Draw";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Draw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_imag;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox picture_draw;
        private System.Windows.Forms.Button btn_clear;
    }
}