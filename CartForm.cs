using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class CartForm : Form
    {
        private Event selectedEvent;

        // Constructor for Designer
        public CartForm()
        {
            InitializeComponent();
        }

        // Constructor used when event is added to cart
        public CartForm(Event selectedEvent)
        {
            InitializeComponent();

            this.selectedEvent = selectedEvent;

            // Quantity range
            numAdult.Minimum = 0;
            numAdult.Maximum = 10;

            numStudent.Minimum = 0;
            numStudent.Maximum = 10;

            numFamily.Minimum = 0;
            numFamily.Maximum = 10;

            // Quantity changed events
            numAdult.ValueChanged += numAdult_ValueChanged;
            numStudent.ValueChanged += numStudent_ValueChanged;
            numFamily.ValueChanged += numFamily_ValueChanged;

            DisplayEvent();
        }

        private void DisplayEvent()
        {
            // Event details
            lblCartEventName.Text = selectedEvent.EventName;
            lblCartDate.Text = selectedEvent.EventDate;
            lblCartTime.Text = selectedEvent.EventTime;
            lblCartLocation.Text = selectedEvent.EventLocation;

            // Event image
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            object image =
                Properties.Resources.ResourceManager.GetObject(
                    selectedEvent.EventImg
                );

            pictureBox2.Image = image as Image;

            // Ticket prices
            int adultPrice = selectedEvent.EventPrice;
            int studentPrice = adultPrice - 10;
            int familyPrice = (adultPrice * 4) - 50;

            // Display prices
            lblAdultPrice.Text = adultPrice + " NZD";
            lblStudentPrice.Text = studentPrice + " NZD";
            lblFamilyPrice.Text = familyPrice + " NZD";

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            // Prices
            int adultPrice = selectedEvent.EventPrice;
            int studentPrice = adultPrice - 10;
            int familyPrice = (adultPrice * 4) - 50;

            // Quantities
            int adultQuantity = (int)numAdult.Value;
            int studentQuantity = (int)numStudent.Value;
            int familyQuantity = (int)numFamily.Value;

            // Totals
            int adultTotal = adultPrice * adultQuantity;
            int studentTotal = studentPrice * studentQuantity;
            int familyTotal = familyPrice * familyQuantity;

            // Display totals
            lblAdultTotal.Text = adultTotal + " NZD";
            lblStudentTotal.Text = studentTotal + " NZD";
            lblFamilyTotal.Text = familyTotal + " NZD";
        }

        private void numAdult_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void numStudent_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void numFamily_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Continue to Payment
        private void button2_Click(object sender, EventArgs e)
        {
            // Prices
            int adultPrice = selectedEvent.EventPrice;
            int studentPrice = adultPrice - 10;
            int familyPrice = (adultPrice * 4) - 50;

            // Quantities
            int adultQuantity = (int)numAdult.Value;
            int studentQuantity = (int)numStudent.Value;
            int familyQuantity = (int)numFamily.Value;

            // Total quantity
            int totalQuantity =
                adultQuantity +
                studentQuantity +
                familyQuantity;

            // Check if user selected tickets
            if (totalQuantity == 0)
            {
                MessageBox.Show(
                    "Please select at least one ticket.",
                    "Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Calculate final cart total
            int totalPrice =
                (adultPrice * adultQuantity) +
                (studentPrice * studentQuantity) +
                (familyPrice * familyQuantity);

            // Send Cart data to Form 7
            BookingPayment form7 = new BookingPayment(
                selectedEvent.EventName,
                selectedEvent.EventLocation,
                selectedEvent.EventDate,
                totalQuantity,
                totalPrice,
                pictureBox2.Image
            );

            form7.Show();
            this.Hide();
        }

        // Back to Event Details
        private void button1_Click(object sender, EventArgs e)
        {
            EventDetailsForm eventDetailsForm =
                new EventDetailsForm(selectedEvent.EventID);

            eventDetailsForm.Show();
            this.Hide();
        }
    }
}