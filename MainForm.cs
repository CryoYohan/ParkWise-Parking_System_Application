using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlCommand cmd;
        SqlConnection con;
        private string username = "Admin";
        private string password = "admin123";
        private string idGeneratedVar;
        DateTime parkin = DateTime.Now;
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
            showAllVehicles();
            showMainMenu();
            hideParkin();
            hideDataRegister();
            hideDataGridForm();
            hideResultsForm();

        }

        private void parkinForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            if (plateNoBox.Text.Trim() != "" && vehicleBrandBox.SelectedItem != null && vehicleTypeCBox.SelectedItem != null)
            {
                plateNoVar = plateNoBox.Text.Trim();
                vehicleTypeVar = vehicleTypeCBox.SelectedItem.ToString();
                vehicleBrandVar = vehicleBrandBox.Text;
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
            else
            {
                MessageBox.Show("Fill in empty fields, please");
            }

        }
        // Proceed Button in MainMenu Form
        private void proceedButton_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showParkin();
        }

        // Removes registered data for a new one to be stored
        private void removeCollectedData()
        {
            userLabel.Text = "";
            parkinDateLabel.Text = "";
            vehicleBrandBox.Items.Clear();
            vehicleTypeCBox.SelectedItem = null;
            plateNoLabel.Text = "";
            vehicleTLabel.Text = "";
            vehicleBLabel.Text = "";
            plateNoBox.Text = "";
            vehicleTypeCBox.Text = "";
            vehicleBrandBox.Text = "";
        }
        // The back button in Data Registered Form
        private void parkoutBackButton_Click(object sender, EventArgs e)
        {
            hideDataRegister();
            showParkin();
        }
        // The back button in Park-in Form
        private void parkinBackButton_Click_1(object sender, EventArgs e)
        {
            hideParkin();
            showMainMenu();
        }

        // Confirm Button in Data Registered
        private void parkoutButton_Click(object sender, EventArgs e)
        {
            idGeneratedVar = idGenerator();
            //vehicleDataGrid.Rows.Add(idGeneratedVar, pn, vt, vb, parkin);        
            string command = "INSERT INTO parkwiseDBS(plate_no,vehicle_type, vehicle_brand,parkin_datetime)" +
                "VALUES('" + pn + "', '" + vt + "', '" + vb + "', '" + parkin + "')";
            bool duplicatePlateNo = false;
            try
            {
                exeCommands(command);
            }
            catch (Exception)
            {
                duplicatePlateNo = true;
            }
            if (duplicatePlateNo == true)
            {
                MessageBox.Show("Plate No. already exist!", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                hideDataRegister();
                showParkin();
            }
            else
            {
                hideDataRegister();
                showAllVehicles();
                showDataGridForm();
            }


        }

        private void exeCommands(string command)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void showAllVehicles()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand("SELECT user_id as [Customer ID], plate_no as [Plate Number], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] from parkwiseDBS");
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ParkWiseDBS");
            vehicleDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
 
        // ADD VEHICLE FUNCTION
        private void parkAgainButton_Click(object sender, EventArgs e)
        {
            removeCollectedData();
            hideDataGridForm();
            showParkin();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to log-out?", "ParkWise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                removeCollectedData();
                this.Close();
            }
        }
        private void DataGridButtonMenu_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showDataGridForm();
        }

        private void DataGridButtonParkin_Click(object sender, EventArgs e)
        {
            hideParkin();
            showDataGridForm();
        }
        // DataGRID Access in Parkout Form
        private void DataGridButtonParkout_Click(object sender, EventArgs e)
        {
            hideDataRegister();
            showDataGridForm();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleTypeCBox.SelectedItem == "Motorbike")
            {
                vehicleBrandBox.Items.Clear();
                vehicleBrandBox.Items.AddRange(new object[] { "Kawasaki", "Yamaha", "Ducatti", "Suzuki", "Honda", "Rusi" });
            }

            else if (vehicleTypeCBox.SelectedItem == "SUV")
            {
                vehicleBrandBox.Items.Clear();
                vehicleBrandBox.Items.AddRange(new object[] { "Toyota", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Ford" });
            }
            else if (vehicleTypeCBox.SelectedItem == "Van")
            {
                vehicleBrandBox.Items.Clear();
                vehicleBrandBox.Items.AddRange(new object[] { "Toyota", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Ford" });
            }

            else if (vehicleTypeCBox.SelectedItem == "Sedan")
            {
                vehicleBrandBox.Items.Clear();
                vehicleBrandBox.Items.AddRange(new object[] { "Porsche", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Toyota" });
            }
        }

        private void vehicleBLabel_Click(object sender, EventArgs e)
        {

        }

        // PARKOUT Button
        private void parkoutButtonGrid_Click(object sender, EventArgs e)
        {

            if (vehicleDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewCell cell in vehicleDataGrid.SelectedRows[0].Cells)
                {
                    // Check if the cell value is not null and not empty
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        // If at least one cell in the selected row contains data, return false
                        DateTime parkoutDateTime = DateTime.Now;
                        TimeSpan calcDate = parkoutDateTime.Subtract(parkin);
                        days = calcDate.Days;
                        hours = calcDate.Hours;
                        minutes = calcDate.Minutes;
                        DialogResult dg = MessageBox.Show("Confirm Parkout", "ParkWise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            if (parkoutDateTime < parkin)
                            {
                                MessageBox.Show("Invalid Date. Park-out Date cannot be before the Park-in Date.", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                totalAmount = IdentifyVehicleType(vehicleDataGrid.CurrentRow.Cells[2].Value.ToString().ToLower(), hours, days, minutes); // if any of these objects are null, set trappings for this
                                customerIDResults.Text = vehicleDataGrid.CurrentRow.Cells[0].Value.ToString();
                                plateNoResults.Text = vehicleDataGrid.CurrentRow.Cells[1].Value.ToString();
                                vehicleTypeResults.Text = vehicleDataGrid.CurrentRow.Cells[2].Value.ToString();
                                vehicleBrandResults.Text = vehicleDataGrid.CurrentRow.Cells[3].Value.ToString();
                                parkinResults.Text = vehicleDataGrid.CurrentRow.Cells[4].Value.ToString();
                                parkoutResults.Text = parkoutDateTime.ToString();
                                durationResults.Text = $"{days} day(s) {hours} hour(s) {minutes} minute(s)";
                                flagDownResults.Text = $"₱{getFlagDown(vehicleDataGrid.CurrentRow.Cells[2].Value.ToString().ToLower())}.00";
                                totalAmountResults.Text = $"₱{totalAmount}.00";
                                showResultsForm();
                            }
                            break;
                        }
                        else
                            break;
                    }
                }

            }
            else if (vehicleDataGrid.Rows.Count == 0)
                MessageBox.Show("No Vehicles to Park-out");
            else
                MessageBox.Show("Select Vehicles to Park-out");


        }
        private double getFlagDown(string vehicle)
        {
            switch (vehicle)
            {

                case "motorbike":
                    return 20.00;
                    break;
                case "suv":
                case "van":
                    return 40.00;
                    break;
                case "sedan":
                    return 30.00;
                    break;
                default:
                    return 0;
                    break;
            }

        }
        // Main Menu Button
        private void Home_Click(object sender, EventArgs e)
        {
            hideDataGridForm();
            showMainMenu();
            removeCollectedData();
        }

        // Confirm button in Results Form
        private void confirmResultsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in vehicleDataGrid.SelectedRows)
            {
                // Remove the entire row from the DataGridView
                string command = "DELETE FROM parkwiseDBS WHERE user_id = '" + vehicleDataGrid.CurrentRow.Cells[0].Value.ToString() + "'";
                exeCommands(command);
                vehicleDataGrid.Rows.Remove(row);

            }
            customerIDResults.Text = "";
            plateNoResults.Text = "";
            vehicleTypeResults.Text = "";
            vehicleBrandResults.Text = "";
            parkinResults.Text = "";
            parkoutResults.Text = "";
            durationResults.Text = "";
            totalAmountResults.Text = "";
            hideResultsForm();
            showDataGridForm();
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
        }
        private void showParkin()
        {
            parkinButton.Show();
            parkinForm1.Show();
            parkinBackButton.Show();
            plateNoBox.Show();
            vehicleTypeCBox.Show();
            vehicleBrandBox.Show();
        }

        private void hideDataRegister()
        {
            dataRegistered1.Hide();
            userLabel.Hide();
            plateNoLabel.Hide();
            vehicleTLabel.Hide();
            vehicleBLabel.Hide();
            parkinDateLabel.Hide();
            ConfirmButton.Hide();
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
            ConfirmButton.Show();
            parkoutBackButton.Show();
        }
        private void showDataGridForm()
        {
            dataGridForm1.Show();
            vehicleDataGrid.Show();
            parkAgainButton.Show();
            logoutButton.Show();
            Home.Show();
            parkoutButtonGrid.Show();
            searchBox.Show();
        }
        private void hideDataGridForm()
        {
            dataGridForm1.Hide();
            vehicleDataGrid.Hide();
            parkAgainButton.Hide();
            logoutButton.Hide();
            Home.Hide();
            parkoutButtonGrid.Hide();
            searchBox.Hide();
        }

        private void hideResultsForm()
        {
            resultsForm1.Hide();
            confirmResultsButton.Hide();
            customerIDResults.Hide();
            plateNoResults.Hide();
            vehicleBrandResults.Hide();
            vehicleTypeResults.Hide();
            parkinResults.Hide();
            parkoutResults.Hide();
            durationResults.Hide();
            flagDownResults.Hide();
            totalAmountResults.Hide();
        }
        private void showResultsForm()
        {
            resultsForm1.Show();
            confirmResultsButton.Show();
            customerIDResults.Show();
            plateNoResults.Show();
            vehicleBrandResults.Show();
            vehicleTypeResults.Show();
            parkinResults.Show();
            parkoutResults.Show();
            durationResults.Show();
            flagDownResults.Show();
            totalAmountResults.Show();
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

        private void vehicleBrandBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridForm1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Search BOX in DataGrid to show existing records by initials and numbers
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT user_id as [Customer ID], plate_no as [Plate No.], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] FROM parkwiseDBS WHERE user_id like '" + searchBox.Text + "%' OR plate_no like '" + searchBox.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ParkWiseDBS");
            vehicleDataGrid.DataSource = ds.Tables[0];
            con.Close();
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
