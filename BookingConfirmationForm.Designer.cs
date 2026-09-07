namespace tech_titans
{
    partial class BookingConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblConfirmationTitle = new System.Windows.Forms.Label();
            this.lblSuccessMessage = new System.Windows.Forms.Label();
            this.lblBookingIDTitle = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblEventNameTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblLocationTitle = new System.Windows.Forms.Label();
            this.lblQuantityTitle = new System.Windows.Forms.Label();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblTotalPaidTitle = new System.Windows.Forms.Label();
            this.lblPaymentStatusTitle = new System.Windows.Forms.Label();
            this.btnBackToEvents = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblSuccessTick = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(69, 55);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "Event Booking System";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkOrange;
            this.label22.Location = new System.Drawing.Point(71, 12);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 32);
            this.label22.TabIndex = 2;
            this.label22.Text = "PLANOVA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 95);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(109, 85);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(919, 10);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::tech_titans.Properties.Resources.PlanovaLogo;
            this.pictureBox6.Location = new System.Drawing.Point(12, 12);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // lblConfirmationTitle
            // 
            this.lblConfirmationTitle.AutoSize = true;
            this.lblConfirmationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationTitle.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblConfirmationTitle.Location = new System.Drawing.Point(396, 155);
            this.lblConfirmationTitle.Name = "lblConfirmationTitle";
            this.lblConfirmationTitle.Size = new System.Drawing.Size(290, 32);
            this.lblConfirmationTitle.TabIndex = 33;
            this.lblConfirmationTitle.Text = "Booking Confirmed !";
            // 
            // lblSuccessMessage
            // 
            this.lblSuccessMessage.AutoSize = true;
            this.lblSuccessMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSuccessMessage.Location = new System.Drawing.Point(426, 191);
            this.lblSuccessMessage.Name = "lblSuccessMessage";
            this.lblSuccessMessage.Size = new System.Drawing.Size(223, 20);
            this.lblSuccessMessage.TabIndex = 34;
            this.lblSuccessMessage.Text = "Your payment was successful.";
            // 
            // lblBookingIDTitle
            // 
            this.lblBookingIDTitle.AutoSize = true;
            this.lblBookingIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBookingIDTitle.Location = new System.Drawing.Point(426, 232);
            this.lblBookingIDTitle.Name = "lblBookingIDTitle";
            this.lblBookingIDTitle.Size = new System.Drawing.Size(119, 22);
            this.lblBookingIDTitle.TabIndex = 35;
            this.lblBookingIDTitle.Text = "Booking ID :";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(547, 232);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(80, 22);
            this.lblBookingID.TabIndex = 36;
            this.lblBookingID.Text = "BK1001";
            // 
            // lblEventNameTitle
            // 
            this.lblEventNameTitle.AutoSize = true;
            this.lblEventNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNameTitle.Location = new System.Drawing.Point(324, 324);
            this.lblEventNameTitle.Name = "lblEventNameTitle";
            this.lblEventNameTitle.Size = new System.Drawing.Size(108, 22);
            this.lblEventNameTitle.TabIndex = 37;
            this.lblEventNameTitle.Text = "Event Name";
            this.lblEventNameTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(324, 369);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(48, 22);
            this.lblDateTitle.TabIndex = 38;
            this.lblDateTitle.Text = "Date";
            this.lblDateTitle.Click += new System.EventHandler(this.lblDateTitle_Click);
            // 
            // lblLocationTitle
            // 
            this.lblLocationTitle.AutoSize = true;
            this.lblLocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationTitle.Location = new System.Drawing.Point(324, 414);
            this.lblLocationTitle.Name = "lblLocationTitle";
            this.lblLocationTitle.Size = new System.Drawing.Size(78, 22);
            this.lblLocationTitle.TabIndex = 39;
            this.lblLocationTitle.Text = "Location";
            this.lblLocationTitle.Click += new System.EventHandler(this.lblLocationTitle_Click);
            // 
            // lblQuantityTitle
            // 
            this.lblQuantityTitle.AutoSize = true;
            this.lblQuantityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTitle.Location = new System.Drawing.Point(324, 459);
            this.lblQuantityTitle.Name = "lblQuantityTitle";
            this.lblQuantityTitle.Size = new System.Drawing.Size(77, 22);
            this.lblQuantityTitle.TabIndex = 40;
            this.lblQuantityTitle.Text = "Quantity";
            this.lblQuantityTitle.Click += new System.EventHandler(this.lblQuantityTitle_Click);
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTitle.Location = new System.Drawing.Point(324, 509);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(51, 22);
            this.lblPriceTitle.TabIndex = 41;
            this.lblPriceTitle.Text = "Price";
            this.lblPriceTitle.Click += new System.EventHandler(this.lblPriceTitle_Click);
            // 
            // lblTotalPaidTitle
            // 
            this.lblTotalPaidTitle.AutoSize = true;
            this.lblTotalPaidTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaidTitle.Location = new System.Drawing.Point(324, 551);
            this.lblTotalPaidTitle.Name = "lblTotalPaidTitle";
            this.lblTotalPaidTitle.Size = new System.Drawing.Size(92, 22);
            this.lblTotalPaidTitle.TabIndex = 42;
            this.lblTotalPaidTitle.Text = "Total Paid";
            this.lblTotalPaidTitle.Click += new System.EventHandler(this.lblTotalPaidTitle_Click);
            // 
            // lblPaymentStatusTitle
            // 
            this.lblPaymentStatusTitle.AutoSize = true;
            this.lblPaymentStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatusTitle.Location = new System.Drawing.Point(324, 600);
            this.lblPaymentStatusTitle.Name = "lblPaymentStatusTitle";
            this.lblPaymentStatusTitle.Size = new System.Drawing.Size(136, 22);
            this.lblPaymentStatusTitle.TabIndex = 43;
            this.lblPaymentStatusTitle.Text = "Payment Status";
            this.lblPaymentStatusTitle.Click += new System.EventHandler(this.lblPaymentStatusTitle_Click);
            // 
            // btnBackToEvents
            // 
            this.btnBackToEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackToEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToEvents.Location = new System.Drawing.Point(437, 668);
            this.btnBackToEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackToEvents.Name = "btnBackToEvents";
            this.btnBackToEvents.Size = new System.Drawing.Size(217, 51);
            this.btnBackToEvents.TabIndex = 44;
            this.btnBackToEvents.Text = "Back to Events";
            this.btnBackToEvents.UseVisualStyleBackColor = false;
            this.btnBackToEvents.Click += new System.EventHandler(this.btnBackToEvents_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(634, 324);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(79, 22);
            this.lblEventName.TabIndex = 45;
            this.lblEventName.Text = "DJ Night";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(634, 366);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(117, 22);
            this.lblEventDate.TabIndex = 46;
            this.lblEventDate.Text = "18 Sept 2026";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(634, 411);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(84, 22);
            this.lblLocation.TabIndex = 47;
            this.lblLocation.Text = "Auckland";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(634, 456);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(20, 22);
            this.lblQuantity.TabIndex = 48;
            this.lblQuantity.Text = "2";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(634, 506);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 22);
            this.lblPrice.TabIndex = 49;
            this.lblPrice.Text = "45 NZD";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaid.Location = new System.Drawing.Point(634, 549);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(72, 22);
            this.lblTotalPaid.TabIndex = 50;
            this.lblTotalPaid.Text = "90 NZD";
            this.lblTotalPaid.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(634, 598);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(51, 22);
            this.lblPaymentStatus.TabIndex = 51;
            this.lblPaymentStatus.Text = "PAID";
            this.lblPaymentStatus.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSuccessTick
            // 
            this.lblSuccessTick.AutoSize = true;
            this.lblSuccessTick.BackColor = System.Drawing.Color.Lime;
            this.lblSuccessTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessTick.ForeColor = System.Drawing.Color.White;
            this.lblSuccessTick.Location = new System.Drawing.Point(507, 102);
            this.lblSuccessTick.Name = "lblSuccessTick";
            this.lblSuccessTick.Size = new System.Drawing.Size(51, 52);
            this.lblSuccessTick.TabIndex = 52;
            this.lblSuccessTick.Text = "✓";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(0, 753);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 36);
            this.panel1.TabIndex = 53;
            // 
            // BookingConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 789);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSuccessTick);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnBackToEvents);
            this.Controls.Add(this.lblPaymentStatusTitle);
            this.Controls.Add(this.lblTotalPaidTitle);
            this.Controls.Add(this.lblPriceTitle);
            this.Controls.Add(this.lblQuantityTitle);
            this.Controls.Add(this.lblLocationTitle);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.lblEventNameTitle);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblBookingIDTitle);
            this.Controls.Add(this.lblSuccessMessage);
            this.Controls.Add(this.lblConfirmationTitle);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingConfirmationForm";
            this.Text = "BookingConfirmationForm";
            this.Load += new System.EventHandler(this.BookingConfirmationForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblConfirmationTitle;
        private System.Windows.Forms.Label lblSuccessMessage;
        private System.Windows.Forms.Label lblBookingIDTitle;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblEventNameTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblLocationTitle;
        private System.Windows.Forms.Label lblQuantityTitle;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Label lblTotalPaidTitle;
        private System.Windows.Forms.Label lblPaymentStatusTitle;
        private System.Windows.Forms.Button btnBackToEvents;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblSuccessTick;
        private System.Windows.Forms.Panel panel1;
    }
}