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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            proceedButton = new Button();
            mainMenu1 = new MainMenu();
            parkinButton = new Button();
            parkinForm1 = new ParkinForm();
            plateNoBox = new TextBox();
            vehicleTypeCBox = new ComboBox();
            vehicleBrandBox = new TextBox();
            monthCBox = new ComboBox();
            dayCBox = new ComboBox();
            yearCBox = new ComboBox();
            hourCBox = new ComboBox();
            minuteCBox = new ComboBox();
            amPMCBox = new ComboBox();
            parkoutButton = new Button();
            plateNoLabel = new Label();
            parkinDateLabel = new Label();
            vehicleBLabel = new Label();
            vehicleTLabel = new Label();
            userLabel = new Label();
            parkoutBackButton = new Button();
            parkinBackButton = new Button();
            dataRegistered1 = new DataRegistered();
            resultsForm1 = new ResultsForm();
            parkAgainButton = new Button();
            logoutButton = new Button();
            customerLabelResults = new Label();
            plateNoResultsLabel = new Label();
            vehicleTypeResultsLabel = new Label();
            vehicleBrandResultsLabel = new Label();
            date1ResultsLabel = new Label();
            date2ResultsLabel = new Label();
            durationResultsLabel = new Label();
            flagdownResultsLabel = new Label();
            totalAmountResultsLabel = new Label();
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
            mainMenu1.Location = new Point(-3, 12);
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
            // parkinForm1
            // 
            parkinForm1.BackColor = Color.FromArgb(126, 216, 253);
            parkinForm1.Location = new Point(-3, 12);
            parkinForm1.Name = "parkinForm1";
            parkinForm1.Size = new Size(924, 640);
            parkinForm1.TabIndex = 6;
            parkinForm1.Load += parkinForm1_Load_1;
            // 
            // plateNoBox
            // 
            plateNoBox.Font = new Font("Segoe UI", 20.5F);
            plateNoBox.Location = new Point(106, 273);
            plateNoBox.Name = "plateNoBox";
            plateNoBox.Size = new Size(315, 44);
            plateNoBox.TabIndex = 8;
            // 
            // vehicleTypeCBox
            // 
            vehicleTypeCBox.AutoCompleteCustomSource.AddRange(new string[] { "Motorbike", "SUV", "Van", "Sedan" });
            vehicleTypeCBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            vehicleTypeCBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
            vehicleTypeCBox.Cursor = Cursors.Hand;
            vehicleTypeCBox.DropDownHeight = 80;
            vehicleTypeCBox.Font = new Font("Segoe UI", 20.5F);
            vehicleTypeCBox.FormattingEnabled = true;
            vehicleTypeCBox.IntegralHeight = false;
            vehicleTypeCBox.ItemHeight = 37;
            vehicleTypeCBox.Items.AddRange(new object[] { "Motorbike", "SUV", "Van", "Sedan" });
            vehicleTypeCBox.Location = new Point(106, 411);
            vehicleTypeCBox.Name = "vehicleTypeCBox";
            vehicleTypeCBox.Size = new Size(315, 45);
            vehicleTypeCBox.TabIndex = 9;
            // 
            // vehicleBrandBox
            // 
            vehicleBrandBox.Font = new Font("Segoe UI", 20.5F);
            vehicleBrandBox.Location = new Point(522, 273);
            vehicleBrandBox.Name = "vehicleBrandBox";
            vehicleBrandBox.Size = new Size(315, 44);
            vehicleBrandBox.TabIndex = 10;
            // 
            // monthCBox
            // 
            monthCBox.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            monthCBox.Cursor = Cursors.Hand;
            monthCBox.DropDownHeight = 80;
            monthCBox.Font = new Font("Segoe UI", 12F);
            monthCBox.FormattingEnabled = true;
            monthCBox.IntegralHeight = false;
            monthCBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            monthCBox.Location = new Point(516, 411);
            monthCBox.Name = "monthCBox";
            monthCBox.Size = new Size(56, 29);
            monthCBox.TabIndex = 11;
            // 
            // dayCBox
            // 
            dayCBox.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayCBox.Cursor = Cursors.Hand;
            dayCBox.DropDownHeight = 80;
            dayCBox.Font = new Font("Segoe UI", 12F);
            dayCBox.FormattingEnabled = true;
            dayCBox.IntegralHeight = false;
            dayCBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayCBox.Location = new Point(578, 411);
            dayCBox.Name = "dayCBox";
            dayCBox.Size = new Size(56, 29);
            dayCBox.TabIndex = 12;
            // 
            // yearCBox
            // 
            yearCBox.AutoCompleteCustomSource.AddRange(new string[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040" });
            yearCBox.Cursor = Cursors.Hand;
            yearCBox.DropDownHeight = 80;
            yearCBox.Font = new Font("Segoe UI", 12F);
            yearCBox.FormattingEnabled = true;
            yearCBox.IntegralHeight = false;
            yearCBox.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040" });
            yearCBox.Location = new Point(640, 411);
            yearCBox.Name = "yearCBox";
            yearCBox.Size = new Size(56, 29);
            yearCBox.TabIndex = 13;
            // 
            // hourCBox
            // 
            hourCBox.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            hourCBox.Cursor = Cursors.Hand;
            hourCBox.DropDownHeight = 80;
            hourCBox.Font = new Font("Segoe UI", 12F);
            hourCBox.FormattingEnabled = true;
            hourCBox.IntegralHeight = false;
            hourCBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            hourCBox.Location = new Point(702, 411);
            hourCBox.Name = "hourCBox";
            hourCBox.Size = new Size(56, 29);
            hourCBox.TabIndex = 14;
            // 
            // minuteCBox
            // 
            minuteCBox.AutoCompleteCustomSource.AddRange(new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            minuteCBox.Cursor = Cursors.Hand;
            minuteCBox.DropDownHeight = 80;
            minuteCBox.Font = new Font("Segoe UI", 12F);
            minuteCBox.FormattingEnabled = true;
            minuteCBox.IntegralHeight = false;
            minuteCBox.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            minuteCBox.Location = new Point(764, 411);
            minuteCBox.Name = "minuteCBox";
            minuteCBox.Size = new Size(56, 29);
            minuteCBox.TabIndex = 15;
            // 
            // amPMCBox
            // 
            amPMCBox.AutoCompleteCustomSource.AddRange(new string[] { "AM", "PM" });
            amPMCBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            amPMCBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
            amPMCBox.Cursor = Cursors.Hand;
            amPMCBox.DropDownHeight = 80;
            amPMCBox.Font = new Font("Segoe UI", 10F);
            amPMCBox.FormattingEnabled = true;
            amPMCBox.IntegralHeight = false;
            amPMCBox.Items.AddRange(new object[] { "AM", "PM" });
            amPMCBox.Location = new Point(826, 414);
            amPMCBox.Name = "amPMCBox";
            amPMCBox.Size = new Size(53, 25);
            amPMCBox.TabIndex = 16;
            amPMCBox.SelectedIndexChanged += amPMCBox_SelectedIndexChanged;
            // 
            // parkoutButton
            // 
            parkoutButton.BackColor = Color.FromArgb(32, 105, 158);
            parkoutButton.Cursor = Cursors.Hand;
            parkoutButton.FlatAppearance.BorderSize = 0;
            parkoutButton.FlatStyle = FlatStyle.Flat;
            parkoutButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkoutButton.ForeColor = Color.FromArgb(238, 231, 231);
            parkoutButton.Location = new Point(367, 516);
            parkoutButton.Name = "parkoutButton";
            parkoutButton.Size = new Size(251, 70);
            parkoutButton.TabIndex = 17;
            parkoutButton.Text = "PARK-OUT";
            parkoutButton.UseVisualStyleBackColor = false;
            parkoutButton.Click += parkoutButton_Click;
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
            // dataRegistered1
            // 
            dataRegistered1.BackColor = Color.FromArgb(126, 216, 253);
            dataRegistered1.Location = new Point(-9, 12);
            dataRegistered1.Name = "dataRegistered1";
            dataRegistered1.Size = new Size(939, 650);
            dataRegistered1.TabIndex = 27;
            // 
            // resultsForm1
            // 
            resultsForm1.BackColor = Color.FromArgb(126, 216, 253);
            resultsForm1.ForeColor = SystemColors.ControlText;
            resultsForm1.Location = new Point(-3, 17);
            resultsForm1.Name = "resultsForm1";
            resultsForm1.Size = new Size(933, 645);
            resultsForm1.TabIndex = 28;
            // 
            // parkAgainButton
            // 
            parkAgainButton.BackColor = Color.FromArgb(32, 105, 158);
            parkAgainButton.Cursor = Cursors.Hand;
            parkAgainButton.FlatAppearance.BorderSize = 0;
            parkAgainButton.FlatStyle = FlatStyle.Flat;
            parkAgainButton.Font = new Font("STXihei", 18F);
            parkAgainButton.ForeColor = Color.FromArgb(238, 231, 231);
            parkAgainButton.Location = new Point(256, 523);
            parkAgainButton.Name = "parkAgainButton";
            parkAgainButton.Size = new Size(198, 42);
            parkAgainButton.TabIndex = 29;
            parkAgainButton.Text = "Park Again";
            parkAgainButton.UseVisualStyleBackColor = false;
            parkAgainButton.Click += parkAgainButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(32, 105, 158);
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.FromArgb(238, 231, 231);
            logoutButton.Location = new Point(498, 522);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(198, 42);
            logoutButton.TabIndex = 30;
            logoutButton.Text = "Log-out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // customerLabelResults
            // 
            customerLabelResults.AutoSize = true;
            customerLabelResults.BackColor = Color.FromArgb(208, 212, 212);
            customerLabelResults.Font = new Font("Lucida Console", 10F);
            customerLabelResults.ForeColor = Color.FromArgb(32, 105, 158);
            customerLabelResults.Location = new Point(304, 288);
            customerLabelResults.Name = "customerLabelResults";
            customerLabelResults.Size = new Size(15, 14);
            customerLabelResults.TabIndex = 31;
            customerLabelResults.Text = ".";
            customerLabelResults.Click += customerLabelResults_Click;
            // 
            // plateNoResultsLabel
            // 
            plateNoResultsLabel.AutoSize = true;
            plateNoResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            plateNoResultsLabel.Font = new Font("Segoe UI", 10F);
            plateNoResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            plateNoResultsLabel.Location = new Point(306, 314);
            plateNoResultsLabel.Name = "plateNoResultsLabel";
            plateNoResultsLabel.Size = new Size(12, 19);
            plateNoResultsLabel.TabIndex = 33;
            plateNoResultsLabel.Text = ".";
            // 
            // vehicleTypeResultsLabel
            // 
            vehicleTypeResultsLabel.AutoSize = true;
            vehicleTypeResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            vehicleTypeResultsLabel.Font = new Font("Segoe UI", 10F);
            vehicleTypeResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleTypeResultsLabel.Location = new Point(325, 345);
            vehicleTypeResultsLabel.Name = "vehicleTypeResultsLabel";
            vehicleTypeResultsLabel.Size = new Size(12, 19);
            vehicleTypeResultsLabel.TabIndex = 34;
            vehicleTypeResultsLabel.Text = ".";
            // 
            // vehicleBrandResultsLabel
            // 
            vehicleBrandResultsLabel.AutoSize = true;
            vehicleBrandResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            vehicleBrandResultsLabel.Font = new Font("Lucida Console", 10F);
            vehicleBrandResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleBrandResultsLabel.Location = new Point(589, 288);
            vehicleBrandResultsLabel.Name = "vehicleBrandResultsLabel";
            vehicleBrandResultsLabel.Size = new Size(15, 14);
            vehicleBrandResultsLabel.TabIndex = 35;
            vehicleBrandResultsLabel.Text = ".";
            // 
            // date1ResultsLabel
            // 
            date1ResultsLabel.AutoSize = true;
            date1ResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            date1ResultsLabel.Font = new Font("Lucida Console", 6.5F);
            date1ResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            date1ResultsLabel.Location = new Point(616, 319);
            date1ResultsLabel.Name = "date1ResultsLabel";
            date1ResultsLabel.Size = new Size(10, 9);
            date1ResultsLabel.TabIndex = 36;
            date1ResultsLabel.Text = ".";
            // 
            // date2ResultsLabel
            // 
            date2ResultsLabel.AutoSize = true;
            date2ResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            date2ResultsLabel.Font = new Font("Lucida Console", 6.5F);
            date2ResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            date2ResultsLabel.Location = new Point(628, 352);
            date2ResultsLabel.Name = "date2ResultsLabel";
            date2ResultsLabel.Size = new Size(10, 9);
            date2ResultsLabel.TabIndex = 37;
            date2ResultsLabel.Text = ".";
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
            // totalAmountResultsLabel
            // 
            totalAmountResultsLabel.AutoSize = true;
            totalAmountResultsLabel.BackColor = Color.FromArgb(208, 212, 212);
            totalAmountResultsLabel.Font = new Font("Segoe UI", 12F);
            totalAmountResultsLabel.ForeColor = Color.FromArgb(32, 105, 158);
            totalAmountResultsLabel.Location = new Point(505, 469);
            totalAmountResultsLabel.Name = "totalAmountResultsLabel";
            totalAmountResultsLabel.Size = new Size(13, 21);
            totalAmountResultsLabel.TabIndex = 32;
            totalAmountResultsLabel.Text = ".";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(919, 656);
            Controls.Add(flagdownResultsLabel);
            Controls.Add(durationResultsLabel);
            Controls.Add(date2ResultsLabel);
            Controls.Add(date1ResultsLabel);
            Controls.Add(vehicleBrandResultsLabel);
            Controls.Add(vehicleTypeResultsLabel);
            Controls.Add(plateNoResultsLabel);
            Controls.Add(totalAmountResultsLabel);
            Controls.Add(customerLabelResults);
            Controls.Add(logoutButton);
            Controls.Add(parkAgainButton);
            Controls.Add(resultsForm1);
            Controls.Add(userLabel);
            Controls.Add(parkoutBackButton);
            Controls.Add(parkinDateLabel);
            Controls.Add(vehicleTLabel);
            Controls.Add(plateNoLabel);
            Controls.Add(vehicleBLabel);
            Controls.Add(parkoutButton);
            Controls.Add(dataRegistered1);
            Controls.Add(parkinBackButton);
            Controls.Add(amPMCBox);
            Controls.Add(minuteCBox);
            Controls.Add(hourCBox);
            Controls.Add(yearCBox);
            Controls.Add(dayCBox);
            Controls.Add(monthCBox);
            Controls.Add(vehicleBrandBox);
            Controls.Add(vehicleTypeCBox);
            Controls.Add(plateNoBox);
            Controls.Add(parkinButton);
            Controls.Add(parkinForm1);
            Controls.Add(proceedButton);
            Controls.Add(mainMenu1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button proceedButton;
        private MainMenu mainMenu1;
        private Button parkinButton;
        private ParkinForm parkinForm1;
        private Button parkoutBackButton;
        private TextBox plateNoBox;
        private ComboBox vehicleTypeCBox;
        private TextBox vehicleBrandBox;
        private ComboBox monthCBox;
        private ComboBox dayCBox;
        private ComboBox yearCBox;
        private ComboBox hourCBox;
        private ComboBox minuteCBox;
        private ComboBox amPMCBox;
        private Button parkoutButton;
        private Label plateNoLabel;
        private Label parkinDateLabel;
        private Label vehicleBLabel;
        private Label vehicleTLabel;
        private Label userLabel;
        private Button parkinBackButton;
        private DataRegistered dataRegistered1;
        private ResultsForm resultsForm1;
        private Button parkAgainButton;
        private Button logoutButton;
        private Label customerLabelResults;
        private Label plateNoResultsLabel;
        private Label vehicleTypeResultsLabel;
        private Label vehicleBrandResultsLabel;
        private Label date1ResultsLabel;
        private Label date2ResultsLabel;
        private Label durationResultsLabel;
        private Label flagdownResultsLabel;
        private Label totalAmountResultsLabel;
        //private Button parkoutBackButton;
    }
}