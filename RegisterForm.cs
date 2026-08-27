using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            // Date of Birth placeholder
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "' Date Of Birth'";
            dtpDOB.ValueChanged += dtpDOB_ValueChanged;

            // Password placeholder
            txtpass.Text = " Password";
            txtpass.ForeColor = Color.DimGray;
            txtpass.PasswordChar = '\0';

            // Confirm Password placeholder
            txtpassconfirm.Text = " Confirm Password";
            txtpassconfirm.ForeColor = Color.DimGray;
            txtpassconfirm.PasswordChar = '\0';
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == " Full Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                txtname.Text = " Full Name";
                txtname.ForeColor = Color.DimGray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == " E-mail")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                txtemail.Text = " E-mail";
                txtemail.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == " Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
            }

            txtpass.PasswordChar = '*';
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                txtpass.PasswordChar = '\0';
                txtpass.Text = " Password";
                txtpass.ForeColor = Color.DimGray;
            }
        }

        private void txtpassconfirm_Enter(object sender, EventArgs e)
        {
            if (txtpassconfirm.Text == " Confirm Password")
            {
                txtpassconfirm.Text = "";
                txtpassconfirm.ForeColor = Color.Black;
            }

            txtpassconfirm.PasswordChar = '*';
        }

        private void txtpassconfirm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpassconfirm.Text))
            {
                txtpassconfirm.PasswordChar = '\0';
                txtpassconfirm.Text = " Confirm Password";
                txtpassconfirm.ForeColor = Color.DimGray;
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dd/MM/yyyy";
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            // Check Full Name
            if (txtname.Text == " Full Name" ||
                string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter your full name.");
                return;
            }

            // Check Email
            if (txtemail.Text == " E-mail" ||
                string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            // Basic email validation
            if (!txtemail.Text.Contains("@") ||
                !txtemail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check Date of Birth
            if (dtpDOB.CustomFormat == "' Date Of Birth'")
            {
                MessageBox.Show("Please select your date of birth.");
                return;
            }

            if (dtpDOB.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Please select a valid date of birth.");
                return;
            }

            // Check Password
            if (txtpass.Text == " Password" ||
                string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            // Password length
            if (txtpass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            // Check Confirm Password
            if (txtpassconfirm.Text == " Confirm Password" ||
                string.IsNullOrWhiteSpace(txtpassconfirm.Text))
            {
                MessageBox.Show("Please confirm your password.");
                return;
            }

            // Check if passwords match
            if (txtpass.Text != txtpassconfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Registration successful
            MessageBox.Show(
                "Registration successful!\n\nWelcome, " +
                txtname.Text.Trim() + "!",
                "Planova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btneye_Click_1(object sender, EventArgs e)
        {
            // Do nothing if placeholder is showing
            if (txtpass.Text == " Password")
            {
                return;
            }

            // Show / hide password
            if (txtpass.PasswordChar == '*')
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Hide();
            loginform.ShowDialog();
        }
        private void btneye2_Click(object sender, EventArgs e)
        {
            // Do nothing if placeholder is showing
            if (txtpassconfirm.Text == " Confirm Password")
            {
                return;
            }

            // Show / hide password
            if (txtpassconfirm.PasswordChar == '*')
            {
                txtpassconfirm.PasswordChar = '\0';
            }
            else
            {
                txtpassconfirm.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }
    }
}