namespace tech_titans
{
    partial class EventDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlanovaSubtitle = new System.Windows.Forms.Label();
            this.PlanovaName = new System.Windows.Forms.Label();
            this.PlanovaLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.eventName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAboutEvent = new System.Windows.Forms.Label();
            this.buttonBookNow = new System.Windows.Forms.Button();
            this.aboutEvent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanovaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PlanovaSubtitle);
            this.panel1.Controls.Add(this.PlanovaName);
            this.panel1.Controls.Add(this.PlanovaLogo);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 76);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(97, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 8);
            this.panel3.TabIndex = 4;
            // 
            // PlanovaSubtitle
            // 
            this.PlanovaSubtitle.AutoSize = true;
            this.PlanovaSubtitle.Font = new System.Drawing.Font("Nirmala Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanovaSubtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlanovaSubtitle.Location = new System.Drawing.Point(62, 44);
            this.PlanovaSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlanovaSubtitle.Name = "PlanovaSubtitle";
            this.PlanovaSubtitle.Size = new System.Drawing.Size(132, 15);
            this.PlanovaSubtitle.TabIndex = 3;
            this.PlanovaSubtitle.Text = "Event Booking System";
            // 
            // PlanovaName
            // 
            this.PlanovaName.AutoSize = true;
            this.PlanovaName.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanovaName.ForeColor = System.Drawing.Color.DarkOrange;
            this.PlanovaName.Location = new System.Drawing.Point(61, 10);
            this.PlanovaName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlanovaName.Name = "PlanovaName";
            this.PlanovaName.Size = new System.Drawing.Size(128, 32);
            this.PlanovaName.TabIndex = 2;
            this.PlanovaName.Text = "PLANOVA";
            // 
            // PlanovaLogo
            // 
            this.PlanovaLogo.BackColor = System.Drawing.Color.Lavender;
            this.PlanovaLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlanovaLogo.Image = global::tech_titans.Properties.Resources.PlanovaLogo;
            this.PlanovaLogo.Location = new System.Drawing.Point(9, 10);
            this.PlanovaLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PlanovaLogo.Name = "PlanovaLogo";
            this.PlanovaLogo.Size = new System.Drawing.Size(48, 49);
            this.PlanovaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlanovaLogo.TabIndex = 1;
            this.PlanovaLogo.TabStop = false;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.Orange;
            this.pictureBoxEvent.Location = new System.Drawing.Point(26, 96);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(439, 232);
            this.pictureBoxEvent.TabIndex = 8;
            this.pictureBoxEvent.TabStop = false;
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(17)))), ((int)(((byte)(153)))));
            this.eventName.Location = new System.Drawing.Point(483, 96);
            this.eventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(161, 31);
            this.eventName.TabIndex = 2;
            this.eventName.Text = "Event Name";
            this.eventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblDate);
            this.flowLayoutPanel1.Controls.Add(this.lblTime);
            this.flowLayoutPanel1.Controls.Add(this.lblLocation);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(489, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 139);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = " Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(57, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(109, 0);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 20);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = " Location";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.lblAboutEvent);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 381);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(958, 170);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // lblAboutEvent
            // 
            this.lblAboutEvent.AutoSize = true;
            this.lblAboutEvent.Location = new System.Drawing.Point(3, 0);
            this.lblAboutEvent.Name = "lblAboutEvent";
            this.lblAboutEvent.Size = new System.Drawing.Size(93, 20);
            this.lblAboutEvent.TabIndex = 13;
            this.lblAboutEvent.Text = " Description";
            // 
            // buttonBookNow
            // 
            this.buttonBookNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookNow.ForeColor = System.Drawing.Color.White;
            this.buttonBookNow.Location = new System.Drawing.Point(796, 288);
            this.buttonBookNow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBookNow.Name = "buttonBookNow";
            this.buttonBookNow.Size = new System.Drawing.Size(188, 40);
            this.buttonBookNow.TabIndex = 11;
            this.buttonBookNow.Text = "Book Now";
            this.buttonBookNow.UseVisualStyleBackColor = false;
            // 
            // aboutEvent
            // 
            this.aboutEvent.AutoSize = true;
            this.aboutEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(17)))), ((int)(((byte)(153)))));
            this.aboutEvent.Location = new System.Drawing.Point(27, 347);
            this.aboutEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutEvent.Name = "aboutEvent";
            this.aboutEvent.Size = new System.Drawing.Size(212, 31);
            this.aboutEvent.TabIndex = 12;
            this.aboutEvent.Text = "About the Event";
            this.aboutEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1010, 617);
            this.Controls.Add(this.aboutEvent);
            this.Controls.Add(this.buttonBookNow);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.panel1);
            this.Name = "EventDetailsForm";
            this.Text = "Event Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanovaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PlanovaSubtitle;
        private System.Windows.Forms.Label PlanovaName;
        private System.Windows.Forms.PictureBox PlanovaLogo;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonBookNow;
        private System.Windows.Forms.Label aboutEvent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAboutEvent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLocation;
    }
}