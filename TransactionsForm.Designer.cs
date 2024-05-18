namespace ParkingSystemGUI
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            panel1 = new Panel();
            label1 = new Label();
            transactionsGrid = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            paymentGrid = new DataGridView();
            totalPaymenBTN = new Button();
            returnBTN = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsGrid).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 105, 158);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(transactionsGrid);
            panel1.Location = new Point(91, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 303);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(139, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 1;
            label1.Text = "Park-in";
            // 
            // transactionsGrid
            // 
            transactionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsGrid.Location = new Point(17, 34);
            transactionsGrid.Name = "transactionsGrid";
            transactionsGrid.Size = new Size(334, 255);
            transactionsGrid.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 105, 158);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(paymentGrid);
            panel2.Location = new Point(495, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 303);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(151, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 2;
            label2.Text = "Park-out";
            // 
            // paymentGrid
            // 
            paymentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentGrid.Location = new Point(22, 34);
            paymentGrid.Name = "paymentGrid";
            paymentGrid.Size = new Size(334, 255);
            paymentGrid.TabIndex = 1;
            // 
            // totalPaymenBTN
            // 
            totalPaymenBTN.BackColor = Color.FromArgb(32, 105, 158);
            totalPaymenBTN.ForeColor = SystemColors.ButtonHighlight;
            totalPaymenBTN.Location = new Point(424, 558);
            totalPaymenBTN.Name = "totalPaymenBTN";
            totalPaymenBTN.Size = new Size(128, 33);
            totalPaymenBTN.TabIndex = 2;
            totalPaymenBTN.Text = "Total Payment";
            totalPaymenBTN.UseVisualStyleBackColor = false;
            totalPaymenBTN.Click += totalPaymenBTN_Click;
            // 
            // returnBTN
            // 
            returnBTN.BackColor = Color.FromArgb(32, 105, 158);
            returnBTN.ForeColor = SystemColors.ButtonHighlight;
            returnBTN.Location = new Point(794, 205);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(73, 23);
            returnBTN.TabIndex = 3;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = false;
            returnBTN.Click += returnBTN_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 216, 253);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 656);
            Controls.Add(returnBTN);
            Controls.Add(totalPaymenBTN);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionsForm";
            Load += TransactionsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paymentGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView transactionsGrid;
        private Panel panel2;
        private Label label2;
        private DataGridView paymentGrid;
        private Button totalPaymenBTN;
        private Button returnBTN;
    }
}