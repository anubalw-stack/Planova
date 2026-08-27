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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if (Session.IsLoggedIn)
            {
                labelWelcome.Text = "Welcome, " + Session.LoggedInEmail;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventDetails eventdetais = new EventDetails();
            eventdetais.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CategoriesForm form5 = new CategoriesForm();
            form5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CartForm form6 = new CartForm();
            form6.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            labelWelcome.Text = " ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
