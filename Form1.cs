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
            else
                MessageBox.Show("Login Failed", "LOGIN");
        }
    }
}
