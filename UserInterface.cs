using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ParkingSystemGUI
{
    public partial class UserInterface : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        DateTime parkin = DateTime.Now;
        double days, hours, minutes, totalAmount;
        private string username = "";
        public UserInterface()
        {

        }
        public UserInterface(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        // Vehicle Type CombO Box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleTypeCBox.SelectedItem == "Motorbike")
            {
                vehicleBrandCBox.Items.Clear();
                vehicleBrandCBox.Items.AddRange(new object[] { "Kawasaki", "Yamaha", "Ducatti", "Suzuki", "Honda", "Rusi" });
            }

            else if (vehicleTypeCBox.SelectedItem == "SUV")
            {
                vehicleBrandCBox.Items.Clear();
                vehicleBrandCBox.Items.AddRange(new object[] { "Toyota", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Ford" });
            }
            else if (vehicleTypeCBox.SelectedItem == "Van")
            {
                vehicleBrandCBox.Items.Clear();
                vehicleBrandCBox.Items.AddRange(new object[] { "Toyota", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Ford" });
            }

            else if (vehicleTypeCBox.SelectedItem == "Sedan")
            {
                vehicleBrandCBox.Items.Clear();
                vehicleBrandCBox.Items.AddRange(new object[] { "Porsche", "Nissan", "Volkswagen", "Mercedez", "Hyundai", "Toyota" });
            }
        }

        private string plateNoVar = "", vehicleTypeVar = "", vehicleBrandVar, parkoutDateTimeVar = "", pn, vt, vb;

        // Park-in Button 
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Confirm Park-in? Re-check details if needed.", "ParkWise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {

                if (plateNoBox.Text.Trim() != "" && vehicleBrandCBox.SelectedItem != null && vehicleTypeCBox.SelectedItem != null)
                {
                    plateNoVar = plateNoBox.Text.Trim();
                    vehicleTypeVar = vehicleTypeCBox.SelectedItem.ToString();
                    vehicleBrandVar = vehicleBrandCBox.Text;
                    Blueprint bluePrint = new Blueprint(plateNoVar, vehicleTypeVar, vehicleBrandVar);
                    bluePrint.GetPoint(out pn, out vt, out vb);
                    userLabel.Text = $"User: {username}";
                    plateNoLabelRegister.Text = pn;
                    vehicleTypeLabelRegister.Text = vt;
                    vehicleBrandLabelRegister.Text = vb;
                    parkinTimeLabelRegister.Text = parkin.ToString();
                    hideParkinForm();
                    showDataRegisteredForm();
                }
                else
                {
                    MessageBox.Show("Fill in empty fields, please");
                }
            }
        }

        private void exeCommands(string command)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // Register vehicle details in DB and this method is used in the confirm button function in DataRegistered Form
        private void registerVehicleToDB(string pn, string vt, string vb, string parkin)
        {
            string command = "INSERT INTO parkwiseDBS(plate_no,vehicle_type, vehicle_brand,parkin_datetime)" +
               "VALUES('" + pn + "', '" + vt + "', '" + vb + "', '" + parkin + "')";
            exeCommands(command);
        }

        // Proceed Button in Main Menu Form
        private void proceedBTN_Click(object sender, EventArgs e)
        {
            hideMainMenu();
            showParkinForm();
            hideDataRegisteredForm();
        }

        // Confirm Button in Data Registered form
        private void button2_Click(object sender, EventArgs e)
        {
            plateNoVar = plateNoBox.Text.Trim();
            vehicleTypeVar = vehicleTypeCBox.SelectedItem.ToString();
            vehicleBrandVar = vehicleBrandCBox.Text;
            Blueprint bluePrint = new Blueprint(plateNoVar, vehicleTypeVar, vehicleBrandVar);
            bluePrint.GetPoint(out pn, out vt, out vb);
             bool duplicatePlateNo = false;
            try
            {
                registerVehicleToDB(pn, vt, vb, parkin.ToString());
            }
            catch (Exception)
            {
                duplicatePlateNo = true;
            }
            if (duplicatePlateNo == true)
            {
                MessageBox.Show("Plate No. already exist!", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
                hideDataRegisteredForm();
                showParkinForm();
            }
            else
            {
                showDataGridForm();
            }

        }



        // Get Flagdown
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

        // Show and Hide Elements

        private void showMainMenu()
        {
            mainMenu1.Show();
            proceedBTN.Show();
            dataGridBTN.Show();
        }
        private void hideMainMenu()
        {
            mainMenu1.Hide();
            proceedBTN.Hide();
        }

        private void showParkinForm()
        {
            parkinForm1.Show();
            plateNoBox.Show();
            vehicleTypeCBox.Show();
            vehicleBrandCBox.Show();
            button1.Show(); // Park-in Button
            backBTNParkin.Show();
            dataGridBTN.Show();
        }

        private void hideParkinForm()
        {
            parkinForm1.Hide();
            plateNoBox.Hide();
            vehicleTypeCBox.Hide();
            vehicleBrandCBox.Hide();
            button1.Hide(); // Park-in Button
            backBTNParkin.Hide();
        }

        private void showDataRegisteredForm()
        {
            dataRegistered1.Show();
            plateNoLabelRegister.Show();
            vehicleTypeLabelRegister.Show();
            vehicleBrandLabelRegister.Show();
            parkinTimeLabelRegister.Show();
            confirmBTN.Show();
            userLabel.Show();
            backBTNParkn.Show();
        }

        private void hideDataRegisteredForm()
        {
            dataRegistered1.Hide();
            plateNoLabelRegister.Hide();
            vehicleTypeLabelRegister.Hide();
            vehicleBrandLabelRegister.Hide();
            parkinTimeLabelRegister.Hide();
            confirmBTN.Hide();
            userLabel.Hide();
            backBTNParkn.Hide();
        }

        private void showDataGridForm()
        {
            dataGridForm1.Show();
            searchBox.Show();
            vehicleDataGrid.Show();
            parkoutBTN.Show();
            addVehicleBTN.Show();
            editBTN.Show();
            logoutBTN.Show();
            menuBTN.Show();
            dataGridBTN.Hide();
            showAllVehicles();
        }
        private void hideDataGridForm()
        {
            dataGridForm1.Hide();
            searchBox.Hide();
            vehicleDataGrid.Hide();
            parkoutBTN.Hide();
            addVehicleBTN.Hide();
            editBTN.Hide();
            logoutBTN.Hide();
            menuBTN.Hide();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            showAllVehicles();
            showMainMenu();
            dataGridBTN.Show();
            hideParkinForm();
            hideDataRegisteredForm();
            hideDataGridForm();
            receiptPanel.Hide();
            editPanel.Hide();
        }


        private void logoutBTN_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to log-out?", "ParkWise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                removeCollectedData();
                Close();
            }
        }


        // Removes registered data for a new one to be stored
        private void removeCollectedData()
        {
            userLabel.Text = "";
            parkinTimeLabelRegister.Text = "";
            vehicleBrandCBox.Items.Clear();
            vehicleTypeCBox.SelectedItem = null;
            plateNoLabelRegister.Text = "";
            vehicleTypeLabelRegister.Text = "";
            vehicleBrandLabelRegister.Text = "";
            plateNoBox.Text = "";
            vehicleTypeCBox.Text = "";
            vehicleBrandCBox.Text = "";
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

        private void vehicleTypeLabelRegister_Click(object sender, EventArgs e)
        {

        }

        private void closeReceiptButton_Click(object sender, EventArgs e)
        {
            receiptPanel.Hide();
            hideDataRegisteredForm();
            hideMainMenu();
            removeCollectedData();
        }
        // Back button to navigate to Main menu form
        private void backBTNParkin_Click(object sender, EventArgs e)
        {
            showMainMenu();
            hideParkinForm();
        }
        // Back arrow button to navigate back to Park-in Prompt details
        private void backBTNParkn_Click(object sender, EventArgs e)
        {
            showParkinForm();
            hideDataRegisteredForm();
        }
        // Search Box for Database Vehicles
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            conn.Open();
            cmd = new SqlCommand("SELECT user_id as [Customer ID], plate_no as [Plate No.], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] FROM parkwiseDBS WHERE user_id like '" + searchBox.Text + "%' OR plate_no like '" + searchBox.Text + "%'", conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ParkWiseDBS");
            vehicleDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }
        // Add vehicle function
        private void button3_Click(object sender, EventArgs e)
        {
            removeCollectedData();
            hideDataGridForm();
            showParkinForm();
        }

        // Parkout Button function
        private void parkoutBTN_Click(object sender, EventArgs e)
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
                                string pn = vehicleDataGrid.CurrentRow.Cells[1].Value.ToString();
                                DateTime dtreceipt = DateTime.Now;
                                totalAmount = IdentifyVehicleType(vehicleDataGrid.CurrentRow.Cells[2].Value.ToString().ToLower(), hours, days, minutes); // if any of these objects are null, set trappings for this
                                timeAndDateReceipt.Text = dtreceipt.ToString();
                                customerIDResults.Text = $"Customer #: {vehicleDataGrid.CurrentRow.Cells[0].Value.ToString()}";
                                plateNoResults.Text = $"Plate No.: {pn}";
                                vehicleTypeResults.Text = $"Vehicle Type: {vehicleDataGrid.CurrentRow.Cells[2].Value.ToString()}";
                                vehicleBrandResults.Text = $"Vehicle Brand: {vehicleDataGrid.CurrentRow.Cells[3].Value.ToString()}";
                                parkinResults.Text = $"Park-in Date/Time: {vehicleDataGrid.CurrentRow.Cells[4].Value.ToString()}";
                                parkoutResults.Text = $"Park-out Date/Time: {parkoutDateTime.ToString()}";
                                durationResults.Text = $"Duration: {days} day(s) {hours} hour(s) {minutes} minute(s)";
                                flagDownResults.Text = $"Flagdown: ₱{getFlagDown(vehicleDataGrid.CurrentRow.Cells[2].Value.ToString().ToLower())}.00";
                                totalAmountResults.Text = $"Total Amount: ₱{totalAmount}.00";
                                receiptPanel.Show();
                                // REMOVE DATA FROM DB
                                string command = "DELETE FROM parkwiseDBS WHERE plate_no = '" + pn + "'";
                                exeCommands(command);
                                showAllVehicles();
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

        // Edit button function
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

        // Mainmenu button function
        private void menuBTN_Click(object sender, EventArgs e)
        {
            hideDataGridForm();
            showMainMenu();
        }
        // Load database Vehicles
        private void showAllVehicles()
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            cmd = new SqlCommand("SELECT user_id as [Customer ID], plate_no as [Plate Number], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] from parkwiseDBS");
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ParkWiseDBS");
            vehicleDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dataGridForm1_Load(object sender, EventArgs e)
        {
            dataGridBTN.Hide();
        }
        // Edit Text changed Vehicle Type combobox
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
        // Edit Text changed Vehicle Brand combobox
        private void editVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Done Button in Edit PANEL
        private void doneBTNedit_Click(object sender, EventArgs e)
        {
            string newPlateNo = editPlateNo.Text;
            string newVehicleType = editVehicleType.Text;
            string newVehicleBrand = editVehicleBrand.Text;
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            cmd = new SqlCommand("UPDATE parkwiseDBS SET plate_no = @newPlateNo, vehicle_type = @newVehicleType, vehicle_brand = @newVehicleBrand WHERE plate_no = @oldPN", conn);
            cmd.Parameters.AddWithValue("@newPlateNo", newPlateNo);
            cmd.Parameters.AddWithValue("@newVehicleType", newVehicleType);
            cmd.Parameters.AddWithValue("@newVehicleBrand", newVehicleBrand);
            cmd.Parameters.AddWithValue("@oldPN", vehicleDataGrid.CurrentRow.Cells[1].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Succesfully Edited!", "ParkWise Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            editPanel.Hide();
            dataGridBTN.Hide();
            showAllVehicles();
        }
        // Close button in edit panel
        private void editCloseBTN_Click(object sender, EventArgs e)
        {
            editPanel.Hide();
        }

        private void dataGridBTN_Click(object sender, EventArgs e)
        {
            showDataGridForm();
            hideMainMenu();
            hideParkinForm();
            hideDataRegisteredForm();
        }
    }
}
