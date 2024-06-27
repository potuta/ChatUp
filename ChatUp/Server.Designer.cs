namespace ChatUp
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            Start_Button = new Button();
            textBox1 = new TextBox();
            Send_Button = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(310, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(454, 337);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // Start_Button
            // 
            Start_Button.Location = new Point(82, 397);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(75, 23);
            Start_Button.TabIndex = 1;
            Start_Button.Text = "Start Server";
            Start_Button.UseVisualStyleBackColor = true;
            Start_Button.Click += Start_Button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 397);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 2;
            // 
            // Send_Button
            // 
            Send_Button.Location = new Point(689, 396);
            Send_Button.Name = "Send_Button";
            Send_Button.Size = new Size(75, 23);
            Send_Button.TabIndex = 3;
            Send_Button.Text = "Send";
            Send_Button.UseVisualStyleBackColor = true;
            Send_Button.Click += Send_Button_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Send_Button);
            Controls.Add(textBox1);
            Controls.Add(Start_Button);
            Controls.Add(richTextBox1);
            Name = "Server";
            Text = "Form1";
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private static TextBox textBox1;
        private static Button Send_Button;
        private static Button Start_Button;
        public static RichTextBox richTextBox1;
    }
}
