namespace SendEmail
{
    partial class Ex1
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
            txtSubject = new TextBox();
            txtTo = new TextBox();
            txtFrom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rtbBody = new RichTextBox();
            btnSendMail = new Button();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(130, 77);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(695, 27);
            txtSubject.TabIndex = 17;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(186, 42);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(639, 27);
            txtTo.TabIndex = 16;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(186, 5);
            txtFrom.Name = "txtFrom";
            txtFrom.ReadOnly = true;
            txtFrom.Size = new Size(639, 27);
            txtFrom.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 80);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 14;
            label4.Text = "Subject :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 45);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 13;
            label3.Text = "To :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 8);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "From :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 120);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 11;
            label1.Text = "Body :";
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(130, 120);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(695, 376);
            rtbBody.TabIndex = 10;
            rtbBody.Text = "";
            // 
            // btnSendMail
            // 
            btnSendMail.Location = new Point(8, 8);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(94, 57);
            btnSendMail.TabIndex = 9;
            btnSendMail.Text = "Send Mail";
            btnSendMail.UseVisualStyleBackColor = true;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 507);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbBody);
            Controls.Add(btnSendMail);
            Name = "Ex1";
            Text = "Ex1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubject;
        private TextBox txtTo;
        private TextBox txtFrom;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rtbBody;
        private Button btnSendMail;
    }
}