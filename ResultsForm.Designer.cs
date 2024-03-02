namespace ParkingSystemGUI
{
    partial class ResultsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            pictureBox1 = new PictureBox();
            parkAgainButton = new Button();
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(933, 692);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // parkAgainButton
            // 
            parkAgainButton.BackColor = Color.FromArgb(32, 105, 158);
            parkAgainButton.Cursor = Cursors.Hand;
            parkAgainButton.FlatAppearance.BorderSize = 0;
            parkAgainButton.FlatStyle = FlatStyle.Flat;
            parkAgainButton.Font = new Font("STXihei", 18F);
            parkAgainButton.ForeColor = Color.FromArgb(238, 231, 231);
            parkAgainButton.Location = new Point(258, 516);
            parkAgainButton.Name = "parkAgainButton";
            parkAgainButton.Size = new Size(198, 42);
            parkAgainButton.TabIndex = 4;
            parkAgainButton.Text = "Park Again";
            parkAgainButton.UseVisualStyleBackColor = false;
            parkAgainButton.Click += parkoutButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(32, 105, 158);
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("STXihei", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.FromArgb(238, 231, 231);
            logoutButton.Location = new Point(509, 515);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(198, 42);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Log-out";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            Controls.Add(logoutButton);
            Controls.Add(parkAgainButton);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "ResultsForm";
            Size = new Size(933, 692);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button parkAgainButton;
        private Button logoutButton;
    }
}
