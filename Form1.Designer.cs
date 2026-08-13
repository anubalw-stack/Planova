namespace tech_titans
{
    partial class RegisterForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btneye = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.ptpass = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.ptmail = new System.Windows.Forms.PictureBox();
            this.ptname = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptname)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 69);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(72, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Event Booking System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(69, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "PLANOVA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::tech_titans.Properties.Resources.fgtr4e3wasdftr543ed;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btneye);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.ptpass);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ptage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnregister);
            this.panel2.Controls.Add(this.ptmail);
            this.panel2.Controls.Add(this.ptname);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Location = new System.Drawing.Point(318, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 399);
            this.panel2.TabIndex = 1;
            // 
            // btneye
            // 
            this.btneye.BackColor = System.Drawing.SystemColors.Window;
            this.btneye.ForeColor = System.Drawing.Color.Black;
            this.btneye.Location = new System.Drawing.Point(289, 271);
            this.btneye.Name = "btneye";
            this.btneye.Size = new System.Drawing.Size(26, 30);
            this.btneye.TabIndex = 12;
            this.btneye.Text = "👁️";
            this.btneye.UseVisualStyleBackColor = false;
            this.btneye.Click += new System.EventHandler(this.btneye_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(66, 208);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(258, 40);
            this.dtpDOB.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(66, 154);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(258, 39);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = " E-mail";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // ptpass
            // 
            this.ptpass.BackColor = System.Drawing.Color.White;
            this.ptpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptpass.Image = global::tech_titans.Properties.Resources._09876;
            this.ptpass.Location = new System.Drawing.Point(31, 266);
            this.ptpass.Name = "ptpass";
            this.ptpass.Size = new System.Drawing.Size(38, 41);
            this.ptpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptpass.TabIndex = 6;
            this.ptpass.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.DimGray;
            this.txtname.Location = new System.Drawing.Point(66, 95);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(258, 39);
            this.txtname.TabIndex = 3;
            this.txtname.Text = " Full Name";
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(54, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Join Planova and explore amazing events";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptage
            // 
            this.ptage.BackColor = System.Drawing.Color.White;
            this.ptage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptage.Image = global::tech_titans.Properties.Resources.ava13c3ac53812cde1b88;
            this.ptage.Location = new System.Drawing.Point(31, 208);
            this.ptage.Name = "ptage";
            this.ptage.Size = new System.Drawing.Size(38, 40);
            this.ptage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptage.TabIndex = 7;
            this.ptage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(17)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create An Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(75, 331);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(208, 49);
            this.btnregister.TabIndex = 0;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // ptmail
            // 
            this.ptmail.BackColor = System.Drawing.Color.White;
            this.ptmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptmail.Image = global::tech_titans.Properties.Resources.R;
            this.ptmail.Location = new System.Drawing.Point(31, 154);
            this.ptmail.Name = "ptmail";
            this.ptmail.Size = new System.Drawing.Size(38, 39);
            this.ptmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptmail.TabIndex = 8;
            this.ptmail.TabStop = false;
            // 
            // ptname
            // 
            this.ptname.BackColor = System.Drawing.Color.Lavender;
            this.ptname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptname.Image = global::tech_titans.Properties.Resources._53c2df674569ab7ef72bc6023307f264;
            this.ptname.Location = new System.Drawing.Point(31, 95);
            this.ptname.Name = "ptname";
            this.ptname.Size = new System.Drawing.Size(38, 39);
            this.ptname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptname.TabIndex = 2;
            this.ptname.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(66, 266);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(258, 36);
            this.txtpass.TabIndex = 11;
            this.txtpass.Text = " Password";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-2, 578);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 38);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(-2, 565);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 17);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "------ Already a user? ------";
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblogin.Location = new System.Drawing.Point(466, 516);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(56, 22);
            this.lblogin.TabIndex = 5;
            this.lblogin.Text = "Login";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 617);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planova-Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptname;
        private System.Windows.Forms.PictureBox ptmail;
        private System.Windows.Forms.PictureBox ptage;
        private System.Windows.Forms.PictureBox ptpass;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btneye;
    }
}

