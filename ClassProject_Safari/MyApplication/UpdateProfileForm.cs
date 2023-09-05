using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            if (Infrastructure.Utility.AauthenticatedUser == null)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }

            Persistence.DatabaseContext? databaseContext = null;
            try
            {
                var currentUser = Infrastructure.Utility.AauthenticatedUser;

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                    return;
                }
                if (currentUser.IsActive == false)
                {
                    System.Windows.Forms.Application.Exit();
                    return;
                }
                fullNameTextBox.Text = currentUser.FullName;

                descriptionTextBox.Text = currentUser.Description;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                databaseContext?.Dispose();
                databaseContext = null;
            }
        }
        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Infrastructure.Utility.AauthenticatedUser == null)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }
            if (Infrastructure.Utility.AauthenticatedUser.IsActive == false)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }

            Persistence.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext = new Persistence.DatabaseContext();
                var curretnUser = databaseContext.Users.Where(u => u.Id == Infrastructure.Utility.AauthenticatedUser.Id).FirstOrDefault();
                if (curretnUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                    return;
                }
                if (curretnUser.IsActive == false)
                {
                    System.Windows.Forms.Application.Exit();
                    return;
                }
                fullNameTextBox.Text = Infrastructure.Utility.FixText(fullNameTextBox.Text);
                descriptionTextBox.Text = Infrastructure.Utility.FixText(descriptionTextBox.Text);

                curretnUser.FullName = fullNameTextBox.Text;
                curretnUser.Description = descriptionTextBox.Text;
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Your profile is updated successfully...");
                Infrastructure.Utility.AauthenticatedUser = curretnUser;
                Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error {ex.Message}");
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext?.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
