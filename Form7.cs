using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace tech_titans
{
    public partial class BookingPayment : Form
    {
        int currentEvent = 0;
        int quantity = 1;
        string[] eventNames =
        {
        "DJ Night",
        "Battle of the Bands",
        "Street Music Festival",
        "Rythm Nights",
        "Summer Beats",
        "Comedy Night Live",
        };

        string[] eventLocations =
    {
        "Auckland Town Hall",
        "Spark Arena",
        "Queen Street",
        "Western Springs",
        "Aotea Square",
        "Comedy Club",

    };
        int[] eventPrices =
        {
         100,
         80,
         50,
         70,
         60,
         1000,
        };
        string[] eventDates =
        {
        "20 August 2026",
        "5 September 2026",
        "15 September 2026",
        "25 September 2026",
        "10 October 2026",
        "99 December 2026",
        };
        public BookingPayment   ()
        {
            InitializeComponent();
            ShowEvent();
            UpdateQuantity();

        }
        private void ShowEvent()
        {
            lblEventName.Text = eventNames[currentEvent];
            lblLocation.Text = eventLocations[currentEvent];
            lblDate.Text = eventDates[currentEvent];
            lblPrice.Text = "$" + eventPrices[currentEvent];

            if (currentEvent == 0)
            {
                pictureBox2.Image = Properties.Resources.event1;
            }
            else if (currentEvent == 1)
            {
                pictureBox2.Image = Properties.Resources.event2;
            }
            else if (currentEvent == 2)
            {
                pictureBox2.Image = Properties.Resources.event3;
            }
            else if (currentEvent == 3)
            {
                pictureBox2.Image = Properties.Resources.event4;
            }
            else if (currentEvent == 4)
            {
                pictureBox2.Image = Properties.Resources.event5;
            }
            else if (currentEvent == 4)
            {
                pictureBox2.Image = Properties.Resources.event6;
            }
        }

        private void UpdateQuantity()
        {
            lblQuantity.Text = quantity.ToString();

            double total = eventPrices[currentEvent] * quantity;

            lblTotalPrice.Text = "$" + total.ToString("0.00");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Check if cart is empty
            if (lblCartQuantity.Text == "0" || lblCartEvent.Text == "")
            {
                MessageBox.Show("Please add an event to the cart first.");
                return;
            }

            // Card Number
            if (txtCardNumber.Text == "")
            {
                MessageBox.Show("Please enter your card number.");
                return;
            }

            if (!long.TryParse(txtCardNumber.Text, out _))
            {
                MessageBox.Show("Card Number must contain numbers only.");
                return;
            }

            if (txtCardNumber.Text.Length != 16)
            {
                MessageBox.Show("Card Number must be exactly 16 digits.");
                return;
            }

            // Expiry Date
            if (txtExpiry.Text == "")
            {
                MessageBox.Show("Please enter your expiry date.");
                return;
            }

            if (!int.TryParse(txtExpiry.Text, out _))
            {
                MessageBox.Show("Expiry date must contain numbers only.");
                return;
            }

            if (txtExpiry.Text.Length != 4)
            {
                MessageBox.Show("Expiry date must be exactly 4 digits.");
                return;
            }

            // CVV
            if (txtCVV.Text == "")
            {
                MessageBox.Show("Please enter your CVV.");
                return;
            }

            if (!int.TryParse(txtCVV.Text, out _))
            {
                MessageBox.Show("CVV must contain numbers only.");
                return;
            }

            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV must be exactly 3 digits.");
                return;
            }

            // Payment successful
            MessageBox.Show(
                "Payment successful! Your booking has been confirmed.",
                "Booking Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void lblRhythmNightsName_Click(object sender, EventArgs e)
        {

        }

        private void lblBattleBandsName_Click(object sender, EventArgs e)
        {

        }

        private void lblStreetFestivalName_Click(object sender, EventArgs e)
        {

        }

        private void lblDJNightName_Click(object sender, EventArgs e)
        {

        }

        private void lblSummerBeatsName_Click(object sender, EventArgs e)
        {

        }

        private void picStreetFestival_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (currentEvent < eventNames.Length - 1)
            {
                currentEvent++;
                quantity = 1;
                ShowEvent();
                UpdateQuantity();

            }
        }


            if (currentEvent > 0)
            {
                currentEvent--;
                quantity = 1;
                UpdateQuantity();
                ShowEvent();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateQuantity();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                UpdateQuantity();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            lblCartEvent.Text = eventNames[currentEvent];
            lblCartQuantity.Text = quantity.ToString();
            lblCartPrice.Text = "$" + eventPrices[currentEvent].ToString();

            int total = eventPrices[currentEvent] * quantity;
            lblCartTotal.Text = "$" + total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblCartEvent.Text = "";
            lblCartQuantity.Text = "0";
            lblCartPrice.Text = "$0";
            lblCartTotal.Text = "$0";
        }
    }
}



