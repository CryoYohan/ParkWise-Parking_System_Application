namespace ParkingSystemGUI
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            mainMenu1 = new MainMenu();
            proceedBTN = new Button();
            parkinForm1 = new ParkinForm();
            vehicleTypeCBox = new ComboBox();
            vehicleBrandCBox = new ComboBox();
            plateNoBox = new TextBox();
            button1 = new Button();
            plateNoLabelRegister = new Label();
            vehicleTypeLabelRegister = new Label();
            vehicleBrandLabelRegister = new Label();
            parkinTimeLabelRegister = new Label();
            confirmBTN = new Button();
            logoutBTN = new Button();
            userLabel = new Label();
            receiptPanel = new Panel();
            closeReceiptButton = new Button();
            totalAmountResults = new Label();
            flagDownResults = new Label();
            durationResults = new Label();
            parkoutResults = new Label();
            parkinResults = new Label();
            vehicleBrandResults = new Label();
            vehicleTypeResults = new Label();
            plateNoResults = new Label();
            customerIDResults = new Label();
            timeAndDateReceipt = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backBTNParkin = new Button();
            dataRegistered1 = new DataRegistered();
            backBTNParkn = new Button();
            dataGridForm1 = new DataGridForm();
            vehicleDataGrid = new DataGridView();
            searchBox = new TextBox();
            editBTN = new Button();
            addVehicleBTN = new Button();
            parkoutBTN = new Button();
            menuBTN = new Button();
            editPanel = new Panel();
            editVehicleBrand = new ComboBox();
            editVehicleType = new ComboBox();
            doneBTNedit = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            editPlateNo = new TextBox();
            editCloseBTN = new Button();
            dataGridBTN = new Button();
            receiptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).BeginInit();
            editPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu1
            // 
            mainMenu1.BackColor = Color.FromArgb(126, 216, 253);
            mainMenu1.Location = new Point(-17, 12);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Size = new Size(928, 645);
            mainMenu1.TabIndex = 0;
            // 
            // proceedBTN
            // 
            proceedBTN.BackColor = Color.FromArgb(32, 105, 158);
            proceedBTN.Font = new Font("Segoe UI", 19F);
            proceedBTN.ForeColor = Color.FromArgb(255, 255, 192);
            proceedBTN.Location = new Point(371, 528);
            proceedBTN.Name = "proceedBTN";
            proceedBTN.Size = new Size(238, 67);
            proceedBTN.TabIndex = 1;
            proceedBTN.Text = "PROCEED";
            proceedBTN.UseVisualStyleBackColor = false;
            proceedBTN.Click += proceedBTN_Click;
            // 
            // parkinForm1
            // 
            parkinForm1.BackColor = Color.FromArgb(126, 216, 253);
            parkinForm1.ForeColor = Color.FromArgb(204, 211, 214);
            parkinForm1.Location = new Point(-8, 12);
            parkinForm1.Name = "parkinForm1";
            parkinForm1.Size = new Size(939, 695);
            parkinForm1.TabIndex = 2;
            // 
            // vehicleTypeCBox
            // 
            vehicleTypeCBox.Cursor = Cursors.Hand;
            vehicleTypeCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleTypeCBox.Font = new Font("Segoe UI", 25F);
            vehicleTypeCBox.FormattingEnabled = true;
            vehicleTypeCBox.Items.AddRange(new object[] { "Motorbike", "SUV", "Van", "Sedan" });
            vehicleTypeCBox.Location = new Point(564, 273);
            vehicleTypeCBox.Name = "vehicleTypeCBox";
            vehicleTypeCBox.Size = new Size(277, 53);
            vehicleTypeCBox.TabIndex = 3;
            vehicleTypeCBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // vehicleBrandCBox
            // 
            vehicleBrandCBox.Cursor = Cursors.Hand;
            vehicleBrandCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleBrandCBox.Font = new Font("Segoe UI", 25F);
            vehicleBrandCBox.FormattingEnabled = true;
            vehicleBrandCBox.Location = new Point(330, 409);
            vehicleBrandCBox.Name = "vehicleBrandCBox";
            vehicleBrandCBox.Size = new Size(277, 53);
            vehicleBrandCBox.TabIndex = 4;
            // 
            // plateNoBox
            // 
            plateNoBox.Font = new Font("Segoe UI", 25F);
            plateNoBox.Location = new Point(90, 273);
            plateNoBox.Name = "plateNoBox";
            plateNoBox.Size = new Size(277, 52);
            plateNoBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 105, 158);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 19F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(347, 499);
            button1.Name = "button1";
            button1.Size = new Size(253, 66);
            button1.TabIndex = 6;
            button1.Text = "PARK-IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // plateNoLabelRegister
            // 
            plateNoLabelRegister.AutoSize = true;
            plateNoLabelRegister.BackColor = Color.FromArgb(204, 211, 214);
            plateNoLabelRegister.Font = new Font("Segoe UI", 19F);
            plateNoLabelRegister.ForeColor = Color.FromArgb(32, 105, 158);
            plateNoLabelRegister.Location = new Point(375, 294);
            plateNoLabelRegister.Name = "plateNoLabelRegister";
            plateNoLabelRegister.Size = new Size(83, 36);
            plateNoLabelRegister.TabIndex = 8;
            plateNoLabelRegister.Text = "label1";
            // 
            // vehicleTypeLabelRegister
            // 
            vehicleTypeLabelRegister.AutoSize = true;
            vehicleTypeLabelRegister.BackColor = Color.FromArgb(204, 211, 214);
            vehicleTypeLabelRegister.Font = new Font("Segoe UI", 19F);
            vehicleTypeLabelRegister.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleTypeLabelRegister.Location = new Point(414, 337);
            vehicleTypeLabelRegister.Name = "vehicleTypeLabelRegister";
            vehicleTypeLabelRegister.Size = new Size(83, 36);
            vehicleTypeLabelRegister.TabIndex = 9;
            vehicleTypeLabelRegister.Text = "label1";
            vehicleTypeLabelRegister.Click += vehicleTypeLabelRegister_Click;
            // 
            // vehicleBrandLabelRegister
            // 
            vehicleBrandLabelRegister.AutoSize = true;
            vehicleBrandLabelRegister.BackColor = Color.FromArgb(204, 211, 214);
            vehicleBrandLabelRegister.Font = new Font("Segoe UI", 19F);
            vehicleBrandLabelRegister.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleBrandLabelRegister.Location = new Point(431, 391);
            vehicleBrandLabelRegister.Name = "vehicleBrandLabelRegister";
            vehicleBrandLabelRegister.Size = new Size(83, 36);
            vehicleBrandLabelRegister.TabIndex = 10;
            vehicleBrandLabelRegister.Text = "label1";
            // 
            // parkinTimeLabelRegister
            // 
            parkinTimeLabelRegister.AutoSize = true;
            parkinTimeLabelRegister.BackColor = Color.FromArgb(204, 211, 214);
            parkinTimeLabelRegister.Font = new Font("Segoe UI", 11F);
            parkinTimeLabelRegister.ForeColor = Color.FromArgb(32, 105, 158);
            parkinTimeLabelRegister.Location = new Point(484, 457);
            parkinTimeLabelRegister.Name = "parkinTimeLabelRegister";
            parkinTimeLabelRegister.Size = new Size(50, 20);
            parkinTimeLabelRegister.TabIndex = 11;
            parkinTimeLabelRegister.Text = "label1";
            // 
            // confirmBTN
            // 
            confirmBTN.BackColor = Color.FromArgb(32, 105, 158);
            confirmBTN.Cursor = Cursors.Hand;
            confirmBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            confirmBTN.FlatStyle = FlatStyle.Flat;
            confirmBTN.Font = new Font("Segoe UI", 19F);
            confirmBTN.ForeColor = SystemColors.ButtonFace;
            confirmBTN.Location = new Point(375, 509);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(204, 65);
            confirmBTN.TabIndex = 12;
            confirmBTN.Text = "CONFIRM";
            confirmBTN.UseVisualStyleBackColor = false;
            confirmBTN.Click += button2_Click;
            // 
            // logoutBTN
            // 
            logoutBTN.BackColor = Color.FromArgb(32, 105, 158);
            logoutBTN.Cursor = Cursors.Hand;
            logoutBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            logoutBTN.FlatStyle = FlatStyle.Flat;
            logoutBTN.Font = new Font("Segoe UI", 8F);
            logoutBTN.ForeColor = SystemColors.ButtonFace;
            logoutBTN.Location = new Point(815, 509);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(59, 30);
            logoutBTN.TabIndex = 13;
            logoutBTN.Text = "Log-out";
            logoutBTN.UseVisualStyleBackColor = false;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.FromArgb(32, 105, 158);
            userLabel.Font = new Font("Segoe UI", 19F);
            userLabel.ForeColor = SystemColors.ButtonFace;
            userLabel.Location = new Point(330, 223);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(73, 36);
            userLabel.TabIndex = 14;
            userLabel.Text = "User:";
            // 
            // receiptPanel
            // 
            receiptPanel.BackColor = Color.FromArgb(255, 255, 192);
            receiptPanel.Controls.Add(closeReceiptButton);
            receiptPanel.Controls.Add(totalAmountResults);
            receiptPanel.Controls.Add(flagDownResults);
            receiptPanel.Controls.Add(durationResults);
            receiptPanel.Controls.Add(parkoutResults);
            receiptPanel.Controls.Add(parkinResults);
            receiptPanel.Controls.Add(vehicleBrandResults);
            receiptPanel.Controls.Add(vehicleTypeResults);
            receiptPanel.Controls.Add(plateNoResults);
            receiptPanel.Controls.Add(customerIDResults);
            receiptPanel.Controls.Add(timeAndDateReceipt);
            receiptPanel.Controls.Add(label4);
            receiptPanel.Controls.Add(label3);
            receiptPanel.Controls.Add(label2);
            receiptPanel.Controls.Add(label1);
            receiptPanel.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptPanel.Location = new Point(161, 130);
            receiptPanel.Name = "receiptPanel";
            receiptPanel.Size = new Size(467, 478);
            receiptPanel.TabIndex = 15;
            // 
            // closeReceiptButton
            // 
            closeReceiptButton.BackColor = Color.Red;
            closeReceiptButton.Cursor = Cursors.Hand;
            closeReceiptButton.FlatAppearance.BorderColor = Color.Red;
            closeReceiptButton.FlatStyle = FlatStyle.Flat;
            closeReceiptButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeReceiptButton.ForeColor = SystemColors.ButtonHighlight;
            closeReceiptButton.Location = new Point(438, 3);
            closeReceiptButton.Name = "closeReceiptButton";
            closeReceiptButton.Size = new Size(24, 24);
            closeReceiptButton.TabIndex = 14;
            closeReceiptButton.Text = "X";
            closeReceiptButton.UseVisualStyleBackColor = false;
            closeReceiptButton.Click += closeReceiptButton_Click;
            // 
            // totalAmountResults
            // 
            totalAmountResults.AutoSize = true;
            totalAmountResults.Font = new Font("SimSun-ExtB", 13F);
            totalAmountResults.Location = new Point(67, 423);
            totalAmountResults.Name = "totalAmountResults";
            totalAmountResults.Size = new Size(125, 18);
            totalAmountResults.TabIndex = 13;
            totalAmountResults.Text = "Total Amount:";
            // 
            // flagDownResults
            // 
            flagDownResults.AutoSize = true;
            flagDownResults.Font = new Font("SimSun-ExtB", 12F);
            flagDownResults.Location = new Point(69, 391);
            flagDownResults.Name = "flagDownResults";
            flagDownResults.Size = new Size(87, 16);
            flagDownResults.TabIndex = 12;
            flagDownResults.Text = "Flag Down:";
            // 
            // durationResults
            // 
            durationResults.AutoSize = true;
            durationResults.Font = new Font("SimSun-ExtB", 12F);
            durationResults.Location = new Point(68, 368);
            durationResults.Name = "durationResults";
            durationResults.Size = new Size(79, 16);
            durationResults.TabIndex = 11;
            durationResults.Text = "Duration:";
            // 
            // parkoutResults
            // 
            parkoutResults.AutoSize = true;
            parkoutResults.Font = new Font("SimSun-ExtB", 12F);
            parkoutResults.Location = new Point(67, 346);
            parkoutResults.Name = "parkoutResults";
            parkoutResults.Size = new Size(159, 16);
            parkoutResults.TabIndex = 10;
            parkoutResults.Text = "Park-out Date/Time:";
            // 
            // parkinResults
            // 
            parkinResults.AutoSize = true;
            parkinResults.Font = new Font("SimSun-ExtB", 12F);
            parkinResults.Location = new Point(67, 320);
            parkinResults.Name = "parkinResults";
            parkinResults.Size = new Size(151, 16);
            parkinResults.TabIndex = 9;
            parkinResults.Text = "Park-in Date/Time:";
            // 
            // vehicleBrandResults
            // 
            vehicleBrandResults.AutoSize = true;
            vehicleBrandResults.Font = new Font("SimSun-ExtB", 12F);
            vehicleBrandResults.Location = new Point(67, 293);
            vehicleBrandResults.Name = "vehicleBrandResults";
            vehicleBrandResults.Size = new Size(119, 16);
            vehicleBrandResults.TabIndex = 8;
            vehicleBrandResults.Text = "Vehicle Brand:";
            // 
            // vehicleTypeResults
            // 
            vehicleTypeResults.AutoSize = true;
            vehicleTypeResults.Font = new Font("SimSun-ExtB", 12F);
            vehicleTypeResults.Location = new Point(67, 264);
            vehicleTypeResults.Name = "vehicleTypeResults";
            vehicleTypeResults.Size = new Size(111, 16);
            vehicleTypeResults.TabIndex = 7;
            vehicleTypeResults.Text = "Vehicle Type:";
            // 
            // plateNoResults
            // 
            plateNoResults.AutoSize = true;
            plateNoResults.Font = new Font("SimSun-ExtB", 12F);
            plateNoResults.Location = new Point(67, 236);
            plateNoResults.Name = "plateNoResults";
            plateNoResults.Size = new Size(87, 16);
            plateNoResults.TabIndex = 6;
            plateNoResults.Text = "Plate No: ";
            // 
            // customerIDResults
            // 
            customerIDResults.AutoSize = true;
            customerIDResults.Font = new Font("SimSun-ExtB", 13F);
            customerIDResults.Location = new Point(35, 201);
            customerIDResults.Name = "customerIDResults";
            customerIDResults.Size = new Size(89, 18);
            customerIDResults.TabIndex = 5;
            customerIDResults.Text = "Customer:";
            // 
            // timeAndDateReceipt
            // 
            timeAndDateReceipt.AutoSize = true;
            timeAndDateReceipt.Font = new Font("SimSun-ExtB", 14F);
            timeAndDateReceipt.Location = new Point(128, 157);
            timeAndDateReceipt.Name = "timeAndDateReceipt";
            timeAndDateReceipt.Size = new Size(139, 19);
            timeAndDateReceipt.TabIndex = 4;
            timeAndDateReceipt.Text = "Time and Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 14F);
            label4.Location = new Point(134, 110);
            label4.Name = "label4";
            label4.Size = new Size(179, 19);
            label4.TabIndex = 3;
            label4.Text = "Tel: 650-302-1992";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 14F);
            label3.Location = new Point(155, 89);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 2;
            label3.Text = "Cebu City,PH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 24);
            label2.Name = "label2";
            label2.Size = new Size(406, 33);
            label2.TabIndex = 1;
            label2.Text = "ParkWise Parking System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 17F);
            label1.Location = new Point(144, 61);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 0;
            label1.Text = "Sanciangko St.";
            // 
            // backBTNParkin
            // 
            backBTNParkin.BackColor = Color.FromArgb(152, 188, 204);
            backBTNParkin.Cursor = Cursors.Hand;
            backBTNParkin.FlatAppearance.BorderColor = Color.FromArgb(152, 188, 204);
            backBTNParkin.FlatStyle = FlatStyle.Flat;
            backBTNParkin.Image = (Image)resources.GetObject("backBTNParkin.Image");
            backBTNParkin.Location = new Point(188, 509);
            backBTNParkin.Name = "backBTNParkin";
            backBTNParkin.Size = new Size(114, 49);
            backBTNParkin.TabIndex = 16;
            backBTNParkin.UseVisualStyleBackColor = false;
            backBTNParkin.Click += backBTNParkin_Click;
            // 
            // dataRegistered1
            // 
            dataRegistered1.BackColor = Color.FromArgb(126, 216, 253);
            dataRegistered1.Location = new Point(-8, 12);
            dataRegistered1.Name = "dataRegistered1";
            dataRegistered1.Size = new Size(939, 708);
            dataRegistered1.TabIndex = 17;
            // 
            // backBTNParkn
            // 
            backBTNParkn.BackColor = Color.FromArgb(204, 211, 214);
            backBTNParkn.Cursor = Cursors.Hand;
            backBTNParkn.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            backBTNParkn.FlatStyle = FlatStyle.Flat;
            backBTNParkn.Image = (Image)resources.GetObject("backBTNParkn.Image");
            backBTNParkn.Location = new Point(251, 516);
            backBTNParkn.Name = "backBTNParkn";
            backBTNParkn.Size = new Size(114, 49);
            backBTNParkn.TabIndex = 18;
            backBTNParkn.UseVisualStyleBackColor = false;
            // 
            // dataGridForm1
            // 
            dataGridForm1.BackColor = Color.FromArgb(126, 216, 253);
            dataGridForm1.Location = new Point(-10, 12);
            dataGridForm1.Name = "dataGridForm1";
            dataGridForm1.Size = new Size(939, 695);
            dataGridForm1.TabIndex = 19;
            dataGridForm1.Load += dataGridForm1_Load;
            // 
            // vehicleDataGrid
            // 
            vehicleDataGrid.AllowUserToAddRows = false;
            vehicleDataGrid.AllowUserToDeleteRows = false;
            vehicleDataGrid.BackgroundColor = Color.FromArgb(32, 105, 158);
            vehicleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleDataGrid.Location = new Point(161, 253);
            vehicleDataGrid.Name = "vehicleDataGrid";
            vehicleDataGrid.ReadOnly = true;
            vehicleDataGrid.Size = new Size(588, 310);
            vehicleDataGrid.TabIndex = 20;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(160, 224);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Plate No. or ID";
            searchBox.Size = new Size(148, 23);
            searchBox.TabIndex = 21;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // editBTN
            // 
            editBTN.BackColor = Color.FromArgb(32, 105, 158);
            editBTN.Cursor = Cursors.Hand;
            editBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            editBTN.FlatStyle = FlatStyle.Flat;
            editBTN.Font = new Font("Segoe UI", 10F);
            editBTN.ForeColor = SystemColors.ButtonFace;
            editBTN.Location = new Point(562, 578);
            editBTN.Name = "editBTN";
            editBTN.Size = new Size(78, 30);
            editBTN.TabIndex = 22;
            editBTN.Text = "Edit";
            editBTN.UseVisualStyleBackColor = false;
            editBTN.Click += editBTN_Click;
            // 
            // addVehicleBTN
            // 
            addVehicleBTN.BackColor = Color.FromArgb(32, 105, 158);
            addVehicleBTN.Cursor = Cursors.Hand;
            addVehicleBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            addVehicleBTN.FlatStyle = FlatStyle.Flat;
            addVehicleBTN.Font = new Font("Segoe UI", 10F);
            addVehicleBTN.ForeColor = SystemColors.ButtonFace;
            addVehicleBTN.Location = new Point(310, 578);
            addVehicleBTN.Name = "addVehicleBTN";
            addVehicleBTN.Size = new Size(82, 30);
            addVehicleBTN.TabIndex = 23;
            addVehicleBTN.Text = "Add Vehicle";
            addVehicleBTN.UseVisualStyleBackColor = false;
            addVehicleBTN.Click += button3_Click;
            // 
            // parkoutBTN
            // 
            parkoutBTN.BackColor = Color.FromArgb(32, 105, 158);
            parkoutBTN.Cursor = Cursors.Hand;
            parkoutBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            parkoutBTN.FlatStyle = FlatStyle.Flat;
            parkoutBTN.Font = new Font("Segoe UI", 10F);
            parkoutBTN.ForeColor = SystemColors.ButtonFace;
            parkoutBTN.Location = new Point(424, 572);
            parkoutBTN.Name = "parkoutBTN";
            parkoutBTN.Size = new Size(105, 40);
            parkoutBTN.TabIndex = 24;
            parkoutBTN.Text = "PARK-OUT";
            parkoutBTN.UseVisualStyleBackColor = false;
            parkoutBTN.Click += parkoutBTN_Click;
            // 
            // menuBTN
            // 
            menuBTN.BackColor = Color.FromArgb(32, 105, 158);
            menuBTN.Cursor = Cursors.Hand;
            menuBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            menuBTN.FlatStyle = FlatStyle.Flat;
            menuBTN.Font = new Font("Segoe UI", 8F);
            menuBTN.ForeColor = SystemColors.ButtonFace;
            menuBTN.Location = new Point(815, 565);
            menuBTN.Name = "menuBTN";
            menuBTN.Size = new Size(59, 30);
            menuBTN.TabIndex = 25;
            menuBTN.Text = "Menu";
            menuBTN.UseVisualStyleBackColor = false;
            menuBTN.Click += menuBTN_Click;
            // 
            // editPanel
            // 
            editPanel.BackColor = Color.FromArgb(125, 205, 250);
            editPanel.BorderStyle = BorderStyle.Fixed3D;
            editPanel.Controls.Add(editVehicleBrand);
            editPanel.Controls.Add(editVehicleType);
            editPanel.Controls.Add(doneBTNedit);
            editPanel.Controls.Add(label8);
            editPanel.Controls.Add(label7);
            editPanel.Controls.Add(label6);
            editPanel.Controls.Add(label5);
            editPanel.Controls.Add(editPlateNo);
            editPanel.Controls.Add(editCloseBTN);
            editPanel.Location = new Point(634, 236);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(263, 329);
            editPanel.TabIndex = 26;
            // 
            // editVehicleBrand
            // 
            editVehicleBrand.FormattingEnabled = true;
            editVehicleBrand.Location = new Point(47, 215);
            editVehicleBrand.Name = "editVehicleBrand";
            editVehicleBrand.Size = new Size(159, 23);
            editVehicleBrand.TabIndex = 25;
            editVehicleBrand.SelectedIndexChanged += editVehicleBrand_SelectedIndexChanged;
            // 
            // editVehicleType
            // 
            editVehicleType.FormattingEnabled = true;
            editVehicleType.Location = new Point(46, 146);
            editVehicleType.Name = "editVehicleType";
            editVehicleType.Size = new Size(159, 23);
            editVehicleType.TabIndex = 24;
            editVehicleType.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // doneBTNedit
            // 
            doneBTNedit.BackColor = Color.FromArgb(32, 105, 158);
            doneBTNedit.Cursor = Cursors.Hand;
            doneBTNedit.FlatStyle = FlatStyle.Flat;
            doneBTNedit.ForeColor = SystemColors.ButtonFace;
            doneBTNedit.Location = new Point(67, 261);
            doneBTNedit.Name = "doneBTNedit";
            doneBTNedit.Size = new Size(113, 36);
            doneBTNedit.TabIndex = 23;
            doneBTNedit.Text = "Done";
            doneBTNedit.UseVisualStyleBackColor = false;
            doneBTNedit.Click += doneBTNedit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(45, 192);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 22;
            label8.Text = "Vehicle Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(45, 121);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 21;
            label7.Text = "Vehicle Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(47, 57);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 20;
            label6.Text = "Plate No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F);
            label5.Location = new Point(57, 4);
            label5.Name = "label5";
            label5.Size = new Size(142, 36);
            label5.TabIndex = 19;
            label5.Text = "Edit Details";
            // 
            // editPlateNo
            // 
            editPlateNo.Location = new Point(45, 79);
            editPlateNo.Name = "editPlateNo";
            editPlateNo.Size = new Size(160, 23);
            editPlateNo.TabIndex = 16;
            // 
            // editCloseBTN
            // 
            editCloseBTN.BackColor = Color.Red;
            editCloseBTN.Cursor = Cursors.Hand;
            editCloseBTN.FlatAppearance.BorderColor = Color.Red;
            editCloseBTN.FlatStyle = FlatStyle.Flat;
            editCloseBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editCloseBTN.ForeColor = SystemColors.ButtonHighlight;
            editCloseBTN.Location = new Point(237, -2);
            editCloseBTN.Name = "editCloseBTN";
            editCloseBTN.Size = new Size(24, 24);
            editCloseBTN.TabIndex = 15;
            editCloseBTN.Text = "X";
            editCloseBTN.UseVisualStyleBackColor = false;
            editCloseBTN.Click += editCloseBTN_Click;
            // 
            // dataGridBTN
            // 
            dataGridBTN.BackColor = Color.FromArgb(32, 105, 158);
            dataGridBTN.Cursor = Cursors.Hand;
            dataGridBTN.FlatAppearance.BorderColor = Color.FromArgb(204, 211, 214);
            dataGridBTN.FlatStyle = FlatStyle.Flat;
            dataGridBTN.Font = new Font("Segoe UI", 9F);
            dataGridBTN.ForeColor = SystemColors.ButtonFace;
            dataGridBTN.Location = new Point(792, 553);
            dataGridBTN.Name = "dataGridBTN";
            dataGridBTN.Size = new Size(65, 55);
            dataGridBTN.TabIndex = 27;
            dataGridBTN.Text = "DataGrid";
            dataGridBTN.UseVisualStyleBackColor = false;
            dataGridBTN.Click += dataGridBTN_Click;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(923, 656);
            Controls.Add(dataGridBTN);
            Controls.Add(editPanel);
            Controls.Add(receiptPanel);
            Controls.Add(menuBTN);
            Controls.Add(parkoutBTN);
            Controls.Add(addVehicleBTN);
            Controls.Add(editBTN);
            Controls.Add(searchBox);
            Controls.Add(logoutBTN);
            Controls.Add(vehicleDataGrid);
            Controls.Add(dataGridForm1);
            Controls.Add(backBTNParkn);
            Controls.Add(userLabel);
            Controls.Add(plateNoLabelRegister);
            Controls.Add(vehicleTypeLabelRegister);
            Controls.Add(vehicleBrandLabelRegister);
            Controls.Add(parkinTimeLabelRegister);
            Controls.Add(confirmBTN);
            Controls.Add(dataRegistered1);
            Controls.Add(backBTNParkin);
            Controls.Add(button1);
            Controls.Add(plateNoBox);
            Controls.Add(vehicleBrandCBox);
            Controls.Add(vehicleTypeCBox);
            Controls.Add(parkinForm1);
            Controls.Add(proceedBTN);
            Controls.Add(mainMenu1);
            MaximizeBox = false;
            Name = "UserInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWise Parking System";
            Load += UserInterface_Load;
            receiptPanel.ResumeLayout(false);
            receiptPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).EndInit();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MainMenu mainMenu1;
        private Button proceedBTN;
        private ParkinForm parkinForm1;
        private ComboBox vehicleTypeCBox;
        private ComboBox vehicleBrandCBox;
        private TextBox plateNoBox;
        private Button button1;
        private Label plateNoLabelRegister;
        private Label vehicleTypeLabelRegister;
        private Label vehicleBrandLabelRegister;
        private Label parkinTimeLabelRegister;
        private Button confirmBTN;
        private Button logoutBTN;
        private Label userLabel;
        private Panel receiptPanel;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label customerIDResults;
        private Label timeAndDateReceipt;
        private Label plateNoResults;
        private Label flagDownResults;
        private Label durationResults;
        private Label parkoutResults;
        private Label parkinResults;
        private Label vehicleBrandResults;
        private Label vehicleTypeResults;
        private Button closeReceiptButton;
        private Label totalAmountResults;
        private Button backBTNParkin;
        private DataRegistered dataRegistered1;
        private Button backBTNParkn;
        private DataGridForm dataGridForm1;
        private DataGridView vehicleDataGrid;
        private TextBox searchBox;
        private Button editBTN;
        private Button addVehicleBTN;
        private Button parkoutBTN;
        private Button menuBTN;
        private Panel editPanel;
        private Button editCloseBTN;
        private Button doneBTNedit;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox editPlateNo;
        private ComboBox editVehicleBrand;
        private ComboBox editVehicleType;
        private Button dataGridBTN;
    }
}