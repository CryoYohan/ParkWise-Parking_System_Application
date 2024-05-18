using System.Data.SqlClient;
using System.Xml.Linq;

namespace ParkingSystemGUI
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string storedPassword = "";
        string userLog = "";
        private string usernameAdmin = "Admin";
        private string passwordAdmin = "admin123";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideRegisterForm();
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
            if (promptUser == usernameAdmin && promptPass == passwordAdmin)
            {
                MessageBox.Show("Login Succesful", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userTextbox.Text = "";
                passwordTextbox.Text = "";
                Hide();
                using (MainForm mainForm = new MainForm(promptUser))
                {
                    mainForm.ShowDialog();
                }
                Show();
            }
            
            else if (promptUser == "" || promptPass == "")
            {
                MessageBox.Show("Field cannot be empty!", "LOGIN");

            }
            else
            {
                string command = "SELECT usrpw FROM Users WHERE usrname = @promptUser";
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object with the query and connection
                    using (SqlCommand cmd2 = new SqlCommand(command, connection))
                    {
                        // Add parameter to the command
                        cmd2.Parameters.AddWithValue("@promptUser", promptUser);

                        // Execute the query and get the result
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            // Check if there are any rows in the result
                            if (reader.HasRows)
                            {
                                // Read the first row
                                reader.Read();

                                // Retrieve the stored password from the reader
                                storedPassword = reader.GetString(0);

                                // Compare the stored password with the provided password
                                if (promptPass == storedPassword)
                                {
                                    MessageBox.Show("Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    userTextbox.Text = "";
                                    passwordTextbox.Text = "";
                                    registerUserToLogs(promptUser, getUserID(promptUser)); // If sign-in successful, log users to User Logs
                                    Hide();
                                    using (UserInterface userGUI = new UserInterface(promptUser))
                                    {
                                        userGUI.ShowDialog();
                                    }
                                    Show();

                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    passwordTextbox.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("User does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                userTextbox.Text = "";
                                passwordTextbox.Text = "";
                            }
                        }
                    }
                }
            }

        }

        private void registerUserToLogs(string promptUser, int userID)
        {
            DateTime datetime = DateTime.Now;
            string datenow = datetime.ToString();
            string command = "INSERT INTO Userlogs VALUES(" + userID + ",'" + promptUser + "','" + datenow + "')";
            try
            {
                exeCommand(command);
            }
            catch (Exception)
            {
                MessageBox.Show($"User {promptUser} already logged-in to Logs.", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int getUserID(string promptUser)
        {
            string command = "SELECT usrID FROM Users WHERE usrname = @promptUser";
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command object with the query and connection
                using (SqlCommand cmd2 = new SqlCommand(command, connection))
                {
                    // Add parameter to the command
                    cmd2.Parameters.AddWithValue("@promptUser", promptUser);

                    // Execute the query and get the result
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        // Check if there are any rows in the result
                        if (reader.HasRows)
                        {
                            // Read the first row
                            reader.Read();

                            // Retrieve the stored password from the reader
                            int usrID = reader.GetInt32(0);
                            return usrID;
                        }
                        else
                        {
                            MessageBox.Show("User does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordTextbox.UseSystemPasswordChar = false;
            }
            else if (showPassCheckBox.CheckState == CheckState.Unchecked)
                passwordTextbox.UseSystemPasswordChar = true;
        }

        private void registerForm1_Load(object sender, EventArgs e)
        {

        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            clearRegistrationData();
            HideRegisterForm();
        }

        private void showRegisterForm()
        {
            registerForm1.Show();
            doneBTN.Show();
            backToLogin.Show();
            firstNameBox.Show();
            lastNameBox.Show();
            middleInitialBox.Show();
            usernameBox.Show();
            passwordBox.Show();
            confirmPassBox.Show();
            checkBox1.Show();
            checkBox2.Show();
        }
        private void HideRegisterForm()
        {
            registerForm1.Hide();
            doneBTN.Hide();
            backToLogin.Hide();
            firstNameBox.Hide();
            lastNameBox.Hide();
            middleInitialBox.Hide();
            usernameBox.Hide();
            passwordBox.Hide();
            confirmPassBox.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
        }

        private string firstName = "";
        private string lastName = "";
        private string middleInitial = "";
        private string username = "";
        private string password = "";
        private string confirmPass = "";

        // Registration done button
        private void doneBTN_Click(object sender, EventArgs e)
        {
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            middleInitial = middleInitialBox.Text;
            username = usernameBox.Text;
            password = passwordBox.Text;
            confirmPass = confirmPassBox.Text;
            if (firstName == "" && lastName == "" && middleInitial == "" && username == "" && password == "" && confirmPass == "")
            {
                MessageBox.Show("Please fill empty fields.", "ParkWise Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (password != confirmPass)
            {
                MessageBox.Show("Password do not match.", "ParkWise Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                middleInitial = middleInitial[0].ToString() + ".";
                string command = "INSERT INTO Users(usrFN, usrLN, usrMI, usrname, usrpw)" +
                "VALUES('" + firstName + "', '" + lastName + "', '" + middleInitial + "', '" + username + "', '" + password + "')";
                try
                {
                    exeCommand(command);
                    MessageBox.Show($"Registered Successfully!", "ParkWise Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearRegistrationData();
                    HideRegisterForm();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Username \"{username}\" already exists! Try another.", "ParkWise Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }
        private void exeCommand(string command)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            showRegisterForm();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
                passwordBox.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                confirmPassBox.UseSystemPasswordChar = false;
            }
            else if (checkBox2
                .CheckState == CheckState.Unchecked)
                confirmPassBox.UseSystemPasswordChar = true;
        }

        private void clearRegistrationData()
        {
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            middleInitialBox.Text = "";
            usernameBox.Text = "";
            passwordBox.Text = "";
            confirmPassBox.Text = "";
        }
    }
}
