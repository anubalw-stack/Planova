using System;
using System.ComponentModel;
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
            SetupCartForm();

            // If there is already something in the cart,
            // display the first event.
            if (Cart.Items.Count > 0)
            {
                selectedEvent = Cart.Items[0].Event;

                DisplayEvent();
                LoadExistingCartItem();
            }
            else
            {
                ClearCartDisplay();
            }
        }

        // Constructor used when event is added to cart
        public CartForm(Event selectedEvent)
        {
            InitializeComponent();
            SetupCartForm();

            this.selectedEvent = selectedEvent;

            DisplayEvent();
            LoadExistingCartItem();
        }

        private void SetupCartForm()
        {
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

            // Buttons
            button1.Click += Back_Click;
            iconButton6.Click += Back_Click;
            button2.Click += buttonProceed_Click;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;

            // Navigation menu
            iconButton14.Click += iconButton14_Click;

            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            cartToolStripMenuItem.Click += cartToolStripMenuItem_Click;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;

            CartMenuStrip.Opening += CartMenuStrip_Opening;
        }

        private void LoadExistingCartItem()
        {
            if (selectedEvent == null)
            {
                return;
            }

            CartItem existing = Cart.FindByEventId(selectedEvent.EventID);

            if (existing != null)
            {
                numAdult.Value = existing.AdultQty;
                numStudent.Value = existing.StudentQty;
                numFamily.Value = existing.FamilyQty;
            }
        }

        private void DisplayEvent()
        {
            if (selectedEvent == null)
            {
                ClearCartDisplay();
                return;
            }

            // Enable cart buttons when an event exists.
            btnRemoveFromCart.Enabled = true;
            button2.Enabled = true;

            // Event information
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

        private void ClearCartDisplay()
        {
            // Clear event information
            lblCartEventName.Text = "";
            lblCartDate.Text = "";
            lblCartTime.Text = "";
            lblCartLocation.Text = "";

            // Clear prices
            lblAdultPrice.Text = "";
            lblStudentPrice.Text = "";
            lblFamilyPrice.Text = "";

            // Clear totals
            lblAdultTotal.Text = "";
            lblStudentTotal.Text = "";
            lblFamilyTotal.Text = "";

            // Clear image
            pictureBox2.Image = null;

            // Reset quantities
            numAdult.Value = 0;
            numStudent.Value = 0;
            numFamily.Value = 0;

            // Disable buttons when cart is empty
            btnRemoveFromCart.Enabled = false;
            button2.Enabled = false;
        }

        private void UpdateTotals()
        {
            if (selectedEvent == null)
            {
                lblAdultTotal.Text = "";
                lblStudentTotal.Text = "";
                lblFamilyTotal.Text = "";

                return;
            }

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

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            if (selectedEvent == null)
            {
                MessageBox.Show(
                    "Your cart is empty.",
                    "Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int adultQty = (int)numAdult.Value;
            int studentQty = (int)numStudent.Value;
            int familyQty = (int)numFamily.Value;

            // Make sure at least one ticket has been selected.
            if (adultQty == 0 &&
                studentQty == 0 &&
                familyQty == 0)
            {
                MessageBox.Show(
                    "Please select at least one ticket before proceeding.",
                    "Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Save/update the cart.
            Cart.AddOrUpdate(
                selectedEvent,
                adultQty,
                studentQty,
                familyQty
            );

            // Calculate prices.
            int adultPrice = selectedEvent.EventPrice;
            int studentPrice = adultPrice - 10;
            int familyPrice = (adultPrice * 4) - 50;

            // Calculate the complete cart total.
            int totalPrice =
                (adultPrice * adultQty) +
                (studentPrice * studentQty) +
                (familyPrice * familyQty);

            // Total number of ticket selections.
            int totalQuantity =
                adultQty +
                studentQty +
                familyQty;

            // Get the event image currently displayed.
            Image eventImage = pictureBox2.Image;

            // Open teammate's payment form.
            BookingPayment paymentForm = new BookingPayment(
                selectedEvent.EventName,
                selectedEvent.EventLocation,
                selectedEvent.EventDate + " " + selectedEvent.EventTime,
                totalQuantity,
                totalPrice,
                eventImage
            );

            paymentForm.Show();

            // Close the cart form.
            this.Close();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (selectedEvent == null)
            {
                return;
            }

            // Remove event from the shared cart.
            Cart.Remove(selectedEvent.EventID);

            // Clear everything displayed on the form.
            ClearCartDisplay();

            // Forget the selected event.
            selectedEvent = null;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                EventDetailsForm eventDetailsForm =
                    new EventDetailsForm(selectedEvent.EventID);

                eventDetailsForm.Show();
            }
            else
            {
                HomePage homepage = new HomePage();
                homepage.Show();
            }

            this.Close();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            CartMenuStrip.Show(
                iconButton14,
                new Point(
                    iconButton14.Width - CartMenuStrip.Width,
                    iconButton14.Height
                )
            );
        }

        private void CartMenuStrip_Opening(
            object sender,
            CancelEventArgs e)
        {
            registerToolStripMenuItem.Visible = !Session.IsLoggedIn;
            loginToolStripMenuItem.Visible = !Session.IsLoggedIn;
            logoutToolStripMenuItem.Visible = Session.IsLoggedIn;

            cartToolStripMenuItem.Enabled = false;
        }

        private void homeToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Close();
        }

        private void registerToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
        }

        private void loginToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void cartToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            // Already on the cart page.
        }

        private void logoutToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            Session.Logout();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}