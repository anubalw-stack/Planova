using System;
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

            LoadEvent(eventId);
        }

        // TEMPORARY: lets you open this form without a caller yet. Remove once
        // there's a real events list/search page passing in the ID.
        public EventDetailsForm() : this("msc001")
        {
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

            // Book Now only makes sense once someone's logged in
            buttonBookNow.Visible = Session.IsLoggedIn;
        }

        // Images live in Properties.Resources; the CSV stores a file name like "cdy001.jpg",
        // so we strip the extension and look the resource up by its key.
        private Image LoadEventImage(string fileName)
        {
            string key = Path.GetFileNameWithoutExtension(fileName);
            object resource = Properties.Resources.ResourceManager.GetObject(key);
            return resource as Image;
        }

        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            // TODO: booking flow goes here
            MessageBox.Show(
                "Booking flow not implemented yet.",
                "Book Now",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}