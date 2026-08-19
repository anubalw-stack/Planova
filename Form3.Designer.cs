namespace tech_titans
{
    partial class EventDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlanovaSubtitle = new System.Windows.Forms.Label();
            this.PlanovaName = new System.Windows.Forms.Label();
            this.PlanovaLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanovaLogo)).BeginInit();
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
            this.PlanovaLogo.Image = global::tech_titans.Properties.Resources.fgtr4e3wasdftr543ed;
            this.PlanovaLogo.Location = new System.Drawing.Point(9, 10);
            this.PlanovaLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PlanovaLogo.Name = "PlanovaLogo";
            this.PlanovaLogo.Size = new System.Drawing.Size(48, 49);
            this.PlanovaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlanovaLogo.TabIndex = 1;
            this.PlanovaLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 51);
            this.panel2.TabIndex = 7;
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventDetails";
            this.Text = "Event Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanovaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PlanovaSubtitle;
        private System.Windows.Forms.Label PlanovaName;
        private System.Windows.Forms.PictureBox PlanovaLogo;
        private System.Windows.Forms.Panel panel2;
    }
}