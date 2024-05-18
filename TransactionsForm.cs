using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemGUI
{
    public partial class TransactionsForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string userLog = "";
        public TransactionsForm(string userLog)
        {
            InitializeComponent();
            showAllTransactions();
            showAllPayments();
            this.userLog = userLog;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        // Display all transactions
        private void showAllTransactions()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand("SELECT p_usrlog as [User Log], p_plateNo as [Plate Number], p_loc as [Parking Slot], p_flagdown as [Flag Down],p_date as [Park-in Date/Time] FROM p_trans");
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ParkWiseDBS");
            transactionsGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        // Display all Payments
        private void showAllPayments()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkWiseDBS;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            cmd = new SqlCommand("SELECT t_id as [Transaction No.], t_usrlog as [User Log], t_pn as [Plate No.], t_vt as [Vehicle Type],t_date as [Park-out Date/Time], t_payment as [Payment] FROM payments");
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ParkWiseDBS");
            paymentGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void TransactionsForm_Load(object sender, EventArgs e)
        {

        }
        // Return to Main Form
        private void returnBTN_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        // Calculate Total Payment
        private void totalPaymenBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
