using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            // Connect ContextMenuStrip items
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Open menu below hamburger button
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
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}