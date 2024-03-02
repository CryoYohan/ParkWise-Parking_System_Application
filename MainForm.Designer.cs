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
            parkinButton.Location = new Point(340, 529);
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
            minuteCBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
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
            // 
            // plateNoLabel
            // 
            plateNoLabel.AutoSize = true;
            plateNoLabel.BackColor = Color.LightGray;
            plateNoLabel.Font = new Font("Segoe UI", 21F);
            plateNoLabel.ForeColor = Color.FromArgb(32, 105, 158);
            plateNoLabel.Location = new Point(527, 298);
            plateNoLabel.Name = "plateNoLabel";
            plateNoLabel.Size = new Size(63, 38);
            plateNoLabel.TabIndex = 19;
            plateNoLabel.Text = "null";
            // 
            // parkinDateLabel
            // 
            parkinDateLabel.AutoSize = true;
            parkinDateLabel.BackColor = Color.LightGray;
            parkinDateLabel.Font = new Font("Segoe UI", 21F);
            parkinDateLabel.ForeColor = Color.FromArgb(32, 105, 158);
            parkinDateLabel.Location = new Point(528, 443);
            parkinDateLabel.Name = "parkinDateLabel";
            parkinDateLabel.Size = new Size(63, 38);
            parkinDateLabel.TabIndex = 20;
            parkinDateLabel.Text = "null";
            // 
            // vehicleBLabel
            // 
            vehicleBLabel.AutoSize = true;
            vehicleBLabel.BackColor = Color.LightGray;
            vehicleBLabel.Font = new Font("Segoe UI", 21F);
            vehicleBLabel.ForeColor = Color.FromArgb(32, 105, 158);
            vehicleBLabel.Location = new Point(527, 384);
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
            vehicleTLabel.Location = new Point(527, 336);
            vehicleTLabel.Name = "vehicleTLabel";
            vehicleTLabel.Size = new Size(63, 38);
            vehicleTLabel.TabIndex = 22;
            vehicleTLabel.Text = "null";
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
            parkinBackButton.Location = new Point(265, 545);
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
            dataRegistered1.Location = new Point(-3, 12);
            dataRegistered1.Name = "dataRegistered1";
            dataRegistered1.Size = new Size(939, 650);
            dataRegistered1.TabIndex = 27;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(919, 656);
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
        //private Button parkoutBackButton;
    }
}