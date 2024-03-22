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
            mainMenu1 = new MainMenu();
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
            parkinForm1 = new ParkinForm();
            dataRegistered1 = new DataRegistered();
            dataGridForm1 = new DataGridForm();
            vehicleDataGrid = new DataGridView();
            customerIDGridVar = new DataGridViewTextBoxColumn();
            plateNoGridVar = new DataGridViewTextBoxColumn();
            vehicleTypeGridVar = new DataGridViewTextBoxColumn();
            vehicleBrandGridVar = new DataGridViewTextBoxColumn();
            parkinDateTimeGridVar = new DataGridViewTextBoxColumn();
            parkingRepositoryBindingSource = new BindingSource(components);
            resultsForm1 = new ResultsForm();
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
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkingRepositoryBindingSource).BeginInit();
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
            proceedButton.Location = new Point(367, 517);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(251, 70);
            proceedButton.TabIndex = 2;
            proceedButton.Text = "PROCEED";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += proceedButton_Click;
            // 
            // mainMenu1
            // 
            mainMenu1.BackColor = Color.FromArgb(126, 216, 253);
            mainMenu1.Location = new Point(-5, 12);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Size = new Size(939, 638);
            mainMenu1.TabIndex = 3;
            mainMenu1.Load += mainMenu1_Load_1;
            // 
            // parkinButton
            // 
            parkinButton.BackColor = Color.FromArgb(32, 105, 158);
            parkinButton.Cursor = Cursors.Hand;
            parkinButton.FlatAppearance.BorderSize = 0;
            parkinButton.FlatStyle = FlatStyle.Flat;
            parkinButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkinButton.ForeColor = Color.FromArgb(238, 231, 231);
            parkinButton.Location = new Point(347, 522);
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
            ConfirmButton.Location = new Point(367, 516);
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
            plateNoLabel.Location = new Point(488, 295);
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
            parkinDateLabel.Location = new Point(499, 450);
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
            vehicleBLabel.Location = new Point(488, 387);
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
            vehicleTLabel.Location = new Point(488, 337);
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
            parkoutBackButton.Location = new Point(306, 529);
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
            parkinBackButton.Location = new Point(265, 538);
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
            parkAgainButton.Location = new Point(235, 550);
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
            logoutButton.Font = new Font("STXihei", 11F);
            logoutButton.ForeColor = Color.FromArgb(238, 231, 231);
            logoutButton.Location = new Point(636, 550);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(74, 42);
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
            userLabel.Location = new Point(367, 217);
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
            DataGridButtonMenu.Location = new Point(813, 571);
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
            DataGridButtonParkin.Location = new Point(813, 571);
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
            vehicleTypeCBox.Location = new Point(536, 272);
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
            vehicleBrandBox.Location = new Point(331, 402);
            vehicleBrandBox.Name = "vehicleBrandBox";
            vehicleBrandBox.Size = new Size(287, 48);
            vehicleBrandBox.TabIndex = 49;
            // 
            // plateNoBox
            // 
            plateNoBox.Font = new Font("Segoe UI", 22F);
            plateNoBox.Location = new Point(104, 273);
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
            DataGridButtonParkout.Location = new Point(813, 571);
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
            Home.Location = new Point(813, 571);
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
            parkoutButtonGrid.Location = new Point(400, 550);
            parkoutButtonGrid.Name = "parkoutButtonGrid";
            parkoutButtonGrid.Size = new Size(198, 42);
            parkoutButtonGrid.TabIndex = 56;
            parkoutButtonGrid.Text = "PARK-OUT";
            parkoutButtonGrid.UseVisualStyleBackColor = false;
            parkoutButtonGrid.Click += parkoutButtonGrid_Click;
            // 
            // parkinForm1
            // 
            parkinForm1.BackColor = Color.FromArgb(126, 216, 253);
            parkinForm1.Location = new Point(-17, 12);
            parkinForm1.Name = "parkinForm1";
            parkinForm1.Size = new Size(939, 695);
            parkinForm1.TabIndex = 57;
            // 
            // dataRegistered1
            // 
            dataRegistered1.BackColor = Color.FromArgb(126, 216, 253);
            dataRegistered1.Location = new Point(-17, 12);
            dataRegistered1.Name = "dataRegistered1";
            dataRegistered1.Size = new Size(939, 695);
            dataRegistered1.TabIndex = 58;
            // 
            // dataGridForm1
            // 
            dataGridForm1.BackColor = Color.FromArgb(126, 216, 253);
            dataGridForm1.Location = new Point(-17, 12);
            dataGridForm1.Name = "dataGridForm1";
            dataGridForm1.Size = new Size(939, 695);
            dataGridForm1.TabIndex = 59;
            dataGridForm1.Load += dataGridForm1_Load;
            // 
            // vehicleDataGrid
            // 
            vehicleDataGrid.AllowUserToAddRows = false;
            vehicleDataGrid.AllowUserToDeleteRows = false;
            vehicleDataGrid.AllowUserToResizeColumns = false;
            vehicleDataGrid.AllowUserToResizeRows = false;
            vehicleDataGrid.BackgroundColor = Color.FromArgb(32, 105, 158);
            vehicleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleDataGrid.Columns.AddRange(new DataGridViewColumn[] { customerIDGridVar, plateNoGridVar, vehicleTypeGridVar, vehicleBrandGridVar, parkinDateTimeGridVar });
            vehicleDataGrid.Location = new Point(104, 232);
            vehicleDataGrid.Name = "vehicleDataGrid";
            vehicleDataGrid.ReadOnly = true;
            vehicleDataGrid.RowHeadersWidth = 150;
            vehicleDataGrid.Size = new Size(701, 267);
            vehicleDataGrid.TabIndex = 60;
            // 
            // customerIDGridVar
            // 
            customerIDGridVar.HeaderText = "Customer ID";
            customerIDGridVar.Name = "customerIDGridVar";
            customerIDGridVar.ReadOnly = true;
            // 
            // plateNoGridVar
            // 
            plateNoGridVar.HeaderText = "Plate No.";
            plateNoGridVar.Name = "plateNoGridVar";
            plateNoGridVar.ReadOnly = true;
            // 
            // vehicleTypeGridVar
            // 
            vehicleTypeGridVar.HeaderText = "Vehicle Type";
            vehicleTypeGridVar.Name = "vehicleTypeGridVar";
            vehicleTypeGridVar.ReadOnly = true;
            // 
            // vehicleBrandGridVar
            // 
            vehicleBrandGridVar.HeaderText = "Vehicle Brand";
            vehicleBrandGridVar.Name = "vehicleBrandGridVar";
            vehicleBrandGridVar.ReadOnly = true;
            // 
            // parkinDateTimeGridVar
            // 
            parkinDateTimeGridVar.HeaderText = "Park-in Date/Time";
            parkinDateTimeGridVar.Name = "parkinDateTimeGridVar";
            parkinDateTimeGridVar.ReadOnly = true;
            parkinDateTimeGridVar.Width = 150;
            // 
            // parkingRepositoryBindingSource
            // 
            parkingRepositoryBindingSource.DataSource = typeof(DataRepository.ParkingRepository);
            // 
            // resultsForm1
            // 
            resultsForm1.BackColor = Color.FromArgb(126, 216, 253);
            resultsForm1.ForeColor = SystemColors.ControlText;
            resultsForm1.Location = new Point(-17, 15);
            resultsForm1.Name = "resultsForm1";
            resultsForm1.Size = new Size(933, 692);
            resultsForm1.TabIndex = 61;
            // 
            // customerIDResults
            // 
            customerIDResults.AutoSize = true;
            customerIDResults.BackColor = Color.Gainsboro;
            customerIDResults.Font = new Font("Segoe UI", 11F);
            customerIDResults.ForeColor = Color.FromArgb(32, 105, 158);
            customerIDResults.Location = new Point(291, 285);
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
            parkinResults.Location = new Point(607, 316);
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
            vehicleBrandResults.Location = new Point(576, 282);
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
            vehicleTypeResults.Location = new Point(312, 344);
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
            plateNoResults.Location = new Point(291, 314);
            plateNoResults.Name = "plateNoResults";
            plateNoResults.Size = new Size(33, 20);
            plateNoResults.TabIndex = 66;
            plateNoResults.Text = "null";
            // 
            // parkoutResults
            // 
            parkoutResults.AutoSize = true;
            parkoutResults.BackColor = Color.Gainsboro;
            parkoutResults.ForeColor = Color.FromArgb(32, 105, 158);
            parkoutResults.Location = new Point(617, 348);
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
            totalAmountResults.Location = new Point(493, 452);
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
            flagDownResults.Location = new Point(405, 420);
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
            durationResults.Location = new Point(397, 394);
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
            confirmResultsButton.Location = new Point(354, 505);
            confirmResultsButton.Name = "confirmResultsButton";
            confirmResultsButton.Size = new Size(208, 61);
            confirmResultsButton.TabIndex = 71;
            confirmResultsButton.Text = "CONFIRM";
            confirmResultsButton.UseVisualStyleBackColor = false;
            confirmResultsButton.Click += confirmResultsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(919, 656);
            Controls.Add(confirmResultsButton);
            Controls.Add(durationResults);
            Controls.Add(flagDownResults);
            Controls.Add(totalAmountResults);
            Controls.Add(parkoutResults);
            Controls.Add(plateNoResults);
            Controls.Add(vehicleTypeResults);
            Controls.Add(vehicleBrandResults);
            Controls.Add(parkinResults);
            Controls.Add(customerIDResults);
            Controls.Add(resultsForm1);
            Controls.Add(vehicleDataGrid);
            Controls.Add(Home);
            Controls.Add(logoutButton);
            Controls.Add(parkAgainButton);
            Controls.Add(parkoutButtonGrid);
            Controls.Add(dataGridForm1);
            Controls.Add(parkinDateLabel);
            Controls.Add(vehicleBLabel);
            Controls.Add(vehicleTLabel);
            Controls.Add(plateNoLabel);
            Controls.Add(userLabel);
            Controls.Add(DataGridButtonParkout);
            Controls.Add(parkoutBackButton);
            Controls.Add(ConfirmButton);
            Controls.Add(dataRegistered1);
            Controls.Add(DataGridButtonParkin);
            Controls.Add(parkinButton);
            Controls.Add(parkinBackButton);
            Controls.Add(vehicleTypeCBox);
            Controls.Add(vehicleBrandBox);
            Controls.Add(plateNoBox);
            Controls.Add(parkinForm1);
            Controls.Add(DataGridButtonMenu);
            Controls.Add(flagdownResultsLabel);
            Controls.Add(durationResultsLabel);
            Controls.Add(proceedButton);
            Controls.Add(mainMenu1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)parkingRepositoryBindingSource).EndInit();
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
        private DataRegistered dataRegistered1;
        private DataGridForm dataGridForm1;
        private DataGridView vehicleDataGrid;
        private DataGridViewTextBoxColumn customerIDGridVar;
        private DataGridViewTextBoxColumn plateNoGridVar;
        private DataGridViewTextBoxColumn vehicleTypeGridVar;
        private DataGridViewTextBoxColumn vehicleBrandGridVar;
        private DataGridViewTextBoxColumn parkinDateTimeGridVar;
        private ResultsForm resultsForm1;
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
        //private Button parkoutBackButton;
    }
}