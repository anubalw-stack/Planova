using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class BookingPayment : Form
    {
        private string selectedEventName;
        private string selectedLocation;
        private string selectedDate;
        private int selectedQuantity;
        private int selectedTotalPrice;
        private Image selectedImage;

        // True once the user has actually picked a value on dtpexpiry,
        // since DateTimePicker always has *some* date selected by default.
        private bool expirySelected = false;

        // Constructor for Designer
        public BookingPayment()
        {
            InitializeComponent();

            SetupExpiryDate();

            lblEventName.Text = "";
            lblLocation.Text = "";
            lblDate.Text = "";

            lblCartEvent.Text = "";
            lblCartQuantity.Text = "0";
            lblCartPrice.Text = "$0.00";
            lblCartTotal.Text = "$0.00";
        }

        // Constructor used by CartForm
        public BookingPayment(
            string eventName,
            string location,
            string date,
            int quantity,
            int totalPrice,
            Image image)
        {
            InitializeComponent();

            SetupExpiryDate();

            selectedEventName = eventName;
            selectedLocation = location;
            selectedDate = date;
            selectedQuantity = quantity;
            selectedTotalPrice = totalPrice;
            selectedImage = image;

            ShowBooking();
        }


        // SETUP EXPIRY DATE PICKER
        private void SetupExpiryDate()
        {
            dtpexpiry.Format = DateTimePickerFormat.Custom;
            dtpexpiry.CustomFormat = "' select date '";

            dtpexpiry.ValueChanged += dtpexpiry_ValueChanged;
        }


        // EXPIRY DATE CHANGED
        private void dtpexpiry_ValueChanged(object sender, EventArgs e)
        {
            dtpexpiry.CustomFormat = "MM/yy";
            expirySelected = true;
        }


        // SHOW BOOKING DETAILS
        private void ShowBooking()
        {
            lblEventName.Text = selectedEventName;
            lblLocation.Text = selectedLocation;
            lblDate.Text = selectedDate;

            pictureBox2.Image = selectedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            lblCartEvent.Text = selectedEventName;
            lblCartQuantity.Text = selectedQuantity.ToString();
            lblCartPrice.Text = "$" + selectedTotalPrice.ToString("0.00");
            lblCartTotal.Text = "$" + selectedTotalPrice.ToString("0.00");
        }


        // PAY NOW
        private void btnPay_Click(object sender, EventArgs e)
        {
            // CARD NUMBER
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text))
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


            // EXPIRY DATE
            if (!expirySelected)
            {
                MessageBox.Show("Please select your expiry date.");
                return;
            }

            DateTime firstOfExpiryMonth = new DateTime(dtpexpiry.Value.Year, dtpexpiry.Value.Month, 1);
            DateTime firstOfThisMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            if (firstOfExpiryMonth < firstOfThisMonth)
            {
                MessageBox.Show("Card has expired. Please select a valid expiry date.");
                return;
            }


            // CVV
            if (string.IsNullOrWhiteSpace(txtCVV.Text))
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


            // SUCCESSFUL PAYMENT
            MessageBox.Show(
                "Payment successful! Your booking has been confirmed.",
                "Booking Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


            // OPEN CONFIRMATION FORM
            BookingConfirmationForm confirmationForm =
                new BookingConfirmationForm(
                    selectedEventName,
                    selectedLocation,
                    selectedDate,
                    selectedQuantity,
                    selectedTotalPrice
                );

            confirmationForm.Show();
            this.Hide();
        }


        // CLEAR PAYMENT
        private void button6_Click(object sender, EventArgs e)
        {
            lblCartEvent.Text = "";
            lblCartQuantity.Text = "0";
            lblCartPrice.Text = "$0.00";
            lblCartTotal.Text = "$0.00";

            lblEventName.Text = "";
            lblLocation.Text = "";
            lblDate.Text = "";

            pictureBox2.Image = null;

            txtCardNumber.Clear();
            txtCVV.Clear();

            dtpexpiry.CustomFormat = "' select date '";
            expirySelected = false;

            selectedEventName = "";
            selectedLocation = "";
            selectedDate = "";
            selectedQuantity = 0;
            selectedTotalPrice = 0;
            selectedImage = null;
        }


        // CANCEL / BACK
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Find already opened EventDetailsForm
            foreach (Form form in Application.OpenForms)
            {
                if (form is EventDetailsForm)
                {
                    form.Show();
                    this.Hide();
                    return;
                }
            }

            // If EventDetailsForm is not open, go to Home Page
            HomePage homePage = new HomePage();
            homePage.Show();

            this.Hide();
        }


        // OLD DESIGNER EVENT HANDLERS

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

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
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

        private void lblLocation_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {
        }
    }
}