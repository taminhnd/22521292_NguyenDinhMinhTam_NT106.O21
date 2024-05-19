namespace SendEmail
{
    partial class Ex1_LoginForm
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
            txtPass = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(120, 50);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(256, 27);
            txtPass.TabIndex = 9;
            txtPass.Text = "gtrvscvbmeteywod";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(120, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(256, 27);
            txtUser.TabIndex = 8;
            txtUser.Text = "sendemailtestnt106.o21@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 53);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(282, 83);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Ex1_LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 129);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Name = "Ex1_LoginForm";
            Text = "Ex1_LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private Button btnLogin;
    }
}