using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class Form1 : Form
    {
        MainForm mainForm = new MainForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string promptUser = "";
        private string promptPass = "";

        private void button1_Click(object sender, EventArgs e)
        {
            promptUser = userTextbox.Text;
            promptPass = passwordTextbox.Text;
            if (promptUser == mainForm.GetUser() && promptPass == mainForm.GetPassword())
            {
                MessageBox.Show("Login Succesful", "LOGIN");
                userTextbox.Text = "";
                passwordTextbox.Text = "";
                Hide();
                using (MainForm mainForm = new MainForm())
                {
                    mainForm.ShowDialog();
                }
                Show();
            }
            else if(promptUser == "" || promptPass == "")
            {
                MessageBox.Show("Field cannot be empty!", "LOGIN");
                if(promptUser == null)
                {
                    userTextbox.ForeColor = Color.Red;
                    userTextbox.PlaceholderText = "Field cannot be empty!";
                    Thread.Sleep(1500);
                    userTextbox.ForeColor = Color.LightGray;
                    userTextbox.PlaceholderText = "Enter username";
                }
                else if(promptPass == null)
                {
                    passwordTextbox.ForeColor = Color.Red;
                    passwordTextbox.PlaceholderText = "Field cannot be empty!";
                    Thread.Sleep(1500);
                    passwordTextbox.ForeColor = Color.LightGray;
                    passwordTextbox.PlaceholderText = "Enter password";
                }
            }
            else
                MessageBox.Show("Login Failed", "LOGIN");
        }
    }
}
