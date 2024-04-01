namespace CSCN72030_group6
{
    partial class LoginForm
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
            loginButton = new Button();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            createAccountButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(334, 230);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(82, 22);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += login_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(256, 123);
            usernameBox.Margin = new Padding(3, 2, 3, 2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(236, 23);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += password_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(256, 158);
            passwordBox.Margin = new Padding(3, 2, 3, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(236, 23);
            passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 125);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 160);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 191);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(305, 256);
            createAccountButton.Margin = new Padding(3, 2, 3, 2);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(149, 22);
            createAccountButton.TabIndex = 3;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(createAccountButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(loginButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "CredentialFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button loginButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button createAccountButton;
    }
}