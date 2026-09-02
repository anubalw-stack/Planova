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
    public partial class Form4 : Form
    {

        private void OpenBookingPayment(
    string eventName,
    string location,
    string date,
    string price,
    Image image)
        {
            int eventPrice = int.Parse(
                price.Replace("$", "").Replace("NZD", "").Trim()
            );

            // Temporary quantity
            // Cart will provide the real quantity later
            int quantity = 1;

            BookingPayment payment = new BookingPayment(
                eventName,
                location,
                date,
                quantity,
                eventPrice,
                image
            );

            payment.Show();
            this.Hide();
        }
        public Form4()
        {
            InitializeComponent();

            txtSearch.Text = "Search events...";
            txtSearch.ForeColor = Color.Gray;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenBookingPayment(
        lblDJNightName.Text,
        lblDJNightLocation.Text,
        lblDJNightDate.Text,
        lblDJNightPrice.Text,
        picDJNight.Image
    );
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text == "Search events...")
                return;

            string search = txtSearch.Text.Trim();

            // Check which event names match the search
            bool djMatch = EventMatches(lblDJNightName.Text, search);
            bool battleMatch = EventMatches(lblBattleBandsName.Text, search);
            bool streetMatch = EventMatches(lblStreetFestivalName.Text, search);
            bool rhythmMatch = EventMatches(lblRhythmNightsName.Text, search);
            bool summerMatch = EventMatches(lblSummerBeatsName.Text, search);
            bool comedyMatch = EventMatches(lblComedyNightName.Text, search);

            int y = 20;

            ShowEvent(
                djMatch,
                picDJNight,
                lblDJNightName,
                lblDJNightDate,
                lblDJNightLocation,
                lblDJNightPrice,
                btnDJNight,
                ref y);

            ShowEvent(
                battleMatch,
                picBattleBands,
                lblBattleBandsName,
                lblBattleBandsDate,
                lblBattleBandsLocation,
                lblBattleBandsPrice,
                btnBattleBands,
                ref y);

            ShowEvent(
                streetMatch,
                picStreetFestival,
                lblStreetFestivalName,
                lblStreetFestivalDate,
                lblStreetFestivalLocation,
                lblStreetFestivalPrice,
                btnStreetFestival,
                ref y);

            ShowEvent(
                rhythmMatch,
                picRhythmNights,
                lblRhythmNightsName,
                lblRhythmNightsDate,
                lblRhythmNightsLocation,
                lblRhythmNightsPrice,
                btnRhythmNights,
                ref y);

            ShowEvent(
                summerMatch,
                picSummerBeats,
                lblSummerBeatsName,
                lblSummerBeatsDate,
                lblSummerBeatsLocation,
                lblSummerBeatsPrice,
                btnSummerBeats,
                ref y);

            ShowEvent(
                comedyMatch,
                picComedyNight,
                lblComedyNightName,
                lblComedyNightDate,
                lblComedyNightLocation,
                lblComedyNightPrice,
                btnComedyNight,
                ref y);

            // Always return scrollbar to the top after searching
            pnlEvents.AutoScrollPosition = new Point(0, 0);


        }




        private bool EventMatches(string eventName, string search)
        {
            // Empty search means show everything
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
                // Move the event to the next available row
                picture.Location = new Point(20, y);

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

                // Space before next event
                y += 145;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search events...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search events...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnBattleBands_Click(object sender, EventArgs e)
        {
            OpenBookingPayment(
        lblBattleBandsName.Text,
        lblBattleBandsLocation.Text,
        lblBattleBandsDate.Text,
        lblBattleBandsPrice.Text,
        picBattleBands.Image
    );
        }

        private void btnStreetFestival_Click(object sender, EventArgs e)
        {
            OpenBookingPayment(
      lblStreetFestivalName.Text,
      lblStreetFestivalLocation.Text,
      lblStreetFestivalDate.Text,
      lblStreetFestivalPrice.Text,
      picStreetFestival.Image
  );
        }

        private void btnRhythmNights_Click(object sender, EventArgs e)
        {
            OpenBookingPayment(
       lblRhythmNightsName.Text,
       lblRhythmNightsLocation.Text,
       lblRhythmNightsDate.Text,
       lblRhythmNightsPrice.Text,
       picRhythmNights.Image
   );
        }

        private void btnSummerBeats_Click(object sender, EventArgs e)
        {
            OpenBookingPayment(
       lblSummerBeatsName.Text,
       lblSummerBeatsLocation.Text,
       lblSummerBeatsDate.Text,
       lblSummerBeatsPrice.Text,
       picSummerBeats.Image
   );
        }

        private void btnComedyNight_Click(object sender, EventArgs e)
        {
            OpenBookingPayment(
        lblComedyNightName.Text,
        lblComedyNightLocation.Text,
        lblComedyNightDate.Text,
        lblComedyNightPrice.Text,
        picComedyNight.Image
    );
        }
    }
}
