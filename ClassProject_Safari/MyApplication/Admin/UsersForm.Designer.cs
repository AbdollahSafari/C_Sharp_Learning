namespace MyApplication.Admin
{
    partial class UsersForm
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
            fullNameTextBox = new Dtat.Windows.Forms.TextBox();
            searchButton = new Dtat.Windows.Forms.Button();
            usersDataGridView = new Dtat.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
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
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fullNameTextBox.Location = new System.Drawing.Point(94, 6);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new System.Drawing.Size(488, 27);
            fullNameTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(94, 39);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(94, 29);
            searchButton.TabIndex = 2;
            searchButton.Text = "&Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AllowUserToDeleteRows = false;
            usersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Location = new System.Drawing.Point(0, 74);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.ReadOnly = true;
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.RowTemplate.Height = 29;
            usersDataGridView.Size = new System.Drawing.Size(582, 279);
            usersDataGridView.TabIndex = 3;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(582, 353);
            Controls.Add(usersDataGridView);
            Controls.Add(searchButton);
            Controls.Add(fullNameTextBox);
            Controls.Add(fullNameLabel);
            MinimumSize = new System.Drawing.Size(600, 400);
            Name = "UsersForm";
            Text = "Users List";
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label fullNameLabel;
        private Dtat.Windows.Forms.TextBox fullNameTextBox;
        private Dtat.Windows.Forms.Button searchButton;
        private Dtat.Windows.Forms.DataGridView usersDataGridView;
    }
}