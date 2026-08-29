using System;
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

      
    }
}