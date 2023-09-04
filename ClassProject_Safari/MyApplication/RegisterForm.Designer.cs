namespace MyApplication
{
    partial class RegisterForm
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
            usernameTextBox = new Dtat.Windows.Forms.TextBox();
            passwordLabel = new Dtat.Windows.Forms.Label();
            passwordTextBox = new Dtat.Windows.Forms.TextBox();
            fullNameLabel = new Dtat.Windows.Forms.Label();
            fullNameTextBox = new Dtat.Windows.Forms.TextBox();
            registerButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            loginButton = new Dtat.Windows.Forms.Button();
            exitButton = new Dtat.Windows.Forms.Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(12, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(75, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "&Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            usernameTextBox.Location = new System.Drawing.Point(94, 6);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(394, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 42);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "&Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            passwordTextBox.Location = new System.Drawing.Point(94, 39);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(394, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(12, 75);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(76, 20);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "&Full Name";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fullNameTextBox.Location = new System.Drawing.Point(94, 72);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new System.Drawing.Size(394, 27);
            fullNameTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new System.Drawing.Point(94, 105);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(94, 29);
            registerButton.TabIndex = 6;
            registerButton.Text = "Re&gister";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(194, 105);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(94, 29);
            resetButton.TabIndex = 7;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new System.Drawing.Point(294, 105);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(94, 29);
            loginButton.TabIndex = 8;
            loginButton.Text = "&Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(394, 105);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(94, 29);
            exitButton.TabIndex = 9;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AcceptButton = registerButton;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new System.Drawing.Size(491, 138);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(resetButton);
            Controls.Add(registerButton);
            Controls.Add(fullNameTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            MaximumSize = new System.Drawing.Size(800, 185);
            MinimumSize = new System.Drawing.Size(509, 185);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label usernameLabel;
        private Dtat.Windows.Forms.TextBox usernameTextBox;
        private Dtat.Windows.Forms.Label passwordLabel;
        private Dtat.Windows.Forms.TextBox passwordTextBox;
        private Dtat.Windows.Forms.Label fullNameLabel;
        private Dtat.Windows.Forms.TextBox fullNameTextBox;
        private Dtat.Windows.Forms.Button registerButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.Button loginButton;
        private Dtat.Windows.Forms.Button exitButton;
    }
}