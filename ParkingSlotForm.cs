using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class ParkingSlotForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlConnection conn;
        const int maxSlots = 25;
        string userLog = "", pn ="", vt = "", vb = "";
        DateTime parkin;
        public ParkingSlotForm(string userLog, string pn, string vt, string vb, DateTime parkin)
        {
            InitializeComponent();
            this.userLog = userLog;
            this.pn = pn;
            this.vt = vt;
            this.vb = vb;
            this.parkin = parkin;
        }
        // Return button back to MainForm
        private void button29_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ParkingSlotForm_Load(object sender, EventArgs e)
        {
            loadGroundFloorParkingSlots();
            loadFloor1ParkingSlots();
            loadFloor2ParkingSlots();
            hideF1Slot();
            hideF2Slot();
            gfBTN.Enabled = false;
            gfBTN.BackColor = Color.DarkSlateGray;
            updateSlotGF(groundFloorButtons);
        }
        List<Button> groundFloorButtons = new List<Button>();
        List<Button> floor1Buttons = new List<Button>();
        List<Button> floor2Buttons = new List<Button>();

        // Generate the buttons parking slots for Ground Floor
        private void loadGroundFloorParkingSlots()
        {

            for (int i = 1; i <= maxSlots; i++)
            {
                Button button = new Button();
                button.SetBounds(0, 0, 69, 69);
                button.Cursor = Cursors.Hand;
                button.BackColor = Color.MediumSeaGreen;
                button.Click += groundFloorButtons_Click;
                button.Enabled = true;
                button.Text = $"GF{i}";
                parkingSlotsPanel.Controls.Add(button);
                groundFloorButtons.Add(button);
            }
        }
        // Generate the buttons parking slots for Floor 1
        private void loadFloor1ParkingSlots()
        {

            for (int i = 1; i <= maxSlots; i++)
            {
                Button button = new Button();
                button.SetBounds(0, 0, 69, 69);
                button.Cursor = Cursors.Hand;
                button.BackColor = Color.MediumSeaGreen;
                button.Click += groundFloorButtons_Click;
                button.Enabled = true;
                button.Text = $"A{i}";
                parkingSlotsPanel.Controls.Add(button);
                floor1Buttons.Add(button);
            }
        }
        // Generate the buttons parking slots for Floor 2
        private void loadFloor2ParkingSlots()
        {

            for (int i = 1; i <= maxSlots; i++)
            {
                Button button = new Button();
                button.SetBounds(0, 0, 69, 69);
                button.Cursor = Cursors.Hand;
                button.BackColor = Color.MediumSeaGreen;
                button.Click += groundFloorButtons_Click;
                button.Enabled = true;
                button.Text = $"B{i}";
                parkingSlotsPanel.Controls.Add(button);
                floor2Buttons.Add(button);
            }
        }
        // Hide Ground Floor Buttons
        private void hideGFSlot()
        {
            foreach(Button buttons in groundFloorButtons)
            {
                buttons.Hide();
            }
        }
        // Show Ground Floor Buttons
        private void showGFSlot()
        {
            foreach (Button buttons in groundFloorButtons)
            {
                buttons.Show();
            }
        }
        // Show  Floor 1 Buttons
        private void showF1Slot()
        {
            foreach (Button buttons in floor1Buttons)
            {
                buttons.Show();
            }
        }

        // Hide  Floor 1 Buttons
        private void hideF1Slot()
        {
            foreach (Button buttons in floor1Buttons)
            {
                buttons.Hide();
            }
        }
        // Show  Floor 2 Buttons
        private void showF2Slot()
        {
            foreach (Button buttons in floor2Buttons)
            {
                buttons.Show();
            }
        }
        // Hide  Floor 2 Buttons
        private void hideF2Slot()
        {
            foreach (Button buttons in floor2Buttons)
            {
                buttons.Hide();
            }
        }

        private void exeCommands(string command)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            con.Open();
            cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // Confirmed Slot and initiate parking
        private void groundFloorButtons_Click(object sender, EventArgs e)
        {
            string slotLocation = "";
            int counter = 1;
            Button clickedButton = (Button)sender;
            DialogResult dg = MessageBox.Show("Confirm Slot?", "ParkWise ParkingSlot", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dg == DialogResult.Yes)
            {
                foreach(Button buttons in groundFloorButtons)
                {
                    if(clickedButton == buttons)
                    {
                        slotLocation = $"GF{counter}";
                    }
                    else
                        counter++;
                }
                counter = 1;
                foreach (Button buttons in floor1Buttons)
                {
                    if (clickedButton == buttons)
                    {
                        slotLocation = $"A{counter}";
                    }
                    else
                        counter++;
                }
                counter = 1;
                foreach (Button buttons in floor2Buttons)
                {
                    if (clickedButton == buttons)
                    {
                        slotLocation = $"B{counter}";
                    }
                    else
                        counter++;
                }

                string command1 = "INSERT INTO p_trans(p_usrlog, p_plateNo, p_loc, p_date)" +
               "VALUES('" + userLog + "', '" + pn + "','" + slotLocation + "', '" + parkin + "')";
                exeCommands(command1);
                string command2 = "INSERT INTO parkwiseDBS(plate_no,vehicle_type, vehicle_brand,parkin_datetime)" +
                "VALUES('" + pn + "', '" + vt + "', '" + vb + "', '" + parkin + "')";
                bool duplicatePlateNo = false;
                try
                {
                    exeCommands(command2);
                }
                catch (Exception)
                {
                    duplicatePlateNo = true;
                }
                if (duplicatePlateNo == true)
                {
                    MessageBox.Show("Plate No. already exist!", "ParkWise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
                else
                {
                    Dispose();
                   
                }
            }

        }
       
        // Choose Ground Floor for Parking
        private void gfBTN_Click(object sender, EventArgs e)
        {
            hideF1Slot();
            hideF2Slot();
            showGFSlot();
            updateSlotGF(groundFloorButtons);

        }
        // Choose Floor 1 for Parking
        private void floor1BTN_Click(object sender, EventArgs e)
        {
            showF1Slot();
            hideF2Slot();
            hideGFSlot();
            Color defaultColor = Color.FromArgb(32, 105, 158);
            gfBTN.Enabled = true;
            gfBTN.BackColor = defaultColor;
            updateSlotFloor1(floor1Buttons);

        }
        // Choose Floor 2 for Parking
        private void floor2BTN_Click(object sender, EventArgs e)
        {
            hideF1Slot();
            showF2Slot();
            hideGFSlot();
            Color defaultColor = Color.FromArgb(32, 105, 158);
            gfBTN.Enabled = true;
            gfBTN.BackColor = defaultColor;
            updateSlotFloor2(floor2Buttons);

        }
        private string retrievedSlot = "";
        // Search Existing Slot
        private void searchPSlot(Button buttons)
        {
            string slot = buttons.Text;
            string command = $"SELECT p_loc FROM p_trans WHERE  p_loc = '{slot}'";
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command object with the query and connection
                using (SqlCommand cmd2 = new SqlCommand(command, connection))
                {


                    // Execute the query and get the result
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        // Check if there are any rows in the result
                        if (reader.HasRows)
                        {
                            // Read the first row
                            reader.Read();

                            // Retrieve the stored password from the reader
                            retrievedSlot = reader.GetString(0);
                            switch (retrievedSlot[0])
                            {
                                case 'G':
                                    foreach(Button buttonsGF in groundFloorButtons)
                                    {
                                        if(buttonsGF.Text == retrievedSlot)
                                        {
                                            buttonsGF.BackColor = Color.DarkRed;
                                            buttonsGF.Enabled = false;
                                        }
                                            
                                    }
                                    break;
                                case 'A':
                                    foreach (Button buttonsF1 in floor1Buttons)
                                    {
                                        if (buttonsF1.Text == retrievedSlot)
                                        {
                                            buttonsF1.BackColor = Color.DarkRed;
                                            buttonsF1.Enabled = false;
                                        }

                                    }
                                    break;
                                case 'B':
                                    foreach (Button buttonsF2 in floor2Buttons)
                                    {
                                        if (buttonsF2.Text == retrievedSlot)
                                        {
                                            buttonsF2.BackColor = Color.DarkRed;
                                            buttonsF2.Enabled = false;
                                        }

                                    }
                                    break;

                            }
                        }
                    }
                }
            }
        }
        // Update SLOT by Coloring Occupied Slot
        private void updateSlotGF(List<Button> buttonList)
        {
            foreach(Button buttons in buttonList)
            {
                searchPSlot(buttons);
            }
        }
        private void updateSlotFloor1(List<Button> buttonList)
        {
            foreach (Button buttons in buttonList)
            {
                searchPSlot(buttons);
            }
        }
        private void updateSlotFloor2(List<Button> buttonList)
        {
            foreach (Button buttons in buttonList)
            {
                searchPSlot(buttons);
            }
        }
    }
}
