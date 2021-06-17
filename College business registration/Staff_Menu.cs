using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_business_registration
{
    public partial class Staff_Menu : Form
    {
        public Staff_Menu()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //to close form and exit
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();

            //open update form
            StaffUpdate update = new StaffUpdate();
            update.Show();
        }


        private void btnreport_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();

            //open report form
            Report rpt = new Report();
            rpt.Show();
        }

        private void btnmainmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();

            //return to login form back
            Form1 main = new Form1();
            main.Show();
        }

        private void Staff_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
