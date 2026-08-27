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

            bool loginSuccessful = false;

            // Read each line of the CSV file
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Skip the header row
                if (line.StartsWith("Email,"))
                {
                    continue;
                }

                string[] data = line.Split(',');

                // Make sure the row contains email and password
                if (data.Length >= 2)
                {
                    string csvEmail = data[0].Trim();
                    string csvPassword = data[1].Trim();

                    // Compare entered credentials with CSV credentials
                    if (email.Equals(csvEmail, StringComparison.OrdinalIgnoreCase)
                        && password == csvPassword)
                    {
                        loginSuccessful = true;
                        break;
                    }
                }
            }

            if (loginSuccessful)
            {
                // Store the logged-in user's email
                Session.LoggedInEmail = email;

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
            MessageBox.Show(
                "Password recovery is not available yet.",
                "Forgot Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
    }
}
