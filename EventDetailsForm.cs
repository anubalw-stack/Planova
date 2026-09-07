using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class EventDetailsForm : Form
    {
        private Event currentEvent;

        public EventDetailsForm(string eventId)
        {
            InitializeComponent();
            buttonBookNow.Click += buttonBookNow_Click;

            iconButton1.Click += iconButton1_Click;
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            cartToolStripMenuItem.Click += cartToolStripMenuItem_Click;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            EventDetailsMenuStrip.Opening += EventDetailsMenuStrip_Opening;

            LoadEvent(eventId);
        }

        private void LoadEvent(string eventId)
        {
            string filePath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.FullName,
                "events.csv"
            );

            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    "Event database file could not be found in " + filePath,
                    "Event Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            currentEvent = Event.SelectEvent(eventId, filePath);

            if (currentEvent == null)
            {
                MessageBox.Show(
                    "No event was found with ID \"" + eventId + "\".",
                    "Event Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            PopulateDetails();
        }

        private void PopulateDetails()
        {
            eventName.Text = currentEvent.EventName;
            lblDate.Text = currentEvent.EventDate;
            lblTime.Text = currentEvent.EventTime;
            lblLocation.Text = currentEvent.EventLocation;
            lblAboutEvent.Text = currentEvent.EventDescription;

            pictureBoxEvent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEvent.Image = LoadEventImage(currentEvent.EventImg);
        }

        // Images live in Properties.Resources; the CSV stores a file name like "cdy001.jpg",
        // so we strip the extension and look the resource up by its key.
        private Image LoadEventImage(string fileName)
        {
            // Resources.resx names image keys after the file name with '.' swapped for '_'
            // (e.g. "cdy001.jpg" is stored as "cdy001_jpg"), so match that here.
            string key = fileName;
            object resource = Properties.Resources.ResourceManager.GetObject(key);

            return resource as Image;

        }

        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show(
                    "Please log in first to book this event.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
                return;
            }

            CartForm cart = new CartForm(currentEvent);
            cart.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void PlanovaLogo_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            EventDetailsMenuStrip.Show(
                iconButton1,
                new Point(iconButton1.Width - EventDetailsMenuStrip.Width, iconButton1.Height)
            );
        }

        // Fires every time the menu is about to open, so it always reflects current session state
        private void EventDetailsMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            registerToolStripMenuItem.Visible = !Session.IsLoggedIn;
            loginToolStripMenuItem.Visible = !Session.IsLoggedIn;
            logoutToolStripMenuItem.Visible = Session.IsLoggedIn;
            // homeToolStripMenuItem and cartToolStripMenuItem always show
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                CartForm cart = new CartForm(currentEvent);
                cart.Show();
                this.Close();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Logout();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}