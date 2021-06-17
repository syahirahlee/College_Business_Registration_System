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
using System.Drawing.Printing; //to allow printing of window form

namespace College_business_registration
{
    public partial class License : Form
    {
        //where textfile is located
        string fileupdated = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\UPDATED.txt";
        //create objects of both Student and Business class
        Student mystudent = new Student();
        Business biz = new Business();
        public License()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Close();

            //open menu form back
            Student_Menu menu = new Student_Menu();
            menu.Show();
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
                using (StreamReader reader = new StreamReader(fileupdated))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        ParseStudent(line, out mystudent, out biz);

                        if (search == mystudent.StudID)
                        {
                            if (biz.Statusapprov == "APPROVED")
                            {
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("\t            KOLEJ PROFESIONAL MARA BERANANG BUSINESS LICENSE \r\n");
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("\r\n***************************************************************************************************************");
                                lstDisplay.Items.Add("\t\t\t\t\t\t      License ID: KPMBBUS020 \r\n");
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("This certified license belongs to " + mystudent.Studname + ", " + mystudent.StudID + " student of " + mystudent.Course + " Program.");
                                lstDisplay.Items.Add("The product type/service offered is " + mystudent.ProductType);
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("Business type selected: " + biz.Type + "\t\t Fee: " + biz.Fee);
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("I hereby promise to conduct the following business with proper ethics and keep the area clean.\r\n");
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("  ");
                                lstDisplay.Items.Add("\r\nTel no: " + mystudent.Telno + "\t\t Status: " + biz.Statusapprov);

                            }
                            else
                            {
                                //for student's business that has not been approved by staff
                                MessageBox.Show("Your business is not approved, no license is issued.");
                            }
                        }
                        
                    }//END WHILE
                    
                }
            }
            else
                MessageBox.Show("File" + fileupdated + "doesn't exist");
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //ensure student ID is in capital letter
            txtID.CharacterCasing = CharacterCasing.Upper;
        }

        private void License_Load(object sender, EventArgs e)
        {

        }
    }
}
