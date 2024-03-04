using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class MainForm : Form
    {
        private string username = "Negusius";
        private string password = "negus123";
        DateTime parkin = DateTime.Now;
        DateTime parkout;
        double days, hours, minutes, totalAmount;
        string plateNoVar = "", vehicleTypeVar = "", vehicleBrandVar = "", parkoutDateTimeVar = "", pn, vt, vb;
        public MainForm()
        {
            InitializeComponent();

        }

        public string GetUser() { return username; }
        public string GetPassword() { return password; }

        private void mainMenu1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showMainMenu();
            hideParkin();
            hideDataRegister();
            hideResults();
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
        private void parkinForm1_Load_1(object sender, EventArgs e)
        {

        }

        //---- Changing Panels Functionality of Buttons-------
        private void parkinButton_Click(object sender, EventArgs e)
        {
            plateNoVar = plateNoBox.Text;
            vehicleTypeVar = vehicleTypeCBox.SelectedItem.ToString();
            vehicleBrandVar = vehicleBrandBox.Text;
            parkoutDateTimeVar = $"{monthCBox.SelectedItem?.ToString()}/{dayCBox.SelectedItem?.ToString()}/{yearCBox.SelectedItem?.ToString()} {hourCBox.SelectedItem?.ToString()}:{minuteCBox.SelectedItem?.ToString()} {amPMCBox.SelectedItem?.ToString()}";
            parkout = DateTime.Parse(parkoutDateTimeVar);

            TimeSpan calcDate = parkout.Subtract(parkin);
            days = calcDate.Days;
            hours = calcDate.Hours;
            minutes = calcDate.Minutes;
            Blueprint bluePrint = new Blueprint(plateNoVar, vehicleTypeVar, vehicleBrandVar);
            bluePrint.GetPoint(out pn, out vt, out vb);
            userLabel.Text = username;
            plateNoLabel.Text = pn;
            vehicleTLabel.Text = vt;
            vehicleBLabel.Text = vb;
            parkinDateLabel.Text = parkin.ToString();
            hideParkin();
            showDataRegister();
        }

        // Removes registered data for a new one to be stored
        private void removeCollectedData()
        {
            userLabel.Text = "";
            parkinDateLabel.Text = "";
            customerLabelResults.Text = "";
            plateNoLabel.Text = "";
            vehicleTLabel.Text = "";
            vehicleBLabel.Text = "";
            plateNoResultsLabel.Text = "";
            vehicleTypeResultsLabel.Text = "";
            vehicleBrandResultsLabel.Text = "";
            date1ResultsLabel.Text = "";
            date2ResultsLabel.Text = "";
            durationResultsLabel.Text = "";
            totalAmountResultsLabel.Text = "";
            plateNoBox.Text = "";
            vehicleTypeCBox.Text = "";
            vehicleBrandBox.Text = "";
            monthCBox.Text = "";
            dayCBox.Text = "";
            yearCBox.Text = "";
            hourCBox.Text = "";
            minuteCBox.Text = "";
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
        private void parkoutButton_Click(object sender, EventArgs e)
        {
            hideDataRegister();
            customerLabelResults.Text = username;
            plateNoResultsLabel.Text = pn;
            vehicleTypeResultsLabel.Text = vt;
            vehicleBrandResultsLabel.Text = vb;
            totalAmount = IdentifyVehicleType(vt.ToLower(), hours, days, minutes);
            date1ResultsLabel.Text = parkin.ToString();
            date2ResultsLabel.Text = parkout.ToString();
            durationResultsLabel.Text = $"{days} day(s) {hours} hour(s) {minutes} minute(s)";
            totalAmountResultsLabel.Text = $"{totalAmount}";
            // flagdownResultsLabel
            showResults();

        }

        private void parkAgainButton_Click(object sender, EventArgs e)
        {
            removeCollectedData();
            hideResults();
            showMainMenu();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            removeCollectedData();
            this.Close();
        }


        // Switch for Chosen Vehicle Type
        public double IdentifyVehicleType(string vehicle, double hours, double days, double minutes)
        {
            const int dayHours = 24;
            int vehicleIndex = 0;
            switch (vehicle)
            {

                case "motorbike":
                    vehicleIndex = 0;
                    return returnCalculatedFeeCondition(days, hours, minutes, dayHours, vehicleIndex);
                    break;
                case "suv":
                case "van":
                    vehicleIndex = 1;
                    return returnCalculatedFeeCondition(days, hours, minutes, dayHours, vehicleIndex);
                    break;
                case "sedan":
                    vehicleIndex = 2;
                    return returnCalculatedFeeCondition(days, hours, minutes, dayHours, vehicleIndex);
                    break;
                default:
                    return 0;
                    break;
            }
        }
        // Reusable Condition Method for Fee Calculation
        public double returnCalculatedFeeCondition(double days, double hours, double minutes, double dayHours24, int vehicleIndex)
        {
            Motorbike motorbike = new Motorbike();
            SUVan suvan = new SUVan();
            Sedan sedan = new Sedan();
            switch (vehicleIndex)
            {
                case 0:
                    if (days > 0)
                    {
                        if (hours == 0)
                            return motorbike.chargingFee((days * dayHours24), minutes);
                        else
                        {
                            double current = motorbike.chargingFee((hours + (days * 24)), minutes);
                            return current;
                        }
                    }
                    else
                        return motorbike.chargingFee(hours, minutes);
                    break;
                case 1:
                    if (days > 0)
                    {
                        if (hours == 0)
                            return suvan.chargingFee((days * dayHours24), minutes);
                        else
                        {
                            double current = suvan.chargingFee((hours + (days * 24)), minutes);
                            return current;
                        }
                    }
                    else
                        return suvan.chargingFee(hours, minutes);
                    break;
                case 2:
                    if (days > 0)
                    {
                        if (hours == 0)
                            return sedan.chargingFee((days * dayHours24), minutes);
                        else
                        {
                            double current = sedan.chargingFee((hours + (days * 24)), minutes);
                            return current;
                        }
                    }
                    else
                        return sedan.chargingFee(hours, minutes);
                    break;
                default:
                    return 0;
                    break;
            }
        }

        // WATCH OUT MA ERROR NI DIRE, POSSIBLY

        // Methods for Showing and Hiding necesarry Pages
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
        private void showResults()
        {
            resultsForm1.Show();
            customerLabelResults.Show();
            plateNoResultsLabel.Show();
            vehicleTypeResultsLabel.Show();
            vehicleBrandResultsLabel.Show();
            date1ResultsLabel.Show();
            date2ResultsLabel.Show();
            durationResultsLabel.Show();
            flagdownResultsLabel.Show();
            totalAmountResultsLabel.Show();
            parkAgainButton.Show();
            logoutButton.Show();
        }
        private void hideResults()
        {
            resultsForm1.Hide();
            customerLabelResults.Hide();
            plateNoResultsLabel.Hide();
            vehicleTypeResultsLabel.Hide();
            vehicleBrandResultsLabel.Hide();
            date1ResultsLabel.Hide();
            date2ResultsLabel.Hide();
            durationResultsLabel.Hide();
            flagdownResultsLabel.Hide();
            totalAmountResultsLabel.Hide();
            parkAgainButton.Hide();
            logoutButton.Hide();
        }

        private void amPMCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataRegistered1_Load(object sender, EventArgs e)
        {

        }

        private void customerLabelResults_Click(object sender, EventArgs e)
        {

        }

        private void vehicleTLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public abstract class Charge
    {
        public double chargeFee = 0;
        public string plateNo = "", vehicleType = "", vehicleBrand = "";
        public double motorbikeFee = 20.00, suvVanFee = 40.00, sedanFee = 30.00;
        public DateTime dateTime = DateTime.Now;
        public abstract double chargingFee(double hours, double minutes);
        public double vehicleChargeConditions(double hours, double minutes, double addHour, double vehicleFee)
        {
            if (minutes >= 30)
            {
                chargeFee = (hours * addHour) + vehicleFee;
                return chargeFee + addHour;
            }
            else
            {
                chargeFee = (hours * addHour) + vehicleFee;
                return chargeFee;
            }
        }
    }

    public class Motorbike : Charge
    {
        public override double chargingFee(double hours, double minutes)
        {
            const double addHour = 5.00;
            return vehicleChargeConditions(hours, minutes, addHour,motorbikeFee);

        }     
    }
    public class SUVan : Charge
    {
        public override double chargingFee(double hours, double minutes)
        {
            const double addHour = 20.00;
            return vehicleChargeConditions(hours, minutes, addHour, suvVanFee);
        }
    }
    public class Sedan : Charge
    {
        public override double chargingFee(double hours, double minutes)
        {
            const double addHour = 15.00;
            return vehicleChargeConditions(hours, minutes, addHour, sedanFee);
        }
    }
    public class Blueprint
    {
        public Blueprint(string plateNo, string vehicleType, string vehicleBrand)
        {
            this.plateNo = plateNo;
            this.vehicleType = vehicleType;
            this.vehicleBrand = vehicleBrand;
        }
        public void GetPoint(out string plateNo, out string vehicleType, out string vehicleBrand)
        {
            plateNo = this.plateNo;
            vehicleType = this.vehicleType;
            vehicleBrand = this.vehicleBrand;
        }

        string plateNo = "", vehicleType = "", vehicleBrand = "";
    }
}
