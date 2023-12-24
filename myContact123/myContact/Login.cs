using System;
using System.Windows.Forms;

namespace myContact
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Additional initialization code if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the entered username and password are "nabi"
            if (userTb.Text == "djafar" && passwordTb.Text == "122333")
            {
                // If true, create an instance of the Contacts form
                Contacts contactForm = new Contacts();

                // Show the Contact form
                contactForm.Show();

                // Hide the current form (Login form)
                this.Hide();
            }
            else
            {
                // If the username or password is not "nabi", show a message
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for userTb if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for passwordTb if needed
        }
    }
}