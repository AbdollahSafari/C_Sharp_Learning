namespace MyApplication;

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
        usernameLabel.Location = new System.Drawing.Point(12, 9);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new System.Drawing.Size(75, 20);
        usernameLabel.TabIndex = 0;
        usernameLabel.Text = "&Username";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new System.Drawing.Point(12, 42);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new System.Drawing.Size(70, 20);
        passwordLabel.TabIndex = 1;
        passwordLabel.Text = "&Password";
        // 
        // usernameTextBox
        // 
        usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        usernameTextBox.Location = new System.Drawing.Point(93, 6);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new System.Drawing.Size(394, 27);
        usernameTextBox.TabIndex = 2;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        passwordTextBox.Location = new System.Drawing.Point(93, 39);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new System.Drawing.Size(394, 27);
        passwordTextBox.TabIndex = 3;
        // 
        // loginButton
        // 
        loginButton.Location = new System.Drawing.Point(93, 72);
        loginButton.Name = "loginButton";
        loginButton.Size = new System.Drawing.Size(94, 29);
        loginButton.TabIndex = 4;
        loginButton.Text = "&Login";
        loginButton.UseVisualStyleBackColor = true;
        // 
        // resetButton
        // 
        resetButton.Location = new System.Drawing.Point(193, 72);
        resetButton.Name = "resetButton";
        resetButton.Size = new System.Drawing.Size(94, 29);
        resetButton.TabIndex = 5;
        resetButton.Text = "&Reset";
        resetButton.UseVisualStyleBackColor = true;
        // 
        // registerButton
        // 
        registerButton.Location = new System.Drawing.Point(293, 72);
        registerButton.Name = "registerButton";
        registerButton.Size = new System.Drawing.Size(94, 29);
        registerButton.TabIndex = 6;
        registerButton.Text = "Re&gister";
        registerButton.UseVisualStyleBackColor = true;
        // 
        // exitButton
        // 
        exitButton.Location = new System.Drawing.Point(393, 72);
        exitButton.Name = "exitButton";
        exitButton.Size = new System.Drawing.Size(94, 29);
        exitButton.TabIndex = 7;
        exitButton.Text = "E&xit";
        exitButton.UseVisualStyleBackColor = true;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(494, 104);
        Controls.Add(exitButton);
        Controls.Add(registerButton);
        Controls.Add(resetButton);
        Controls.Add(loginButton);
        Controls.Add(passwordTextBox);
        Controls.Add(usernameTextBox);
        Controls.Add(passwordLabel);
        Controls.Add(usernameLabel);
        MaximumSize = new System.Drawing.Size(800, 151);
        MinimumSize = new System.Drawing.Size(512, 151);
        Name = "LoginForm";
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