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
    public partial class Help : Form
    {
        //where textfile is located
        string filepath = @"D:\MEH\HND\ASSGMT H2B\OOP\College business registration\\HELP GUIDE.txt";

        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {

            if (File.Exists(filepath))
            {
                string[] readText = File.ReadAllLines(filepath);
                for (int i = 0; i < readText.Length; i++)
                {
                    lstGuide.Items.Add(readText[i]); //read text from HELP GUIDE textfile
                }
            }

            else
            {
                MessageBox.Show("File does not exist!");
            }
        }
    }
}
