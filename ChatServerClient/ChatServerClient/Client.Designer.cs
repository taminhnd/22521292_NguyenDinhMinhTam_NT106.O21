namespace ChatServerClient
{
    partial class Client
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
            label1 = new Label();
            client_name = new TextBox();
            btnSaveName = new Button();
            textChatBox = new TextBox();
            listBox1 = new ListBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 0;
            label1.Text = "Client's name";
            // 
            // client_name
            // 
            client_name.Location = new Point(146, 13);
            client_name.Name = "client_name";
            client_name.Size = new Size(542, 27);
            client_name.TabIndex = 1;
            // 
            // btnSaveName
            // 
            btnSaveName.BackColor = SystemColors.ActiveCaption;
            btnSaveName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveName.Location = new Point(694, 13);
            btnSaveName.Name = "btnSaveName";
            btnSaveName.Size = new Size(94, 29);
            btnSaveName.TabIndex = 2;
            btnSaveName.Text = "Save";
            btnSaveName.UseVisualStyleBackColor = false;
            btnSaveName.Click += btnSaveName_Click;
            // 
            // textChatBox
            // 
            textChatBox.Location = new Point(12, 421);
            textChatBox.Name = "textChatBox";
            textChatBox.Size = new Size(676, 27);
            textChatBox.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 364);
            listBox1.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveCaption;
            btnSend.Location = new Point(694, 421);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(797, 459);
            Controls.Add(btnSend);
            Controls.Add(listBox1);
            Controls.Add(textChatBox);
            Controls.Add(btnSaveName);
            Controls.Add(client_name);
            Controls.Add(label1);
            Name = "Client";
            Text = "Client";
            FormClosed += Client_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox client_name;
        private Button btnSaveName;
        private TextBox textChatBox;
        private ListBox listBox1;
        private Button btnSend;
    }
}