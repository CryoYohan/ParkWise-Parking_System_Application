
namespace ParkingSystemGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            proceedButton = new Button();
            parkinButton = new Button();
            ConfirmButton = new Button();
            plateNoLabel = new Label();
            parkinDateLabel = new Label();
            vehicleBLabel = new Label();
            vehicleTLabel = new Label();
            parkoutBackButton = new Button();
            parkinBackButton = new Button();
            parkAgainButton = new Button();
            logoutButton = new Button();
            durationResultsLabel = new Label();
            flagdownResultsLabel = new Label();
            userLabel = new Label();
            DataGridButtonMenu = new Button();
            DataGridButtonParkin = new Button();
            vehicleTypeCBox = new ComboBox();
            vehicleBrandBox = new ComboBox();
            plateNoBox = new TextBox();
            DataGridButtonParkout = new Button();
            Home = new Button();
            parkoutButtonGrid = new Button();
            vehicleDataGrid = new DataGridView();
            parkingRepositoryBindingSource = new BindingSource(components);
            customerIDResults = new Label();
            parkinResults = new Label();
            vehicleBrandResults = new Label();
            vehicleTypeResults = new Label();
            plateNoResults = new Label();
            parkoutResults = new Label();
            totalAmountResults = new Label();
            flagDownResults = new Label();
            durationResults = new Label();
            confirmResultsButton = new Button();
            searchBox = new TextBox();
            editBTN = new Button();
            mainMenu2 = new MainMenu();
            parkinForm1 = new ParkinForm();
            dataRegistered1 = new DataRegistered();
            dataGridForm1 = new DataGridForm();
            editPanel = new Panel();
            editCancel = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            editDone = new Button();
            editVehicleBrand = new ComboBox();
            editVehicleType = new ComboBox();
            editPlateNo = new TextBox();
            accessDBVehicles = new Button();
            accessDBUsers = new Button();
            accessDBUserLogs = new Button();
            resultsForm1 = new ResultsForm();
            usersDBPanel = new Panel();
            deleteUserBTN = new Button();
            updateUserBTN = new Button();
            closeUsersDBGrid = new Button();
            usersDBGrid = new DataGridView();
            searchBoxUsers = new TextBox();
            userLogsDBPanel = new Panel();
            deleteAllUserLogsBTN = new Button();
            deleteUserLogsBTN = new Button();
            closeUserLogsDB = new Button();
            userLogsDBGrid = new DataGridView();
            searchUserLogsDB = new TextBox();
            editUsersPanel = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            closeEditUsersBTN = new Button();
            editUsersCB2 = new CheckBox();
            editUsersCB = new CheckBox();
            editUsersDoneBTN = new Button();
            label4 = new Label();
            editConfirmPassBox = new TextBox();
            editPassBox = new TextBox();
            editUsernameBox = new TextBox();
            editMIBox = new TextBox();
            editLnameBox = new TextBox();
            editFnameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkingRepositoryBindingSource).BeginInit();
            editPanel.SuspendLayout();
            usersDBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDBGrid).BeginInit();
            userLogsDBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userLogsDBGrid).BeginInit();
            editUsersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.FromArgb(32, 105, 158);
            proceedButton.Cursor = Cursors.Hand;
            proceedButton.FlatAppearance.BorderSize = 0;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proceedButton.ForeColor = Color.FromArgb(238, 231, 231);
            proceedButton.Location = new Point(367, 522);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(251, 70);
            proceedButton.TabIndex = 2;
            proceedButton.Text = "PROCEED";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += proceedButton_Click;
            // 
            // parkinButton
            // 
            parkinButton.BackColor = Color.FromArgb(32, 105, 158);
            parkinButton.Cursor = Cursors.Hand;
            parkinButton.FlatAppearance.BorderSize = 0;
            parkinButton.FlatStyle = FlatStyle.Flat;
            parkinButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkinButton.ForeColor = Color.FromArgb(238, 231, 231);
            parkinButton.Location = new Point(341, 498);
            parkinButton.Name = "parkinButton";
            parkinButton.Size = new Size(251, 70);
            parkinButton.TabIndex = 5;
            parkinButton.Text = "PARK-IN";
            parkinButton.UseVisualStyleBackColor = false;
            parkinButton.Click += parkinButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(32, 105, 158);
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = Color.FromArgb(238, 231, 231);
            ConfirmButton.Location = new Point(341, 510);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(251, 70);
            ConfirmButton.TabIndex = 17;
            ConfirmButton.Text = "CONFIRM";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += parkoutButton_Click;
            // 
            // plateNoLabel
            // 
            plateNoLabel.AutoSize = true;
            plateNoLabel.BackColor = Color.LightGray;
            plateNoLabel.Font = new Font("Segoe UI", 21F);
            plateNoLabel.ForeColor = Color.FromArgb(32, 105, 158);
            plateNoLabel.Location = new Point(341, 294);
            plateNoLabel.Name = "plateNoLabel";
            plateNoLabel.Size = new Size(63, 38);
            plateNoLabel.TabIndex = 19;
            plateNoLabel.Text = "null";
            // 
            // parkinDateLabel
            // 
            parkinDateLabel.AutoSize = true;
            parkinDateLabel.BackColor = Color.LightGray;
            parkinDateLabel.Font = new Font("Segoe UI", 17F);
            parkinDateLabel.ForeColor = Color.FromArgb(32, 105, 158);
            parkinDateLabel.Location = new Point(453, 452);
            parkinDateLabel.Name = "parkinDateLabel";
            parkinDateLabel.Size = new Size(52, 31);
            parkinDateLabel.TabIndex = 20;
            parkinDateLabel.Text = "null";
            // 
            // vehicleBLabel
            // 
            vehicleBLabel.AutoSize = true;
            vehicleBLabel.BackColor = Color.LightGray;
            vehicleBLabel.Font = new Font("Segoe UI", 21F);
            vehicleBLabel.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleBLabel.Location = new Point(402, 391);
            vehicleBLabel.Name = "vehicleBLabel";
            vehicleBLabel.Size = new Size(63, 38);
            vehicleBLabel.TabIndex = 21;
            vehicleBLabel.Text = "null";
            vehicleBLabel.Click += vehicleBLabel_Click;
            // 
            // vehicleTLabel
            // 
            vehicleTLabel.AutoSize = true;
            vehicleTLabel.BackColor = Color.LightGray;
            vehicleTLabel.Font = new Font("Segoe UI", 21F);
            vehicleTLabel.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleTLabel.Location = new Point(386, 337);
            vehicleTLabel.Name = "vehicleTLabel";
            vehicleTLabel.Size = new Size(63, 38);
            vehicleTLabel.TabIndex = 22;
            vehicleTLabel.Text = "null";
            vehicleTLabel.Click += vehicleTLabel_Click;
            // 
            // parkoutBackButton
            // 
            parkoutBackButton.BackColor = Color.FromArgb(208, 212, 212);
            parkoutBackButton.BackgroundImage = (Image)resources.GetObject("parkoutBackButton.BackgroundImage");
            parkoutBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            parkoutBackButton.Cursor = Cursors.Hand;
            parkoutBackButton.FlatStyle = FlatStyle.Flat;
            parkoutBackButton.ForeColor = Color.FromArgb(208, 212, 212);
            parkoutBackButton.Location = new Point(274, 532);
            parkoutBackButton.Name = "parkoutBackButton";
            parkoutBackButton.Size = new Size(35, 35);
            parkoutBackButton.TabIndex = 24;
            parkoutBackButton.UseVisualStyleBackColor = false;
            parkoutBackButton.Visible = false;
            parkoutBackButton.Click += parkoutBackButton_Click;
            // 
            // parkinBackButton
            // 
            parkinBackButton.BackColor = Color.FromArgb(152, 188, 204);
            parkinBackButton.BackgroundImage = (Image)resources.GetObject("parkinBackButton.BackgroundImage");
            parkinBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            parkinBackButton.Cursor = Cursors.Hand;
            parkinBackButton.FlatStyle = FlatStyle.Flat;
            parkinBackButton.ForeColor = Color.FromArgb(152, 188, 204);
            parkinBackButton.Location = new Point(274, 520);
            parkinBackButton.Name = "parkinBackButton";
            parkinBackButton.Size = new Size(35, 35);
            parkinBackButton.TabIndex = 26;
            parkinBackButton.UseVisualStyleBackColor = false;
            parkinBackButton.Visible = false;
            parkinBackButton.Click += parkinBackButton_Click_1;
            // 
            // parkAgainButton
            // 
            parkAgainButton.BackColor = Color.FromArgb(32, 105, 158);
            parkAgainButton.Cursor = Cursors.Hand;
            parkAgainButton.FlatAppearance.BorderSize = 0;
            parkAgainButton.FlatStyle = FlatStyle.Flat;
            parkAgainButton.Font = new Font("STXihei", 12F);
            parkAgainButton.ForeColor = Color.FromArgb(238, 231, 231);
            parkAgainButton.Location = new Point(203, 556);
            parkAgainButton.Name = "parkAgainButton";
            parkAgainButton.Size = new Size(126, 42);
            parkAgainButton.TabIndex = 29;
            parkAgainButton.Text = "Add Vehicle";
            parkAgainButton.UseVisualStyleBackColor = false;
            parkAgainButton.Click += parkAgainButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(32, 105, 158);
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("STXihei", 9F);
            logoutButton.ForeColor = Color.FromArgb(238, 231, 231);
            logoutButton.Location = new Point(798, 205);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(64, 29);
            logoutButton.TabIndex = 30;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // durationResultsLabel
            // 
            durationResultsLabel.AutoSize = true;
            durationResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            durationResultsLabel.Font = new Font("Segoe UI", 12F);
            durationResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            durationResultsLabel.Location = new Point(411, 394);
            durationResultsLabel.Name = "durationResultsLabel";
            durationResultsLabel.Size = new Size(13, 21);
            durationResultsLabel.TabIndex = 38;
            durationResultsLabel.Text = ".";
            // 
            // flagdownResultsLabel
            // 
            flagdownResultsLabel.AutoSize = true;
            flagdownResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            flagdownResultsLabel.Font = new Font("Segoe UI", 12F);
            flagdownResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            flagdownResultsLabel.Location = new Point(417, 420);
            flagdownResultsLabel.Name = "flagdownResultsLabel";
            flagdownResultsLabel.Size = new Size(13, 21);
            flagdownResultsLabel.TabIndex = 39;
            flagdownResultsLabel.Text = ".";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.FromArgb(32, 105, 158);
            userLabel.Font = new Font("Segoe UI", 21F);
            userLabel.ForeColor = Color.Gainsboro;
            userLabel.Location = new Point(343, 218);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(87, 38);
            userLabel.TabIndex = 23;
            userLabel.Text = "User: ";
            // 
            // DataGridButtonMenu
            // 
            DataGridButtonMenu.BackColor = Color.FromArgb(32, 105, 158);
            DataGridButtonMenu.Cursor = Cursors.Hand;
            DataGridButtonMenu.FlatAppearance.BorderSize = 0;
            DataGridButtonMenu.FlatStyle = FlatStyle.Flat;
            DataGridButtonMenu.Font = new Font("STXihei", 12F);
            DataGridButtonMenu.ForeColor = Color.FromArgb(238, 231, 231);
            DataGridButtonMenu.Location = new Point(801, 566);
            DataGridButtonMenu.Name = "DataGridButtonMenu";
            DataGridButtonMenu.Size = new Size(61, 48);
            DataGridButtonMenu.TabIndex = 44;
            DataGridButtonMenu.Text = "DataGrid";
            DataGridButtonMenu.UseVisualStyleBackColor = false;
            DataGridButtonMenu.Click += DataGridButtonMenu_Click;
            // 
            // DataGridButtonParkin
            // 
            DataGridButtonParkin.BackColor = Color.FromArgb(32, 105, 158);
            DataGridButtonParkin.Cursor = Cursors.Hand;
            DataGridButtonParkin.FlatAppearance.BorderSize = 0;
            DataGridButtonParkin.FlatStyle = FlatStyle.Flat;
            DataGridButtonParkin.Font = new Font("STXihei", 12F);
            DataGridButtonParkin.ForeColor = Color.FromArgb(238, 231, 231);
            DataGridButtonParkin.Location = new Point(801, 566);
            DataGridButtonParkin.Name = "DataGridButtonParkin";
            DataGridButtonParkin.Size = new Size(61, 48);
            DataGridButtonParkin.TabIndex = 45;
            DataGridButtonParkin.Text = "DataGrid";
            DataGridButtonParkin.UseVisualStyleBackColor = false;
            DataGridButtonParkin.Click += DataGridButtonParkin_Click;
            // 
            // vehicleTypeCBox
            // 
            vehicleTypeCBox.AutoCompleteCustomSource.AddRange(new string[] { "Motorbike", "SUV", "Van", "Sedan" });
            vehicleTypeCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleTypeCBox.Font = new Font("Segoe UI", 22F);
            vehicleTypeCBox.FormattingEnabled = true;
            vehicleTypeCBox.Items.AddRange(new object[] { "Motorbike", "SUV", "Van", "Sedan" });
            vehicleTypeCBox.Location = new Point(532, 280);
            vehicleTypeCBox.Name = "vehicleTypeCBox";
            vehicleTypeCBox.Size = new Size(287, 48);
            vehicleTypeCBox.TabIndex = 48;
            vehicleTypeCBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // vehicleBrandBox
            // 
            vehicleBrandBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleBrandBox.Font = new Font("Segoe UI", 22F);
            vehicleBrandBox.FormattingEnabled = true;
            vehicleBrandBox.Location = new Point(322, 402);
            vehicleBrandBox.Name = "vehicleBrandBox";
            vehicleBrandBox.Size = new Size(287, 48);
            vehicleBrandBox.TabIndex = 49;
            // 
            // plateNoBox
            // 
            plateNoBox.Font = new Font("Segoe UI", 22F);
            plateNoBox.Location = new Point(90, 280);
            plateNoBox.Name = "plateNoBox";
            plateNoBox.Size = new Size(287, 47);
            plateNoBox.TabIndex = 50;
            // 
            // DataGridButtonParkout
            // 
            DataGridButtonParkout.BackColor = Color.FromArgb(32, 105, 158);
            DataGridButtonParkout.Cursor = Cursors.Hand;
            DataGridButtonParkout.FlatAppearance.BorderSize = 0;
            DataGridButtonParkout.FlatStyle = FlatStyle.Flat;
            DataGridButtonParkout.Font = new Font("STXihei", 12F);
            DataGridButtonParkout.ForeColor = Color.FromArgb(238, 231, 231);
            DataGridButtonParkout.Location = new Point(801, 566);
            DataGridButtonParkout.Name = "DataGridButtonParkout";
            DataGridButtonParkout.Size = new Size(61, 48);
            DataGridButtonParkout.TabIndex = 51;
            DataGridButtonParkout.Text = "DataGrid";
            DataGridButtonParkout.UseVisualStyleBackColor = false;
            DataGridButtonParkout.Click += DataGridButtonParkout_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.FromArgb(32, 105, 158);
            Home.Cursor = Cursors.Hand;
            Home.FlatAppearance.BorderSize = 0;
            Home.FlatStyle = FlatStyle.Flat;
            Home.Font = new Font("STXihei", 12F);
            Home.ForeColor = Color.FromArgb(238, 231, 231);
            Home.Location = new Point(801, 566);
            Home.Name = "Home";
            Home.Size = new Size(61, 48);
            Home.TabIndex = 55;
            Home.Text = "Main Menu";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // parkoutButtonGrid
            // 
            parkoutButtonGrid.BackColor = Color.FromArgb(32, 105, 158);
            parkoutButtonGrid.Cursor = Cursors.Hand;
            parkoutButtonGrid.FlatAppearance.BorderSize = 0;
            parkoutButtonGrid.FlatStyle = FlatStyle.Flat;
            parkoutButtonGrid.Font = new Font("STXihei", 18F);
            parkoutButtonGrid.ForeColor = Color.FromArgb(238, 231, 231);
            parkoutButtonGrid.Location = new Point(367, 556);
            parkoutButtonGrid.Name = "parkoutButtonGrid";
            parkoutButtonGrid.Size = new Size(198, 42);
            parkoutButtonGrid.TabIndex = 56;
            parkoutButtonGrid.Text = "PARK-OUT";
            parkoutButtonGrid.UseVisualStyleBackColor = false;
            parkoutButtonGrid.Click += parkoutButtonGrid_Click;
            // 
            // vehicleDataGrid
            // 
            vehicleDataGrid.AllowUserToAddRows = false;
            vehicleDataGrid.AllowUserToDeleteRows = false;
            vehicleDataGrid.AllowUserToResizeColumns = false;
            vehicleDataGrid.AllowUserToResizeRows = false;
            vehicleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            vehicleDataGrid.BackgroundColor = Color.FromArgb(32, 105, 158);
            vehicleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleDataGrid.Location = new Point(145, 265);
            vehicleDataGrid.Name = "vehicleDataGrid";
            vehicleDataGrid.ReadOnly = true;
            vehicleDataGrid.RowHeadersWidth = 150;
            vehicleDataGrid.Size = new Size(622, 267);
            vehicleDataGrid.TabIndex = 60;
            // 
            // customerIDResults
            // 
            customerIDResults.AutoSize = true;
            customerIDResults.BackColor = Color.Gainsboro;
            customerIDResults.Font = new Font("Segoe UI", 11F);
            customerIDResults.ForeColor = Color.FromArgb(32, 105, 158);
            customerIDResults.Location = new Point(314, 285);
            customerIDResults.Name = "customerIDResults";
            customerIDResults.Size = new Size(33, 20);
            customerIDResults.TabIndex = 62;
            customerIDResults.Text = "null";
            // 
            // parkinResults
            // 
            parkinResults.AutoSize = true;
            parkinResults.BackColor = Color.Gainsboro;
            parkinResults.ForeColor = Color.FromArgb(32, 105, 158);
            parkinResults.Location = new Point(608, 315);
            parkinResults.Name = "parkinResults";
            parkinResults.Size = new Size(27, 15);
            parkinResults.TabIndex = 63;
            parkinResults.Text = "null";
            // 
            // vehicleBrandResults
            // 
            vehicleBrandResults.AutoSize = true;
            vehicleBrandResults.BackColor = Color.Gainsboro;
            vehicleBrandResults.Font = new Font("Segoe UI", 11F);
            vehicleBrandResults.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleBrandResults.Location = new Point(577, 283);
            vehicleBrandResults.Name = "vehicleBrandResults";
            vehicleBrandResults.Size = new Size(33, 20);
            vehicleBrandResults.TabIndex = 64;
            vehicleBrandResults.Text = "null";
            // 
            // vehicleTypeResults
            // 
            vehicleTypeResults.AutoSize = true;
            vehicleTypeResults.BackColor = Color.Gainsboro;
            vehicleTypeResults.Font = new Font("Segoe UI", 11F);
            vehicleTypeResults.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleTypeResults.Location = new Point(314, 345);
            vehicleTypeResults.Name = "vehicleTypeResults";
            vehicleTypeResults.Size = new Size(33, 20);
            vehicleTypeResults.TabIndex = 65;
            vehicleTypeResults.Text = "null";
            // 
            // plateNoResults
            // 
            plateNoResults.AutoSize = true;
            plateNoResults.BackColor = Color.Gainsboro;
            plateNoResults.Font = new Font("Segoe UI", 11F);
            plateNoResults.ForeColor = Color.FromArgb(32, 105, 158);
            plateNoResults.Location = new Point(293, 314);
            plateNoResults.Name = "plateNoResults";
            plateNoResults.Size = new Size(33, 20);
            plateNoResults.TabIndex = 66;
            plateNoResults.Text = "null";
            plateNoResults.Click += plateNoResults_Click;
            // 
            // parkoutResults
            // 
            parkoutResults.AutoSize = true;
            parkoutResults.BackColor = Color.Gainsboro;
            parkoutResults.ForeColor = Color.FromArgb(32, 105, 158);
            parkoutResults.Location = new Point(619, 349);
            parkoutResults.Name = "parkoutResults";
            parkoutResults.Size = new Size(27, 15);
            parkoutResults.TabIndex = 67;
            parkoutResults.Text = "null";
            // 
            // totalAmountResults
            // 
            totalAmountResults.AutoSize = true;
            totalAmountResults.BackColor = Color.Gainsboro;
            totalAmountResults.Font = new Font("Segoe UI", 21F);
            totalAmountResults.ForeColor = Color.FromArgb(32, 105, 158);
            totalAmountResults.Location = new Point(502, 453);
            totalAmountResults.Name = "totalAmountResults";
            totalAmountResults.Size = new Size(63, 38);
            totalAmountResults.TabIndex = 68;
            totalAmountResults.Text = "null";
            totalAmountResults.Click += label6_Click;
            // 
            // flagDownResults
            // 
            flagDownResults.AutoSize = true;
            flagDownResults.BackColor = Color.Gainsboro;
            flagDownResults.Font = new Font("Segoe UI", 11F);
            flagDownResults.ForeColor = Color.FromArgb(32, 105, 158);
            flagDownResults.Location = new Point(411, 420);
            flagDownResults.Name = "flagDownResults";
            flagDownResults.Size = new Size(33, 20);
            flagDownResults.TabIndex = 69;
            flagDownResults.Text = "null";
            // 
            // durationResults
            // 
            durationResults.AutoSize = true;
            durationResults.BackColor = Color.Gainsboro;
            durationResults.Font = new Font("Segoe UI", 11F);
            durationResults.ForeColor = Color.FromArgb(32, 105, 158);
            durationResults.Location = new Point(402, 394);
            durationResults.Name = "durationResults";
            durationResults.Size = new Size(33, 20);
            durationResults.TabIndex = 70;
            durationResults.Text = "null";
            // 
            // confirmResultsButton
            // 
            confirmResultsButton.BackColor = Color.FromArgb(32, 105, 158);
            confirmResultsButton.Font = new Font("Segoe UI", 20F);
            confirmResultsButton.ForeColor = SystemColors.ButtonFace;
            confirmResultsButton.Location = new Point(343, 519);
            confirmResultsButton.Name = "confirmResultsButton";
            confirmResultsButton.Size = new Size(208, 61);
            confirmResultsButton.TabIndex = 71;
            confirmResultsButton.Text = "CONFIRM";
            confirmResultsButton.UseVisualStyleBackColor = false;
            confirmResultsButton.Click += confirmResultsButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(145, 236);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search ID or Plate No.";
            searchBox.Size = new Size(154, 23);
            searchBox.TabIndex = 72;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // editBTN
            // 
            editBTN.BackColor = Color.FromArgb(32, 105, 158);
            editBTN.Cursor = Cursors.Hand;
            editBTN.FlatAppearance.BorderSize = 0;
            editBTN.FlatStyle = FlatStyle.Flat;
            editBTN.Font = new Font("STXihei", 11F);
            editBTN.ForeColor = Color.FromArgb(238, 231, 231);
            editBTN.Location = new Point(598, 557);
            editBTN.Name = "editBTN";
            editBTN.Size = new Size(74, 42);
            editBTN.TabIndex = 74;
            editBTN.Text = "Edit";
            editBTN.UseVisualStyleBackColor = false;
            editBTN.Click += editBTN_Click;
            // 
            // mainMenu2
            // 
            mainMenu2.BackColor = Color.FromArgb(126, 216, 253);
            mainMenu2.Location = new Point(-17, 12);
            mainMenu2.Name = "mainMenu2";
            mainMenu2.Size = new Size(928, 676);
            mainMenu2.TabIndex = 75;
            mainMenu2.Load += mainMenu2_Load;
            // 
            // parkinForm1
            // 
            parkinForm1.BackColor = Color.FromArgb(126, 216, 253);
            parkinForm1.Location = new Point(-8, 9);
            parkinForm1.Name = "parkinForm1";
            parkinForm1.Size = new Size(939, 695);
            parkinForm1.TabIndex = 76;
            // 
            // dataRegistered1
            // 
            dataRegistered1.BackColor = Color.FromArgb(126, 216, 253);
            dataRegistered1.Location = new Point(-28, 12);
            dataRegistered1.Name = "dataRegistered1";
            dataRegistered1.Size = new Size(939, 708);
            dataRegistered1.TabIndex = 77;
            // 
            // dataGridForm1
            // 
            dataGridForm1.BackColor = Color.FromArgb(126, 216, 253);
            dataGridForm1.Location = new Point(-8, 12);
            dataGridForm1.Name = "dataGridForm1";
            dataGridForm1.Size = new Size(939, 695);
            dataGridForm1.TabIndex = 78;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editCancel);
            editPanel.Controls.Add(label3);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(label1);
            editPanel.Controls.Add(editDone);
            editPanel.Controls.Add(editVehicleBrand);
            editPanel.Controls.Add(editVehicleType);
            editPanel.Controls.Add(editPlateNo);
            editPanel.Location = new Point(305, 236);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(297, 318);
            editPanel.TabIndex = 80;
            // 
            // editCancel
            // 
            editCancel.BackColor = Color.FromArgb(32, 105, 158);
            editCancel.ForeColor = SystemColors.ButtonHighlight;
            editCancel.Location = new Point(169, 257);
            editCancel.Name = "editCancel";
            editCancel.Size = new Size(94, 30);
            editCancel.TabIndex = 7;
            editCancel.Text = "Cancel";
            editCancel.UseVisualStyleBackColor = false;
            editCancel.Click += editCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 178);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Vehicle Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 111);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "Vehicle Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Plate No.";
            // 
            // editDone
            // 
            editDone.BackColor = Color.FromArgb(32, 105, 158);
            editDone.ForeColor = SystemColors.ButtonHighlight;
            editDone.Location = new Point(38, 257);
            editDone.Name = "editDone";
            editDone.Size = new Size(94, 30);
            editDone.TabIndex = 3;
            editDone.Text = "Done";
            editDone.UseVisualStyleBackColor = false;
            editDone.Click += editDone_Click;
            // 
            // editVehicleBrand
            // 
            editVehicleBrand.FormattingEnabled = true;
            editVehicleBrand.Location = new Point(69, 196);
            editVehicleBrand.Name = "editVehicleBrand";
            editVehicleBrand.Size = new Size(160, 23);
            editVehicleBrand.TabIndex = 2;
            // 
            // editVehicleType
            // 
            editVehicleType.FormattingEnabled = true;
            editVehicleType.Items.AddRange(new object[] { "Motorbike", "Van", "SUV", "Sedan" });
            editVehicleType.Location = new Point(69, 129);
            editVehicleType.Name = "editVehicleType";
            editVehicleType.Size = new Size(160, 23);
            editVehicleType.TabIndex = 1;
            editVehicleType.SelectedIndexChanged += editVehicleType_SelectedIndexChanged;
            // 
            // editPlateNo
            // 
            editPlateNo.Location = new Point(69, 64);
            editPlateNo.Name = "editPlateNo";
            editPlateNo.Size = new Size(160, 23);
            editPlateNo.TabIndex = 0;
            // 
            // accessDBVehicles
            // 
            accessDBVehicles.BackColor = Color.FromArgb(32, 105, 158);
            accessDBVehicles.ForeColor = Color.Snow;
            accessDBVehicles.Location = new Point(339, 236);
            accessDBVehicles.Name = "accessDBVehicles";
            accessDBVehicles.Size = new Size(74, 23);
            accessDBVehicles.TabIndex = 81;
            accessDBVehicles.Text = "Vehicles";
            accessDBVehicles.UseVisualStyleBackColor = false;
            accessDBVehicles.Click += accessDBVehicles_Click;
            // 
            // accessDBUsers
            // 
            accessDBUsers.BackColor = Color.FromArgb(32, 105, 158);
            accessDBUsers.ForeColor = Color.Snow;
            accessDBUsers.Location = new Point(422, 236);
            accessDBUsers.Name = "accessDBUsers";
            accessDBUsers.Size = new Size(74, 23);
            accessDBUsers.TabIndex = 82;
            accessDBUsers.Text = "Users";
            accessDBUsers.UseVisualStyleBackColor = false;
            accessDBUsers.Click += accessDBUsers_Click;
            // 
            // accessDBUserLogs
            // 
            accessDBUserLogs.BackColor = Color.FromArgb(32, 105, 158);
            accessDBUserLogs.ForeColor = Color.Snow;
            accessDBUserLogs.Location = new Point(512, 236);
            accessDBUserLogs.Name = "accessDBUserLogs";
            accessDBUserLogs.Size = new Size(74, 23);
            accessDBUserLogs.TabIndex = 83;
            accessDBUserLogs.Text = "User Logs";
            accessDBUserLogs.UseVisualStyleBackColor = false;
            accessDBUserLogs.Click += accessDBUserLogs_Click;
            // 
            // resultsForm1
            // 
            resultsForm1.BackColor = Color.FromArgb(126, 216, 253);
            resultsForm1.ForeColor = SystemColors.ControlText;
            resultsForm1.Location = new Point(-8, 15);
            resultsForm1.Name = "resultsForm1";
            resultsForm1.Size = new Size(933, 692);
            resultsForm1.TabIndex = 84;
            resultsForm1.Load += resultsForm1_Load;
            // 
            // usersDBPanel
            // 
            usersDBPanel.BackColor = Color.DarkSlateGray;
            usersDBPanel.Controls.Add(deleteUserBTN);
            usersDBPanel.Controls.Add(updateUserBTN);
            usersDBPanel.Controls.Add(closeUsersDBGrid);
            usersDBPanel.Controls.Add(usersDBGrid);
            usersDBPanel.Controls.Add(searchBoxUsers);
            usersDBPanel.Location = new Point(474, 46);
            usersDBPanel.Name = "usersDBPanel";
            usersDBPanel.Size = new Size(437, 568);
            usersDBPanel.TabIndex = 85;
            // 
            // deleteUserBTN
            // 
            deleteUserBTN.BackColor = Color.FromArgb(32, 105, 158);
            deleteUserBTN.FlatAppearance.BorderColor = Color.FromArgb(32, 105, 158);
            deleteUserBTN.FlatStyle = FlatStyle.Flat;
            deleteUserBTN.Font = new Font("Segoe UI", 12F);
            deleteUserBTN.ForeColor = SystemColors.ButtonHighlight;
            deleteUserBTN.Location = new Point(227, 501);
            deleteUserBTN.Name = "deleteUserBTN";
            deleteUserBTN.Size = new Size(118, 33);
            deleteUserBTN.TabIndex = 17;
            deleteUserBTN.Text = "Delete User";
            deleteUserBTN.UseVisualStyleBackColor = false;
            deleteUserBTN.Click += deleteUserBTN_Click;
            // 
            // updateUserBTN
            // 
            updateUserBTN.BackColor = Color.FromArgb(32, 105, 158);
            updateUserBTN.FlatAppearance.BorderColor = Color.FromArgb(32, 105, 158);
            updateUserBTN.FlatStyle = FlatStyle.Flat;
            updateUserBTN.Font = new Font("Segoe UI", 12F);
            updateUserBTN.ForeColor = SystemColors.ButtonHighlight;
            updateUserBTN.Location = new Point(87, 501);
            updateUserBTN.Name = "updateUserBTN";
            updateUserBTN.Size = new Size(118, 33);
            updateUserBTN.TabIndex = 16;
            updateUserBTN.Text = "Update User";
            updateUserBTN.UseVisualStyleBackColor = false;
            updateUserBTN.Click += updateUserBTN_Click;
            // 
            // closeUsersDBGrid
            // 
            closeUsersDBGrid.BackColor = Color.Red;
            closeUsersDBGrid.FlatStyle = FlatStyle.Popup;
            closeUsersDBGrid.ForeColor = SystemColors.ButtonFace;
            closeUsersDBGrid.Location = new Point(401, 16);
            closeUsersDBGrid.Name = "closeUsersDBGrid";
            closeUsersDBGrid.Size = new Size(24, 23);
            closeUsersDBGrid.TabIndex = 2;
            closeUsersDBGrid.Text = "X";
            closeUsersDBGrid.UseVisualStyleBackColor = false;
            closeUsersDBGrid.Click += closeUsersDBGrid_Click;
            // 
            // usersDBGrid
            // 
            usersDBGrid.AllowUserToAddRows = false;
            usersDBGrid.AllowUserToDeleteRows = false;
            usersDBGrid.BackgroundColor = Color.FromArgb(32, 105, 158);
            usersDBGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDBGrid.Location = new Point(19, 62);
            usersDBGrid.Name = "usersDBGrid";
            usersDBGrid.ReadOnly = true;
            usersDBGrid.Size = new Size(394, 408);
            usersDBGrid.TabIndex = 1;
            // 
            // searchBoxUsers
            // 
            searchBoxUsers.Location = new Point(26, 30);
            searchBoxUsers.Name = "searchBoxUsers";
            searchBoxUsers.PlaceholderText = "Enter First/Last Name";
            searchBoxUsers.Size = new Size(140, 23);
            searchBoxUsers.TabIndex = 0;
            searchBoxUsers.TextChanged += searchBoxUsers_TextChanged;
            // 
            // userLogsDBPanel
            // 
            userLogsDBPanel.BackColor = Color.DarkSlateGray;
            userLogsDBPanel.Controls.Add(deleteAllUserLogsBTN);
            userLogsDBPanel.Controls.Add(deleteUserLogsBTN);
            userLogsDBPanel.Controls.Add(closeUserLogsDB);
            userLogsDBPanel.Controls.Add(userLogsDBGrid);
            userLogsDBPanel.Controls.Add(searchUserLogsDB);
            userLogsDBPanel.Location = new Point(12, 46);
            userLogsDBPanel.Name = "userLogsDBPanel";
            userLogsDBPanel.Size = new Size(440, 568);
            userLogsDBPanel.TabIndex = 86;
            // 
            // deleteAllUserLogsBTN
            // 
            deleteAllUserLogsBTN.BackColor = Color.FromArgb(32, 105, 158);
            deleteAllUserLogsBTN.FlatAppearance.BorderColor = Color.FromArgb(32, 105, 158);
            deleteAllUserLogsBTN.FlatStyle = FlatStyle.Flat;
            deleteAllUserLogsBTN.Font = new Font("Segoe UI", 12F);
            deleteAllUserLogsBTN.ForeColor = SystemColors.ButtonHighlight;
            deleteAllUserLogsBTN.Location = new Point(247, 497);
            deleteAllUserLogsBTN.Name = "deleteAllUserLogsBTN";
            deleteAllUserLogsBTN.Size = new Size(118, 33);
            deleteAllUserLogsBTN.TabIndex = 5;
            deleteAllUserLogsBTN.Text = "Delete All ";
            deleteAllUserLogsBTN.UseVisualStyleBackColor = false;
            deleteAllUserLogsBTN.Click += deleteAllUserLogsBTN_Click;
            // 
            // deleteUserLogsBTN
            // 
            deleteUserLogsBTN.BackColor = Color.FromArgb(32, 105, 158);
            deleteUserLogsBTN.FlatAppearance.BorderColor = Color.FromArgb(32, 105, 158);
            deleteUserLogsBTN.FlatStyle = FlatStyle.Flat;
            deleteUserLogsBTN.Font = new Font("Segoe UI", 12F);
            deleteUserLogsBTN.ForeColor = SystemColors.ButtonHighlight;
            deleteUserLogsBTN.Location = new Point(78, 497);
            deleteUserLogsBTN.Name = "deleteUserLogsBTN";
            deleteUserLogsBTN.Size = new Size(118, 33);
            deleteUserLogsBTN.TabIndex = 4;
            deleteUserLogsBTN.Text = "Delete Log";
            deleteUserLogsBTN.UseVisualStyleBackColor = false;
            deleteUserLogsBTN.Click += deleteUserLogsBTN_Click;
            // 
            // closeUserLogsDB
            // 
            closeUserLogsDB.BackColor = Color.Red;
            closeUserLogsDB.FlatStyle = FlatStyle.Popup;
            closeUserLogsDB.ForeColor = SystemColors.ButtonFace;
            closeUserLogsDB.Location = new Point(393, 16);
            closeUserLogsDB.Name = "closeUserLogsDB";
            closeUserLogsDB.Size = new Size(24, 23);
            closeUserLogsDB.TabIndex = 2;
            closeUserLogsDB.Text = "X";
            closeUserLogsDB.UseVisualStyleBackColor = false;
            closeUserLogsDB.Click += closeUserLogsDB_Click;
            // 
            // userLogsDBGrid
            // 
            userLogsDBGrid.AllowUserToAddRows = false;
            userLogsDBGrid.AllowUserToDeleteRows = false;
            userLogsDBGrid.BackgroundColor = Color.FromArgb(32, 105, 158);
            userLogsDBGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userLogsDBGrid.Location = new Point(34, 59);
            userLogsDBGrid.Name = "userLogsDBGrid";
            userLogsDBGrid.ReadOnly = true;
            userLogsDBGrid.Size = new Size(378, 411);
            userLogsDBGrid.TabIndex = 1;
            // 
            // searchUserLogsDB
            // 
            searchUserLogsDB.Location = new Point(34, 30);
            searchUserLogsDB.Name = "searchUserLogsDB";
            searchUserLogsDB.PlaceholderText = "Enter User ID/ Username";
            searchUserLogsDB.Size = new Size(140, 23);
            searchUserLogsDB.TabIndex = 0;
            searchUserLogsDB.TextChanged += searchUserLogsDB_TextChanged;
            // 
            // editUsersPanel
            // 
            editUsersPanel.Controls.Add(label10);
            editUsersPanel.Controls.Add(label9);
            editUsersPanel.Controls.Add(label8);
            editUsersPanel.Controls.Add(label7);
            editUsersPanel.Controls.Add(label6);
            editUsersPanel.Controls.Add(label5);
            editUsersPanel.Controls.Add(closeEditUsersBTN);
            editUsersPanel.Controls.Add(editUsersCB2);
            editUsersPanel.Controls.Add(editUsersCB);
            editUsersPanel.Controls.Add(editUsersDoneBTN);
            editUsersPanel.Controls.Add(label4);
            editUsersPanel.Controls.Add(editConfirmPassBox);
            editUsersPanel.Controls.Add(editPassBox);
            editUsersPanel.Controls.Add(editUsernameBox);
            editUsersPanel.Controls.Add(editMIBox);
            editUsersPanel.Controls.Add(editLnameBox);
            editUsersPanel.Controls.Add(editFnameBox);
            editUsersPanel.Location = new Point(324, 109);
            editUsersPanel.Name = "editUsersPanel";
            editUsersPanel.Size = new Size(262, 266);
            editUsersPanel.TabIndex = 87;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6F);
            label10.Location = new Point(136, 124);
            label10.Name = "label10";
            label10.Size = new Size(35, 11);
            label10.TabIndex = 15;
            label10.Text = "Confirm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6F);
            label9.Location = new Point(19, 123);
            label9.Name = "label9";
            label9.Size = new Size(38, 11);
            label9.TabIndex = 14;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6F);
            label8.Location = new Point(136, 82);
            label8.Name = "label8";
            label8.Size = new Size(41, 11);
            label8.TabIndex = 13;
            label8.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F);
            label7.Location = new Point(20, 82);
            label7.Name = "label7";
            label7.Size = new Size(52, 11);
            label7.TabIndex = 12;
            label7.Text = "Middle name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6F);
            label6.Location = new Point(134, 40);
            label6.Name = "label6";
            label6.Size = new Size(41, 11);
            label6.TabIndex = 11;
            label6.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6F);
            label5.Location = new Point(20, 42);
            label5.Name = "label5";
            label5.Size = new Size(42, 11);
            label5.TabIndex = 10;
            label5.Text = "First name";
            // 
            // closeEditUsersBTN
            // 
            closeEditUsersBTN.BackColor = Color.Red;
            closeEditUsersBTN.FlatAppearance.BorderColor = Color.FromArgb(32, 105, 158);
            closeEditUsersBTN.FlatStyle = FlatStyle.Flat;
            closeEditUsersBTN.Font = new Font("Segoe UI", 6F);
            closeEditUsersBTN.ForeColor = SystemColors.ButtonHighlight;
            closeEditUsersBTN.Location = new Point(237, 4);
            closeEditUsersBTN.Name = "closeEditUsersBTN";
            closeEditUsersBTN.Size = new Size(17, 20);
            closeEditUsersBTN.TabIndex = 9;
            closeEditUsersBTN.Text = "X";
            closeEditUsersBTN.UseVisualStyleBackColor = false;
            closeEditUsersBTN.Click += closeEditUsersBTN_Click;
            // 
            // editUsersCB2
            // 
            editUsersCB2.AutoSize = true;
            editUsersCB2.Font = new Font("Segoe UI", 6F);
            editUsersCB2.Location = new Point(203, 168);
            editUsersCB2.Name = "editUsersCB2";
            editUsersCB2.Size = new Size(44, 15);
            editUsersCB2.TabIndex = 8;
            editUsersCB2.Text = "Show";
            editUsersCB2.UseVisualStyleBackColor = true;
            editUsersCB2.CheckedChanged += editUsersCB2_CheckedChanged;
            // 
            // editUsersCB
            // 
            editUsersCB.AutoSize = true;
            editUsersCB.Font = new Font("Segoe UI", 6F);
            editUsersCB.Location = new Point(19, 166);
            editUsersCB.Name = "editUsersCB";
            editUsersCB.Size = new Size(44, 15);
            editUsersCB.TabIndex = 7;
            editUsersCB.Text = "Show";
            editUsersCB.UseVisualStyleBackColor = true;
            editUsersCB.CheckedChanged += editUsersCB_CheckedChanged;
            // 
            // editUsersDoneBTN
            // 
            editUsersDoneBTN.BackColor = Color.FromArgb(32, 105, 158);
            editUsersDoneBTN.FlatAppearance.BorderColor = Color.FromArgb(32, 105, 158);
            editUsersDoneBTN.FlatStyle = FlatStyle.Flat;
            editUsersDoneBTN.Font = new Font("Segoe UI", 12F);
            editUsersDoneBTN.ForeColor = SystemColors.ButtonHighlight;
            editUsersDoneBTN.Location = new Point(78, 195);
            editUsersDoneBTN.Name = "editUsersDoneBTN";
            editUsersDoneBTN.Size = new Size(118, 33);
            editUsersDoneBTN.TabIndex = 6;
            editUsersDoneBTN.Text = "Done";
            editUsersDoneBTN.UseVisualStyleBackColor = false;
            editUsersDoneBTN.Click += editUsersDoneBTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(31, 4);
            label4.Name = "label4";
            label4.Size = new Size(198, 28);
            label4.TabIndex = 6;
            label4.Text = "Update User Account";
            // 
            // editConfirmPassBox
            // 
            editConfirmPassBox.Location = new Point(136, 138);
            editConfirmPassBox.Name = "editConfirmPassBox";
            editConfirmPassBox.Size = new Size(111, 23);
            editConfirmPassBox.TabIndex = 5;
            editConfirmPassBox.UseSystemPasswordChar = true;
            // 
            // editPassBox
            // 
            editPassBox.Location = new Point(19, 137);
            editPassBox.Name = "editPassBox";
            editPassBox.Size = new Size(111, 23);
            editPassBox.TabIndex = 4;
            editPassBox.UseSystemPasswordChar = true;
            // 
            // editUsernameBox
            // 
            editUsernameBox.Location = new Point(136, 96);
            editUsernameBox.Name = "editUsernameBox";
            editUsernameBox.Size = new Size(111, 23);
            editUsernameBox.TabIndex = 3;
            // 
            // editMIBox
            // 
            editMIBox.Location = new Point(19, 96);
            editMIBox.Name = "editMIBox";
            editMIBox.Size = new Size(111, 23);
            editMIBox.TabIndex = 2;
            // 
            // editLnameBox
            // 
            editLnameBox.Location = new Point(136, 54);
            editLnameBox.Name = "editLnameBox";
            editLnameBox.Size = new Size(111, 23);
            editLnameBox.TabIndex = 1;
            // 
            // editFnameBox
            // 
            editFnameBox.Location = new Point(19, 54);
            editFnameBox.Name = "editFnameBox";
            editFnameBox.Size = new Size(111, 23);
            editFnameBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(923, 656);
            Controls.Add(editUsersPanel);
            Controls.Add(userLogsDBPanel);
            Controls.Add(usersDBPanel);
            Controls.Add(editPanel);
            Controls.Add(flagDownResults);
            Controls.Add(durationResults);
            Controls.Add(vehicleTypeResults);
            Controls.Add(plateNoResults);
            Controls.Add(customerIDResults);
            Controls.Add(vehicleBrandResults);
            Controls.Add(parkinResults);
            Controls.Add(parkoutResults);
            Controls.Add(totalAmountResults);
            Controls.Add(confirmResultsButton);
            Controls.Add(resultsForm1);
            Controls.Add(accessDBUserLogs);
            Controls.Add(accessDBUsers);
            Controls.Add(accessDBVehicles);
            Controls.Add(vehicleDataGrid);
            Controls.Add(searchBox);
            Controls.Add(parkAgainButton);
            Controls.Add(parkoutButtonGrid);
            Controls.Add(editBTN);
            Controls.Add(Home);
            Controls.Add(logoutButton);
            Controls.Add(dataGridForm1);
            Controls.Add(DataGridButtonParkout);
            Controls.Add(userLabel);
            Controls.Add(plateNoLabel);
            Controls.Add(vehicleTLabel);
            Controls.Add(vehicleBLabel);
            Controls.Add(parkinDateLabel);
            Controls.Add(parkoutBackButton);
            Controls.Add(ConfirmButton);
            Controls.Add(dataRegistered1);
            Controls.Add(vehicleBrandBox);
            Controls.Add(parkinBackButton);
            Controls.Add(DataGridButtonParkin);
            Controls.Add(vehicleTypeCBox);
            Controls.Add(parkinButton);
            Controls.Add(plateNoBox);
            Controls.Add(parkinForm1);
            Controls.Add(DataGridButtonMenu);
            Controls.Add(proceedButton);
            Controls.Add(flagdownResultsLabel);
            Controls.Add(durationResultsLabel);
            Controls.Add(mainMenu2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWise Parking System";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)parkingRepositoryBindingSource).EndInit();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            usersDBPanel.ResumeLayout(false);
            usersDBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDBGrid).EndInit();
            userLogsDBPanel.ResumeLayout(false);
            userLogsDBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userLogsDBGrid).EndInit();
            editUsersPanel.ResumeLayout(false);
            editUsersPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button proceedButton;
        private MainMenu mainMenu1;
        private Button parkinButton;
        private Button parkoutBackButton;
        private Button ConfirmButton;
        private Label plateNoLabel;
        private Label parkinDateLabel;
        private Label vehicleBLabel;
        private Label vehicleTLabel;
        private Button parkinBackButton;
        private Button parkAgainButton;
        private Button logoutButton;
        private Label durationResultsLabel;
        private Label flagdownResultsLabel;
        private Label userLabel;
        private Button DataGridButtonMenu;
        private Button DataGridButtonParkin;
        private ComboBox vehicleTypeCBox;
        private ComboBox vehicleBrandBox;
        private TextBox plateNoBox;
        private Button DataGridButtonParkout;
        private Button Home;
        private Button parkoutButtonGrid;
        private ParkinForm parkinForm1;
        private DataGridView vehicleDataGrid;
        private Label customerIDResults;
        private Label parkinResults;
        private Label vehicleBrandResults;
        private Label vehicleTypeResults;
        private Label plateNoResults;
        private Label parkoutResults;
        private Label totalAmountResults;
        private Label flagDownResults;
        private Label durationResults;
        private Button confirmResultsButton;
        private BindingSource parkingRepositoryBindingSource;
        private TextBox searchBox;
        private Button editBTN;
        private MainMenu mainMenu2;
        private DataRegistered dataRegistered1;
        private DataGridForm dataGridForm1;
        private Panel editPanel;
        private Button editDone;
        private ComboBox editVehicleBrand;
        private ComboBox editVehicleType;
        private TextBox editPlateNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button editCancel;
        private Button accessDBVehicles;
        private Button accessDBUsers;
        private Button accessDBUserLogs;
        private ResultsForm resultsForm1;
        private Panel usersDBPanel;
        private TextBox searchBoxUsers;
        private DataGridView usersDBGrid;
        private Button closeUsersDBGrid;
        private Panel userLogsDBPanel;
        private Button closeUserLogsDB;
        private DataGridView userLogsDBGrid;
        private TextBox searchUserLogsDB;
        private Button deleteUserLogsBTN;
        private Panel editUsersPanel;
        private Button deleteAllUserLogsBTN;
        private CheckBox editUsersCB2;
        private CheckBox editUsersCB;
        private Button editUsersDoneBTN;
        private Label label4;
        private TextBox editConfirmPassBox;
        private TextBox editPassBox;
        private TextBox editUsernameBox;
        private TextBox editMIBox;
        private TextBox editLnameBox;
        private TextBox editFnameBox;
        private Button closeEditUsersBTN;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button deleteUserBTN;
        private Button updateUserBTN;
        //private Button parkoutBackButton;
    }
}