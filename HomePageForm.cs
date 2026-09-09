using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;

            contextMenuStrip1.Opening += contextMenuStrip1_Opening;

            this.Load += HomePage_Load;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            UpdateLoginUI();
        }

        private void UpdateLoginUI()
        {
            if (Session.IsLoggedIn)
            {
                labelWelcome.Text = "Welcome, " + Session.CurrentUser.Name;
                labelWelcome.Visible = true;
            }
            else
            {
                labelWelcome.Text = "";
                labelWelcome.Visible = false;
            }

            PositionWelcomeLabel();
        }

        private void PositionWelcomeLabel()
        {
            int rightMargin = 20;

            labelWelcome.Left =
                this.ClientSize.Width - labelWelcome.Width - rightMargin;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            registerToolStripMenuItem.Visible = !Session.IsLoggedIn;
            loginToolStripMenuItem.Visible = !Session.IsLoggedIn;
            logoutToolStripMenuItem.Visible = Session.IsLoggedIn;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(
                iconButton2,
                new Point(
                    iconButton2.Width - contextMenuStrip1.Width,
                    iconButton2.Height
                )
            );
        }

        // iconButton1 is the "User" icon — opens a small menu with just "Profile"
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show(
                    "Please log in to view your profile.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                return;
            }

            profileMenuStrip.Show(
                iconButton1,
                new Point(
                    iconButton1.Width - profileMenuStrip.Width,
                    iconButton1.Height
                )
            );
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 profileForm = new Form9();
            profileForm.Show();
            this.Hide();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Logout();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            cartForm.Show();
            this.Hide();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}