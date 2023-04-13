using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8___Zane_Neely
{
    public partial class formSelect : Form
    {
        formLogIn form1;
        public formSelect(formLogIn form2)
        {
            InitializeComponent();
            form1 = form2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSwitchboard f1 = new formSwitchboard(form1);
            f1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dbConnectionString;

            SqlConnection RepSearchConnection;
            SqlDataAdapter RepSearchAdapter;
            DataSet RepSearchDataset;

            dbConnectionString = form1.ConnectionString();
            RepSearchConnection = new SqlConnection(dbConnectionString);
            RepSearchAdapter = new SqlDataAdapter();
            RepSearchDataset = new DataSet();

                RepSearchAdapter.SelectCommand = new SqlCommand();
                RepSearchAdapter.SelectCommand.Connection = RepSearchConnection;

                    RepSearchAdapter.SelectCommand.CommandText = "Select R.FIRST_NAME, R.LAST_NAME " + "C.CUSTOMER_NAME, I.DESCRIPTION, I.ITEM_NUM, OL.NUM_ORDERED " + "OL.QUOTED_PRICE from REP R, CUSTOMER C, ORDER_LINE OL, " + 
                    "ITEM I WHERE R.REP_NUM = C.REP_NUM AND C.CUSTOMER_NUM = O.CUSTOMER_NUM AND " + "O.ORDER_NUM = OL.ORDER_NUM AND OL.ITEM_NUM = I.ITEM_NUM AND " 
                    + "R.FIRST_NAME = '" + txtRepFirstName.Text + "' AND R.LAST_NAME = '" + txtRepLastName.Text + "';";

                RepSearchConnection.Open();
                RepSearchAdapter.Fill(RepSearchDataset, "Rep_Sales");
                
            dgvRepOrderDetails.DataSource = RepSearchDataset;
            dgvRepOrderDetails.DataMember = "Rep_Sales";
            dgvRepOrderDetails.AutoGenerateColumns = true;

            RepSearchConnection.Close();
        }
    }
}
