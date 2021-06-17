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
using System.Diagnostics;//ADDED to provide classes that allow to interact with system processes, event logs and performance counters

namespace College_business_registration
{
    
    public partial class Student_Register : Form
    {
        //where textfile is located
        string filepath = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\STUDENT.txt";

        //create objects of both Student and Business class
        Student mystudent;
        Business biz;
        //declare count for  kiosk
        int count;

        public Student_Register()
        {
            InitializeComponent();

            //add items to combobox dropdown list :
            //business types 
            cbotype.Items.Add("Kiosk");
            cbotype.Items.Add("Daily");
            cbotype.Items.Add("Mobile");
            //courses in college
            cbocourse.Items.Add("HND");
            cbocourse.Items.Add("DAB");
            cbocourse.Items.Add("DIA");
            cbocourse.Items.Add("DBS");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //to close form and exit
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all textboxes
            txtname.Text = "";
            txtID.Text = "";
            cbocourse.Text ="";
            txtTelno.Text = "";
            txtproductType.Text = "";
            cbotype.Text ="";
            txtday.Text = "";
            txtfee.Text = "";
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
           
            if (cbotype.Text == "Kiosk") //to determine kiosk business count registered by students
             {   
                  count =count+1; 
                  
                 //saves count to COUNT KIOSK textfile
                  TextWriter txt2 = new StreamWriter(@"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\COUNT KIOSK.txt"); 
                
                  txt2.Write(count);

                  txt2.Close();
                }      
            
              //call method to save student info to STUDENT textfile 
              SaveToFile(filepath);
            //inform student data has been registered
            MessageBox.Show("Data is saved. You have successfully registered.");
      
        }
        //bool SaveToFile
             void SaveToFile(string Filepath)
             {
                 if (!File.Exists(filepath))
                 {
                    //create a file to write to
                    using (StreamWriter file = File.CreateText(filepath))
                    {
                    string Line = StudentToLine(mystudent);
                    file.WriteLine(Line); //write to file
                   }
                 }
                 else
                //this text is always added, making the file longer over time
                //if it is not deleted
                {
                      using (StreamWriter file = File.AppendText(filepath))
                     {
                        string Line = StudentToLine(mystudent);
                        file.WriteLine(Line);
                     }
                }
             }

             string StudentToLine(Student mystudent)
            {
                StringBuilder sb = new StringBuilder(); //to combine each data to become a long string readable to testfile
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

                Debug.WriteLine(sb.ToString());

                return sb.ToString();

            }

        //calculate registration fee
        private void btncalc_Click(object sender, EventArgs e)
        {
            //instantiate objects of class Student and Business
            mystudent = new Student();
            biz = new Business();
            //read textboxes
            mystudent.Studname = txtname.Text;
            mystudent.StudID = txtID.Text;
            mystudent.Course = cbocourse.Text;
            mystudent.Telno = txtTelno.Text;
            mystudent.ProductType = txtproductType.Text;
            biz.Statusapprov = txtapprov.Text;
            biz.Type = cbotype.Text;

            //call  method
            mystudent.RegisterNew(biz);

            //exception handling for error when user enter alphabet letters instead of number in day box
            try
            {
                //read textbox day/month for kiosk and daily fee calculation 
                if (biz.Type == "Kiosk" || biz.Type == "Daily")
                {
                    biz.Days = int.Parse(txtday.Text);
                    biz.Month = int.Parse(txtday.Text);
                }

                //call method to calculate registration fee based on type of business chosen
                biz.Fee = mystudent.getTotalFee();
                //display total fee calculated
                txtfee.Text = Convert.ToString(biz.Fee);
            }
            catch(Exception)
            {
                //display message to inform user of correct format to be input
                MessageBox.Show("Please insert number value. "); 
                txtday.Clear(); //clear day textbox for user to enter numeric value
            }

            if (biz.Type == "Kiosk" || biz.Type == "Daily")
            {
                if (biz.Days <= 0)
                {
                    MessageBox.Show("Total fee incorrect. Please enter correct number.");
                    txtday.Clear(); //clear day textbox for user to enter numeric value
                    txtfee.Clear();
                 
                }
            }
           
     
        }


    private void btnmenu_Click(object sender, EventArgs e)
        {
            //hide form
            this.Close();

            //to open menu form back
            Student_Menu menu = new Student_Menu();
            menu.Show();
        }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
            
        }

        //once student register form loads
        private void Student_Register_Load(object sender, EventArgs e)
        {
            //read count of kiosk saved in textfile
            TextReader txt = new StreamReader(@"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\COUNT KIOSK.txt");
       
        count = int.Parse(txt.ReadLine());
            //display number of kiosk registered
            MessageBox.Show("Kiosk count is " + Convert.ToString(count));
            txt.Close();

            //for kiosk business that is limited to 6
            if (count >= 6)
            {
                MessageBox.Show("Kiosk is fully occupied. Please choose another business type.");
                
            }
            txtday.Enabled = false;  //disable day/month textbox upon loading form

            txtapprov.Text = "Pending"; //set default due to waiting approval from staff
        }


        //for duration of business based on business type selected
        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotype.Text == "Daily")  //daily business by day
            {
                labelday.Text = "Day";
                txtday.Enabled = true;
            }
           else if (cbotype.Text == "Kiosk")  //kiosk business by month
            {
                if (count >= 6)
                {
                    MessageBox.Show("Kiosk is limited. Please choose another business type.");
                    txtday.Enabled = false;
                }
                else
                    labelday.Text = "Month";
                    txtday.Enabled = true;
            }
            else //mobile requires no input of day or month
            {
                txtday.Enabled = false;
            }
        }

        private void txtapprov_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            //open help form
            Help guide = new Help();
            guide.Show();


            
        }

        private void txtTelno_TextChanged(object sender, EventArgs e)
        {
          
            //to ensure correct input of telephone number
            if (txtTelno.Text.Length >11)
            {
                MessageBox.Show("Your tel no must not exceed 10 digits.");
                txtTelno.Clear();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //ensure student ID is in capital letter
            txtID.CharacterCasing = CharacterCasing.Upper;

            //to ensure correct input of ID
            if (txtID.Text.Length >11)
            {
                MessageBox.Show("Your ID is in incorrect length.");
                txtID.Clear();
            }
        }
    }
}
