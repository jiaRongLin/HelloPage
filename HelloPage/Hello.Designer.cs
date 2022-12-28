namespace HelloPage
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.text_message = new System.Windows.Forms.TextBox();
            this.lab_message = new System.Windows.Forms.Label();
            this.text_Mail = new System.Windows.Forms.TextBox();
            this.lab_Mail = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Hello.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Hello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Hello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hello.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_Hello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hello.Location = new System.Drawing.Point(845, 415);
            this.btn_Hello.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(128, 53);
            this.btn_Hello.TabIndex = 15;
            this.btn_Hello.Text = "Hello";
            this.btn_Hello.UseVisualStyleBackColor = false;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("標楷體", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_send.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Location = new System.Drawing.Point(845, 496);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(128, 53);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "送出";
            this.btn_send.UseVisualStyleBackColor = false;
            // 
            // text_message
            // 
            this.text_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_message.Font = new System.Drawing.Font("新細明體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_message.Location = new System.Drawing.Point(548, 362);
            this.text_message.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_message.Multiline = true;
            this.text_message.Name = "text_message";
            this.text_message.Size = new System.Drawing.Size(250, 187);
            this.text_message.TabIndex = 13;
            // 
            // lab_message
            // 
            this.lab_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_message.AutoSize = true;
            this.lab_message.BackColor = System.Drawing.Color.Transparent;
            this.lab_message.Font = new System.Drawing.Font("標楷體", 14.02597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_message.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lab_message.Location = new System.Drawing.Point(438, 362);
            this.lab_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(106, 30);
            this.lab_message.TabIndex = 12;
            this.lab_message.Text = "留言：";
            // 
            // text_Mail
            // 
            this.text_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Mail.Font = new System.Drawing.Font("新細明體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_Mail.Location = new System.Drawing.Point(548, 308);
            this.text_Mail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_Mail.Name = "text_Mail";
            this.text_Mail.Size = new System.Drawing.Size(250, 43);
            this.text_Mail.TabIndex = 11;
            // 
            // lab_Mail
            // 
            this.lab_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Mail.AutoSize = true;
            this.lab_Mail.BackColor = System.Drawing.Color.Transparent;
            this.lab_Mail.Font = new System.Drawing.Font("標楷體", 14.02597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Mail.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lab_Mail.Location = new System.Drawing.Point(404, 308);
            this.lab_Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Mail.Name = "lab_Mail";
            this.lab_Mail.Size = new System.Drawing.Size(140, 30);
            this.lab_Mail.TabIndex = 10;
            this.lab_Mail.Text = "E-Mail：";
            // 
            // text_Name
            // 
            this.text_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Name.Font = new System.Drawing.Font("新細明體", 14.02597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_Name.Location = new System.Drawing.Point(548, 257);
            this.text_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(250, 43);
            this.text_Name.TabIndex = 9;
            // 
            // lab_Name
            // 
            this.lab_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Name.AutoSize = true;
            this.lab_Name.BackColor = System.Drawing.Color.Transparent;
            this.lab_Name.Font = new System.Drawing.Font("標楷體", 14.02597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lab_Name.Location = new System.Drawing.Point(438, 257);
            this.lab_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(106, 30);
            this.lab_Name.TabIndex = 8;
            this.lab_Name.Text = "姓名：";
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.btn_Hello);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.text_message);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.text_Mail);
            this.Controls.Add(this.lab_Mail);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.lab_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox text_message;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.TextBox text_Mail;
        private System.Windows.Forms.Label lab_Mail;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Label lab_Name;
    }
}