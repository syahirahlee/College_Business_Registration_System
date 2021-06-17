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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide(); 

            //open student menu form
            Student_Menu stud = new Student_Menu();
            stud.Show();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();
            //open staff update approval and status form
            Staff_Menu staff = new Staff_Menu();
            staff.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //to close form and exit
            Application.Exit();
        }
    }
}
