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
    public partial class formInsert : Form
    {
        formLogIn form1;
        public formInsert(formLogIn form2)
        {
            InitializeComponent();
            form1 = form2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToSB_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSwitchboard f1 = new formSwitchboard(form1);
            f1.Show();
        }
    }
}
