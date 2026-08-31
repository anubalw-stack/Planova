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

            iconButton2.Click += iconButton2_Click;
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;

            // contextMenuStrip2 is the menu actually shown from iconButton2 (see iconButton2_Click below)
            registerToolStripMenuItem1.Click += registerToolStripMenuItem1_Click;
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;

            this.Load += HomePage_Load;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            UpdateLoginUI();
        }

        // Shows/hides the "Welcome, Name" label based on whether someone is logged in
        private void UpdateLoginUI()
        {
            if (Session.IsLoggedIn)
            {
                labelWelcome.Text = $"Welcome, {Session.CurrentUser.Name}";
                labelWelcome.Visible = true;
            }
            else
            {
                labelWelcome.Text = string.Empty;
                labelWelcome.Visible = false;
            }

            PositionWelcomeLabel();
        }

        // labelWelcome is AutoSize, so its width changes with the name — recompute Left
        // each time so it stays flush against the right edge instead of drifting.
        private void PositionWelcomeLabel()
        {
            const int rightMargin = 20;
            labelWelcome.Left = this.ClientSize.Width - labelWelcome.Width - rightMargin;
        }

        // Fires every time the menu is about to open, so it always reflects the current session state
        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            registerToolStripMenuItem1.Visible = !Session.IsLoggedIn;
            loginToolStripMenuItem1.Visible = !Session.IsLoggedIn;
            logoutToolStripMenuItem.Visible = Session.IsLoggedIn;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(
                iconButton2,
                new Point(
                    iconButton2.Width - contextMenuStrip2.Width,
                    iconButton2.Height
                )
            );
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

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Logout();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}