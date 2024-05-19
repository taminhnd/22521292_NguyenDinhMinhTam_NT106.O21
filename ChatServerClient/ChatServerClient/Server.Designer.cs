namespace ChatServerClient
{
    partial class Server
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
            listBox1 = new ListBox();
            textChatBox = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 404);
            listBox1.TabIndex = 0;
            // 
            // textChatBox
            // 
            textChatBox.Location = new Point(12, 422);
            textChatBox.Name = "textChatBox";
            textChatBox.Size = new Size(676, 27);
            textChatBox.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveCaption;
            btnSend.Location = new Point(694, 422);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(801, 460);
            Controls.Add(btnSend);
            Controls.Add(textChatBox);
            Controls.Add(listBox1);
            Name = "Server";
            Text = "Server";
            FormClosed += Server_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textChatBox;
        private Button btnSend;
    }
}