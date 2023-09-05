using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication;

public partial class ChangePasswordForm : Infrastructure.BaseForm
{
    public ChangePasswordForm()
    {
        InitializeComponent();
    }
    private void ChangePasswordForm_Load(object sender, EventArgs e)
    {
        var currentUser = Infrastructure.Utility.AauthenticatedUser;
        if (currentUser == null)
        {
            System.Windows.Forms.Application.Exit();
        }
        if (currentUser.IsActive == false)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        oldPasswordTextBox.Text =
            Infrastructure.Utility.FixText(oldPasswordTextBox.Text);
        newPasswordTextBox.Text =
            Infrastructure.Utility.FixText(newPasswordTextBox.Text);
        confirmPasswordTextBox.Text =
            Infrastructure.Utility.FixText(confirmPasswordTextBox.Text);

        var currentUser = Infrastructure.Utility.AauthenticatedUser;
        if (currentUser == null)
        {
            System.Windows.Forms.Application.Exit();
        }
        if (currentUser.IsActive == false)
        {
            System.Windows.Forms.Application.Exit();
        }

        var errorMessages = string.Empty;
        if (currentUser.Password != oldPasswordTextBox.Text)
        {
            errorMessages = "Old password is NOT correct!";
            oldPasswordTextBox.Text = string.Empty;
            oldPasswordTextBox.Focus();
        }
        else
        {
            if (newPasswordTextBox.Text.Length < 8)
            {
                if (errorMessages != null)
                {
                    errorMessages += System.Environment.NewLine;
                }
                errorMessages += "New password must be at least 8 character!";
                newPasswordTextBox.Text = string.Empty;
                newPasswordTextBox.Focus();
            }
            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                if (errorMessages != null)
                {
                    errorMessages += System.Environment.NewLine;
                }
                errorMessages += "New password and confirm does NOT match!";
                newPasswordTextBox.Focus();
            }
        }
        if (errorMessages != string.Empty)
        {
            System.Windows.Forms.MessageBox.Show(errorMessages);
        }

        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext = new Persistence.DatabaseContext();
            var foundedUser = databaseContext.Users.Where(u => u.Id == currentUser.Id).FirstOrDefault();
            if (foundedUser == null)
            {
                System.Windows.Forms.Application.Exit();
            }
            if (foundedUser.IsActive == false)
            {
                System.Windows.Forms.Application.Exit();
            }
            foundedUser.Password = newPasswordTextBox.Text;
            databaseContext.SaveChanges();
            Infrastructure.Utility.AauthenticatedUser = foundedUser;
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
        }
        finally
        {
            if (databaseContext != null)
            {
                databaseContext.Dispose();
                databaseContext = null;
            }
            System.Windows.Forms.MessageBox.Show("Your password hes been successfuly updated.");
            Close();
        }

    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        oldPasswordTextBox.Text = string.Empty;
        newPasswordTextBox.Text = string.Empty;
        confirmPasswordTextBox.Text = string.Empty;
        oldPasswordTextBox.Focus();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
