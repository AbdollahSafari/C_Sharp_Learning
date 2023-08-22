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
            passwordLabel = new Dtat.Windows.Forms.Label();
            fullNameLabel = new Dtat.Windows.Forms.Label();
            textBox1 = new Dtat.Windows.Forms.TextBox();
            textBox2 = new Dtat.Windows.Forms.TextBox();
            textBox3 = new Dtat.Windows.Forms.TextBox();
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
            usernameLabel.Size = new System.Drawing.Size(60, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "&Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 38);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "&Password";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(12, 67);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(61, 15);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "&Full Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(79, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(318, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox2.Location = new System.Drawing.Point(79, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(318, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox3.Location = new System.Drawing.Point(79, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(318, 23);
            textBox3.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new System.Drawing.Point(79, 93);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(75, 23);
            registerButton.TabIndex = 6;
            registerButton.Text = "&Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(160, 93);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(75, 23);
            resetButton.TabIndex = 7;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Location = new System.Drawing.Point(241, 93);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(75, 23);
            loginButton.TabIndex = 8;
            loginButton.Text = "&Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(322, 93);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(75, 23);
            exitButton.TabIndex = 9;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AcceptButton = registerButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new System.Drawing.Size(401, 120);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(resetButton);
            Controls.Add(registerButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(fullNameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            MaximumSize = new System.Drawing.Size(800, 159);
            MinimumSize = new System.Drawing.Size(417, 159);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label usernameLabel;
        private Dtat.Windows.Forms.Label passwordLabel;
        private Dtat.Windows.Forms.Label fullNameLabel;
        private Dtat.Windows.Forms.TextBox textBox1;
        private Dtat.Windows.Forms.TextBox textBox2;
        private Dtat.Windows.Forms.TextBox textBox3;
        private Dtat.Windows.Forms.Button registerButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.Button loginButton;
        private Dtat.Windows.Forms.Button exitButton;
    }
}