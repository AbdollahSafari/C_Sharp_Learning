namespace MyApplication.Admin
{
    partial class UpdateUserForm
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
            isActiveCheckBox = new Dtat.Windows.Forms.CheckBox();
            isAdminCheckBox = new Dtat.Windows.Forms.CheckBox();
            updateButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            deleteButton = new Dtat.Windows.Forms.Button();
            resetPasswordButton = new Dtat.Windows.Forms.Button();
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
            descriptionLabel.Location = new System.Drawing.Point(12, 42);
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
            fullNameTextBox.Size = new System.Drawing.Size(427, 27);
            fullNameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            descriptionTextBox.Location = new System.Drawing.Point(103, 39);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            descriptionTextBox.Size = new System.Drawing.Size(427, 118);
            descriptionTextBox.TabIndex = 3;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Location = new System.Drawing.Point(103, 163);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new System.Drawing.Size(72, 24);
            isActiveCheckBox.TabIndex = 4;
            isActiveCheckBox.Text = "Active";
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAdminCheckBox
            // 
            isAdminCheckBox.AutoSize = true;
            isAdminCheckBox.Location = new System.Drawing.Point(103, 193);
            isAdminCheckBox.Name = "isAdminCheckBox";
            isAdminCheckBox.Size = new System.Drawing.Size(75, 24);
            isAdminCheckBox.TabIndex = 5;
            isAdminCheckBox.Text = "Admin";
            isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new System.Drawing.Point(103, 223);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(94, 29);
            updateButton.TabIndex = 6;
            updateButton.Text = "&Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(203, 223);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(94, 29);
            resetButton.TabIndex = 7;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(436, 223);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(94, 29);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "De&lete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.Location = new System.Drawing.Point(303, 223);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new System.Drawing.Size(127, 29);
            resetPasswordButton.TabIndex = 8;
            resetPasswordButton.Text = "Reset &Password";
            resetPasswordButton.UseVisualStyleBackColor = true;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(533, 253);
            Controls.Add(resetPasswordButton);
            Controls.Add(deleteButton);
            Controls.Add(resetButton);
            Controls.Add(updateButton);
            Controls.Add(isAdminCheckBox);
            Controls.Add(isActiveCheckBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(fullNameLabel);
            MaximumSize = new System.Drawing.Size(800, 300);
            MinimumSize = new System.Drawing.Size(420, 300);
            Name = "UpdateUserForm";
            Text = "Update User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label fullNameLabel;
        private Dtat.Windows.Forms.Label descriptionLabel;
        private Dtat.Windows.Forms.TextBox fullNameTextBox;
        private Dtat.Windows.Forms.TextBox descriptionTextBox;
        private Dtat.Windows.Forms.CheckBox isActiveCheckBox;
        private Dtat.Windows.Forms.CheckBox isAdminCheckBox;
        private Dtat.Windows.Forms.Button updateButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.Button deleteButton;
        private Dtat.Windows.Forms.Button resetPasswordButton;
    }
}