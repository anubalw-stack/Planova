using System;
using System.Drawing;
using System.Windows.Forms;

namespace tech_titans
{
    public partial class CartForm : Form
    {
        private Event selectedEvent;

        public CartForm()
        {
            InitializeComponent();
        }

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


            // Adult price comes directly from Event
            int adultPrice = selectedEvent.EventPrice;

            // Student = Adult - 10
            int studentPrice = adultPrice - 10;

            // Family = Adult x 4 - 50
            int familyPrice = (adultPrice * 4) - 50;


            // ONLY changing Text.
            // Font/size stays whatever you selected in Designer.
            lblAdultPrice.Text = adultPrice + " NZD";
            lblStudentPrice.Text = studentPrice + " NZD";
            lblFamilyPrice.Text = familyPrice + " NZD";


            UpdateTotals();
        }


        private void UpdateTotals()
        {
            int adultPrice = selectedEvent.EventPrice;
            int studentPrice = adultPrice - 10;
            int familyPrice = (adultPrice * 4) - 50;


            int adultQuantity = (int)numAdult.Value;
            int studentQuantity = (int)numStudent.Value;
            int familyQuantity = (int)numFamily.Value;


            int adultTotal = adultPrice * adultQuantity;
            int studentTotal = studentPrice * studentQuantity;
            int familyTotal = familyPrice * familyQuantity;


            // Again, only Text changes
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
    }
}