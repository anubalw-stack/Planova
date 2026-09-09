using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

           

            // Placeholders
            SetPlaceholder(txtName, "Full Name");
            SetPlaceholder(txtBirthdate, "Date Of Birth");
            SetPlaceholder(txtEmail, "E-mail");
            SetPlaceholder(txtCurrentpassword, "Current Password");
            SetPlaceholder(txtNewpassword, "New Password");
            SetPlaceholder(txtConfirmpassword, "Confirm Password");

            // Placeholder events
            txtName.Enter += TextBox_Enter;
            txtBirthdate.Enter += TextBox_Enter;
            txtEmail.Enter += TextBox_Enter;
            txtCurrentpassword.Enter += TextBox_Enter;
            txtNewpassword.Enter += TextBox_Enter;
            txtConfirmpassword.Enter += TextBox_Enter;

            txtName.Leave += TextBox_Leave;
            txtBirthdate.Leave += TextBox_Leave;
            txtEmail.Leave += TextBox_Leave;
            txtCurrentpassword.Leave += TextBox_Leave;
            txtNewpassword.Leave += TextBox_Leave;
            txtConfirmpassword.Leave += TextBox_Leave;
        }


        private void SetPlaceholder(TextBox box, string text)
        {
            box.Text = text;
            box.ForeColor = Color.DimGray;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.ForeColor == Color.DimGray)
            {
                box.Text = "";
                box.ForeColor = Color.Black;

                if (box == txtCurrentpassword ||
                    box == txtNewpassword ||
                    box == txtConfirmpassword)
                {
                    box.PasswordChar = '*';
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(box.Text))
            {
                if (box == txtName)
                    SetPlaceholder(box, "Full Name");

                else if (box == txtBirthdate)
                    SetPlaceholder(box, "Date Of Birth");

                else if (box == txtEmail)
                    SetPlaceholder(box, "E-mail");

                else if (box == txtCurrentpassword)
                {
                    box.PasswordChar = '\0';
                    SetPlaceholder(box, "Current Password");
                }

                else if (box == txtNewpassword)
                {
                    box.PasswordChar = '\0';
                    SetPlaceholder(box, "New Password");
                }

                else if (box == txtConfirmpassword)
                {
                    box.PasswordChar = '\0';
                    SetPlaceholder(box, "Confirm Password");
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCurrentpassword_Click(object sender, EventArgs e)
        {
            if (txtCurrentpassword.PasswordChar == '*')
                txtCurrentpassword.PasswordChar = '\0';
            else
                txtCurrentpassword.PasswordChar = '*';
        }

        private void btnNewpassword_Click(object sender, EventArgs e)
        {
            if (txtNewpassword.PasswordChar == '*')
                txtNewpassword.PasswordChar = '\0';
            else
                txtNewpassword.PasswordChar = '*';
        }

        private void btnConfirmpassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmpassword.PasswordChar == '*')
                txtConfirmpassword.PasswordChar = '\0';
            else
                txtConfirmpassword.PasswordChar = '*';
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check Full Name
            if (txtName.Text == "Full Name" ||
                string.IsNullOrWhiteSpace(txtName.Text)) 
            {
                MessageBox.Show("Please enter your full name.");
                return;
            }

            // Check Email
            if (txtEmail.Text == "E-mail" ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            // Basic email validation
            if (!txtEmail.Text.Contains("@") ||
                !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check Date of Birth
            if (txtBirthdate.Text == "Date Of Birth" ||
                string.IsNullOrWhiteSpace(txtBirthdate.Text))
            {
                MessageBox.Show("Please enter your date of birth.");
                return;
            }

            // Check Current Password
            if (txtCurrentpassword.Text == "Current Password" ||
                string.IsNullOrWhiteSpace(txtCurrentpassword.Text))
            {
                MessageBox.Show("Please enter your current password.");
                return;
            }

            // Check New Password
            if (txtNewpassword.Text == "New Password" ||
                string.IsNullOrWhiteSpace(txtNewpassword.Text))
            {
                MessageBox.Show("Please enter your new password.");
                return;
            }

            // Password length
            if (txtNewpassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long."
                );
                return;
            }

            // Check Confirm Password
            if (txtConfirmpassword.Text == "Confirm Password" ||
                string.IsNullOrWhiteSpace(txtConfirmpassword.Text))
            {
                MessageBox.Show("Please confirm your new password.");
                return;
            }

            // Check if passwords match
            if (txtNewpassword.Text != txtConfirmpassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Everything is valid
            MessageBox.Show(
                "Account details are valid!",
                "Planova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
    }
