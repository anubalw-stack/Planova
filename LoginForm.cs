using System;
using System.IO;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPW.Text.Trim();

            // Check that both fields have been filled in
            if (email == "" || email == "E-mail" ||
                password == "" || password == "Password")
            {
                MessageBox.Show(
                    "Please enter your email and password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Location of the CSV file
            string filePath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.FullName,
                "users.csv"
            );

            // Check if the CSV file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    "User database file could not be found in " + filePath,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Look up the matching row and build a UserAccount object (e.g. u1) from it
            UserAccount account = UserAccount.FindByEmail(email, filePath);

            // account.Login() compares the password and, on success, sets Session.CurrentUser
            if (account != null && account.Login(password))
            {
                MessageBox.Show(
                    "Login successful!",
                    "Welcome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Open the home page
                HomePage homeForm = new HomePage();

                // Hide login form while the user is logged in
                this.Hide();

                // Show home page
                homeForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Invalid email or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void forgotPW_Click(object sender, EventArgs e)
        {
            // Pre-fill the email field if the user already typed one in
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm(textBoxEmail.Text.Trim());
            forgotPasswordForm.ShowDialog();
        }

        private void signupLink_Click(object sender, EventArgs e)
        {
            // Open RegisterForm
            RegisterForm registerForm = new RegisterForm();

            this.Hide();

            registerForm.ShowDialog();
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == " E-mail")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = " E-mail";
            }
        }
        private void textBoxPW_Enter(object sender, EventArgs e)
        {
            if (textBoxPW.Text == " Password")
            {
                textBoxPW.Text = "";
            }
        }

        private void textBoxPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPW.Text))
            {
                textBoxPW.Text = " Password";
            }
        }

        private void PlanovaLogo_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}