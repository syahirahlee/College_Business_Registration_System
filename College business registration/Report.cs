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
using System.Drawing.Printing;//for printing option

namespace College_business_registration
{
    public partial class Report : Form
    {
        //declare variables for calculation total revenue of each business type
        double totalkiosk = 0, totaldaily=0, totalmobile=0;
        int countkiosk = 0, countdaily = 0, countmobile=0;
        //where textfile is located
        string fileupdated = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\UPDATED.txt";

        //create objects of both Student and Business class
        Student mystudent = new Student();
        Business biz = new Business();

        public Report()
        {
            InitializeComponent();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //to print REPORT
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
            StringFormat Fmtcenter = new StringFormat() { Alignment = StringAlignment.Far };
            StringFormat fmt = Fmtright;

            using (Font font = new Font("Arial Narrow", 12f))
            {
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + leading;
                for (int i = 0; i < lstReport.Items.Count; i++)
                {
                    e.Graphics.DrawString(lstReport.Items[i].ToString(), font, Brushes.Black, leftMargin, topMargin + h * i, fmt);
                }
            }

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //to close form and exit
            Application.Exit();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Close();

            //open menu form back
            Staff_Menu menu = new Staff_Menu();
            menu.Show();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            //view all student details and total revenues for each type of business
            string line;

            if (System.IO.File.Exists(fileupdated) == true)
            {
                using (StreamReader reader = new StreamReader(fileupdated))
                {
                    lstReport.Items.Add("Student Name \t ID\t\tCourse \t Tel no \t\t Product \t\tBusiness Type   Status\tFee");
                    lstReport.Items.Add("");
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        
                        ParseStudent(line, out mystudent, out biz); //passing by "out" to get return value

                        if (biz.Statusapprov == "APPROVED")
                        {
                            //display approved student details ONLY
                            lstReport.Items.Add("\r\n" + mystudent.Studname + "\t\t" + mystudent.StudID + "\t" + mystudent.Course + "\t" + mystudent.Telno + "\t" + mystudent.ProductType + "\t " + biz.Type + "\t    " + biz.Statusapprov + " \t" + biz.Fee);
                        }
                            
                    }
                    //display total revenues for each business types
                    lstReport.Items.Add("");
                    lstReport.Items.Add("**********************************************************************************************************************************************************************");
                    lstReport.Items.Add("\tKiosk Business      Total Fee: RM " + totalkiosk + "\tNumber of students: " + countkiosk);
                    lstReport.Items.Add("");
                    lstReport.Items.Add("\tDaily Business        Total Fee: RM " + totaldaily + "\tNumber of students: " + countdaily);
                    lstReport.Items.Add("");
                    lstReport.Items.Add("\tMobile Business     Total Fee: RM " + totalmobile + "\tNumber of students: " + countmobile);
                    lstReport.Items.Add("");
    
                }
            }
            else
            {
                MessageBox.Show("File" + fileupdated + "Doesnt Exist");
            }

        }//end codes for button VIEW

        bool ParseStudent(string Text, out Student mystudent, out Business biz) //to split data by bar
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

            
            if (biz.Statusapprov == "APPROVED")
            {
                //calculation for total revenues on each type of business
                //and total number of students registered in each business types
                if (biz.Type == "Kiosk")
                {
                    totalkiosk = totalkiosk + biz.Fee;
                    countkiosk = countkiosk + 1;
                }


                else if (biz.Type == "Daily")
                {
                    totaldaily = totaldaily + biz.Fee;
                    countdaily = countdaily + 1;
                }
                else
                {
                    totalmobile = totalmobile + biz.Fee;
                    countmobile = countmobile + 1;
                }
            }
           
            return true;
        }

    }
}
