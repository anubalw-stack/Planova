using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Make sure password events are connected
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;

            // Password starts as placeholder
            txtpass.Text = " Password";
            txtpass.ForeColor = Color.DimGray;
            txtpass.UseSystemPasswordChar = false;
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
            if (txtname.Text == "")
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
            if (txtemail.Text == "")
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

            // Hide password
            txtpass.UseSystemPasswordChar = true;
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                txtpass.UseSystemPasswordChar = false;
                txtpass.Text = " Password";
                txtpass.ForeColor = Color.DimGray;
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dd/MM/yyyy";
        }

        private void btneye_Click(object sender, EventArgs e)
        {
            // Do nothing if placeholder is showing
            if (txtpass.Text == " Password")
            {
                return;
            }

            // Show or hide password
            txtpass.UseSystemPasswordChar =
                !txtpass.UseSystemPasswordChar;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
         
            // Check Full Name
            if (txtname.Text == " Full Name" || string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter your full name.");
                return;
            }

            // Check Email
            if (txtemail.Text == " E-mail" || string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            // Basic email check
            if (!txtemail.Text.Contains("@") || !txtemail.Text.Contains("."))
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

            // Date of birth cannot be today or in the future
            if (dtpDOB.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Please select a valid date of birth.");
                return;
            }

            // Check Password
            if (txtpass.Text == " Password" || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            // Password must contain at least 6 characters
            if (txtpass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            // Everything is valid
            MessageBox.Show(
                "Registration successful!\n\nWelcome, " + txtname.Text.Trim() + "!",
                "Planova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
    }
