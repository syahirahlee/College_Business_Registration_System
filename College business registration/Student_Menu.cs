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
    public partial class Student_Menu : Form
    {
        public Student_Menu()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //to close form and exit
            Application.Exit();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();
            //open registration form
            Student_Register s1 = new Student_Register();
            s1.Show();

        }

        private void btnstatus_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();
            //open check approval form
            Check ch = new Check();
            ch.Show();
        }

        private void btnmainmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();

            //return to login form back
            Form1 main = new Form1();
            main.Show();
        }

        private void Student_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
