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
using System.Drawing.Printing; //to allow printing 

namespace College_business_registration
{
    public partial class Check : Form
    {
        //where textfile is located
        string fileupdated = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\UPDATED.txt";
        string filepath = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\STUDENT.txt";

        //create objects of both Student and Business class
        Student mystudent = new Student();
        Business biz = new Business();

        public Check()
        {
            InitializeComponent();
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

            if (System.IO.File.Exists(fileupdated) == true)
            {
                using (StreamReader reader = new StreamReader(filepath)) //textfile STUDENT
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        ParseStudent(line, out mystudent, out biz);

                        if (search == mystudent.StudID)
                        {
                            lstDisplay.Items.Clear();
                            lstDisplay.Items.Add("Student ID: " + mystudent.StudID + "\r\n");
                            lstDisplay.Items.Add("\r\nName: " + mystudent.Studname);
                            lstDisplay.Items.Add("\r\nCourse: " + mystudent.Course);
                            lstDisplay.Items.Add("\r\nTel no: " + mystudent.Telno);
                            lstDisplay.Items.Add("\r\nBusiness type: " + biz.Type);
                            lstDisplay.Items.Add("\r\nFee: " + biz.Fee);
                            lstDisplay.Items.Add("\r\nStatus: " + biz.Statusapprov);
                        }
                    }//END WHILE
                    
                }
                using (StreamReader reader = new StreamReader(fileupdated)) //textfile UPDATE
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        ParseStudent(line, out mystudent, out biz);

                        if (search == mystudent.StudID)
                        {
                            lstDisplay.Items.Clear();
                            lstDisplay.Items.Add("Student ID: " + mystudent.StudID + "\r\n");
                            lstDisplay.Items.Add("\r\nName: " + mystudent.Studname);
                            lstDisplay.Items.Add("\r\nCourse: " + mystudent.Course);
                            lstDisplay.Items.Add("\r\nTel no: " + mystudent.Telno);
                            lstDisplay.Items.Add("\r\nBusiness type: " + biz.Type);
                            lstDisplay.Items.Add("\r\nFee: " + biz.Fee);
                            lstDisplay.Items.Add("\r\nStatus: " + biz.Statusapprov);
                        }
                        
                    }//END WHILE
                   
                }
                 
            }
            else  //displays appropriate message if textfile is not found
            {
                MessageBox.Show("File" + fileupdated + "doesn't exist");
            }
                
        }
        bool ParseStudent(string Text, out Student mystudent, out Business biz)//TO split data by bar
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

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Close();

            //open menu form back
            Student_Menu menu = new Student_Menu();
            menu.Show();
        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            //to print registration fee receipt
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.printDocument1_Printpage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;

            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
         
        }

        private void printDocument1_Printpage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            int leading = 5;
            int leftMargin = 25;
            int topMargin = 10;

            StringFormat Fmtright = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat Fmtleft = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat Fmtcenter = new StringFormat() { Alignment = StringAlignment.Far};
            StringFormat fmt = Fmtright;

            using (Font font = new Font("Arial Narrow", 12f))
            {
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + leading;
                for (int i =0; i<lstDisplay.Items.Count; i++)
                {
                    e.Graphics.DrawString(lstDisplay.Items[i].ToString(), font, Brushes.Black, leftMargin, topMargin + h*i, fmt);
                }
            }

        }

        private void btnlicense_Click(object sender, EventArgs e)
        {
            //hide form
            this.Hide();
            //open license form
            License l = new License();
            l.Show();
        }
        

        private void Check_Load_1(object sender, EventArgs e)
        {
            //for student ID that is not available in registered 'STUDENT' textfile
            MessageBox.Show("If your status details are not displayed, the student ID entered does not exist/registered in system.");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //ensure student ID is in capital letter
            txtID.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
