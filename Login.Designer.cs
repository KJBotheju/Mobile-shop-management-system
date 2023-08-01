namespace Mobile_shop_management_system
{
    partial class Login
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            passwd = new Label();
            uName = new Label();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(223, 321);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 53);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(437, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(437, 117);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(185, 27);
            txtUserName.TabIndex = 7;
            // 
            // passwd
            // 
            passwd.AutoSize = true;
            passwd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwd.Location = new Point(181, 183);
            passwd.Name = "passwd";
            passwd.Size = new Size(145, 41);
            passwd.TabIndex = 6;
            passwd.Text = "password";
            // 
            // uName
            // 
            uName.AutoSize = true;
            uName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            uName.Location = new Point(181, 101);
            uName.Name = "uName";
            uName.Size = new Size(148, 41);
            uName.TabIndex = 5;
            uName.Text = "username";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(481, 321);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(141, 53);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(passwd);
            Controls.Add(uName);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label passwd;
        private Label uName;
        private Button btnSignUp;
    }
}