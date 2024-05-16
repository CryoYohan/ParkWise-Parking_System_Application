namespace ParkingSystemGUI
{
    partial class ParkingSlotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingSlotForm));
            parkingSlotsPanel = new FlowLayoutPanel();
            gfBTN = new Button();
            floor1BTN = new Button();
            floor2BTN = new Button();
            button29 = new Button();
            SuspendLayout();
            // 
            // parkingSlotsPanel
            // 
            parkingSlotsPanel.BackColor = Color.White;
            parkingSlotsPanel.Location = new Point(438, 214);
            parkingSlotsPanel.Name = "parkingSlotsPanel";
            parkingSlotsPanel.Size = new Size(376, 374);
            parkingSlotsPanel.TabIndex = 0;
            // 
            // gfBTN
            // 
            gfBTN.BackColor = Color.FromArgb(32, 105, 158);
            gfBTN.Cursor = Cursors.Hand;
            gfBTN.ForeColor = SystemColors.ControlLight;
            gfBTN.Location = new Point(127, 248);
            gfBTN.Name = "gfBTN";
            gfBTN.Size = new Size(184, 49);
            gfBTN.TabIndex = 1;
            gfBTN.Text = "Ground Floor";
            gfBTN.UseVisualStyleBackColor = false;
            gfBTN.Click += gfBTN_Click;
            // 
            // floor1BTN
            // 
            floor1BTN.BackColor = Color.FromArgb(32, 105, 158);
            floor1BTN.Cursor = Cursors.Hand;
            floor1BTN.ForeColor = SystemColors.ControlLightLight;
            floor1BTN.Location = new Point(127, 353);
            floor1BTN.Name = "floor1BTN";
            floor1BTN.Size = new Size(184, 49);
            floor1BTN.TabIndex = 2;
            floor1BTN.Text = "Floor 1";
            floor1BTN.UseVisualStyleBackColor = false;
            floor1BTN.Click += floor1BTN_Click;
            // 
            // floor2BTN
            // 
            floor2BTN.BackColor = Color.FromArgb(32, 105, 158);
            floor2BTN.Cursor = Cursors.Hand;
            floor2BTN.ForeColor = SystemColors.ControlLight;
            floor2BTN.Location = new Point(127, 449);
            floor2BTN.Name = "floor2BTN";
            floor2BTN.Size = new Size(184, 49);
            floor2BTN.TabIndex = 3;
            floor2BTN.Text = "Floor 2";
            floor2BTN.UseVisualStyleBackColor = false;
            floor2BTN.Click += floor2BTN_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.FromArgb(32, 105, 158);
            button29.Cursor = Cursors.Hand;
            button29.ForeColor = SystemColors.ControlLight;
            button29.Location = new Point(756, 184);
            button29.Name = "button29";
            button29.Size = new Size(68, 24);
            button29.TabIndex = 4;
            button29.Text = "Return";
            button29.UseVisualStyleBackColor = false;
            button29.Click += button29_Click;
            // 
            // ParkingSlotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 656);
            Controls.Add(button29);
            Controls.Add(floor2BTN);
            Controls.Add(floor1BTN);
            Controls.Add(gfBTN);
            Controls.Add(parkingSlotsPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ParkingSlotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWise Parking System";
            Load += ParkingSlotForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel parkingSlotsPanel;
        private Button gfBTN;
        private Button floor1BTN;
        private Button floor2BTN;
        private Button button29;
    }
}