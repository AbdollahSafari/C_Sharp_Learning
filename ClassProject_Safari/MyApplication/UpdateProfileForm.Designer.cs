namespace MyApplication
{
    partial class UpdateProfileForm
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
            fullNameLabel = new Dtat.Windows.Forms.Label();
            descriptionLabel = new Dtat.Windows.Forms.Label();
            fullNameTextBox = new Dtat.Windows.Forms.TextBox();
            descriptionTextBox = new Dtat.Windows.Forms.TextBox();
            saveButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(12, 9);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(76, 20);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "&Full Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 45);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(85, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "&Description";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fullNameTextBox.Location = new System.Drawing.Point(103, 6);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new System.Drawing.Size(274, 27);
            fullNameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            descriptionTextBox.Location = new System.Drawing.Point(103, 42);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            descriptionTextBox.Size = new System.Drawing.Size(274, 105);
            descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(103, 153);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(94, 29);
            saveButton.TabIndex = 4;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(203, 153);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(94, 29);
            resetButton.TabIndex = 5;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // UpdateProfileForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = resetButton;
            ClientSize = new System.Drawing.Size(382, 188);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(fullNameLabel);
            MaximumSize = new System.Drawing.Size(800, 235);
            MinimumSize = new System.Drawing.Size(400, 235);
            Name = "UpdateProfileForm";
            Text = "Update Profile";
            Load += UpdateProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label fullNameLabel;
        private Dtat.Windows.Forms.Label descriptionLabel;
        private Dtat.Windows.Forms.TextBox fullNameTextBox;
        private Dtat.Windows.Forms.TextBox descriptionTextBox;
        private Dtat.Windows.Forms.Button saveButton;
        private Dtat.Windows.Forms.Button resetButton;
    }
}