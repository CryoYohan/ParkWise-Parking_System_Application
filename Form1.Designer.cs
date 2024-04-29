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
            doneBTN = new Button();
            backToLogin = new Label();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            middleInitialBox = new TextBox();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            confirmPassBox = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            registerForm1 = new RegisterForm();
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
            // doneBTN
            // 
            doneBTN.BackColor = Color.FromArgb(160, 188, 204);
            doneBTN.BackgroundImage = (Image)resources.GetObject("doneBTN.BackgroundImage");
            doneBTN.Cursor = Cursors.Hand;
            doneBTN.FlatAppearance.BorderSize = 0;
            doneBTN.FlatStyle = FlatStyle.Flat;
            doneBTN.ForeColor = Color.FromArgb(160, 188, 204);
            doneBTN.ImageAlign = ContentAlignment.BottomCenter;
            doneBTN.Location = new Point(540, 443);
            doneBTN.Name = "doneBTN";
            doneBTN.Size = new Size(210, 55);
            doneBTN.TabIndex = 14;
            doneBTN.TabStop = false;
            doneBTN.UseVisualStyleBackColor = false;
            doneBTN.Click += doneBTN_Click;
            // 
            // backToLogin
            // 
            backToLogin.AutoSize = true;
            backToLogin.BackColor = Color.FromArgb(160, 188, 204);
            backToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            backToLogin.ForeColor = SystemColors.Control;
            backToLogin.Location = new Point(685, 550);
            backToLogin.Name = "backToLogin";
            backToLogin.Size = new Size(79, 15);
            backToLogin.TabIndex = 15;
            backToLogin.Text = "Back to Login";
            backToLogin.Click += backToLogin_Click;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(507, 255);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.PlaceholderText = "Enter First name";
            firstNameBox.Size = new Size(115, 23);
            firstNameBox.TabIndex = 16;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(663, 255);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.PlaceholderText = "Enter Last name";
            lastNameBox.Size = new Size(115, 23);
            lastNameBox.TabIndex = 17;
            // 
            // middleInitialBox
            // 
            middleInitialBox.Location = new Point(507, 329);
            middleInitialBox.Name = "middleInitialBox";
            middleInitialBox.PlaceholderText = "e.g. [ Tapang or T. ]";
            middleInitialBox.Size = new Size(115, 23);
            middleInitialBox.TabIndex = 18;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(663, 329);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter Username";
            usernameBox.Size = new Size(115, 23);
            usernameBox.TabIndex = 19;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(507, 395);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Enter Password";
            passwordBox.Size = new Size(115, 23);
            passwordBox.TabIndex = 20;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // confirmPassBox
            // 
            confirmPassBox.Location = new Point(663, 396);
            confirmPassBox.Name = "confirmPassBox";
            confirmPassBox.PlaceholderText = "Confirm Password";
            confirmPassBox.Size = new Size(115, 23);
            confirmPassBox.TabIndex = 21;
            confirmPassBox.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(160, 188, 204);
            checkBox1.Font = new Font("Segoe UI", 7F);
            checkBox1.ForeColor = SystemColors.ControlDarkDark;
            checkBox1.Location = new Point(507, 424);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 16);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.FromArgb(160, 188, 204);
            checkBox2.Font = new Font("Segoe UI", 7F);
            checkBox2.ForeColor = SystemColors.ControlDarkDark;
            checkBox2.Location = new Point(663, 424);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(48, 16);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Show";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(160, 188, 204);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(701, 550);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 24;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(160, 188, 204);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(701, 535);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 25;
            label2.Text = "Register";
            label2.Click += label2_Click;
            // 
            // registerForm1
            // 
            registerForm1.BackColor = Color.FromArgb(126, 216, 253);
            registerForm1.Location = new Point(12, 36);
            registerForm1.Name = "registerForm1";
            registerForm1.Size = new Size(864, 680);
            registerForm1.TabIndex = 26;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            ClientSize = new Size(848, 641);
            Controls.Add(firstNameBox);
            Controls.Add(lastNameBox);
            Controls.Add(usernameBox);
            Controls.Add(middleInitialBox);
            Controls.Add(confirmPassBox);
            Controls.Add(passwordBox);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(doneBTN);
            Controls.Add(backToLogin);
            Controls.Add(registerForm1);
            Controls.Add(label2);
            Controls.Add(showPassCheckBox);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(passwordTextbox);
            Controls.Add(userTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
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
        private Button doneBTN;
        private Label backToLogin;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox middleInitialBox;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox confirmPassBox;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label label2;
        private RegisterForm registerForm1;
    }
}