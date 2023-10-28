namespace MyApplication
{
    partial class ChangePasswordForm
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
            oldPasswordLabel = new Dtat.Windows.Forms.Label();
            oldPasswordTextBox = new Dtat.Windows.Forms.TextBox();
            newPasswordLabel = new Dtat.Windows.Forms.Label();
            confirmPasswordTextBox = new Dtat.Windows.Forms.TextBox();
            confirmPasswordLabel = new Dtat.Windows.Forms.Label();
            newPasswordTextBox = new Dtat.Windows.Forms.TextBox();
            saveButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            cancelButton = new Dtat.Windows.Forms.Button();
            SuspendLayout();
            // 
            // oldPasswordLabel
            // 
            oldPasswordLabel.AutoSize = true;
            oldPasswordLabel.Location = new System.Drawing.Point(12, 9);
            oldPasswordLabel.Name = "oldPasswordLabel";
            oldPasswordLabel.Size = new System.Drawing.Size(98, 20);
            oldPasswordLabel.TabIndex = 0;
            oldPasswordLabel.Text = "Old Password";
            // 
            // oldPasswordTextBox
            // 
            oldPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            oldPasswordTextBox.Location = new System.Drawing.Point(145, 6);
            oldPasswordTextBox.Name = "oldPasswordTextBox";
            oldPasswordTextBox.Size = new System.Drawing.Size(294, 27);
            oldPasswordTextBox.TabIndex = 1;
            oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new System.Drawing.Point(12, 42);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new System.Drawing.Size(104, 20);
            newPasswordLabel.TabIndex = 2;
            newPasswordLabel.Text = "New Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            confirmPasswordTextBox.Location = new System.Drawing.Point(145, 72);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new System.Drawing.Size(294, 27);
            confirmPasswordTextBox.TabIndex = 5;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new System.Drawing.Point(12, 75);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new System.Drawing.Size(127, 20);
            confirmPasswordLabel.TabIndex = 4;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            newPasswordTextBox.Location = new System.Drawing.Point(145, 39);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new System.Drawing.Size(294, 27);
            newPasswordTextBox.TabIndex = 3;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(145, 105);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(94, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(245, 105);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(94, 29);
            resetButton.TabIndex = 7;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(345, 105);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(94, 29);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(443, 139);
            Controls.Add(cancelButton);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            Controls.Add(newPasswordTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(newPasswordLabel);
            Controls.Add(oldPasswordTextBox);
            Controls.Add(oldPasswordLabel);
            MaximumSize = new System.Drawing.Size(800, 186);
            MinimumSize = new System.Drawing.Size(461, 186);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label oldPasswordLabel;
        private Dtat.Windows.Forms.TextBox oldPasswordTextBox;
        private Dtat.Windows.Forms.Label newPasswordLabel;
        private Dtat.Windows.Forms.TextBox confirmPasswordTextBox;
        private Dtat.Windows.Forms.Label confirmPasswordLabel;
        private Dtat.Windows.Forms.TextBox newPasswordTextBox;
        private Dtat.Windows.Forms.Button saveButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.Button cancelButton;
    }
}