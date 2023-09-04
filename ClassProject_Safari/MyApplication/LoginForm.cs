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

public partial class LoginForm : Infrastructure.BaseForm
{
    public LoginForm()
    {
        InitializeComponent();
    }

    Persistence.DatabaseContext? databaseContext = null;

    private void loginButton_Click(object sender, EventArgs e)
    {
        usernameTextBox.Text =
            Infrastructure.Utility.FixText(usernameTextBox.Text);

        passwordTextBox.Text =
            Infrastructure.Utility.FixText(passwordTextBox.Text);

        if (passwordTextBox.Text == string.Empty || usernameTextBox.Text == string.Empty)
        {
            var errorMessage = "Username and Password is required!";
            System.Windows.Forms.MessageBox.Show(errorMessage);
        }
        try
        {
            databaseContext = new Persistence.DatabaseContext();

            var foundedUser = databaseContext.Users.
                Where(c => c.Username.ToLower() == usernameTextBox.Text.ToLower()).FirstOrDefault();

            if (foundedUser == null)
            {
                var errorMessage = "Username and/or Password is NOT correct!";
                System.Windows.Forms.MessageBox.Show(errorMessage);
                usernameTextBox.Focus();
                return;
            }

            if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
            {
                var errorMessage = "Username and/or Password is NOT correct!";
                System.Windows.Forms.MessageBox.Show(errorMessage);
                usernameTextBox.Focus();
                return;
            }

            if (foundedUser.IsActive == false)
            {
                var errorMessage = "You can not login right now! Please contact support.";
                System.Windows.Forms.MessageBox.Show(errorMessage);
                usernameTextBox.Focus();
                return;
            }

            Hide();
            Infrastructure.Utility.AauthenticatedUser = foundedUser;
            var mainForm = new MainForm();
            mainForm.Show();
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Error {ex.Message}");
            throw;
        }
        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }
    }

    private void ResetForm()
    {
        usernameTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
        usernameTextBox.Focus();
    }
    private void resetButton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        Hide();
        var registerForm = new RegisterForm();
        registerForm.Show();
    }
}
