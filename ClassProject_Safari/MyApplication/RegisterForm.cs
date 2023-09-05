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

public partial class RegisterForm : Infrastructure.BaseForm
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void ResetForm()
    {
        usernameTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
        fullNameTextBox.Text = string.Empty;
        usernameTextBox.Focus();
    }
    private void loginButton_Click(object sender, EventArgs e)
    {
        Hide();
        var loginForm = new LoginForm();
        loginForm.Show();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        usernameTextBox.Text =
            Infrastructure.Utility.FixText(usernameTextBox.Text);

        passwordTextBox.Text =
            Infrastructure.Utility.FixText(passwordTextBox.Text);

        fullNameTextBox.Text =
            Infrastructure.Utility.FixText(fullNameTextBox.Text);

        if (usernameTextBox.Text == string.Empty 
            || passwordTextBox.Text == string.Empty)
        {
            var errorMessage =
                "Username and Password are required!";

            System.Windows.Forms.MessageBox.Show(errorMessage);
            
            if (usernameTextBox.Text == string.Empty)
            {
                usernameTextBox.Focus();
            }
            else
            {
                passwordTextBox.Focus();
            }
            return;
        }

        var errorMessages = string.Empty;
        if (usernameTextBox.Text.Length < 6)
        {
            errorMessages = "Your username must be at least 6 character!";
        }

        if (passwordTextBox.Text.Length < 8)
        {
            if (errorMessages != string.Empty)
            {
                errorMessages += System.Environment.NewLine;
            }
            errorMessages += "Your password must be at least 8 character!";
        }
        if (errorMessages != string.Empty)
        {
            System.Windows.Forms.MessageBox.Show(errorMessages);
            usernameTextBox.Focus();
            return;
        }

        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext = new Persistence.DatabaseContext();

            var foundedUser = databaseContext.Users
                .Where(u => u.Username.ToLower() == usernameTextBox.Text.ToLower()).FirstOrDefault();
            if (foundedUser != null)
            {
                var errorMassage =
                    "The username is already exist! Please choos another one.";
                System.Windows.Forms.MessageBox.Show(errorMassage);
                usernameTextBox.Focus();
                return;
            }


            var newUser =
                new Domain.User(usernameTextBox.Text, passwordTextBox.Text)
                {
                    FullName = fullNameTextBox.Text,
                    IsActive = true,
                };
            databaseContext.Add(newUser);
            databaseContext.SaveChanges();
            System.Windows.Forms.MessageBox.Show("New user has successfully added.");
            Close();
            var loginForm = new LoginForm();
            loginForm.Show();
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
        }

        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
