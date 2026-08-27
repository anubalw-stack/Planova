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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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
         
            // Check whether a payment method is selected
            if (!chkCardPayment.Checked)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Check card number
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text))
            {
                MessageBox.Show("Please enter your card number.");
                txtCardNumber.Focus();
                return;
            }

            // Check expiry date
            if (string.IsNullOrWhiteSpace(txtExpiry.Text))
            {
                MessageBox.Show("Please enter the expiry date.");
                txtExpiry.Focus();
                return;
            }

            // Check CVV
            if (string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                MessageBox.Show("Please enter the CVV.");
                txtCVV.Focus();
                return;
            }

            // Payment successful
            MessageBox.Show(
                "Payment successful! Your booking has been confirmed.",
                "Booking Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
    }

