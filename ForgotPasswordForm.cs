using System;
using System.IO;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm() : this(string.Empty)
        {
        }

        public ForgotPasswordForm(string initialEmail)
        {
            InitializeComponent();
            textBoxEmail.Text = initialEmail;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string newPassword = textBoxNewPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();

            if (email == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.FullName,
                "users.csv"
            );

            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    "User database file could not be found in " + filePath,
                    "Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            bool updated = UserAccount.UpdatePassword(email, newPassword, filePath);

            if (updated)
            {
                MessageBox.Show(
                    "Your password has been reset. You can now log in.",
                    "Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No account found with that email.",
                    "Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}