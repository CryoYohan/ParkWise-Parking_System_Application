using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void mainMenu1_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showMainMenu();
            hideParkin();
            hideDataRegister();
        }

        private void parkinForm1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showParkin();
        }

        private void mainMenu1_Load_1(object sender, EventArgs e)
        {

        }

        private void parkinForm4_Load(object sender, EventArgs e)
        {

        }

        private void parkinButton_Click(object sender, EventArgs e)
        {
            hideParkin();
            showDataRegister();
        }
        private void parkoutBackButton_Click(object sender, EventArgs e)
        {
            hideDataRegister();
            showParkin();
        }

        private void parkinBackButton_Click_1(object sender, EventArgs e)
        {
            hideParkin();
            showMainMenu();
        }

        private void parkinForm1_Load_1(object sender, EventArgs e)
        {

        }

       
        private void hideMainMenu()
        {
            mainMenu1.Hide();
            proceedButton.Hide();
        }
        private void showMainMenu()
        {
            mainMenu1.Show();
            proceedButton.Show();
        }
        private void hideParkin()
        {
            parkinForm1.Hide();
            parkinButton.Hide();
            parkinBackButton.Hide();
            plateNoBox.Hide();
            vehicleTypeCBox.Hide();
            vehicleBrandBox.Hide();
            monthCBox.Hide();
            dayCBox.Hide();
            yearCBox.Hide();
            hourCBox.Hide();
            minuteCBox.Hide();
            amPMCBox.Hide();
        }
        private void showParkin()
        {
            parkinButton.Show();
            parkinForm1.Show();
            parkinBackButton.Show();
            plateNoBox.Show();
            vehicleTypeCBox.Show();
            vehicleBrandBox.Show();
            monthCBox.Show();
            dayCBox.Show();
            yearCBox.Show();
            hourCBox.Show();
            minuteCBox.Show();
            amPMCBox.Show();
        }

        private void hideDataRegister()
        {
            dataRegistered1.Hide();
            userLabel.Hide();
            plateNoLabel.Hide();
            vehicleTLabel.Hide();
            vehicleBLabel.Hide();
            parkinDateLabel.Hide();
            parkoutButton.Hide();
            parkoutBackButton.Hide();
        }
        private void showDataRegister()
        {
            dataRegistered1.Show();
            userLabel.Show();
            plateNoLabel.Show();
            vehicleTLabel.Show();
            vehicleBLabel.Show();
            parkinDateLabel.Show();
            parkoutButton.Show();
            parkoutBackButton.Show();
        }

        private void amPMCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataRegistered1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
