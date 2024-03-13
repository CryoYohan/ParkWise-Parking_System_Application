using System.Net.Http.Headers;

namespace ParkingSystemGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            userTextbox = new TextBox();
            passwordTextbox = new TextBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            showPassCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(426, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(421, 597);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-16, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(480, 429);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 79);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // userTextbox
            // 
            userTextbox.Font = new Font("Segoe UI", 13F);
            userTextbox.Location = new Point(540, 259);
            userTextbox.Name = "userTextbox";
            userTextbox.PlaceholderText = "Enter username";
            userTextbox.Size = new Size(210, 31);
            userTextbox.TabIndex = 7;
            userTextbox.TextAlign = HorizontalAlignment.Center;
            userTextbox.TextChanged += userTextbox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI", 13F);
            passwordTextbox.Location = new Point(540, 347);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Enter password";
            passwordTextbox.Size = new Size(210, 31);
            passwordTextbox.TabIndex = 8;
            passwordTextbox.TextAlign = HorizontalAlignment.Center;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(53, 183);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(155, 77);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(160, 188, 204);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(160, 188, 204);
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(540, 424);
            button1.Name = "button1";
            button1.Size = new Size(210, 55);
            button1.TabIndex = 11;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.BackColor = Color.FromArgb(160, 188, 204);
            showPassCheckBox.ForeColor = SystemColors.ButtonFace;
            showPassCheckBox.Location = new Point(596, 384);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.Size = new Size(108, 19);
            showPassCheckBox.TabIndex = 12;
            showPassCheckBox.Text = "Show Password";
            showPassCheckBox.UseVisualStyleBackColor = false;
            showPassCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(848, 641);
            Controls.Add(showPassCheckBox);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(passwordTextbox);
            Controls.Add(userTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWise";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox userTextbox;
        private TextBox passwordTextbox;
        private PictureBox pictureBox4;
        private Button button1;
        private CheckBox showPassCheckBox;
    }
}