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
    public partial class formSwitchboard : Form
    {
        formLogIn logFrm1;
        public formSwitchboard(formLogIn logfrm2)
        {
            InitializeComponent();
            logFrm1 = logfrm2;
        }

        private void formSwitchboard_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelect F1 = new formSelect(logFrm1);
            F1.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInsert F1 = new formInsert(logFrm1);
            F1.Show();
        }
    }
}
