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
        private int selectedPrice;
        private Image selectedImage;

        // Constructor for Designer
        public BookingPayment()
        {
            InitializeComponent();

            lblEventName.Text = "";
            lblLocation.Text = "";
            lblDate.Text = "";
           

            lblCartEvent.Text = "";
            lblCartQuantity.Text = "0";
            lblCartPrice.Text = "$0.00";
            lblCartTotal.Text = "$0.00";
        }

        // Constructor used by Form4
        public BookingPayment(
            string eventName,
            string location,
            string date,
            int quantity,
            int price,
            Image image)
        {
            InitializeComponent();

            selectedEventName = eventName;
            selectedLocation = location;
            selectedDate = date;
            selectedQuantity = quantity;
            selectedPrice = price;
            selectedImage = image;

            ShowBooking();
        }

        private void ShowBooking()
        {
            lblEventName.Text = selectedEventName;
            lblLocation.Text = selectedLocation;
            lblDate.Text = selectedDate;

            pictureBox2.Image = selectedImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            int total = selectedPrice * selectedQuantity;

            lblCartEvent.Text = selectedEventName;
            lblCartQuantity.Text = selectedQuantity.ToString();
            lblCartPrice.Text = "$" + selectedPrice.ToString("0.00");
            lblCartTotal.Text = "$" + total.ToString("0.00");

           
        }

        // PAY NOW
        private void btnPay_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCardNumber.Text))
            {
                MessageBox.Show("Please enter your card number.");
                return;
            }

        private void btnPay_Click(object sender, EventArgs e)
        {
         
            // Check whether a payment method is selected
           
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

            if (string.IsNullOrWhiteSpace(txtExpiry.Text))
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

            MessageBox.Show(
                "Payment successful! Your booking has been confirmed.",
                "Booking Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // CANCEL
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
            txtExpiry.Clear();
            txtCVV.Clear();

            selectedEventName = "";
            selectedLocation = "";
            selectedDate = "";
            selectedQuantity = 0;
            selectedPrice = 0;
            selectedImage = null;
        }

        // Old Designer event handlers
        // Kept so Form7.Designer.cs does not give errors

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