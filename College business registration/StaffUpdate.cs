using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//ADDED to allow reading and writing to files and data streams

namespace College_business_registration
{
    public partial class StaffUpdate : Form
    {
        //where textfile is located
        string filepath = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\STUDENT.txt";
        string fileupdated = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\UPDATED.txt";
        
        //create objects of both Student and Business class
        Student mystudent;
        Business biz;
        public StaffUpdate()
        {
            InitializeComponent();
            cbostatus.Items.Add("APPROVED");
            cbostatus.Items.Add("NOT APPROVED");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //to close form and exit
            Application.Exit();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //search students details by student ID
            string search = txtID.Text;

            string line;

            if (System.IO.File.Exists(filepath) == true)
            {
                using (StreamReader reader = new StreamReader(filepath))//read textfile STUDENT
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        ParseStudent(line, out mystudent, out biz);

                        if (search == mystudent.StudID)
                        {
                            txtname.Text = mystudent.Studname;
                            txtcourse.Text = mystudent.Course;
                            txtTelno.Text = mystudent.Telno;
                            txtproductType.Text = mystudent.ProductType;
                            txtbiztype.Text = biz.Type;
                            txtbizfee.Text = Convert.ToString(biz.Fee);
                            cbostatus.Text = biz.Statusapprov;
                        }
                    }
                }
                using (StreamReader reader = new StreamReader(fileupdated)) //read textfile UPDATE
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        ParseStudent(line, out mystudent, out biz);

                        if (search == mystudent.StudID)
                        {
                            txtname.Text = mystudent.Studname;
                            txtcourse.Text = mystudent.Course;
                            txtTelno.Text = mystudent.Telno;
                            txtproductType.Text = mystudent.ProductType;
                            txtbiztype.Text = biz.Type;
                            txtbizfee.Text = Convert.ToString(biz.Fee);
                            cbostatus.Text = biz.Statusapprov;
                        }
                    }
                }
            }

            else
                MessageBox.Show("File" + filepath + "doesn't exist");
        }
        bool ParseStudent(string Text, out Student mystudent, out Business biz)//utk splitkan data by bar
        {
            mystudent = new Student();
            biz = new Business();
            string[] arr = Text.Split('|');
            if (arr.Length != 8)
            {
                return false;
            }
            mystudent.StudID = arr[0];
            mystudent.Studname = arr[1];
            mystudent.Course = arr[2];
            mystudent.Telno = arr[3];
            mystudent.ProductType = arr[4];
            biz.Type = arr[5];
            biz.Fee = Convert.ToInt32(arr[6]);
            biz.Statusapprov = arr[7];

            return true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mystudent = new Student();

            //read textboxes data
            mystudent.StudID = txtID.Text;
            mystudent.Studname = txtname.Text;
            mystudent.Course = txtcourse.Text;
            mystudent.Telno = txtTelno.Text;
            mystudent.ProductType = txtproductType.Text;
            biz.Type = txtbiztype.Text;
            biz.Fee = int.Parse(txtbizfee.Text);
            biz.Statusapprov = cbostatus.Text;

            SaveToFile(fileupdated);
            //inform staff that data has been updated
            MessageBox.Show("The updated student's data is saved successfully.");
        }
        bool SaveToFile(string Fileupdated)
        {
            if (!File.Exists(fileupdated))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(fileupdated))
                {
                    string Line = StudentToLine(mystudent);
                    file.WriteLine(Line);//write to file

                }
            }
            else

                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(fileupdated))
                {
                    string Line = StudentToLine(mystudent);
                    file.WriteLine(Line);  //write to line
                }
            //file.Close();

            return true;

        }
        string StudentToLine(Student myStudent)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(mystudent.StudID);
            sb.Append('|');
            sb.Append(mystudent.Studname);
            sb.Append('|');
            sb.Append(mystudent.Course);
            sb.Append('|');
            sb.Append(mystudent.Telno);
            sb.Append('|');
            sb.Append(mystudent.ProductType);
            sb.Append('|');
            sb.Append(biz.Type);
            sb.Append('|');
            sb.Append(biz.Fee);
            sb.Append('|');
            sb.Append(biz.Statusapprov);


            // Debug.WriteLine(sb.ToString());

            return sb.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all textboxes
            txtID.Text = "";
            txtname.Text= "";
            txtcourse.Text = "";
            txtTelno.Text = "";
            txtproductType.Text = "";
            txtbiztype.Text = "";
            txtbizfee.Text = "";
            cbostatus.Text = "";
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();
            //open report form
            Report r = new Report();
            r.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Close();

            //open menu form back
            Staff_Menu menu = new Staff_Menu();
            menu.Show();
        }

        private void StaffUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            //open help guide form
            STAFF_HELP help = new STAFF_HELP();
            help.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //ensure student ID is in capital letter
            txtID.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
