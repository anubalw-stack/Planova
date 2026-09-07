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
    public partial class BookingConfirmationForm : Form
    {
        public BookingConfirmationForm(
            string eventName,
            string eventDate,
            string location,
            int quantity,
            int price)
        {
            InitializeComponent();

            lblBookingID.Text = "BK" + DateTime.Now.ToString("HHmmss");

            lblEventName.Text = eventName;
            lblEventDate.Text = eventDate;
            lblLocation.Text = location;
            lblQuantity.Text = quantity.ToString();

            lblPrice.Text = price + " NZD";

            int total = quantity * price;
            lblTotalPaid.Text = total + " NZD";

            lblPaymentStatus.Text = "PAID";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BookingConfirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblDateTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblLocationTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantityTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPriceTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPaidTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPaymentStatusTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToEvents_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 eventsForm = new Form4();
            eventsForm.ShowDialog();

            this.Close();
        }
    }
}
