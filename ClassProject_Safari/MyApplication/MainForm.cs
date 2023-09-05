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

public partial class MainForm : Infrastructure.BaseForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    private UpdateProfileForm? MyUpdateProfileForm { get; set; }
    private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MyUpdateProfileForm == null || MyUpdateProfileForm.IsDisposed)
        {
            MyUpdateProfileForm = new UpdateProfileForm()
            {
                MdiParent = this,
            };
        }
        MyUpdateProfileForm.Show();
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var messageBoxResult = System.Windows.Forms.MessageBox.Show(
            "Are you sure to log out?", "Log out confirmatoin", MessageBoxButtons.OKCancel);
        if (messageBoxResult == DialogResult.OK)
        {
            Close();
            Infrastructure.Utility.AauthenticatedUser = null;
            var loginForm = new LoginForm();
            loginForm.Show();
        }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var messageBoxResult = System.Windows.Forms.MessageBox.Show(
            "Are you sure to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
        if (messageBoxResult == DialogResult.Yes)
        {
            Close();
            Infrastructure.Utility.AauthenticatedUser = null;
        }
    }

    private ChangePasswordForm? MyChangePasswordForm { get; set; }
    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MyChangePasswordForm == null || MyChangePasswordForm.IsDisposed)
        {
            MyChangePasswordForm = new ChangePasswordForm() 
            {
                MdiParent = this,
            };
            MyChangePasswordForm.Show();
        }
    }
}
