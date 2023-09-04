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
}
