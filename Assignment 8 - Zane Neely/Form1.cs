using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace Assignment_8___Zane_Neely
{
    public partial class formLogIn : Form
    {
        public formLogIn()
        {
            InitializeComponent();
        }

        public string ConnectionString()
        {
            string SQLServerConnectionString;
            string ServerName, DatabaseName, UserID, Password;

            ServerName = txtServerName.Text;
            DatabaseName = txtDatabaseName.Text;
            UserID = txtUsername.Text;
            Password = txtPassword.Text;

            SQLServerConnectionString = "Data Source = " + ServerName + "; Initial catalog " + DatabaseName + "; UserID = " + UserID + "; Password = " + Password + ";";

            return SQLServerConnectionString;
        }

        public bool CheckConnection()
        {
            bool worked;
            string ConnectionStr;
            SqlConnection OpenConnection;

            ConnectionStr = ConnectionString();
            OpenConnection = new SqlConnection(ConnectionStr);

            try 
            {
                OpenConnection.Open();
                worked = true;
                OpenConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                worked = false;
                OpenConnection.Close();
            }

            return worked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ConnectionOpenned;

            ConnectionOpenned = CheckConnection();

            if (ConnectionOpenned)
            {
                this.Hide();
                formSwitchboard f1 = new formSwitchboard(this);
                f1.Show();
            }
            else
            {
                label6.Show();
                label6.Text = "Something went wrong. Please check your combination.";
            }
        }
    }
}
