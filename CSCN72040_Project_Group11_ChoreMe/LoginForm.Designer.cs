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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
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
            resources.ApplyResources(loginButton, "loginButton");
            loginButton.Name = "loginButton";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += login_Click;
            // 
            // usernameBox
            // 
            resources.ApplyResources(usernameBox, "usernameBox");
            usernameBox.Name = "usernameBox";
            usernameBox.TextChanged += password_TextChanged;
            // 
            // passwordBox
            // 
            resources.ApplyResources(passwordBox, "passwordBox");
            passwordBox.Name = "passwordBox";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(usernameLabel, "usernameLabel");
            usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // createAccountButton
            // 
            resources.ApplyResources(createAccountButton, "createAccountButton");
            createAccountButton.Name = "createAccountButton";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += button1_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createAccountButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(loginButton);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button loginButton;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button createAccountButton;
    }
}