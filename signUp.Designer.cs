namespace Mobile_shop_management_system
{
    partial class signUp
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
            btnSignUp = new Button();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            passwd = new Label();
            uName = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(486, 309);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(141, 53);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(228, 309);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(141, 53);
            btnSignIn.TabIndex = 15;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(442, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(442, 105);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(185, 27);
            txtUserName.TabIndex = 13;
            // 
            // passwd
            // 
            passwd.AutoSize = true;
            passwd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwd.Location = new Point(186, 171);
            passwd.Name = "passwd";
            passwd.Size = new Size(145, 41);
            passwd.TabIndex = 12;
            passwd.Text = "password";
            // 
            // uName
            // 
            uName.AutoSize = true;
            uName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            uName.Location = new Point(186, 89);
            uName.Name = "uName";
            uName.Size = new Size(148, 41);
            uName.TabIndex = 11;
            uName.Text = "username";
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 451);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(passwd);
            Controls.Add(uName);
            Name = "signUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Button btnSignIn;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label passwd;
        private Label uName;
    }
}