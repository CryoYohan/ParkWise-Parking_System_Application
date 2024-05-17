using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingSystemGUI
{
    public partial class MainForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection conn;
        DateTime parkin = DateTime.Now;
        double days, hours, minutes, totalAmount;
        string plateNoVar = "", vehicleTypeVar = "", vehicleBrandVar = "", parkoutDateTimeVar = "", pn, vt, vb;
        string userLog = "";
        public MainForm(string userLog)
        {
            InitializeComponent();
            this.userLog = userLog;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showAllVehicles();
            showMainMenu();
            hideParkin();
            hideDataRegister();
            hideDataGridForm();
            hideResultsForm();
            editPanel.Hide();
            userLogsDBPanel.Hide();
            usersDBPanel.Hide();
            editUsersPanel.Hide();

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
        //
        // Parkin Button
        private void parkinButton_Click(object sender, EventArgs e)
        {
            if (plateNoBox.Text.Trim() != "" && vehicleBrandBox.SelectedItem != null && vehicleTypeCBox.SelectedItem != null)
            {
                plateNoVar = plateNoBox.Text.Trim();
                vehicleTypeVar = vehicleTypeCBox.SelectedItem.ToString();
                vehicleBrandVar = vehicleBrandBox.Text;
                Blueprint bluePrint = new Blueprint(plateNoVar, vehicleTypeVar, vehicleBrandVar);
                bluePrint.GetPoint(out pn, out vt, out vb);
                userLabel.Text = "Admin Cyril Gwapo";
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
            hideDataRegister();
            showAllVehicles();
            showDataGridForm();
            Hide();
            using (ParkingSlotForm parkingSlotForm = new ParkingSlotForm(userLog, pn, vt, vb, parkin))
            {
                parkingSlotForm.ShowDialog();

            }
            Show();
            showAllVehicles();

        }


        private void exeCommands(string command)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void exeCommandsUsers(string command)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void showAllVehicles()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand("SELECT user_id as [Customer ID], plate_no as [Plate Number], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand],parking_slot as [Parking Slot], parkin_datetime as [Park-in Date/Time] from parkwiseDBS");
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ParkWiseDBS");
            vehicleDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void showAllUsers()
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            cmd = new SqlCommand("SELECT usrID as [User ID], usrFN as [First Name], usrLN as [Last Name], usrMI as [Middle Initial], usrname as [Username], usrpw as [Password] FROM Users", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "UsersDB");
            usersDBGrid.DataSource = ds1.Tables[0];
            conn.Close();
        }
        private void showAllUserLogs()
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            cmd = new SqlCommand("SELECT usrLogNo as [User Log No.], usrID as [User ID], usrname as [Username], usrLogDate as [Date/Time] FROM UserLogs", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "UsersDB");
            userLogsDBGrid.DataSource = ds2.Tables[0];
            conn.Close();
        }

        // Register VEHICLE FUNCTION
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

        // PARKOUT Button // Design in Figma for Parking Slots in Results Form
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
        // EDIT BUTTON IN DATAGRID
        private void editBTN_Click(object sender, EventArgs e)
        {
            if (vehicleDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewCell cell in vehicleDataGrid.SelectedRows[0].Cells)
                {
                    // Check if the cell value is not null and not empty
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        editPanel.Show();
                        editPlateNo.Text = vehicleDataGrid.CurrentRow.Cells[1].Value.ToString();
                        editVehicleType.Text = vehicleDataGrid.CurrentRow.Cells[2].Value.ToString();
                        editVehicleBrand.Text = vehicleDataGrid.CurrentRow.Cells[3].Value.ToString();
                    }
                }

            }
            else
                MessageBox.Show("Pick a vehicle to Edit", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Items of vehicle brand in Combo Box Change in EditPanel depending on user's preferrred vehicle type
        private void editVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editVehicleType.SelectedItem == "Motorbike")
            {
                editVehicleBrand.Items.Clear();
                editVehicleBrand.Items.AddRange(new object[] { "Kawasaki", "Yamaha", "Ducatti", "Suzuki", "Honda", "Rusi" });
            }

            else if (editVehicleType.SelectedItem == "SUV")
            {
                editVehicleBrand.Items.Clear();
                editVehicleBrand.Items.AddRange(new object[] { "Toyota", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Ford" });
            }
            else if (editVehicleType.SelectedItem == "Van")
            {
                editVehicleBrand.Items.Clear();
                editVehicleBrand.Items.AddRange(new object[] { "Toyota", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Ford" });
            }

            else if (editVehicleType.SelectedItem == "Sedan")
            {
                editVehicleBrand.Items.Clear();
                editVehicleBrand.Items.AddRange(new object[] { "Porsche", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Toyota" });
            }
        }

        // Done Button in Edit Panel
        private void editDone_Click(object sender, EventArgs e)
        {
            string newPlateNo = editPlateNo.Text;
            string newVehicleType = editVehicleType.Text;
            string newVehicleBrand = editVehicleBrand.Text;
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand("UPDATE parkwiseDBS SET plate_no = @newPlateNo, vehicle_type = @newVehicleType, vehicle_brand = @newVehicleBrand WHERE plate_no = @oldPN", con);
            cmd.Parameters.AddWithValue("@newPlateNo", newPlateNo);
            cmd.Parameters.AddWithValue("@newVehicleType", newVehicleType);
            cmd.Parameters.AddWithValue("@newVehicleBrand", newVehicleBrand);
            cmd.Parameters.AddWithValue("@oldPN", vehicleDataGrid.CurrentRow.Cells[1].Value.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Succesfully Edited!", "ParkWise Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            editPanel.Hide();
            showAllVehicles();
        }

        private void editCancel_Click(object sender, EventArgs e)
        {
            editPanel.Hide();
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
                showAllVehicles();

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
            DataGridButtonMenu.Hide();
            mainMenu2.Hide();
            proceedButton.Hide();
        }
        private void showMainMenu()
        {
            DataGridButtonMenu.Show();
            mainMenu2.Show();
            proceedButton.Show();
        }
        private void hideParkin()
        {
            DataGridButtonParkin.Hide();
            parkinForm1.Hide();
            parkinButton.Hide();
            parkinBackButton.Hide();
            plateNoBox.Hide();
            vehicleTypeCBox.Hide();
            vehicleBrandBox.Hide();
        }
        private void showParkin()
        {
            DataGridButtonParkin.Show();
            parkinButton.Show();
            parkinForm1.Show();
            parkinBackButton.Show();
            plateNoBox.Show();
            vehicleTypeCBox.Show();
            vehicleBrandBox.Show();
        }

        private void hideDataRegister()
        {
            DataGridButtonParkout.Hide();
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
            DataGridButtonParkout.Show();
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
            editBTN.Show();
            dataGridForm1.Show();
            vehicleDataGrid.Show();
            parkAgainButton.Show();
            logoutButton.Show();
            Home.Show();
            parkoutButtonGrid.Show();
            searchBox.Show();
            accessDBVehicles.Show();
            accessDBUsers.Show();
            accessDBUserLogs.Show();
            transactionBTN.Show();
        }
        private void hideDataGridForm()
        {
            editBTN.Hide();
            dataGridForm1.Hide();
            vehicleDataGrid.Hide();
            parkAgainButton.Hide();
            logoutButton.Hide();
            Home.Hide();
            parkoutButtonGrid.Hide();
            searchBox.Hide();
            accessDBVehicles.Hide();
            accessDBUsers.Hide();
            accessDBUserLogs.Hide();
            transactionBTN.Hide();
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

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            con.Open();
            cmd = new SqlCommand("SELECT user_id as [Customer ID], plate_no as [Plate No.], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] FROM parkwiseDBS WHERE user_id like '" + searchBox.Text + "%' OR plate_no like '" + searchBox.Text + "%'", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ParkWiseDBS");
            vehicleDataGrid.DataSource = ds.Tables[0];
            con.Close();

        }

        private void mainMenu2_Load(object sender, EventArgs e)
        {

        }

        private void plateNoResults_Click(object sender, EventArgs e)
        {

        }
        // Access Database Data for Parking Slots
        private void accessDBVehicles_Click(object sender, EventArgs e)
        {
            Hide();
            using (ParkingSlotForm parkingSlotForm = new ParkingSlotForm())
            {
                parkingSlotForm.ShowDialog();
            }
            Show();
        }
        // Access Database Data for Users
        private void accessDBUsers_Click(object sender, EventArgs e)
        {
            usersDBPanel.Show();
            showAllUsers();
        }
        // Access Database Data for User Logs
        private void accessDBUserLogs_Click(object sender, EventArgs e)
        {
            userLogsDBPanel.Show();
            showAllUserLogs();
        }
        // Search Box for Users DB Grid
        private void searchBoxUsers_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            conn.Open();
            cmd = new SqlCommand("SELECT usrID as [User ID], usrFN as [First Name], usrLN as [Last Name], usrMI as [Middle Initial], usrname as [Username], usrpw as [Password] FROM Users WHERE usrFN like '" + searchBoxUsers.Text + "%' OR usrLN like '" + searchBoxUsers.Text + "%'", conn);
            da1 = new SqlDataAdapter(cmd);
            da1.Fill(ds1, "UsersDB");
            usersDBGrid.DataSource = ds1.Tables[0];
            conn.Close();
        }
        // Close Users DB Grid
        private void closeUsersDBGrid_Click(object sender, EventArgs e)
        {
            usersDBPanel.Hide();
        }
        // Search Box for UserLogs DB Grid
        private void searchUserLogsDB_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2;
            DataSet ds2 = new DataSet();
            //conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = UsersDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False;");
            conn.Open();
            cmd = new SqlCommand("SELECT usrLogNo as [User Log No.], usrId as [User ID], usrname as [Username], usrLogDate as [Date/Time] FROM UserLogs WHERE usrId like '" + searchUserLogsDB.Text + "%' OR usrname like '" + searchUserLogsDB.Text + "%'", conn);
            da2 = new SqlDataAdapter(cmd);
            da2.Fill(ds2, "UsersDB");
            userLogsDBGrid.DataSource = ds2.Tables[0];
            conn.Close();
        }
        // Close UserLogs DB Grid
        private void closeUserLogsDB_Click(object sender, EventArgs e)
        {
            userLogsDBPanel.Hide();
        }


        // Close Button Edit User Panel
        private void closeEditUsersBTN_Click(object sender, EventArgs e)
        {
            editUsersPanel.Hide();
        }
        // Checkbox for Edit Users Panel Show Password
        private void editUsersCB_CheckedChanged(object sender, EventArgs e)
        {
            if (editUsersCB.Checked)
            {
                editPassBox.UseSystemPasswordChar = false;
            }
            else if (editUsersCB.CheckState == CheckState.Unchecked)
            {
                editPassBox.UseSystemPasswordChar = true;
            }
        }
        // Checkbox for Edit Users Panel Show Confirm Password
        private void editUsersCB2_CheckedChanged(object sender, EventArgs e)
        {
            if (editUsersCB2.Checked)
            {
                editConfirmPassBox.UseSystemPasswordChar = false;
            }
            else if (editUsersCB2.CheckState == CheckState.Unchecked)
            {
                editConfirmPassBox.UseSystemPasswordChar = true;
            }
        }
        // Done Button in Edit Users Panel
        private void editUsersDoneBTN_Click(object sender, EventArgs e)
        {
            if ((editFnameBox.Text == null || editFnameBox.Text == "") && (editLnameBox.Text == null || editLnameBox.Text == "") && (editMIBox.Text == null || editMIBox.Text == "") && (editUsernameBox.Text == null || editUsernameBox.Text == "") && (editPassBox.Text == null || editPassBox.Text == "") && (editConfirmPassBox.Text == null || editConfirmPassBox.Text == ""))
            {
                MessageBox.Show("Fields cannot be empty!", "ParkWise User Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (editPassBox.Text != editConfirmPassBox.Text)
                MessageBox.Show("Password do not match!", "ParkWise User Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string fname = editFnameBox.Text.Trim();
                string lname = editLnameBox.Text.Trim();
                string extractMI = editMIBox.Text.Trim();
                string minitial = extractMI[0].ToString() + ".";
                string usernameUsr = editUsernameBox.Text.Trim();
                string password = editPassBox.Text.Trim();
                try
                {
                    conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Users SET usrFN = @fname, usrLN = @lname, usrMI = @minitial, usrname = @usernameUsr, usrpw = @password WHERE usrname = @oldPN", conn);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@minitial", minitial);
                    cmd.Parameters.AddWithValue("@usernameUsr", usernameUsr);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@oldPN", usersDBGrid.CurrentRow.Cells[4].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User Succesfully Updated!", "ParkWise Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editUsersPanel.Hide();
                    showAllUsers();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Username already exist! \"{usernameUsr}\"", "ParkWise Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        // Update user button from Users Panel, this opens the Edit Users Panel
        private void updateUserBTN_Click(object sender, EventArgs e)
        {
            if (usersDBGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewCell cell in usersDBGrid.SelectedRows[0].Cells)
                {
                    // Check if the cell value is not null and not empty
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        editUsersPanel.Show();
                        editFnameBox.Text = usersDBGrid.CurrentRow.Cells[1].Value.ToString();
                        editLnameBox.Text = usersDBGrid.CurrentRow.Cells[2].Value.ToString();
                        editMIBox.Text = usersDBGrid.CurrentRow.Cells[3].Value.ToString();
                        editUsernameBox.Text = usersDBGrid.CurrentRow.Cells[4].Value.ToString();
                        editPassBox.Text = usersDBGrid.CurrentRow.Cells[5].Value.ToString();
                        editConfirmPassBox.Text = usersDBGrid.CurrentRow.Cells[5].Value.ToString();
                    }
                }

            }
            else
                MessageBox.Show("Pick a User to Update", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        // Delete a User Button from Users Panel
        private void deleteUserBTN_Click(object sender, EventArgs e)
        {
            if (usersDBGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewCell cell in usersDBGrid.SelectedRows[0].Cells)
                {
                    // Check if the cell value is not null and not empty
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        string username = usersDBGrid.CurrentRow.Cells[4].Value.ToString();
                        string command = "DELETE FROM Users WHERE usrname = '" + username + "'";
                        exeCommandsUsers(command);
                        MessageBox.Show("User successfully deleted!", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showAllUsers();
                    }
                }

            }
            else
                MessageBox.Show("Pick a User to Delete", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Delete a single user log in User Logs
        private void deleteUserLogsBTN_Click(object sender, EventArgs e)
        {
            if (userLogsDBGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewCell cell in userLogsDBGrid.SelectedRows[0].Cells)
                {
                    // Check if the cell value is not null and not empty
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        string extractLogNo = userLogsDBGrid.CurrentRow.Cells[0].Value.ToString();
                        int logNo = Convert.ToInt32(extractLogNo);
                        string command = $"DELETE FROM UserLogs WHERE usrLogNo = {logNo}";
                        exeCommandsUsers(command);
                        MessageBox.Show("User Logs successfully deleted!", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showAllUserLogs();
                    }
                }

            }
            else
                MessageBox.Show("Pick User Logs to Delete", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // Delete all user logs in User Logs
        private void deleteAllUserLogsBTN_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM UserLogs";
            exeCommandsUsers(command);
            MessageBox.Show("All User Logs successfully deleted!", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showAllUserLogs();
        }
        // Dialog for Closing the form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to close the application?", "ParkWise Parking System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                Dispose();
            }
            else
                e.Cancel = true;
        }

        private void resultsForm1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridForm1_Load_1(object sender, EventArgs e)
        {
            showAllVehicles();
        }
        // Transactions Form
        private void transactionBTN_Click(object sender, EventArgs e)
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
            return vehicleChargeConditions(hours, minutes, addHour, motorbikeFee);

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
