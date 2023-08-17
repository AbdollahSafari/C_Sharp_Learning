namespace MyApplication
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
            usernameLabel = new Dtat.Windows.Forms.Label();
            passwordLabel = new Dtat.Windows.Forms.Label();
            usernameTextBox = new Dtat.Windows.Forms.TextBox();
            passwordTextBox = new Dtat.Windows.Forms.TextBox();
            loginButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            registerButton = new Dtat.Windows.Forms.Button();
            exitButton = new Dtat.Windows.Forms.Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(14, 12);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(75, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "&Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(14, 51);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "&Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            usernameTextBox.Location = new System.Drawing.Point(86, 8);
            usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(362, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            passwordTextBox.Location = new System.Drawing.Point(86, 47);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(362, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new System.Drawing.Point(86, 85);
            loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(86, 31);
            loginButton.TabIndex = 4;
            loginButton.Text = "&Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(178, 85);
            resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(86, 31);
            resetButton.TabIndex = 5;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.Location = new System.Drawing.Point(271, 85);
            registerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(86, 31);
            registerButton.TabIndex = 6;
            registerButton.Text = "Re&gister";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(363, 85);
            exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(86, 31);
            exitButton.TabIndex = 7;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 118);
            Controls.Add(exitButton);
            Controls.Add(registerButton);
            Controls.Add(resetButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(912, 165);
            MinimumSize = new System.Drawing.Size(468, 165);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label usernameLabel;
        private Dtat.Windows.Forms.Label passwordLabel;
        private Dtat.Windows.Forms.TextBox usernameTextBox;
        private Dtat.Windows.Forms.TextBox passwordTextBox;
        private Dtat.Windows.Forms.Button loginButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.Button registerButton;
        private Dtat.Windows.Forms.Button exitButton;
    }
}