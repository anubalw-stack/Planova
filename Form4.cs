using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            // Event IDs from events.csv
            btnDJNight.Tag = "msc001";
            btnBattleBands.Tag = "msc002";
            btnStreetFestival.Tag = "msc003";
            btnRhythmNights.Tag = "msc004";
            btnSummerBeats.Tag = "msc005";
            btnComedyNight.Tag = "cdy001";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateLoginUI();

            txtSearch.Text = "Search events...";
            txtSearch.ForeColor = Color.Gray;
        }

        private void UpdateLoginUI()
        {
            if (Session.IsLoggedIn)
            {
                labelWelcome.Text =
                    "Welcome, " + Session.CurrentUser.Name;

                labelWelcome.Visible = true;
            }
            else
            {
                labelWelcome.Text = "";
                labelWelcome.Visible = false;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }


        // OPEN EVENT DETAILS
        private void button4_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (clicked == null || clicked.Tag == null)
            {
                return;
            }

            string eventId = clicked.Tag.ToString();

            EventDetailsForm eventDetailsForm =
                new EventDetailsForm(eventId);

            eventDetailsForm.Show();

            this.Hide();
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }


        // SEARCH EVENTS
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search events...")
            {
                return;
            }

            string search = txtSearch.Text.Trim();

            bool djMatch =
                EventMatches(lblDJNightName.Text, search);

            bool battleMatch =
                EventMatches(lblBattleBandsName.Text, search);

            bool streetMatch =
                EventMatches(lblStreetFestivalName.Text, search);

            bool rhythmMatch =
                EventMatches(lblRhythmNightsName.Text, search);

            bool summerMatch =
                EventMatches(lblSummerBeatsName.Text, search);

            bool comedyMatch =
                EventMatches(lblComedyNightName.Text, search);


            int y = 20;


            ShowEvent(
                djMatch,
                picDJNight,
                lblDJNightName,
                lblDJNightDate,
                lblDJNightLocation,
                lblDJNightPrice,
                btnDJNight,
                ref y
            );

            ShowEvent(
                battleMatch,
                picBattleBands,
                lblBattleBandsName,
                lblBattleBandsDate,
                lblBattleBandsLocation,
                lblBattleBandsPrice,
                btnBattleBands,
                ref y
            );

            ShowEvent(
                streetMatch,
                picStreetFestival,
                lblStreetFestivalName,
                lblStreetFestivalDate,
                lblStreetFestivalLocation,
                lblStreetFestivalPrice,
                btnStreetFestival,
                ref y
            );

            ShowEvent(
                rhythmMatch,
                picRhythmNights,
                lblRhythmNightsName,
                lblRhythmNightsDate,
                lblRhythmNightsLocation,
                lblRhythmNightsPrice,
                btnRhythmNights,
                ref y
            );

            ShowEvent(
                summerMatch,
                picSummerBeats,
                lblSummerBeatsName,
                lblSummerBeatsDate,
                lblSummerBeatsLocation,
                lblSummerBeatsPrice,
                btnSummerBeats,
                ref y
            );

            ShowEvent(
                comedyMatch,
                picComedyNight,
                lblComedyNightName,
                lblComedyNightDate,
                lblComedyNightLocation,
                lblComedyNightPrice,
                btnComedyNight,
                ref y
            );


            pnlEvents.AutoScrollPosition =
                new Point(0, 0);
        }


        // CHECK EVENT NAME
        private bool EventMatches(
            string eventName,
            string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                return true;
            }

            string[] words = eventName.Split(' ');

            foreach (string word in words)
            {
                if (word.StartsWith(
                    search,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }


        // SHOW / HIDE EVENT
        private void ShowEvent(
            bool show,
            PictureBox picture,
            Label name,
            Label date,
            Label location,
            Label price,
            Button button,
            ref int y)
        {
            picture.Visible = show;
            name.Visible = show;
            date.Visible = show;
            location.Visible = show;
            price.Visible = show;
            button.Visible = show;

            if (show)
            {
                picture.Location =
                    new Point(20, y);

                name.Location =
                    new Point(190, y);

                date.Location =
                    new Point(190, y + 35);

                location.Location =
                    new Point(190, y + 55);

                price.Location =
                    new Point(190, y + 75);

                button.Location =
                    new Point(760, y + 5);

                y += 145;
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {
        }


        // SEARCH PLACEHOLDER
        private void txtSearch_Enter(
            object sender,
            EventArgs e)
        {
            if (txtSearch.Text == "Search events...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }


        private void txtSearch_Leave(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search events...";
                txtSearch.ForeColor = Color.Gray;
            }
        }


        // HOME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();

            homePage.Show();

            this.Hide();
        }
    }
}