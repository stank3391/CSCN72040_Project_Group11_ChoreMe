namespace ChoreMe
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
            usernameLabel = new Label();
            passwordLabel = new Label();
            createAccountButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
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
            usernameBox.Anchor = AnchorStyles.None;
            usernameBox.Location = new Point(256, 122);
            usernameBox.Margin = new Padding(3, 2, 3, 2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(236, 23);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += password_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.None;
            passwordBox.Location = new Point(256, 158);
            passwordBox.Margin = new Padding(3, 2, 3, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(236, 23);
            passwordBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(183, 125);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(186, 161);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // createAccountButton
            // 
            createAccountButton.Anchor = AnchorStyles.None;
            createAccountButton.Location = new Point(305, 256);
            createAccountButton.Margin = new Padding(3, 2, 3, 2);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(149, 22);
            createAccountButton.TabIndex = 3;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(createAccountButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
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

        private Button loginButton;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button createAccountButton;
    }
}